﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WheateForecast.Data;

#nullable disable

namespace WheateForecast.Migrations
{
    [DbContext(typeof(WheateForecastContext))]
    [Migration("20221003151542_CadastroFuncionario")]
    partial class CadastroFuncionario
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("WheateForecast.Models.AlmoxarifatoModel", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("Data")
                        .HasColumnType("datetime2");

                    b.Property<string>("Forncedor")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Matricula")
                        .HasColumnType("int");

                    b.Property<string>("NameProduct")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NumeroNota")
                        .HasColumnType("int");

                    b.Property<string>("Valor")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("Id");

                    b.ToTable("AlmoxarifatoModel");
                });

            modelBuilder.Entity("WheateForecast.Models.CadastroFuncionarioModel", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("CEP")
                        .HasColumnType("int");

                    b.Property<int>("CPF")
                        .HasMaxLength(11)
                        .HasColumnType("int");

                    b.Property<DateTime>("DataAdmicao")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataNacimento")
                        .HasColumnType("datetime2");

                    b.Property<string>("Endereco")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<int>("Identidade")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NumeroTelefone")
                        .HasColumnType("int");

                    b.Property<string>("Setor")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("CadastroFuncionarioModel");
                });
#pragma warning restore 612, 618
        }
    }
}
