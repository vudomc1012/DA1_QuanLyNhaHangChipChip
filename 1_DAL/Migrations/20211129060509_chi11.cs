using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace _1_DAL.Migrations
{
    public partial class chi11 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CachCheBien",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CachCheBien", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "DanhMucFood",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DanhMucFood", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "DonVi",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DonVi", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Floor",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false),
                    FloorNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Floor", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "MonAnChiTiet",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    IDUnit = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "money", nullable: false),
                    IDCategory = table.Column<int>(type: "int", nullable: false),
                    IDMethod = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: true),
                    GhiChu = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    Anh = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MonAnChiTiet", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MonAnChiTiet_CachChebien",
                        column: x => x.IDMethod,
                        principalTable: "CachCheBien",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MonAnChiTiet_DanhMucFood",
                        column: x => x.IDCategory,
                        principalTable: "DanhMucFood",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MonAnChiTiet_DonVi",
                        column: x => x.IDUnit,
                        principalTable: "DonVi",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "BanAn",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Floor = table.Column<int>(type: "int", nullable: true),
                    Busy = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true),
                    TinhTrang = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    Rong = table.Column<int>(type: "int", nullable: false),
                    Cao = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BanAn", x => x.ID);
                    table.ForeignKey(
                        name: "FK_BanAn_Floor",
                        column: x => x.Floor,
                        principalTable: "Floor",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "NhanVien",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false),
                    MaNV = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    Password = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: false),
                    Role = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Sex = table.Column<bool>(type: "bit", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    PhoneNo = table.Column<string>(type: "varchar(12)", unicode: false, maxLength: 12, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NhanVien", x => x.ID);
                    table.ForeignKey(
                        name: "FK_NhanVien_Roles",
                        column: x => x.Role,
                        principalTable: "Roles",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ThucDon",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false),
                    IDChiTiet = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Status = table.Column<decimal>(type: "money", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ThucDon", x => x.ID);
                    table.ForeignKey(
                        name: "FK_ThucDon_MonAnChiTiet",
                        column: x => x.IDChiTiet,
                        principalTable: "MonAnChiTiet",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "HoaDon",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false),
                    DateCheckIn = table.Column<DateTime>(type: "datetime", nullable: false),
                    DateCheckOut = table.Column<DateTime>(type: "datetime", nullable: false),
                    IDtable = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    TotalMoney = table.Column<decimal>(type: "money", nullable: false),
                    IDNhanVien = table.Column<int>(type: "int", nullable: false),
                    SoDT = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DiaChi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DichVu = table.Column<int>(type: "int", nullable: true),
                    GhiChu = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HoaDon", x => x.ID);
                    table.ForeignKey(
                        name: "FK_HoaDon_BanAn",
                        column: x => x.IDtable,
                        principalTable: "BanAn",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_HoaDon_NhanVien",
                        column: x => x.IDNhanVien,
                        principalTable: "NhanVien",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "HoaDonChiTiet",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false),
                    IDBill = table.Column<int>(type: "int", nullable: false),
                    IDFood = table.Column<int>(type: "int", nullable: false),
                    Count = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "money", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HoaDonChiTiet", x => x.ID);
                    table.ForeignKey(
                        name: "FK_HoaDonChiTiet_HoaDon",
                        column: x => x.IDBill,
                        principalTable: "HoaDon",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_HoaDonChiTiet_MonAnChiTiet",
                        column: x => x.IDFood,
                        principalTable: "MonAnChiTiet",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BanAn_Floor",
                table: "BanAn",
                column: "Floor");

            migrationBuilder.CreateIndex(
                name: "IX_HoaDon_IDNhanVien",
                table: "HoaDon",
                column: "IDNhanVien");

            migrationBuilder.CreateIndex(
                name: "IX_HoaDon_IDtable",
                table: "HoaDon",
                column: "IDtable");

            migrationBuilder.CreateIndex(
                name: "IX_HoaDonChiTiet_IDBill",
                table: "HoaDonChiTiet",
                column: "IDBill");

            migrationBuilder.CreateIndex(
                name: "IX_HoaDonChiTiet_IDFood",
                table: "HoaDonChiTiet",
                column: "IDFood");

            migrationBuilder.CreateIndex(
                name: "IX_MonAnChiTiet_IDCategory",
                table: "MonAnChiTiet",
                column: "IDCategory");

            migrationBuilder.CreateIndex(
                name: "IX_MonAnChiTiet_IDMethod",
                table: "MonAnChiTiet",
                column: "IDMethod");

            migrationBuilder.CreateIndex(
                name: "IX_MonAnChiTiet_IDUnit",
                table: "MonAnChiTiet",
                column: "IDUnit");

            migrationBuilder.CreateIndex(
                name: "IX_NhanVien_Role",
                table: "NhanVien",
                column: "Role");

            migrationBuilder.CreateIndex(
                name: "IX_ThucDon_IDChiTiet",
                table: "ThucDon",
                column: "IDChiTiet");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HoaDonChiTiet");

            migrationBuilder.DropTable(
                name: "ThucDon");

            migrationBuilder.DropTable(
                name: "HoaDon");

            migrationBuilder.DropTable(
                name: "MonAnChiTiet");

            migrationBuilder.DropTable(
                name: "BanAn");

            migrationBuilder.DropTable(
                name: "NhanVien");

            migrationBuilder.DropTable(
                name: "CachCheBien");

            migrationBuilder.DropTable(
                name: "DanhMucFood");

            migrationBuilder.DropTable(
                name: "DonVi");

            migrationBuilder.DropTable(
                name: "Floor");

            migrationBuilder.DropTable(
                name: "Roles");
        }
    }
}
