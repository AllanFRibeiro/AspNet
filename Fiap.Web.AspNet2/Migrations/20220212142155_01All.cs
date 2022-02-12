using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Fiap.Web.AspNet2.Migrations
{
    public partial class _01All : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Loja",
                columns: table => new
                {
                    LojaId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomeLoja = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Loja", x => x.LojaId);
                });

            migrationBuilder.CreateTable(
                name: "Produto",
                columns: table => new
                {
                    ProdutoId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomeProduto = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Produto", x => x.ProdutoId);
                });

            migrationBuilder.CreateTable(
                name: "Representante",
                columns: table => new
                {
                    RepresentanteId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomeRepresentante = table.Column<string>(maxLength: 70, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Representante", x => x.RepresentanteId);
                });

            migrationBuilder.CreateTable(
                name: "ProdutoLoja",
                columns: table => new
                {
                    ProdutoLojaId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LojaId = table.Column<int>(nullable: false),
                    ProdutoId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProdutoLoja", x => x.ProdutoLojaId);
                    table.ForeignKey(
                        name: "FK_ProdutoLoja_Loja_LojaId",
                        column: x => x.LojaId,
                        principalTable: "Loja",
                        principalColumn: "LojaId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProdutoLoja_Produto_ProdutoId",
                        column: x => x.ProdutoId,
                        principalTable: "Produto",
                        principalColumn: "ProdutoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Cliente",
                columns: table => new
                {
                    ClienteId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: false),
                    DataNascimento = table.Column<DateTime>(nullable: false),
                    Observacao = table.Column<string>(nullable: true),
                    RepresentanteId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cliente", x => x.ClienteId);
                    table.ForeignKey(
                        name: "FK_Cliente_Representante_RepresentanteId",
                        column: x => x.RepresentanteId,
                        principalTable: "Representante",
                        principalColumn: "RepresentanteId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cliente_RepresentanteId",
                table: "Cliente",
                column: "RepresentanteId");

            migrationBuilder.CreateIndex(
                name: "IX_ProdutoLoja_LojaId",
                table: "ProdutoLoja",
                column: "LojaId");

            migrationBuilder.CreateIndex(
                name: "IX_ProdutoLoja_ProdutoId",
                table: "ProdutoLoja",
                column: "ProdutoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cliente");

            migrationBuilder.DropTable(
                name: "ProdutoLoja");

            migrationBuilder.DropTable(
                name: "Representante");

            migrationBuilder.DropTable(
                name: "Loja");

            migrationBuilder.DropTable(
                name: "Produto");
        }
    }
}
