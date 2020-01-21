﻿// <auto-generated />
using System;
using CustomerService.API.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CustomerService.API.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20200104064821_AddedDataToTransactionTypeClass")]
    partial class AddedDataToTransactionTypeClass
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CustomerService.API.Models.CustomerLedger", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("Amount")
                        .HasColumnType("float");

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.Property<DateTime>("TransactionDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("TransactionId")
                        .HasColumnType("int");

                    b.Property<int>("TransactionTypeId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TransactionTypeId");

                    b.ToTable("CustomerLedgers");
                });

            modelBuilder.Entity("CustomerService.API.Models.CustomerMaster", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("Amount")
                        .HasColumnType("float");

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.Property<DateTime>("LastTransactionDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("CustomerMasters");
                });

            modelBuilder.Entity("CustomerService.API.Models.TransactionType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("TypeName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("TransactionTypes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            TypeName = "Debit"
                        },
                        new
                        {
                            Id = 2,
                            TypeName = "Credit"
                        });
                });

            modelBuilder.Entity("CustomerService.API.Models.CustomerLedger", b =>
                {
                    b.HasOne("CustomerService.API.Models.TransactionType", "TransactionType")
                        .WithMany()
                        .HasForeignKey("TransactionTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
