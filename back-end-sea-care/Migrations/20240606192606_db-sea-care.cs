using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace back_end_sea_care.Migrations
{
    /// <inheritdoc />
    public partial class dbseacare : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TB_CATEGORIA",
                columns: table => new
                {
                    ID_CATEGORIA = table.Column<long>(type: "NUMBER(19)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    NM_CATEGORIA = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_CATEGORIA", x => x.ID_CATEGORIA);
                });

            migrationBuilder.CreateTable(
                name: "TB_EVENTO",
                columns: table => new
                {
                    ID_EVENTO = table.Column<long>(type: "NUMBER(19)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    NM_EVENTO = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    DT_EVENTO = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: false),
                    TP_EVENTO = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    DESCRICAO = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    FOTO = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    LOCAL = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    NR_PARTICIPANTES = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    AVALIACAO = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    MEDIA_AVALIACOES = table.Column<double>(type: "BINARY_DOUBLE", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_EVENTO", x => x.ID_EVENTO);
                });

            migrationBuilder.CreateTable(
                name: "TB_FORNECEDOR",
                columns: table => new
                {
                    ID_FORNECEDOR = table.Column<long>(type: "NUMBER(19)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    NM_FORNECEDOR = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    CNPJ = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    TELEFONE = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    SETOR = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_FORNECEDOR", x => x.ID_FORNECEDOR);
                });

            migrationBuilder.CreateTable(
                name: "TB_PARCEIROS",
                columns: table => new
                {
                    ID_PARCEIRO = table.Column<long>(type: "NUMBER(19)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    NM_PARCEIRO = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    CNPJ = table.Column<string>(type: "NVARCHAR2(18)", maxLength: 18, nullable: false),
                    TELEFONE = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    SETOR = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    EMAIL = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    STATUS = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    DT_INICIO = table.Column<string>(type: "NVARCHAR2(10)", nullable: false),
                    DT_FIM = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_PARCEIROS", x => x.ID_PARCEIRO);
                });

            migrationBuilder.CreateTable(
                name: "TB_USUARIO",
                columns: table => new
                {
                    ID_USUARIO = table.Column<long>(type: "NUMBER(19)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    NM_USUARIO = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    NL_PERMISSAO = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    CPF = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    LOGIN = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    SENHA = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    CEP = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    EMAIL = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    TELEFONE = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_USUARIO", x => x.ID_USUARIO);
                });

            migrationBuilder.CreateTable(
                name: "TB_PRODUTO",
                columns: table => new
                {
                    ID_PRODUTO = table.Column<long>(type: "NUMBER(19)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    NM_PRODUTO = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    VL_PRODUTO = table.Column<double>(type: "BINARY_DOUBLE", nullable: false),
                    LINK = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    FornecedorId = table.Column<long>(type: "NUMBER(19)", nullable: false),
                    CategoriaId = table.Column<long>(type: "NUMBER(19)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_PRODUTO", x => x.ID_PRODUTO);
                    table.ForeignKey(
                        name: "FK_TB_PRODUTO_TB_CATEGORIA_CategoriaId",
                        column: x => x.CategoriaId,
                        principalTable: "TB_CATEGORIA",
                        principalColumn: "ID_CATEGORIA",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TB_PRODUTO_TB_FORNECEDOR_FornecedorId",
                        column: x => x.FornecedorId,
                        principalTable: "TB_FORNECEDOR",
                        principalColumn: "ID_FORNECEDOR",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EventoParceiro",
                columns: table => new
                {
                    EventosId = table.Column<long>(type: "NUMBER(19)", nullable: false),
                    ParceirosId = table.Column<long>(type: "NUMBER(19)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EventoParceiro", x => new { x.EventosId, x.ParceirosId });
                    table.ForeignKey(
                        name: "FK_EventoParceiro_TB_EVENTO_EventosId",
                        column: x => x.EventosId,
                        principalTable: "TB_EVENTO",
                        principalColumn: "ID_EVENTO",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EventoParceiro_TB_PARCEIROS_ParceirosId",
                        column: x => x.ParceirosId,
                        principalTable: "TB_PARCEIROS",
                        principalColumn: "ID_PARCEIRO",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TB_INSCRICAO",
                columns: table => new
                {
                    ID_INSCRICAO = table.Column<long>(type: "NUMBER(19)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    DT_INSCRICAO = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: false),
                    EventoId = table.Column<long>(type: "NUMBER(19)", nullable: false),
                    UsuarioId = table.Column<long>(type: "NUMBER(19)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_INSCRICAO", x => x.ID_INSCRICAO);
                    table.ForeignKey(
                        name: "FK_TB_INSCRICAO_TB_EVENTO_EventoId",
                        column: x => x.EventoId,
                        principalTable: "TB_EVENTO",
                        principalColumn: "ID_EVENTO",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TB_INSCRICAO_TB_USUARIO_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "TB_USUARIO",
                        principalColumn: "ID_USUARIO",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TB_RELATO",
                columns: table => new
                {
                    ID_RELATO = table.Column<long>(type: "NUMBER(19)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    NM_RELATO = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    DESCRICAO = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    FOTO = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    UsuarioId = table.Column<long>(type: "NUMBER(19)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_RELATO", x => x.ID_RELATO);
                    table.ForeignKey(
                        name: "FK_TB_RELATO_TB_USUARIO_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "TB_USUARIO",
                        principalColumn: "ID_USUARIO",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_EventoParceiro_ParceirosId",
                table: "EventoParceiro",
                column: "ParceirosId");

            migrationBuilder.CreateIndex(
                name: "IX_TB_INSCRICAO_EventoId",
                table: "TB_INSCRICAO",
                column: "EventoId");

            migrationBuilder.CreateIndex(
                name: "IX_TB_INSCRICAO_UsuarioId",
                table: "TB_INSCRICAO",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_TB_PRODUTO_CategoriaId",
                table: "TB_PRODUTO",
                column: "CategoriaId");

            migrationBuilder.CreateIndex(
                name: "IX_TB_PRODUTO_FornecedorId",
                table: "TB_PRODUTO",
                column: "FornecedorId");

            migrationBuilder.CreateIndex(
                name: "IX_TB_RELATO_UsuarioId",
                table: "TB_RELATO",
                column: "UsuarioId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EventoParceiro");

            migrationBuilder.DropTable(
                name: "TB_INSCRICAO");

            migrationBuilder.DropTable(
                name: "TB_PRODUTO");

            migrationBuilder.DropTable(
                name: "TB_RELATO");

            migrationBuilder.DropTable(
                name: "TB_PARCEIROS");

            migrationBuilder.DropTable(
                name: "TB_EVENTO");

            migrationBuilder.DropTable(
                name: "TB_CATEGORIA");

            migrationBuilder.DropTable(
                name: "TB_FORNECEDOR");

            migrationBuilder.DropTable(
                name: "TB_USUARIO");
        }
    }
}
