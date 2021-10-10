using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Identity.Api.Migrations
{
    public partial class IdentityDbContext_v1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "identity");

            migrationBuilder.CreateTable(
                name: "Role",
                schema: "identity",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Description = table.Column<string>(nullable: false),
                    Label = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Role", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserStatus",
                schema: "identity",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false, defaultValue: 1),
                    Name = table.Column<string>(maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserStatus", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "User",
                schema: "identity",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    StatusId = table.Column<int>(nullable: false),
                    Email = table.Column<string>(nullable: false),
                    FirstName = table.Column<string>(nullable: false),
                    Jwt = table.Column<string>(nullable: false),
                    LastName = table.Column<string>(nullable: false),
                    Password = table.Column<string>(nullable: false),
                    RoleId = table.Column<Guid>(nullable: false),
                    Username = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                    table.ForeignKey(
                        name: "FK_User_Role_RoleId",
                        column: x => x.RoleId,
                        principalSchema: "identity",
                        principalTable: "Role",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_User_UserStatus_StatusId",
                        column: x => x.StatusId,
                        principalSchema: "identity",
                        principalTable: "UserStatus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Role_Id",
                schema: "identity",
                table: "Role",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_User_Id",
                schema: "identity",
                table: "User",
                column: "Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_User_RoleId",
                schema: "identity",
                table: "User",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_User_StatusId",
                schema: "identity",
                table: "User",
                column: "StatusId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "User",
                schema: "identity");

            migrationBuilder.DropTable(
                name: "Role",
                schema: "identity");

            migrationBuilder.DropTable(
                name: "UserStatus",
                schema: "identity");
        }
    }
}
