using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class inicial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "COMPROBANTES",
                columns: table => new
                {
                    Id = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    Fecha = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: true),
                    Estado = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    Cae = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    Numero = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    Emisor = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    Receptor = table.Column<int>(type: "NUMBER(10)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_COMPROBANTES", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "COMPROBANTES");
        }
    }
}
