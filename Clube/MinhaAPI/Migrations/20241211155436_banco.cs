using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MinhaAPI.Migrations
{
    /// <inheritdoc />
    public partial class banco : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Associado",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomeTitular = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Endereco = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Bairro = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cep = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Complemento = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CidadeId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EstadoId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Celular = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Facebook = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Instagram = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CPF = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RegistroGeral = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DataNascimento = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TipoDeAssociacao = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Associado", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Cidade",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DDD = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EstadoId = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cidade", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Convidado",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CPF = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RegistroGeral = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Celular = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EventoId = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Convidado", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Dependente",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CPF = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RG = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DataNascimento = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TipoVinculo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SocioTitular_Associado = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dependente", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EspacoLocavel",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomeEspaco = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Tamanho = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CapacidadePessoas = table.Column<int>(type: "int", nullable: false),
                    Locavel = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EspacoLocavel", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Estado",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Sigla = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Estado", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Evento",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Descricao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EspacoLocavelId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ResponsavelId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Inicio = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Fim = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ValorLocacao = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Evento", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Fornecedor",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomeRazaoSocial = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Endereco = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Bairro = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Numero = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CEP = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CidadeId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SiglaId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Celular = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Facebook = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Instagram = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fornecedor", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Produto",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Descricao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Preco = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    FornecedorId = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Produto", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Associado");

            migrationBuilder.DropTable(
                name: "Cidade");

            migrationBuilder.DropTable(
                name: "Convidado");

            migrationBuilder.DropTable(
                name: "Dependente");

            migrationBuilder.DropTable(
                name: "EspacoLocavel");

            migrationBuilder.DropTable(
                name: "Estado");

            migrationBuilder.DropTable(
                name: "Evento");

            migrationBuilder.DropTable(
                name: "Fornecedor");

            migrationBuilder.DropTable(
                name: "Produto");
        }
    }
}
