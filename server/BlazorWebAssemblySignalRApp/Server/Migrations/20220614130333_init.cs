using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorWebAssemblySignalRApp.Server.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Dialogs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name_dialogs = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Time_creation = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dialogs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Massages",
                columns: table => new
                {
                    Id_massages = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Dialog_id = table.Column<int>(type: "int", nullable: false),
                    Text = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Time_creation = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Text_changed = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Massages", x => x.Id_massages);
                    table.ForeignKey(
                        name: "FK_Massages_Dialogs_Dialog_id",
                        column: x => x.Dialog_id,
                        principalTable: "Dialogs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Id_roles = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    User_id = table.Column<int>(type: "int", nullable: false),
                    Id_dialogs = table.Column<int>(type: "int", nullable: false),
                    role = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id_roles);
                    table.ForeignKey(
                        name: "FK_Roles_Dialogs_Id_dialogs",
                        column: x => x.Id_dialogs,
                        principalTable: "Dialogs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MassageToPhotos",
                columns: table => new
                {
                    Photo_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Massage_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MassageToPhotos", x => x.Photo_id);
                    table.ForeignKey(
                        name: "FK_MassageToPhotos_Massages_Massage_id",
                        column: x => x.Massage_id,
                        principalTable: "Massages",
                        principalColumn: "Id_massages",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id_user = table.Column<int>(type: "int", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Time_creation = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id_user);
                    table.ForeignKey(
                        name: "FK_User_Roles_Id_user",
                        column: x => x.Id_user,
                        principalTable: "Roles",
                        principalColumn: "Id_roles",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Photos",
                columns: table => new
                {
                    Photo_id = table.Column<int>(type: "int", nullable: false),
                    Path = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Time_creation = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Photos", x => x.Photo_id);
                    table.ForeignKey(
                        name: "FK_Photos_MassageToPhotos_Photo_id",
                        column: x => x.Photo_id,
                        principalTable: "MassageToPhotos",
                        principalColumn: "Photo_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Friends",
                columns: table => new
                {
                    Id_friends = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    User_id = table.Column<int>(type: "int", nullable: false),
                    Time_creation = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Friends", x => x.Id_friends);
                    table.ForeignKey(
                        name: "FK_Friends_User_User_id",
                        column: x => x.User_id,
                        principalTable: "User",
                        principalColumn: "Id_user",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserToDialogs",
                columns: table => new
                {
                    Id_user_to_dialogs = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    User_id = table.Column<int>(type: "int", nullable: false),
                    Dialogs_id = table.Column<int>(type: "int", nullable: false),
                    Time_creation = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserToDialogs", x => x.Id_user_to_dialogs);
                    table.ForeignKey(
                        name: "FK_UserToDialogs_Dialogs_Dialogs_id",
                        column: x => x.Dialogs_id,
                        principalTable: "Dialogs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserToDialogs_User_User_id",
                        column: x => x.User_id,
                        principalTable: "User",
                        principalColumn: "Id_user",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Friends_User_id",
                table: "Friends",
                column: "User_id");

            migrationBuilder.CreateIndex(
                name: "IX_Massages_Dialog_id",
                table: "Massages",
                column: "Dialog_id");

            migrationBuilder.CreateIndex(
                name: "IX_MassageToPhotos_Massage_id",
                table: "MassageToPhotos",
                column: "Massage_id");

            migrationBuilder.CreateIndex(
                name: "IX_Roles_Id_dialogs",
                table: "Roles",
                column: "Id_dialogs");

            migrationBuilder.CreateIndex(
                name: "IX_UserToDialogs_Dialogs_id",
                table: "UserToDialogs",
                column: "Dialogs_id");

            migrationBuilder.CreateIndex(
                name: "IX_UserToDialogs_User_id",
                table: "UserToDialogs",
                column: "User_id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Friends");

            migrationBuilder.DropTable(
                name: "Photos");

            migrationBuilder.DropTable(
                name: "UserToDialogs");

            migrationBuilder.DropTable(
                name: "MassageToPhotos");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "Massages");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "Dialogs");
        }
    }
}
