﻿// <auto-generated />
using System;
using ASPNET_CORE.DataBase;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ASPNET_CORE.Migrations
{
    [DbContext(typeof(ApplicationDBContext))]
    [Migration("20200120170134_Produtosadd")]
    partial class Produtosadd
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("ASPNET_CORE.Models.Categoria", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("Id");

                    b.ToTable("categorias");
                });

            modelBuilder.Entity("ASPNET_CORE.Models.Funcionario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Cpf")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Nome")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<float>("Salario")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("Funcionarios");
                });

            modelBuilder.Entity("ASPNET_CORE.Models.Produto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<int?>("categoriaId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("categoriaId");

                    b.ToTable("Produtos");
                });

            modelBuilder.Entity("ASPNET_CORE.Models.Produto", b =>
                {
                    b.HasOne("ASPNET_CORE.Models.Categoria", "categoria")
                        .WithMany()
                        .HasForeignKey("categoriaId");
                });
#pragma warning restore 612, 618
        }
    }
}
