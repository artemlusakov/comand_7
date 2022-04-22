using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorWebAssemblySignalRApp.Server.Migrations
{
    public partial class ono : Migration
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
                    time_creation = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dialogs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id_user = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    time_creation = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id_user);
                });

            migrationBuilder.CreateTable(
                name: "Massages",
                columns: table => new
                {
                    Id_massages = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    dialog_id = table.Column<int>(type: "int", nullable: false),
                    text = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    time_creation = table.Column<DateTime>(type: "datetime2", nullable: false),
                    text_changed = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Massages", x => x.Id_massages);
                    table.ForeignKey(
                        name: "FK_Massages_Dialogs_dialog_id",
                        column: x => x.dialog_id,
                        principalTable: "Dialogs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Friends",
                columns: table => new
                {
                    Id_friends = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    user_id = table.Column<int>(type: "int", nullable: false),
                    time_creation = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Friends", x => x.Id_friends);
                    table.ForeignKey(
                        name: "FK_Friends_Users_user_id",
                        column: x => x.user_id,
                        principalTable: "Users",
                        principalColumn: "Id_user",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Id_roles = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    user_id = table.Column<int>(type: "int", nullable: false),
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
                    table.ForeignKey(
                        name: "FK_Roles_Users_user_id",
                        column: x => x.user_id,
                        principalTable: "Users",
                        principalColumn: "Id_user",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserToDialogs",
                columns: table => new
                {
                    Id_user_to_dialogs = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    user_id = table.Column<int>(type: "int", nullable: false),
                    dialogs_id = table.Column<int>(type: "int", nullable: false),
                    time_creation = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserToDialogs", x => x.Id_user_to_dialogs);
                    table.ForeignKey(
                        name: "FK_UserToDialogs_Dialogs_dialogs_id",
                        column: x => x.dialogs_id,
                        principalTable: "Dialogs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserToDialogs_Users_user_id",
                        column: x => x.user_id,
                        principalTable: "Users",
                        principalColumn: "Id_user",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MassageToPhotos",
                columns: table => new
                {
                    photo_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    massage_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MassageToPhotos", x => x.photo_id);
                    table.ForeignKey(
                        name: "FK_MassageToPhotos_Massages_massage_id",
                        column: x => x.massage_id,
                        principalTable: "Massages",
                        principalColumn: "Id_massages",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Photos",
                columns: table => new
                {
                    Photo_id = table.Column<int>(type: "int", nullable: false),
                    Path = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    time_creation = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Photos", x => x.Photo_id);
                    table.ForeignKey(
                        name: "FK_Photos_MassageToPhotos_Photo_id",
                        column: x => x.Photo_id,
                        principalTable: "MassageToPhotos",
                        principalColumn: "photo_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Friends_user_id",
                table: "Friends",
                column: "user_id");

            migrationBuilder.CreateIndex(
                name: "IX_Massages_dialog_id",
                table: "Massages",
                column: "dialog_id");

            migrationBuilder.CreateIndex(
                name: "IX_MassageToPhotos_massage_id",
                table: "MassageToPhotos",
                column: "massage_id");

            migrationBuilder.CreateIndex(
                name: "IX_Roles_Id_dialogs",
                table: "Roles",
                column: "Id_dialogs");

            migrationBuilder.CreateIndex(
                name: "IX_Roles_user_id",
                table: "Roles",
                column: "user_id");

            migrationBuilder.CreateIndex(
                name: "IX_UserToDialogs_dialogs_id",
                table: "UserToDialogs",
                column: "dialogs_id");

            migrationBuilder.CreateIndex(
                name: "IX_UserToDialogs_user_id",
                table: "UserToDialogs",
                column: "user_id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Friends");

            migrationBuilder.DropTable(
                name: "Photos");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "UserToDialogs");

            migrationBuilder.DropTable(
                name: "MassageToPhotos");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Massages");

            migrationBuilder.DropTable(
                name: "Dialogs");
        }
    }
}
