using Microsoft.EntityFrameworkCore.Migrations;

namespace Infraestrutura.Migrations
{
    public partial class CriacaoInicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TB_ARTIGO",
                columns: table => new
                {
                    ART_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ART_CATEGORIA = table.Column<int>(type: "int", nullable: false),
                    ART_CONTEUDO = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_ARTIGO", x => x.ART_ID);
                });

            migrationBuilder.CreateTable(
                name: "TB_CADASTRO_IMAGENS",
                columns: table => new
                {
                    IMG_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IMG_NOME_ARQUIVO = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IMG_CAMINHO_ARQUIVO = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IMG_TITULO = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IMG_LEGENDA = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IMG_LINK = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IMG_STATUS = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_CADASTRO_IMAGENS", x => x.IMG_ID);
                });

            migrationBuilder.CreateTable(
                name: "TB_RELATOS_CLIENTES",
                columns: table => new
                {
                    REL_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    REL_NOME_ARQUIVO = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    REL_CAMINHO_ARQUIVO = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    REL_DEPOIMENTO = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    REL_STATUS = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_RELATOS_CLIENTES", x => x.REL_ID);
                });

            migrationBuilder.CreateTable(
                name: "TB_USUARIOS",
                columns: table => new
                {
                    USR_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    USR_CPF = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    USR_STATUS = table.Column<bool>(type: "bit", nullable: false),
                    USR_TIPO = table.Column<int>(type: "int", nullable: false),
                    USR_SENHA = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_USUARIOS", x => x.USR_ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TB_ARTIGO");

            migrationBuilder.DropTable(
                name: "TB_CADASTRO_IMAGENS");

            migrationBuilder.DropTable(
                name: "TB_RELATOS_CLIENTES");

            migrationBuilder.DropTable(
                name: "TB_USUARIOS");
        }
    }
}
