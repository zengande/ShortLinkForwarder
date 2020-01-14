using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace ShortLinkForwarder.Migrations
{
    public partial class AddLink : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AppLinks",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    OriginUrl = table.Column<string>(maxLength: 256, nullable: false),
                    Token = table.Column<string>(maxLength: 32, nullable: false),
                    Remarks = table.Column<string>(nullable: true),
                    Enabled = table.Column<bool>(nullable: false, defaultValue: true),
                    UpdateTimeUtc = table.Column<DateTime>(nullable: false),
                    ExpirationTimeUtc = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppLinks", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AppLinks");
        }
    }
}
