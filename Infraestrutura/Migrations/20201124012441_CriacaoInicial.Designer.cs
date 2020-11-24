﻿// <auto-generated />
using Infraestrutura.Configuration;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Infraestrutura.Migrations
{
    [DbContext(typeof(ContextBase))]
    [Migration("20201124012441_CriacaoInicial")]
    partial class CriacaoInicial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("Entidade.Entities.Artigo", b =>
                {
                    b.Property<int>("Artigo_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ART_ID")
                        .UseIdentityColumn();

                    b.Property<int>("Categoria")
                        .HasColumnType("int")
                        .HasColumnName("ART_CATEGORIA");

                    b.Property<string>("Conteudo")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("ART_CONTEUDO");

                    b.HasKey("Artigo_Id");

                    b.ToTable("TB_ARTIGO");
                });

            modelBuilder.Entity("Entidade.Entities.Imagem", b =>
                {
                    b.Property<int>("Img_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("IMG_ID")
                        .UseIdentityColumn();

                    b.Property<string>("FileName")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("IMG_NOME_ARQUIVO");

                    b.Property<string>("FilePath")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("IMG_CAMINHO_ARQUIVO");

                    b.Property<string>("Legenda")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("IMG_LEGENDA");

                    b.Property<string>("Link")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("IMG_LINK");

                    b.Property<bool>("Status")
                        .HasColumnType("bit")
                        .HasColumnName("IMG_STATUS");

                    b.Property<string>("Titulo")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("IMG_TITULO");

                    b.HasKey("Img_Id");

                    b.ToTable("TB_CADASTRO_IMAGENS");
                });

            modelBuilder.Entity("Entidade.Entities.Relato", b =>
                {
                    b.Property<int>("Relato_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("REL_ID")
                        .UseIdentityColumn();

                    b.Property<string>("Depoimento")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("REL_DEPOIMENTO");

                    b.Property<string>("FileName")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("REL_NOME_ARQUIVO");

                    b.Property<string>("FilePath")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("REL_CAMINHO_ARQUIVO");

                    b.Property<bool>("Status")
                        .HasColumnType("bit")
                        .HasColumnName("REL_STATUS");

                    b.HasKey("Relato_Id");

                    b.ToTable("TB_RELATOS_CLIENTES");
                });

            modelBuilder.Entity("Entidade.Entities.Usuario", b =>
                {
                    b.Property<int>("User_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("USR_ID")
                        .UseIdentityColumn();

                    b.Property<string>("CPF")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("USR_CPF");

                    b.Property<string>("Senha")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("USR_SENHA");

                    b.Property<bool>("Status")
                        .HasColumnType("bit")
                        .HasColumnName("USR_STATUS");

                    b.Property<int>("Tipo")
                        .HasColumnType("int")
                        .HasColumnName("USR_TIPO");

                    b.HasKey("User_ID");

                    b.ToTable("TB_USUARIOS");
                });
#pragma warning restore 612, 618
        }
    }
}
