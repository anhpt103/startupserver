using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ATKSmartApi.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TblGroup",
                columns: table => new
                {
                    GroupId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GroupName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    StoreId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblGroup", x => x.GroupId);
                });

            migrationBuilder.CreateTable(
                name: "TblGroupMenu",
                columns: table => new
                {
                    Menu = table.Column<string>(nullable: false),
                    GroupId = table.Column<int>(nullable: false),
                    StoreId = table.Column<int>(nullable: false),
                    View = table.Column<bool>(nullable: false),
                    Add = table.Column<bool>(nullable: false),
                    Edit = table.Column<bool>(nullable: false),
                    Delete = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblGroupMenu", x => new { x.Menu, x.GroupId });
                });

            migrationBuilder.CreateTable(
                name: "TblProduct",
                columns: table => new
                {
                    ProductId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    CreateBy = table.Column<string>(type: "varchar(50)", maxLength: 20, nullable: true),
                    UpdateDate = table.Column<DateTime>(nullable: true),
                    UpdateBy = table.Column<string>(type: "varchar(50)", maxLength: 20, nullable: true),
                    StoreId = table.Column<int>(nullable: false),
                    ProductCode = table.Column<string>(type: "varchar(5)", maxLength: 5, nullable: false),
                    ProductName = table.Column<string>(type: "nvarchar(150)", maxLength: 100, nullable: false),
                    SupplierId = table.Column<int>(nullable: false),
                    TaxId = table.Column<int>(nullable: false),
                    UnitCalcId = table.Column<int>(nullable: true),
                    ProductPrice = table.Column<decimal>(nullable: false),
                    ProductInventory = table.Column<decimal>(nullable: false),
                    Description = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Status = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblProduct", x => x.ProductId);
                });

            migrationBuilder.CreateTable(
                name: "TblRoom",
                columns: table => new
                {
                    RoomId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    CreateBy = table.Column<string>(type: "varchar(50)", maxLength: 20, nullable: true),
                    UpdateDate = table.Column<DateTime>(nullable: true),
                    UpdateBy = table.Column<string>(type: "varchar(50)", maxLength: 20, nullable: true),
                    StoreId = table.Column<int>(nullable: false),
                    RoomName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    RoomType = table.Column<int>(nullable: false),
                    RoomPrice = table.Column<decimal>(nullable: false),
                    Description = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Status = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblRoom", x => x.RoomId);
                });

            migrationBuilder.CreateTable(
                name: "TblStore",
                columns: table => new
                {
                    StoreId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StoreName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Address = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblStore", x => x.StoreId);
                });

            migrationBuilder.CreateTable(
                name: "TblSupplier",
                columns: table => new
                {
                    SupplierId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    CreateBy = table.Column<string>(type: "varchar(50)", maxLength: 20, nullable: true),
                    UpdateDate = table.Column<DateTime>(nullable: true),
                    UpdateBy = table.Column<string>(type: "varchar(50)", maxLength: 20, nullable: true),
                    StoreId = table.Column<int>(nullable: false),
                    SupplierName = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Address = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    Description = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Status = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblSupplier", x => x.SupplierId);
                });

            migrationBuilder.CreateTable(
                name: "TblTax",
                columns: table => new
                {
                    TaxId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    CreateBy = table.Column<string>(type: "varchar(50)", maxLength: 20, nullable: true),
                    UpdateDate = table.Column<DateTime>(nullable: true),
                    UpdateBy = table.Column<string>(type: "varchar(50)", maxLength: 20, nullable: true),
                    StoreId = table.Column<int>(nullable: false),
                    TaxName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    TaxValue = table.Column<decimal>(nullable: false),
                    Status = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblTax", x => x.TaxId);
                });

            migrationBuilder.CreateTable(
                name: "TblUnitCalc",
                columns: table => new
                {
                    UnitCalcId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    CreateBy = table.Column<string>(type: "varchar(50)", maxLength: 20, nullable: true),
                    UpdateDate = table.Column<DateTime>(nullable: true),
                    UpdateBy = table.Column<string>(type: "varchar(50)", maxLength: 20, nullable: true),
                    StoreId = table.Column<int>(nullable: false),
                    UnitCalcName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Status = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblUnitCalc", x => x.UnitCalcId);
                });

            migrationBuilder.CreateTable(
                name: "TblUser",
                columns: table => new
                {
                    UserId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Email = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true),
                    PhoneNumber = table.Column<string>(type: "varchar(15)", maxLength: 15, nullable: true),
                    Address = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Username = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    Password = table.Column<string>(type: "varchar(32)", maxLength: 32, nullable: false),
                    Token = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblUser", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "TblUserGroup",
                columns: table => new
                {
                    UserGroupId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(nullable: false),
                    StoreId = table.Column<int>(nullable: false),
                    GroupId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblUserGroup", x => x.UserGroupId);
                });

            migrationBuilder.CreateTable(
                name: "TblUserMenu",
                columns: table => new
                {
                    Menu = table.Column<string>(nullable: false),
                    UserId = table.Column<int>(nullable: false),
                    StoreId = table.Column<int>(nullable: false),
                    View = table.Column<bool>(nullable: false),
                    Add = table.Column<bool>(nullable: false),
                    Edit = table.Column<bool>(nullable: false),
                    Delete = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblUserMenu", x => new { x.Menu, x.UserId });
                });

            migrationBuilder.CreateTable(
                name: "TblUserStore",
                columns: table => new
                {
                    UserId = table.Column<int>(nullable: false),
                    StoreId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblUserStore", x => new { x.UserId, x.StoreId });
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TblGroup");

            migrationBuilder.DropTable(
                name: "TblGroupMenu");

            migrationBuilder.DropTable(
                name: "TblProduct");

            migrationBuilder.DropTable(
                name: "TblRoom");

            migrationBuilder.DropTable(
                name: "TblStore");

            migrationBuilder.DropTable(
                name: "TblSupplier");

            migrationBuilder.DropTable(
                name: "TblTax");

            migrationBuilder.DropTable(
                name: "TblUnitCalc");

            migrationBuilder.DropTable(
                name: "TblUser");

            migrationBuilder.DropTable(
                name: "TblUserGroup");

            migrationBuilder.DropTable(
                name: "TblUserMenu");

            migrationBuilder.DropTable(
                name: "TblUserStore");
        }
    }
}
