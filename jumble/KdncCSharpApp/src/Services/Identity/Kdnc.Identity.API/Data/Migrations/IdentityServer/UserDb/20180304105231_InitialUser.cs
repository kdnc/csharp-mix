using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace Kdnc.Identity.API.Data.Migrations.IdentityServer.UserDb
{
    public partial class InitialUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    IsActive = table.Column<bool>(nullable: false),
                    Name = table.Column<string>(maxLength: 50, nullable: true),
                    Password = table.Column<string>(maxLength: 50, nullable: false),
                    SubjectId = table.Column<Guid>(nullable: false),
                    UserName = table.Column<string>(maxLength: 50, nullable: false),
                    Website = table.Column<string>(maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserExternalProviders",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ProviderName = table.Column<string>(nullable: true),
                    ProviderSubjectId = table.Column<string>(maxLength: 250, nullable: true),
                    UserId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserExternalProviders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserExternalProviders_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_UserExternalProviders_ProviderName",
                table: "UserExternalProviders",
                column: "ProviderName");

            migrationBuilder.CreateIndex(
                name: "IX_UserExternalProviders_ProviderSubjectId",
                table: "UserExternalProviders",
                column: "ProviderSubjectId");

            migrationBuilder.CreateIndex(
                name: "IX_UserExternalProviders_UserId",
                table: "UserExternalProviders",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserExternalProviders_ProviderName_ProviderSubjectId",
                table: "UserExternalProviders",
                columns: new[] { "ProviderName", "ProviderSubjectId" },
                unique: true,
                filter: "[ProviderName] IS NOT NULL AND [ProviderSubjectId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Users_SubjectId",
                table: "Users",
                column: "SubjectId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Users_UserName",
                table: "Users",
                column: "UserName",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserExternalProviders");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
