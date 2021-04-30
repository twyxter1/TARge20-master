using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TARge20.Data.Migrations
{
    public partial class Andmebaas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Ametinimetused",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nimetus = table.Column<int>(type: "int", nullable: false),
                    Kommentaar = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ametinimetused", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Haiguslehe_tyyp",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nimetus = table.Column<int>(type: "int", nullable: false),
                    Kommentaar = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Haiguslehe_tyyp", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Harukontor",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Aadress = table.Column<int>(type: "int", nullable: false),
                    Telefoninumber = table.Column<int>(type: "int", nullable: false),
                    Email = table.Column<int>(type: "int", nullable: false),
                    Kommentaar = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Harukontor", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Laenutatav_ese",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Eseme_nimi = table.Column<int>(type: "int", nullable: false),
                    Kommentaar = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Laenutatav_ese", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Ligipaasuloa_tyyp",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Ligipaas = table.Column<int>(type: "int", nullable: false),
                    Kommentaar = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ligipaasuloa_tyyp", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Palved",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Saaja_Id = table.Column<int>(type: "int", nullable: false),
                    Saatja_Id = table.Column<int>(type: "int", nullable: false),
                    Kuupaev = table.Column<int>(type: "int", nullable: false),
                    Kommentaar = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Palved", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Puhkuse_tyyp",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nimetus = table.Column<int>(type: "int", nullable: false),
                    Kommentaar = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Puhkuse_tyyp", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Vihjed",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Saaja_id = table.Column<int>(type: "int", nullable: false),
                    Kuupaev = table.Column<int>(type: "int", nullable: false),
                    Kommentaar = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vihjed", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "T66suhe",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AmetinimetusedId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    HarukontorId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Tootaja_Id = table.Column<int>(type: "int", nullable: false),
                    Harukontori_Id = table.Column<int>(type: "int", nullable: false),
                    Ametinimetus_Id = table.Column<int>(type: "int", nullable: false),
                    Tool_alates = table.Column<int>(type: "int", nullable: false),
                    Tool_kuni = table.Column<int>(type: "int", nullable: false),
                    Koormus = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T66suhe", x => x.Id);
                    table.ForeignKey(
                        name: "FK_T66suhe_Ametinimetused_AmetinimetusedId",
                        column: x => x.AmetinimetusedId,
                        principalTable: "Ametinimetused",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_T66suhe_Harukontor_HarukontorId",
                        column: x => x.HarukontorId,
                        principalTable: "Harukontor",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Employee",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PalvedId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    VihjedId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Isikukood = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Kontaktaadress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Kontakttelefon = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Kommentaar = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employee", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Employee_Palved_PalvedId",
                        column: x => x.PalvedId,
                        principalTable: "Palved",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Employee_Vihjed_VihjedId",
                        column: x => x.VihjedId,
                        principalTable: "Vihjed",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Haiguslehed",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    EmployeeId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Haiguslehe_tyypId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Tootaja_Id = table.Column<int>(type: "int", nullable: false),
                    Haiguslehe_tyyp_Id = table.Column<int>(type: "int", nullable: false),
                    Haiguslehe_algus = table.Column<int>(type: "int", nullable: false),
                    Haiguslehe_l6pp = table.Column<int>(type: "int", nullable: false),
                    Kommentaar = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Haiguslehed", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Haiguslehed_Employee_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employee",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Haiguslehed_Haiguslehe_tyyp_Haiguslehe_tyypId",
                        column: x => x.Haiguslehe_tyypId,
                        principalTable: "Haiguslehe_tyyp",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Laenutuskord",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    EmployeeId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Laenutatav_eseId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Laenutatav_ese_Id = table.Column<int>(type: "int", nullable: false),
                    Tootaja_Id = table.Column<int>(type: "int", nullable: false),
                    Laenutuse_algus = table.Column<int>(type: "int", nullable: false),
                    Laenutuse_l6pp = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Laenutuskord", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Laenutuskord_Employee_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employee",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Laenutuskord_Laenutatav_ese_Laenutatav_eseId",
                        column: x => x.Laenutatav_eseId,
                        principalTable: "Laenutatav_ese",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Ligipaasuluba",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    EmployeeId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Ligipaasuloa_tyypId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Tootaja_Id = table.Column<int>(type: "int", nullable: false),
                    Ligipaasuloa_tyyp_Id = table.Column<int>(type: "int", nullable: false),
                    Ligipaasu_algus = table.Column<int>(type: "int", nullable: false),
                    Ligipaasu_lopp = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ligipaasuluba", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ligipaasuluba_Employee_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employee",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Ligipaasuluba_Ligipaasuloa_tyyp_Ligipaasuloa_tyypId",
                        column: x => x.Ligipaasuloa_tyypId,
                        principalTable: "Ligipaasuloa_tyyp",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Puhkused",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    EmployeeId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Puhkuse_tyypId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Tootaja_Id = table.Column<int>(type: "int", nullable: false),
                    Puhkuse_tyyp_Id = table.Column<int>(type: "int", nullable: false),
                    Puhkuse_algus = table.Column<int>(type: "int", nullable: false),
                    Puhkuse_l6pp = table.Column<int>(type: "int", nullable: false),
                    Kommentaar = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Puhkused", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Puhkused_Employee_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employee",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Puhkused_Puhkuse_tyyp_Puhkuse_tyypId",
                        column: x => x.Puhkuse_tyypId,
                        principalTable: "Puhkuse_tyyp",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Tervisekontrollid",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    EmployeeId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Tootaja_Id = table.Column<int>(type: "int", nullable: false),
                    Kuupaev = table.Column<int>(type: "int", nullable: false),
                    Kellaaeg = table.Column<int>(type: "int", nullable: false),
                    Tulemus = table.Column<int>(type: "int", nullable: false),
                    Kommentaar = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tervisekontrollid", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tervisekontrollid_Employee_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employee",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Tootaja_laps",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    EmployeeId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Tootaja_id = table.Column<int>(type: "int", nullable: false),
                    Eesnimi = table.Column<int>(type: "int", nullable: false),
                    Perekonnanimi = table.Column<int>(type: "int", nullable: false),
                    Synniaeg = table.Column<int>(type: "int", nullable: false),
                    Kommentaar = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tootaja_laps", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tootaja_laps_Employee_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employee",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Employee_PalvedId",
                table: "Employee",
                column: "PalvedId");

            migrationBuilder.CreateIndex(
                name: "IX_Employee_VihjedId",
                table: "Employee",
                column: "VihjedId");

            migrationBuilder.CreateIndex(
                name: "IX_Haiguslehed_EmployeeId",
                table: "Haiguslehed",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Haiguslehed_Haiguslehe_tyypId",
                table: "Haiguslehed",
                column: "Haiguslehe_tyypId");

            migrationBuilder.CreateIndex(
                name: "IX_Laenutuskord_EmployeeId",
                table: "Laenutuskord",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Laenutuskord_Laenutatav_eseId",
                table: "Laenutuskord",
                column: "Laenutatav_eseId");

            migrationBuilder.CreateIndex(
                name: "IX_Ligipaasuluba_EmployeeId",
                table: "Ligipaasuluba",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Ligipaasuluba_Ligipaasuloa_tyypId",
                table: "Ligipaasuluba",
                column: "Ligipaasuloa_tyypId");

            migrationBuilder.CreateIndex(
                name: "IX_Puhkused_EmployeeId",
                table: "Puhkused",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Puhkused_Puhkuse_tyypId",
                table: "Puhkused",
                column: "Puhkuse_tyypId");

            migrationBuilder.CreateIndex(
                name: "IX_T66suhe_AmetinimetusedId",
                table: "T66suhe",
                column: "AmetinimetusedId");

            migrationBuilder.CreateIndex(
                name: "IX_T66suhe_HarukontorId",
                table: "T66suhe",
                column: "HarukontorId");

            migrationBuilder.CreateIndex(
                name: "IX_Tervisekontrollid_EmployeeId",
                table: "Tervisekontrollid",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Tootaja_laps_EmployeeId",
                table: "Tootaja_laps",
                column: "EmployeeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Haiguslehed");

            migrationBuilder.DropTable(
                name: "Laenutuskord");

            migrationBuilder.DropTable(
                name: "Ligipaasuluba");

            migrationBuilder.DropTable(
                name: "Puhkused");

            migrationBuilder.DropTable(
                name: "T66suhe");

            migrationBuilder.DropTable(
                name: "Tervisekontrollid");

            migrationBuilder.DropTable(
                name: "Tootaja_laps");

            migrationBuilder.DropTable(
                name: "Haiguslehe_tyyp");

            migrationBuilder.DropTable(
                name: "Laenutatav_ese");

            migrationBuilder.DropTable(
                name: "Ligipaasuloa_tyyp");

            migrationBuilder.DropTable(
                name: "Puhkuse_tyyp");

            migrationBuilder.DropTable(
                name: "Ametinimetused");

            migrationBuilder.DropTable(
                name: "Harukontor");

            migrationBuilder.DropTable(
                name: "Employee");

            migrationBuilder.DropTable(
                name: "Palved");

            migrationBuilder.DropTable(
                name: "Vihjed");
        }
    }
}
