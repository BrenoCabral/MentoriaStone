﻿// <auto-generated />
using System;
using CarrinhoDeCompra.DbContexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CarrinhoDeCompra.Migrations
{
    [DbContext(typeof(CarrinhoDbContext))]
    partial class CarrinhoDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("CarrinhoDeCompra.Modelos.CarrinhoDeCompras", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.HasKey("Id");

                    b.ToTable("CarrinhoDeCompras");
                });

            modelBuilder.Entity("CarrinhoDeCompra.Modelos.Item", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("CarrinhoDeComprasId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CarrinhoDeComprasId");

                    b.ToTable("Item");
                });

            modelBuilder.Entity("CarrinhoDeCompra.Modelos.Item", b =>
                {
                    b.HasOne("CarrinhoDeCompra.Modelos.CarrinhoDeCompras", null)
                        .WithMany("Itens")
                        .HasForeignKey("CarrinhoDeComprasId");
                });

            modelBuilder.Entity("CarrinhoDeCompra.Modelos.CarrinhoDeCompras", b =>
                {
                    b.Navigation("Itens");
                });
#pragma warning restore 612, 618
        }
    }
}
