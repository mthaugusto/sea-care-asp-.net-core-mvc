﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Oracle.EntityFrameworkCore.Metadata;
using back_end_sea_care.Persistencia;

#nullable disable

namespace back_end_sea_care.Migrations
{
    [DbContext(typeof(FiapDbContext))]
    [Migration("20240607021719_update-eventos")]
    partial class updateeventos
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            OracleModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("EventoParceiro", b =>
                {
                    b.Property<long>("EventosId")
                        .HasColumnType("NUMBER(19)");

                    b.Property<long>("ParceirosId")
                        .HasColumnType("NUMBER(19)");

                    b.HasKey("EventosId", "ParceirosId");

                    b.HasIndex("ParceirosId");

                    b.ToTable("EventoParceiro");
                });

            modelBuilder.Entity("back_end_sea_care.Models.Categoria", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(19)")
                        .HasColumnName("ID_CATEGORIA");

                    OraclePropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<string>("NomeCategoria")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)")
                        .HasColumnName("NM_CATEGORIA");

                    b.HasKey("Id");

                    b.ToTable("TB_CATEGORIA");
                });

            modelBuilder.Entity("back_end_sea_care.Models.Evento", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(19)")
                        .HasColumnName("ID_EVENTO");

                    OraclePropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<int>("Avaliacao")
                        .HasColumnType("NUMBER(10)")
                        .HasColumnName("AVALIACAO");

                    b.Property<DateTime>("DataEvento")
                        .HasColumnType("TIMESTAMP(7)")
                        .HasColumnName("DT_EVENTO");

                    b.Property<string>("DescricaoEvento")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)")
                        .HasColumnName("DESCRICAO");

                    b.Property<string>("Foto")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)")
                        .HasColumnName("FOTO");

                    b.Property<string>("Local")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)")
                        .HasColumnName("LOCAL");

                    b.Property<double>("MediaAvaliacoes")
                        .HasColumnType("BINARY_DOUBLE")
                        .HasColumnName("MEDIA_AVALIACOES");

                    b.Property<string>("NomeEvento")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)")
                        .HasColumnName("NM_EVENTO");

                    b.Property<int>("NrParticipantes")
                        .HasColumnType("NUMBER(10)")
                        .HasColumnName("NR_PARTICIPANTES");

                    b.Property<string>("TipoEvento")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)")
                        .HasColumnName("TP_EVENTO");

                    b.HasKey("Id");

                    b.ToTable("TB_EVENTO");
                });

            modelBuilder.Entity("back_end_sea_care.Models.Fornecedor", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(19)")
                        .HasColumnName("ID_FORNECEDOR");

                    OraclePropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<string>("Cnpj")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)")
                        .HasColumnName("CNPJ");

                    b.Property<string>("NomeFornecedor")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)")
                        .HasColumnName("NM_FORNECEDOR");

                    b.Property<string>("Setor")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)")
                        .HasColumnName("SETOR");

                    b.Property<string>("Telefone")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)")
                        .HasColumnName("TELEFONE");

                    b.HasKey("Id");

                    b.ToTable("TB_FORNECEDOR");
                });

            modelBuilder.Entity("back_end_sea_care.Models.Inscricao", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(19)")
                        .HasColumnName("ID_INSCRICAO");

                    OraclePropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<DateTime>("DataInscricao")
                        .HasColumnType("TIMESTAMP(7)")
                        .HasColumnName("DT_INSCRICAO");

                    b.Property<long>("EventoId")
                        .HasColumnType("NUMBER(19)");

                    b.Property<long>("UsuarioId")
                        .HasColumnType("NUMBER(19)");

                    b.HasKey("Id");

                    b.HasIndex("EventoId");

                    b.HasIndex("UsuarioId");

                    b.ToTable("TB_INSCRICAO");
                });

            modelBuilder.Entity("back_end_sea_care.Models.Parceiro", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(19)")
                        .HasColumnName("ID_PARCEIRO");

                    OraclePropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<string>("Cnpj")
                        .IsRequired()
                        .HasMaxLength(18)
                        .HasColumnType("NVARCHAR2(18)")
                        .HasColumnName("CNPJ");

                    b.Property<string>("DtFim")
                        .HasColumnType("NVARCHAR2(10)")
                        .HasColumnName("DT_FIM");

                    b.Property<string>("DtInicio")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(10)")
                        .HasColumnName("DT_INICIO");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)")
                        .HasColumnName("EMAIL");

                    b.Property<string>("NomeParceiro")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)")
                        .HasColumnName("NM_PARCEIRO");

                    b.Property<string>("Setor")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)")
                        .HasColumnName("SETOR");

                    b.Property<int>("Status")
                        .HasColumnType("NUMBER(10)")
                        .HasColumnName("STATUS");

                    b.Property<string>("Telefone")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)")
                        .HasColumnName("TELEFONE");

                    b.HasKey("Id");

                    b.ToTable("TB_PARCEIROS");
                });

            modelBuilder.Entity("back_end_sea_care.Models.Produto", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(19)")
                        .HasColumnName("ID_PRODUTO");

                    OraclePropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<long>("CategoriaId")
                        .HasColumnType("NUMBER(19)");

                    b.Property<long>("FornecedorId")
                        .HasColumnType("NUMBER(19)");

                    b.Property<string>("LinkProduto")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)")
                        .HasColumnName("LINK");

                    b.Property<string>("NomeProduto")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)")
                        .HasColumnName("NM_PRODUTO");

                    b.Property<decimal>("ValorProduto")
                        .HasColumnType("decimal(18, 2)")
                        .HasColumnName("VL_PRODUTO");

                    b.HasKey("Id");

                    b.HasIndex("CategoriaId");

                    b.HasIndex("FornecedorId");

                    b.ToTable("TB_PRODUTO");
                });

            modelBuilder.Entity("back_end_sea_care.Models.Relato", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(19)")
                        .HasColumnName("ID_RELATO");

                    OraclePropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<string>("DescricaoRelato")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)")
                        .HasColumnName("DESCRICAO");

                    b.Property<string>("LinkFoto")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)")
                        .HasColumnName("FOTO");

                    b.Property<string>("NomeRelato")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)")
                        .HasColumnName("NM_RELATO");

                    b.Property<long>("UsuarioId")
                        .HasColumnType("NUMBER(19)");

                    b.HasKey("Id");

                    b.HasIndex("UsuarioId");

                    b.ToTable("TB_RELATO");
                });

            modelBuilder.Entity("back_end_sea_care.Models.Usuario", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(19)")
                        .HasColumnName("ID_USUARIO");

                    OraclePropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<string>("Cep")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)")
                        .HasColumnName("CEP");

                    b.Property<string>("Cpf")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)")
                        .HasColumnName("CPF");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)")
                        .HasColumnName("EMAIL");

                    b.Property<string>("Login")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)")
                        .HasColumnName("LOGIN");

                    b.Property<int>("NivelPermissao")
                        .HasColumnType("NUMBER(10)")
                        .HasColumnName("NL_PERMISSAO");

                    b.Property<string>("NomeUsuario")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)")
                        .HasColumnName("NM_USUARIO");

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)")
                        .HasColumnName("SENHA");

                    b.Property<string>("Telefone")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)")
                        .HasColumnName("TELEFONE");

                    b.HasKey("Id");

                    b.ToTable("TB_USUARIO");
                });

            modelBuilder.Entity("EventoParceiro", b =>
                {
                    b.HasOne("back_end_sea_care.Models.Evento", null)
                        .WithMany()
                        .HasForeignKey("EventosId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("back_end_sea_care.Models.Parceiro", null)
                        .WithMany()
                        .HasForeignKey("ParceirosId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("back_end_sea_care.Models.Inscricao", b =>
                {
                    b.HasOne("back_end_sea_care.Models.Evento", "Evento")
                        .WithMany()
                        .HasForeignKey("EventoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("back_end_sea_care.Models.Usuario", "Usuario")
                        .WithMany()
                        .HasForeignKey("UsuarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Evento");

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("back_end_sea_care.Models.Produto", b =>
                {
                    b.HasOne("back_end_sea_care.Models.Categoria", "Categoria")
                        .WithMany()
                        .HasForeignKey("CategoriaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("back_end_sea_care.Models.Fornecedor", "Fornecedor")
                        .WithMany()
                        .HasForeignKey("FornecedorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Categoria");

                    b.Navigation("Fornecedor");
                });

            modelBuilder.Entity("back_end_sea_care.Models.Relato", b =>
                {
                    b.HasOne("back_end_sea_care.Models.Usuario", "Usuario")
                        .WithMany()
                        .HasForeignKey("UsuarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Usuario");
                });
#pragma warning restore 612, 618
        }
    }
}
