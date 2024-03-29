﻿// <auto-generated />
using System;
using BlazorWebAssemblySignalRApp.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BlazorWebAssemblySignalRApp.Server.Migrations
{
    [DbContext(typeof(DataBaseContext))]
    [Migration("20221123111031_mass")]
    partial class mass
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("BlazorWebAssemblySignalRApp.Models.Dialogs", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name_dialogs")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Time_creation")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Dialogs");
                });

            modelBuilder.Entity("BlazorWebAssemblySignalRApp.Models.Friends", b =>
                {
                    b.Property<int>("Id_friends")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id_friends"), 1L, 1);

                    b.Property<DateTime>("Time_creation")
                        .HasColumnType("datetime2");

                    b.Property<int>("User_id")
                        .HasColumnType("int");

                    b.HasKey("Id_friends");

                    b.HasIndex("User_id");

                    b.ToTable("Friends");
                });

            modelBuilder.Entity("BlazorWebAssemblySignalRApp.Models.Massages", b =>
                {
                    b.Property<int>("Id_massages")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id_massages"), 1L, 1);

                    b.Property<int>("Dialog_id")
                        .HasColumnType("int");

                    b.Property<string>("Text")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Text_changed")
                        .HasColumnType("bit");

                    b.Property<DateTime>("Time_creation")
                        .HasColumnType("datetime2");

                    b.HasKey("Id_massages");

                    b.HasIndex("Dialog_id");

                    b.ToTable("Massages");
                });

            modelBuilder.Entity("BlazorWebAssemblySignalRApp.Models.MassageToPhotos", b =>
                {
                    b.Property<int>("Photo_id")
                        .HasColumnType("int");

                    b.Property<int>("Massage_id")
                        .HasColumnType("int");

                    b.HasKey("Photo_id");

                    b.HasIndex("Massage_id");

                    b.ToTable("MassageToPhotos");
                });

            modelBuilder.Entity("BlazorWebAssemblySignalRApp.Models.Photo", b =>
                {
                    b.Property<int>("Photo_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Photo_id"), 1L, 1);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Path")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Time_creation")
                        .HasColumnType("datetime2");

                    b.HasKey("Photo_id");

                    b.ToTable("Photos");
                });

            modelBuilder.Entity("BlazorWebAssemblySignalRApp.Models.Role", b =>
                {
                    b.Property<int>("Id_roles")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id_roles"), 1L, 1);

                    b.Property<int>("Id_dialogs")
                        .HasColumnType("int");

                    b.Property<int>("User_id")
                        .HasColumnType("int");

                    b.Property<bool>("role")
                        .HasColumnType("bit");

                    b.HasKey("Id_roles");

                    b.HasIndex("Id_dialogs");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("BlazorWebAssemblySignalRApp.Models.User", b =>
                {
                    b.Property<int>("Id_user")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Time_creation")
                        .HasColumnType("datetime2");

                    b.HasKey("Id_user");

                    b.ToTable("User");
                });

            modelBuilder.Entity("BlazorWebAssemblySignalRApp.Models.UserToDialogs", b =>
                {
                    b.Property<int>("Id_user_to_dialogs")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id_user_to_dialogs"), 1L, 1);

                    b.Property<int?>("DialogsId")
                        .HasColumnType("int");

                    b.Property<int>("Dialogs_id")
                        .HasColumnType("int");

                    b.Property<DateTime>("Time_creation")
                        .HasColumnType("datetime2");

                    b.Property<int>("User_id")
                        .HasColumnType("int");

                    b.HasKey("Id_user_to_dialogs");

                    b.HasIndex("DialogsId");

                    b.HasIndex("User_id");

                    b.ToTable("UserToDialogs");
                });

            modelBuilder.Entity("BlazorWebAssemblySignalRApp.Models.Friends", b =>
                {
                    b.HasOne("BlazorWebAssemblySignalRApp.Models.User", "User")
                        .WithMany("Friends")
                        .HasForeignKey("User_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("BlazorWebAssemblySignalRApp.Models.Massages", b =>
                {
                    b.HasOne("BlazorWebAssemblySignalRApp.Models.Dialogs", "Dialogs")
                        .WithMany("Massages")
                        .HasForeignKey("Dialog_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Dialogs");
                });

            modelBuilder.Entity("BlazorWebAssemblySignalRApp.Models.MassageToPhotos", b =>
                {
                    b.HasOne("BlazorWebAssemblySignalRApp.Models.Massages", "Massages")
                        .WithMany("MassageToPhotos")
                        .HasForeignKey("Massage_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BlazorWebAssemblySignalRApp.Models.Photo", "Photos")
                        .WithMany("MassageToPhotos")
                        .HasForeignKey("Photo_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Massages");

                    b.Navigation("Photos");
                });

            modelBuilder.Entity("BlazorWebAssemblySignalRApp.Models.Role", b =>
                {
                    b.HasOne("BlazorWebAssemblySignalRApp.Models.Dialogs", "Dialogs")
                        .WithMany("Roles")
                        .HasForeignKey("Id_dialogs")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Dialogs");
                });

            modelBuilder.Entity("BlazorWebAssemblySignalRApp.Models.User", b =>
                {
                    b.HasOne("BlazorWebAssemblySignalRApp.Models.Role", "Roles")
                        .WithMany("User")
                        .HasForeignKey("Id_user")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Roles");
                });

            modelBuilder.Entity("BlazorWebAssemblySignalRApp.Models.UserToDialogs", b =>
                {
                    b.HasOne("BlazorWebAssemblySignalRApp.Models.Dialogs", "Dialogs")
                        .WithMany("UserToDialogs")
                        .HasForeignKey("DialogsId");

                    b.HasOne("BlazorWebAssemblySignalRApp.Models.User", "User")
                        .WithMany("UserToDialogs")
                        .HasForeignKey("User_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Dialogs");

                    b.Navigation("User");
                });

            modelBuilder.Entity("BlazorWebAssemblySignalRApp.Models.Dialogs", b =>
                {
                    b.Navigation("Massages");

                    b.Navigation("Roles");

                    b.Navigation("UserToDialogs");
                });

            modelBuilder.Entity("BlazorWebAssemblySignalRApp.Models.Massages", b =>
                {
                    b.Navigation("MassageToPhotos");
                });

            modelBuilder.Entity("BlazorWebAssemblySignalRApp.Models.Photo", b =>
                {
                    b.Navigation("MassageToPhotos");
                });

            modelBuilder.Entity("BlazorWebAssemblySignalRApp.Models.Role", b =>
                {
                    b.Navigation("User");
                });

            modelBuilder.Entity("BlazorWebAssemblySignalRApp.Models.User", b =>
                {
                    b.Navigation("Friends");

                    b.Navigation("UserToDialogs");
                });
#pragma warning restore 612, 618
        }
    }
}
