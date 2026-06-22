using System;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.IO;
using System.IO.Compression;
using System.Text;
using System.Xml;

class GetModelSnapshot
{
    static void Main()
    {
        try
        {
            Database.SetInitializer<Cis.Data.CisDbContext>(null);
            var context = new Cis.Data.CisDbContext();

            // Write EDMX directly to a MemoryStream with UTF-8 (no BOM)
            byte[] xmlBytes;
            using (var ms = new MemoryStream())
            {
                var settings = new XmlWriterSettings
                {
                    Encoding = new UTF8Encoding(false),  // UTF-8, no BOM
                    Indent   = false
                };
                using (var writer = XmlWriter.Create(ms, settings))
                {
                    EdmxWriter.WriteEdmx(context, writer);
                }
                xmlBytes = ms.ToArray();
            }

            // GZip compress
            byte[] compressed;
            using (var ms = new MemoryStream())
            {
                using (var gz = new GZipStream(ms, CompressionMode.Compress))
                {
                    gz.Write(xmlBytes, 0, xmlBytes.Length);
                }
                compressed = ms.ToArray();
            }

            // Verify magic bytes
            Console.WriteLine("GZip magic: " + compressed[0].ToString("X2") + compressed[1].ToString("X2") + " (expect 1F8B)");

            // Verify XML declaration says utf-8
            string xmlHead = Encoding.UTF8.GetString(xmlBytes, 0, Math.Min(80, xmlBytes.Length));
            Console.WriteLine("XML head: " + xmlHead);

            string base64 = Convert.ToBase64String(compressed);
            File.WriteAllText("model_snapshot.txt", base64);
            Console.WriteLine("Written: " + compressed.Length + " bytes compressed, " + base64.Length + " chars base64");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
            Console.WriteLine(ex.ToString());
            Environment.Exit(1);
        }
    }
}
