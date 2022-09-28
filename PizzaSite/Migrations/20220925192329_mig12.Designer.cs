﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using PizzaSite.Data;

#nullable disable

namespace PizzaSite.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20220925192329_mig12")]
    partial class mig12
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("text");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("text");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("integer");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("text");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("boolean");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("boolean");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("text");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("text");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("boolean");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("text");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("boolean");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasDiscriminator<string>("Discriminator").HasValue("IdentityUser");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("text");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("text");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("character varying(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("character varying(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("text");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("text");

                    b.Property<string>("RoleId")
                        .HasColumnType("text");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("text");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("character varying(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("character varying(128)");

                    b.Property<string>("Value")
                        .HasColumnType("text");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("PizzaSite.Models.ComplaintModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("AspNetUsersId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Content")
                        .HasColumnType("text");

                    b.Property<DateTime>("Date")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.HasIndex("AspNetUsersId");

                    b.ToTable("Complaints");
                });

            modelBuilder.Entity("PizzaSite.Models.CounterModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("complaint_count")
                        .HasColumnType("text");

                    b.Property<string>("drink_order_count")
                        .HasColumnType("text");

                    b.Property<string>("pizza_order_count")
                        .HasColumnType("text");

                    b.Property<string>("suggestion_count")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Counter");
                });

            modelBuilder.Entity("PizzaSite.Models.CustomOrderModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("AspNetUsersId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("Beef")
                        .HasColumnType("boolean");

                    b.Property<bool>("Cheese")
                        .HasColumnType("boolean");

                    b.Property<DateTime>("Date")
                        .HasColumnType("timestamp with time zone");

                    b.Property<bool>("Ham")
                        .HasColumnType("boolean");

                    b.Property<bool>("Mushroom")
                        .HasColumnType("boolean");

                    b.Property<bool>("Peperoni")
                        .HasColumnType("boolean");

                    b.Property<bool>("Pineapple")
                        .HasColumnType("boolean");

                    b.Property<int>("PizzasModelFinalPrice")
                        .HasColumnType("integer");

                    b.Property<string>("PizzasModelPizzaName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("TomatoSauce")
                        .HasColumnType("boolean");

                    b.Property<bool>("Tuna")
                        .HasColumnType("boolean");

                    b.HasKey("Id");

                    b.HasIndex("AspNetUsersId");

                    b.HasIndex("PizzasModelFinalPrice");

                    b.ToTable("CustomOrders");
                });

            modelBuilder.Entity("PizzaSite.Models.DrinksModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("DrinkName")
                        .HasColumnType("text");

                    b.Property<int>("FinalPrice")
                        .HasColumnType("integer");

                    b.Property<string>("ImageTitle")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Drinks");
                });

            modelBuilder.Entity("PizzaSite.Models.DrinksOrderModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("AspNetUsersId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("Date")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("DrinksModelDrinkName")
                        .HasColumnType("text");

                    b.Property<int>("DrinksModelFinalPrice")
                        .HasColumnType("integer");

                    b.Property<int>("DrinksModelId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("AspNetUsersId");

                    b.HasIndex("DrinksModelId");

                    b.ToTable("DrinkOrders");
                });

            modelBuilder.Entity("PizzaSite.Models.OrderModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("AspNetUsersId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("Date")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("PizzasModelFinalPrice")
                        .HasColumnType("integer");

                    b.Property<int>("PizzasModelId")
                        .HasColumnType("integer");

                    b.Property<string>("PizzasModelPizzaName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("AspNetUsersId");

                    b.HasIndex("PizzasModelId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("PizzaSite.Models.PizzasModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("BasePrice")
                        .HasColumnType("integer");

                    b.Property<bool>("Beef")
                        .HasColumnType("boolean");

                    b.Property<bool>("Cheese")
                        .HasColumnType("boolean");

                    b.Property<int>("FinalPrice")
                        .HasColumnType("integer");

                    b.Property<bool>("Ham")
                        .HasColumnType("boolean");

                    b.Property<string>("ImageTitle")
                        .HasColumnType("text");

                    b.Property<bool>("Mushroom")
                        .HasColumnType("boolean");

                    b.Property<bool>("Peperoni")
                        .HasColumnType("boolean");

                    b.Property<bool>("Pineapple")
                        .HasColumnType("boolean");

                    b.Property<string>("PizzaName")
                        .HasColumnType("text");

                    b.Property<bool>("TomatoSauce")
                        .HasColumnType("boolean");

                    b.Property<bool>("Tuna")
                        .HasColumnType("boolean");

                    b.HasKey("Id");

                    b.ToTable("Pizzas");
                });

            modelBuilder.Entity("PizzaSite.Models.SuggestionModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("AspNetUsersId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Content")
                        .HasColumnType("text");

                    b.Property<DateTime>("Date")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.HasIndex("AspNetUsersId");

                    b.ToTable("Suggestions");
                });

            modelBuilder.Entity("PizzaSite.Models.AspNetUserModel", b =>
                {
                    b.HasBaseType("Microsoft.AspNetCore.Identity.IdentityUser");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasDiscriminator().HasValue("AspNetUserModel");
                });

            modelBuilder.Entity("PizzaSite.Models.AspNetUsers", b =>
                {
                    b.HasBaseType("Microsoft.AspNetCore.Identity.IdentityUser");

                    b.HasDiscriminator().HasValue("AspNetUsers");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("PizzaSite.Models.ComplaintModel", b =>
                {
                    b.HasOne("PizzaSite.Models.AspNetUsers", "AspNetUsers")
                        .WithMany()
                        .HasForeignKey("AspNetUsersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AspNetUsers");
                });

            modelBuilder.Entity("PizzaSite.Models.CustomOrderModel", b =>
                {
                    b.HasOne("PizzaSite.Models.AspNetUsers", "AspNetUsers")
                        .WithMany()
                        .HasForeignKey("AspNetUsersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PizzaSite.Models.PizzasModel", "PizzasModel")
                        .WithMany()
                        .HasForeignKey("PizzasModelFinalPrice")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AspNetUsers");

                    b.Navigation("PizzasModel");
                });

            modelBuilder.Entity("PizzaSite.Models.DrinksOrderModel", b =>
                {
                    b.HasOne("PizzaSite.Models.AspNetUsers", "AspNetUsers")
                        .WithMany()
                        .HasForeignKey("AspNetUsersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PizzaSite.Models.DrinksModel", "DrinksModel")
                        .WithMany()
                        .HasForeignKey("DrinksModelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AspNetUsers");

                    b.Navigation("DrinksModel");
                });

            modelBuilder.Entity("PizzaSite.Models.OrderModel", b =>
                {
                    b.HasOne("PizzaSite.Models.AspNetUsers", "AspNetUsers")
                        .WithMany()
                        .HasForeignKey("AspNetUsersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PizzaSite.Models.PizzasModel", "PizzasModel")
                        .WithMany()
                        .HasForeignKey("PizzasModelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AspNetUsers");

                    b.Navigation("PizzasModel");
                });

            modelBuilder.Entity("PizzaSite.Models.SuggestionModel", b =>
                {
                    b.HasOne("PizzaSite.Models.AspNetUsers", "AspNetUsers")
                        .WithMany()
                        .HasForeignKey("AspNetUsersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AspNetUsers");
                });
#pragma warning restore 612, 618
        }
    }
}
