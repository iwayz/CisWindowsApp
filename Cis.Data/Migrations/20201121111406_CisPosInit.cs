using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Cis.Data.Migrations
{
    public partial class CisPosInit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LOCATION",
                columns: table => new
                {
                    ID = table.Column<string>(maxLength: 36, nullable: false),
                    CREATED_BY = table.Column<string>(nullable: false),
                    CREATED_AT = table.Column<DateTime>(nullable: false),
                    MODIFIED_BY = table.Column<string>(nullable: false),
                    MODIFIED_AT = table.Column<DateTime>(nullable: false),
                    NAME = table.Column<string>(maxLength: 100, nullable: false),
                    LOC_TYPE = table.Column<byte>(nullable: false),
                    PARENT_LOC_ID = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LOCATION", x => x.ID);
                    table.ForeignKey(
                        name: "FK_LOCATION_LOCATION_PARENT_LOC_ID",
                        column: x => x.PARENT_LOC_ID,
                        principalTable: "LOCATION",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MED_CAT",
                columns: table => new
                {
                    ID = table.Column<string>(maxLength: 36, nullable: false),
                    CREATED_BY = table.Column<string>(nullable: false),
                    CREATED_AT = table.Column<DateTime>(nullable: false),
                    MODIFIED_BY = table.Column<string>(nullable: false),
                    MODIFIED_AT = table.Column<DateTime>(nullable: false),
                    DESC = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MED_CAT", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "OUTLET_TYPE",
                columns: table => new
                {
                    ID = table.Column<string>(maxLength: 36, nullable: false),
                    CREATED_BY = table.Column<string>(nullable: false),
                    CREATED_AT = table.Column<DateTime>(nullable: false),
                    MODIFIED_BY = table.Column<string>(nullable: false),
                    MODIFIED_AT = table.Column<DateTime>(nullable: false),
                    DESC = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OUTLET_TYPE", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "ROLE",
                columns: table => new
                {
                    ID = table.Column<string>(maxLength: 36, nullable: false),
                    CREATED_BY = table.Column<string>(nullable: false),
                    CREATED_AT = table.Column<DateTime>(nullable: false),
                    MODIFIED_BY = table.Column<string>(nullable: false),
                    MODIFIED_AT = table.Column<DateTime>(nullable: false),
                    ROLE_CODE = table.Column<string>(maxLength: 50, nullable: false),
                    DESC = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ROLE", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "SALES_AREA",
                columns: table => new
                {
                    ID = table.Column<string>(maxLength: 36, nullable: false),
                    CREATED_BY = table.Column<string>(nullable: false),
                    CREATED_AT = table.Column<DateTime>(nullable: false),
                    MODIFIED_BY = table.Column<string>(nullable: false),
                    MODIFIED_AT = table.Column<DateTime>(nullable: false),
                    AREA_NAME = table.Column<string>(nullable: false),
                    DESC = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SALES_AREA", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "UOM",
                columns: table => new
                {
                    ID = table.Column<string>(maxLength: 36, nullable: false),
                    CREATED_BY = table.Column<string>(nullable: false),
                    CREATED_AT = table.Column<DateTime>(nullable: false),
                    MODIFIED_BY = table.Column<string>(nullable: false),
                    MODIFIED_AT = table.Column<DateTime>(nullable: false),
                    UOM_CODE = table.Column<string>(nullable: false),
                    DESC = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UOM", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "USAGE_TYPE",
                columns: table => new
                {
                    ID = table.Column<string>(maxLength: 36, nullable: false),
                    CREATED_BY = table.Column<string>(nullable: false),
                    CREATED_AT = table.Column<DateTime>(nullable: false),
                    MODIFIED_BY = table.Column<string>(nullable: false),
                    MODIFIED_AT = table.Column<DateTime>(nullable: false),
                    DESC = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_USAGE_TYPE", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "USER",
                columns: table => new
                {
                    ID = table.Column<string>(maxLength: 36, nullable: false),
                    CREATED_BY = table.Column<string>(nullable: false),
                    CREATED_AT = table.Column<DateTime>(nullable: false),
                    MODIFIED_BY = table.Column<string>(nullable: false),
                    MODIFIED_AT = table.Column<DateTime>(nullable: false),
                    USER_NAME = table.Column<string>(nullable: false),
                    PASSWORD = table.Column<string>(nullable: false),
                    FULL_NAME = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_USER", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "PRINCIPAL",
                columns: table => new
                {
                    ID = table.Column<string>(maxLength: 36, nullable: false),
                    CREATED_BY = table.Column<string>(nullable: false),
                    CREATED_AT = table.Column<DateTime>(nullable: false),
                    MODIFIED_BY = table.Column<string>(nullable: false),
                    MODIFIED_AT = table.Column<DateTime>(nullable: false),
                    NAME = table.Column<string>(maxLength: 100, nullable: false),
                    ADDRESS = table.Column<string>(nullable: false),
                    PHONE = table.Column<string>(nullable: true),
                    EMAIL = table.Column<string>(nullable: true),
                    LOC_ID = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PRINCIPAL", x => x.ID);
                    table.ForeignKey(
                        name: "FK_PRINCIPAL_LOCATION_LOC_ID",
                        column: x => x.LOC_ID,
                        principalTable: "LOCATION",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SALESMAN",
                columns: table => new
                {
                    ID = table.Column<string>(maxLength: 36, nullable: false),
                    CREATED_BY = table.Column<string>(nullable: false),
                    CREATED_AT = table.Column<DateTime>(nullable: false),
                    MODIFIED_BY = table.Column<string>(nullable: false),
                    MODIFIED_AT = table.Column<DateTime>(nullable: false),
                    SHORT_NAME = table.Column<string>(nullable: false),
                    FULL_NAME = table.Column<string>(nullable: false),
                    GENDER = table.Column<byte>(nullable: false),
                    ADDRESS = table.Column<string>(nullable: true),
                    POSTAL_CODE = table.Column<string>(nullable: true),
                    PHONE = table.Column<string>(nullable: true),
                    EMAIL = table.Column<string>(nullable: true),
                    LOC_ID = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SALESMAN", x => x.ID);
                    table.ForeignKey(
                        name: "FK_SALESMAN_LOCATION_LOC_ID",
                        column: x => x.LOC_ID,
                        principalTable: "LOCATION",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PERMISSION_ROLE",
                columns: table => new
                {
                    ID = table.Column<string>(maxLength: 36, nullable: false),
                    CREATED_BY = table.Column<string>(nullable: false),
                    CREATED_AT = table.Column<DateTime>(nullable: false),
                    MODIFIED_BY = table.Column<string>(nullable: false),
                    MODIFIED_AT = table.Column<DateTime>(nullable: false),
                    ROLE_ID = table.Column<string>(maxLength: 36, nullable: false),
                    ACCESS_UNIT = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PERMISSION_ROLE", x => x.ID);
                    table.ForeignKey(
                        name: "FK_PERMISSION_ROLE_ROLE_ROLE_ID",
                        column: x => x.ROLE_ID,
                        principalTable: "ROLE",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CUSTOMER",
                columns: table => new
                {
                    ID = table.Column<string>(maxLength: 36, nullable: false),
                    CREATED_BY = table.Column<string>(nullable: false),
                    CREATED_AT = table.Column<DateTime>(nullable: false),
                    MODIFIED_BY = table.Column<string>(nullable: false),
                    MODIFIED_AT = table.Column<DateTime>(nullable: false),
                    NAME = table.Column<string>(nullable: false),
                    ADDRESS = table.Column<string>(nullable: false),
                    POSTAL_CD = table.Column<string>(nullable: true),
                    PHONE = table.Column<string>(nullable: true),
                    EMAIL = table.Column<string>(nullable: true),
                    NPWP = table.Column<string>(nullable: true),
                    PHARMACIST_NAME = table.Column<string>(nullable: true),
                    SIPA_NO = table.Column<string>(nullable: true),
                    SIPA_EXP_DATE = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)),
                    SIA_NO = table.Column<string>(nullable: true),
                    LOC_ID = table.Column<string>(nullable: false),
                    OUTLET_TYPE_ID = table.Column<string>(nullable: false),
                    SALES_AREA_ID = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CUSTOMER", x => x.ID);
                    table.ForeignKey(
                        name: "FK_CUSTOMER_LOCATION_LOC_ID",
                        column: x => x.LOC_ID,
                        principalTable: "LOCATION",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CUSTOMER_OUTLET_TYPE_OUTLET_TYPE_ID",
                        column: x => x.OUTLET_TYPE_ID,
                        principalTable: "OUTLET_TYPE",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CUSTOMER_SALES_AREA_SALES_AREA_ID",
                        column: x => x.SALES_AREA_ID,
                        principalTable: "SALES_AREA",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "USER_ROLE",
                columns: table => new
                {
                    ID = table.Column<string>(maxLength: 36, nullable: false),
                    CREATED_BY = table.Column<string>(nullable: false),
                    CREATED_AT = table.Column<DateTime>(nullable: false),
                    MODIFIED_BY = table.Column<string>(nullable: false),
                    MODIFIED_AT = table.Column<DateTime>(nullable: false),
                    USER_ID = table.Column<string>(maxLength: 36, nullable: false),
                    ROLE_ID = table.Column<string>(maxLength: 36, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_USER_ROLE", x => x.ID);
                    table.ForeignKey(
                        name: "FK_USER_ROLE_ROLE_ROLE_ID",
                        column: x => x.ROLE_ID,
                        principalTable: "ROLE",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_USER_ROLE_USER_USER_ID",
                        column: x => x.USER_ID,
                        principalTable: "USER",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PRODUCT",
                columns: table => new
                {
                    ID = table.Column<string>(maxLength: 36, nullable: false),
                    CREATED_BY = table.Column<string>(nullable: false),
                    CREATED_AT = table.Column<DateTime>(nullable: false),
                    MODIFIED_BY = table.Column<string>(nullable: false),
                    MODIFIED_AT = table.Column<DateTime>(nullable: false),
                    PRODUCT_CODE = table.Column<string>(maxLength: 50, nullable: false),
                    PRODUCT_NAME = table.Column<string>(maxLength: 100, nullable: false),
                    PRICE = table.Column<decimal>(nullable: false, defaultValue: 0m),
                    PRICE_DEC_DATE = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(1900, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)),
                    DISC = table.Column<float>(nullable: false, defaultValue: 0f),
                    RESTOCK_LVL = table.Column<int>(nullable: false, defaultValue: 0),
                    UNIT_ID = table.Column<string>(nullable: false),
                    MED_CAT_ID = table.Column<string>(nullable: false),
                    USAGE_TYPE_ID = table.Column<string>(nullable: false),
                    PRINCIPAL_ID = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PRODUCT", x => x.ID);
                    table.ForeignKey(
                        name: "FK_PRODUCT_MED_CAT_MED_CAT_ID",
                        column: x => x.MED_CAT_ID,
                        principalTable: "MED_CAT",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PRODUCT_PRINCIPAL_PRINCIPAL_ID",
                        column: x => x.PRINCIPAL_ID,
                        principalTable: "PRINCIPAL",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PRODUCT_UOM_UNIT_ID",
                        column: x => x.UNIT_ID,
                        principalTable: "UOM",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PRODUCT_USAGE_TYPE_USAGE_TYPE_ID",
                        column: x => x.USAGE_TYPE_ID,
                        principalTable: "USAGE_TYPE",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "BATCH",
                columns: table => new
                {
                    ID = table.Column<string>(maxLength: 36, nullable: false),
                    CREATED_BY = table.Column<string>(nullable: false),
                    CREATED_AT = table.Column<DateTime>(nullable: false),
                    MODIFIED_BY = table.Column<string>(nullable: false),
                    MODIFIED_AT = table.Column<DateTime>(nullable: false),
                    BATCH_CODE = table.Column<string>(maxLength: 100, nullable: false),
                    QTY = table.Column<int>(nullable: false),
                    ENTRY_DATE = table.Column<DateTime>(nullable: false),
                    EXPIRED_DATE = table.Column<DateTime>(nullable: false),
                    PRODUCT_ID = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BATCH", x => x.ID);
                    table.ForeignKey(
                        name: "FK_BATCH_PRODUCT_PRODUCT_ID",
                        column: x => x.PRODUCT_ID,
                        principalTable: "PRODUCT",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BATCH_CODE",
                table: "BATCH",
                column: "BATCH_CODE",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_BATCH_PRODUCT_ID",
                table: "BATCH",
                column: "PRODUCT_ID");

            migrationBuilder.CreateIndex(
                name: "IX_CUSTOMER_LOC_ID",
                table: "CUSTOMER",
                column: "LOC_ID");

            migrationBuilder.CreateIndex(
                name: "IX_CUST_NAME",
                table: "CUSTOMER",
                column: "NAME");

            migrationBuilder.CreateIndex(
                name: "IX_CUSTOMER_OUTLET_TYPE_ID",
                table: "CUSTOMER",
                column: "OUTLET_TYPE_ID");

            migrationBuilder.CreateIndex(
                name: "IX_CUSTOMER_SALES_AREA_ID",
                table: "CUSTOMER",
                column: "SALES_AREA_ID");

            migrationBuilder.CreateIndex(
                name: "IX_LOC_NAME",
                table: "LOCATION",
                column: "NAME");

            migrationBuilder.CreateIndex(
                name: "IX_LOCATION_PARENT_LOC_ID",
                table: "LOCATION",
                column: "PARENT_LOC_ID");

            migrationBuilder.CreateIndex(
                name: "IX_ROLE_ID_ACCESS_UNIT",
                table: "PERMISSION_ROLE",
                columns: new[] { "ROLE_ID", "ACCESS_UNIT" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_PRINCIPAL_LOC_ID",
                table: "PRINCIPAL",
                column: "LOC_ID");

            migrationBuilder.CreateIndex(
                name: "IX_PRINCIPAL_NAME",
                table: "PRINCIPAL",
                column: "NAME");

            migrationBuilder.CreateIndex(
                name: "IX_PRODUCT_MED_CAT_ID",
                table: "PRODUCT",
                column: "MED_CAT_ID");

            migrationBuilder.CreateIndex(
                name: "IX_PRODUCT_PRINCIPAL_ID",
                table: "PRODUCT",
                column: "PRINCIPAL_ID");

            migrationBuilder.CreateIndex(
                name: "IX_PRODUCT_CODE",
                table: "PRODUCT",
                column: "PRODUCT_CODE",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_PRODUCT_NAME",
                table: "PRODUCT",
                column: "PRODUCT_NAME");

            migrationBuilder.CreateIndex(
                name: "IX_PRODUCT_UNIT_ID",
                table: "PRODUCT",
                column: "UNIT_ID");

            migrationBuilder.CreateIndex(
                name: "IX_PRODUCT_USAGE_TYPE_ID",
                table: "PRODUCT",
                column: "USAGE_TYPE_ID");

            migrationBuilder.CreateIndex(
                name: "IX_ROLE_CODE",
                table: "ROLE",
                column: "ROLE_CODE",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_SALESMAN_LOC_ID",
                table: "SALESMAN",
                column: "LOC_ID");

            migrationBuilder.CreateIndex(
                name: "IX_USER_ROLE_USER_ID",
                table: "USER_ROLE",
                column: "USER_ID");

            migrationBuilder.CreateIndex(
                name: "IX_USER_ROLE_ROLE_ID_USER_ID",
                table: "USER_ROLE",
                columns: new[] { "ROLE_ID", "USER_ID" },
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BATCH");

            migrationBuilder.DropTable(
                name: "CUSTOMER");

            migrationBuilder.DropTable(
                name: "PERMISSION_ROLE");

            migrationBuilder.DropTable(
                name: "SALESMAN");

            migrationBuilder.DropTable(
                name: "USER_ROLE");

            migrationBuilder.DropTable(
                name: "PRODUCT");

            migrationBuilder.DropTable(
                name: "OUTLET_TYPE");

            migrationBuilder.DropTable(
                name: "SALES_AREA");

            migrationBuilder.DropTable(
                name: "ROLE");

            migrationBuilder.DropTable(
                name: "USER");

            migrationBuilder.DropTable(
                name: "MED_CAT");

            migrationBuilder.DropTable(
                name: "PRINCIPAL");

            migrationBuilder.DropTable(
                name: "UOM");

            migrationBuilder.DropTable(
                name: "USAGE_TYPE");

            migrationBuilder.DropTable(
                name: "LOCATION");
        }
    }
}
