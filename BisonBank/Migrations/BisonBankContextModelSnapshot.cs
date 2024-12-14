﻿// <auto-generated />
using System;
using BisonBank.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BisonBank.Migrations
{
    [DbContext(typeof(BisonBankContext))]
    partial class BisonBankContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("BisonBank.Models.Account", b =>
                {
                    b.Property<int>("accountID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("accountID"));

                    b.Property<string>("accountNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("accountType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("balance")
                        .HasColumnType("decimal(18, 2)");

                    b.Property<DateTime>("dateCreated")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("interest")
                        .HasColumnType("decimal(18, 2)");

                    b.Property<string>("routingNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("accountID");

                    b.ToTable("Account");
                });

            modelBuilder.Entity("BisonBank.Models.Transaction", b =>
                {
                    b.Property<int>("transactionID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("transactionID"));

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasMaxLength(13)
                        .HasColumnType("nvarchar(13)");

                    b.Property<int?>("accountID")
                        .HasColumnType("int");

                    b.Property<decimal>("amount")
                        .HasColumnType("decimal(18, 2)");

                    b.Property<DateTime>("date")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2");

                    b.Property<string>("transactionType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("transactionID");

                    b.HasIndex("accountID");

                    b.ToTable("Transaction");

                    b.HasDiscriminator().HasValue("Transaction");

                    b.UseTphMappingStrategy();
                });

            modelBuilder.Entity("BisonBank.Models.Transfer", b =>
                {
                    b.HasBaseType("BisonBank.Models.Transaction");

                    b.Property<string>("description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("destinationAccount")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("originAccount")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasDiscriminator().HasValue("Transfer");
                });

            modelBuilder.Entity("BisonBank.Models.Withdrawal", b =>
                {
                    b.HasBaseType("BisonBank.Models.Transaction");

                    b.Property<string>("originAccount")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.ToTable("Transaction", t =>
                        {
                            t.Property("originAccount")
                                .HasColumnName("Withdrawal_originAccount");
                        });

                    b.HasDiscriminator().HasValue("Withdrawal");
                });

            modelBuilder.Entity("BisonBank.Models.Transaction", b =>
                {
                    b.HasOne("BisonBank.Models.Account", null)
                        .WithMany("transactions")
                        .HasForeignKey("accountID");
                });

            modelBuilder.Entity("BisonBank.Models.Account", b =>
                {
                    b.Navigation("transactions");
                });
#pragma warning restore 612, 618
        }
    }
}
