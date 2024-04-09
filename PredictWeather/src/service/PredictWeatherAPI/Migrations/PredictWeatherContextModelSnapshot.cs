﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PredictWeatherAPI.Data;

#nullable disable

namespace PredictWeatherAPI.Migrations
{
    [DbContext(typeof(PredictWeatherContext))]
    partial class PredictWeatherContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("PredictWeatherAPI.Data.Table.Dispositivo", b =>
                {
                    b.Property<int>("DispositivoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DispositivoId"));

                    b.Property<string>("Comando")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EnderecoIP")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Fabricante")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Porta")
                        .HasColumnType("int");

                    b.HasKey("DispositivoId");

                    b.ToTable("TbDispositivo", (string)null);
                });

            modelBuilder.Entity("PredictWeatherAPI.Data.Table.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Senha")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("TbUsuario", (string)null);
                });
#pragma warning restore 612, 618
        }
    }
}
