﻿// <auto-generated />
using System;
using ExpenseTracker.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace ExpenseTracker.Migrations
{
    [DbContext(typeof(ExpenseTrackerDbContext))]
    [Migration("20240611090920_First")]
    partial class First
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("ExpenseTracker.Model.CatMapUser", b =>
                {
                    b.Property<int>("CateoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("CateoryId"));

                    b.Property<int>("CategoryId")
                        .HasColumnType("integer");

                    b.Property<string>("UserEmailID")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("UserId")
                        .HasColumnType("integer");

                    b.HasKey("CateoryId");

                    b.HasIndex("CategoryId");

                    b.HasIndex("UserEmailID");

                    b.ToTable("CategoriesMapUsers");
                });

            modelBuilder.Entity("ExpenseTracker.Model.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("CategoryId"));

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("ExpenseTracker.Model.Expense", b =>
                {
                    b.Property<int>("ExpenseId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("ExpenseId"));

                    b.Property<int>("Amount")
                        .HasColumnType("integer");

                    b.Property<int>("CategoryId")
                        .HasColumnType("integer");

                    b.Property<int>("CategotyId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("ExpenseDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Remarks")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("UserEmailID")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("UserId")
                        .HasColumnType("integer");

                    b.HasKey("ExpenseId");

                    b.HasIndex("CategoryId");

                    b.HasIndex("UserEmailID");

                    b.ToTable("Expenses");
                });

            modelBuilder.Entity("ExpenseTracker.Model.Income", b =>
                {
                    b.Property<int>("IncomeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("IncomeId"));

                    b.Property<DateTime>("IncomeDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("UserEmailID")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("UserId")
                        .HasColumnType("integer");

                    b.Property<int>("amount")
                        .HasColumnType("integer");

                    b.Property<string>("remarks")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("IncomeId");

                    b.HasIndex("UserEmailID");

                    b.ToTable("Incomes");
                });

            modelBuilder.Entity("ExpenseTracker.Model.Transaction", b =>
                {
                    b.Property<int>("TransId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("TransId"));

                    b.Property<int>("Amount")
                        .HasColumnType("integer");

                    b.Property<bool>("IncomeExpense")
                        .HasColumnType("boolean");

                    b.Property<string>("Remarks")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("TransDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("UserEmailID")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("UserId")
                        .HasColumnType("integer");

                    b.HasKey("TransId");

                    b.HasIndex("UserEmailID");

                    b.ToTable("Transactions");
                });

            modelBuilder.Entity("ExpenseTracker.Model.User", b =>
                {
                    b.Property<string>("EmailID")
                        .HasColumnType("text");

                    b.Property<int>("Balance")
                        .HasColumnType("integer");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("MonthlyIncome")
                        .HasColumnType("integer");

                    b.Property<string>("Occupation")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Photo")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("EmailID");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("ExpenseTracker.Model.CatMapUser", b =>
                {
                    b.HasOne("ExpenseTracker.Model.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ExpenseTracker.Model.User", "User")
                        .WithMany()
                        .HasForeignKey("UserEmailID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("User");
                });

            modelBuilder.Entity("ExpenseTracker.Model.Expense", b =>
                {
                    b.HasOne("ExpenseTracker.Model.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ExpenseTracker.Model.User", "User")
                        .WithMany()
                        .HasForeignKey("UserEmailID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("User");
                });

            modelBuilder.Entity("ExpenseTracker.Model.Income", b =>
                {
                    b.HasOne("ExpenseTracker.Model.User", "User")
                        .WithMany()
                        .HasForeignKey("UserEmailID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("ExpenseTracker.Model.Transaction", b =>
                {
                    b.HasOne("ExpenseTracker.Model.User", "User")
                        .WithMany()
                        .HasForeignKey("UserEmailID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });
#pragma warning restore 612, 618
        }
    }
}
