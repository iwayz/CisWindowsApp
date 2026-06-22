<#
.SYNOPSIS
    Applies pending EF6 migrations to the CIS_POS SQL Server database.

.DESCRIPTION
    Equivalent of "dotnet ef database update" for .NET Framework 4.7 + EF6.
    Builds Cis.Data, compiles a small runner, then calls DbMigrator.Update()
    which executes Up() from each pending migration .cs file and registers
    the result in __MigrationHistory automatically.

.PARAMETER Target
    Optional migration ID to migrate up to. Defaults to latest.

.EXAMPLE
    .\Update-Database.ps1
    .\Update-Database.ps1 -Target 202606160001_AddStockManagement
#>
param(
    [string]$Target     = "",
    [string]$Server     = ".",
    [string]$Database   = "CIS_POS",
    [string]$DbUser     = "capung",
    [string]$DbPassword = "admin"
)

$ErrorActionPreference = "Stop"
$root      = $PSScriptRoot
$buildOut  = Join-Path $root "TempBuild"
$configSrc = Join-Path $root "Cis.Data\bin\Release\net47\Cis.Data.dll.config"
# Runner lives in TempBuild so it loads fresh DLLs from that same directory
$runnerCs  = Join-Path $buildOut "_MigrationRunner.cs"
$runnerExe = Join-Path $buildOut "_MigrationRunner.exe"
$snapFile  = Join-Path $root "model_snapshot.txt"
$configDst = Join-Path $root "GetModelSnapshot.exe.config"
$snapExe   = Join-Path $root "GetModelSnapshot.exe"
$csc       = "C:\Windows\Microsoft.NET\Framework64\v4.0.30319\csc.exe"

# ── 1. Build Cis.Data ─────────────────────────────────────────────────────────
Write-Host ""
Write-Host "[1/4] Building Cis.Data..." -ForegroundColor Cyan
dotnet build "$root\Cis.Data\Cis.Data.csproj" -c Release -o $buildOut --nologo -v quiet
if ($LASTEXITCODE -ne 0) { Write-Error "Build failed."; exit 1 }

# ── 2. Generate and compile the runner ───────────────────────────────────────
Write-Host "[2/4] Compiling migration runner..." -ForegroundColor Cyan

$connStr  = "Server=$Server;Database=$Database;User Id=$DbUser;Password=$DbPassword;"
$targetArg = if ($Target -ne "") { "`"$Target`"" } else { "null" }

$runnerCode = @"
using System;
using System.Data.Entity.Migrations;
using System.Data.Entity.Infrastructure;

class MigrationRunner
{
    static int Main(string[] args)
    {
        try
        {
            var config = new Cis.Data.Migrations.Configuration();
            config.TargetDatabase = new DbConnectionInfo(
                "$connStr",
                "System.Data.SqlClient");

            var migrator = new DbMigrator(config);

            var pending = migrator.GetPendingMigrations();
            bool hasPending = false;
            foreach (var m in pending)
            {
                Console.WriteLine("  Pending: " + m);
                hasPending = true;
            }

            if (!hasPending)
            {
                Console.WriteLine("  Database is already up to date.");
                return 0;
            }

            string target = $targetArg;
            migrator.Update(target);
            Console.WriteLine("  Migrations applied successfully.");
            return 0;
        }
        catch (Exception ex)
        {
            Console.WriteLine("ERROR: " + ex.Message);
            Console.WriteLine(ex.ToString());
            return 1;
        }
    }
}
"@

[System.IO.File]::WriteAllText($runnerCs, $runnerCode, [System.Text.Encoding]::UTF8)

# Compile referencing all DLLs from TempBuild
$refArgs = (Get-ChildItem "$buildOut\*.dll" | ForEach-Object { "/r:$($_.FullName)" })
& $csc /out:$runnerExe /nologo @refArgs $runnerCs
if ($LASTEXITCODE -ne 0) { Write-Error "Compile failed."; exit 1 }

# Copy app config so EF6 can find the assembly and provider
Copy-Item $configSrc ($runnerExe + ".config") -Force

# ── 3. Run migrations ─────────────────────────────────────────────────────────
Write-Host "[3/4] Running migrations..." -ForegroundColor Cyan
Push-Location $root
& $runnerExe
$exitCode = $LASTEXITCODE
Pop-Location

if ($exitCode -ne 0) {
    Write-Error "Migration runner failed (exit code $exitCode)."
    exit 1
}

# ── 4. Refresh model snapshot ─────────────────────────────────────────────────
Write-Host "[4/4] Refreshing model snapshot..." -ForegroundColor Cyan
Copy-Item $configSrc $configDst -Force
Push-Location $root
& $snapExe | Out-Null
Pop-Location
Write-Host "  model_snapshot.txt updated." -ForegroundColor DarkGray

# Cleanup runner (lives in TempBuild)
Remove-Item $runnerCs  -Force -ErrorAction SilentlyContinue
Remove-Item $runnerExe -Force -ErrorAction SilentlyContinue
Remove-Item ($runnerExe + ".config") -Force -ErrorAction SilentlyContinue
Remove-Item ($runnerExe + ".pdb") -Force -ErrorAction SilentlyContinue

Write-Host ""
Write-Host "Done. Database is up to date." -ForegroundColor Green
