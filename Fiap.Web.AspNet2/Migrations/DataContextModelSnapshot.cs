﻿// <auto-generated />
using System;
using Fiap.Web.AspNet2.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Fiap.Web.AspNet2.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.21")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Fiap.Web.AspNet2.Models.ClienteModel", b =>
                {
                    b.Property<int>("ClienteId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DataNascimento")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Observacao")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RepresentanteId")
                        .HasColumnType("int");

                    b.HasKey("ClienteId");

                    b.HasIndex("RepresentanteId");

                    b.ToTable("Cliente");
                });

            modelBuilder.Entity("Fiap.Web.AspNet2.Models.LojaModel", b =>
                {
                    b.Property<int>("LojaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("NomeLoja")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("LojaId");

                    b.ToTable("Loja");
                });

            modelBuilder.Entity("Fiap.Web.AspNet2.Models.PaisModel", b =>
                {
                    b.Property<int>("PaisId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Continente")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NomePais")
                        .IsRequired()
                        .HasColumnType("nvarchar(30)")
                        .HasMaxLength(30);

                    b.HasKey("PaisId");

                    b.HasIndex("NomePais");

                    b.ToTable("Pais");

                    b.HasData(
                        new
                        {
                            PaisId = 1,
                            Continente = "America do Sul",
                            NomePais = "Brasil"
                        },
                        new
                        {
                            PaisId = 2,
                            Continente = "Europa",
                            NomePais = "Alemanha"
                        });
                });

            modelBuilder.Entity("Fiap.Web.AspNet2.Models.ProdutoLojaModel", b =>
                {
                    b.Property<int>("ProdutoLojaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("LojaId")
                        .HasColumnType("int");

                    b.Property<int>("ProdutoId")
                        .HasColumnType("int");

                    b.HasKey("ProdutoLojaId");

                    b.HasIndex("LojaId");

                    b.HasIndex("ProdutoId");

                    b.ToTable("ProdutoLoja");
                });

            modelBuilder.Entity("Fiap.Web.AspNet2.Models.ProdutoModel", b =>
                {
                    b.Property<int>("ProdutoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("NomeProduto")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ProdutoId");

                    b.ToTable("Produto");
                });

            modelBuilder.Entity("Fiap.Web.AspNet2.Models.RepresentanteModel", b =>
                {
                    b.Property<int>("RepresentanteId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("RepresentanteId")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("NomeRepresentante")
                        .IsRequired()
                        .HasColumnName("NomeRepresentante")
                        .HasColumnType("nvarchar(70)")
                        .HasMaxLength(70);

                    b.HasKey("RepresentanteId");

                    b.ToTable("Representante");
                });

            modelBuilder.Entity("Fiap.Web.AspNet2.Models.ClienteModel", b =>
                {
                    b.HasOne("Fiap.Web.AspNet2.Models.RepresentanteModel", "Representante")
                        .WithMany("Clientes")
                        .HasForeignKey("RepresentanteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Fiap.Web.AspNet2.Models.ProdutoLojaModel", b =>
                {
                    b.HasOne("Fiap.Web.AspNet2.Models.LojaModel", "Loja")
                        .WithMany("ProdutoLojas")
                        .HasForeignKey("LojaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Fiap.Web.AspNet2.Models.ProdutoModel", "Produto")
                        .WithMany("ProdutoLojas")
                        .HasForeignKey("ProdutoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
