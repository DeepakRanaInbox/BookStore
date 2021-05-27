﻿// <auto-generated />
using System;
using BookStoreMvcCoreWebApp.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BookStoreMvcCoreWebApp.Migrations
{
    [DbContext(typeof(BookStoreDbContext))]
    [Migration("20210527035825_addnewtablegallery")]
    partial class addnewtablegallery
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.6")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BookStoreMvcCoreWebApp.Data.BookGallery", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BookID")
                        .HasColumnType("int");

                    b.Property<int?>("BooksID")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Url")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("BooksID");

                    b.ToTable("BookGallery");
                });

            modelBuilder.Entity("BookStoreMvcCoreWebApp.Data.MstLanguages", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("vDiscription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("vName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("MstLanguages");
                });

            modelBuilder.Entity("BookStoreMvcCoreWebApp.Data.TbBooks", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<int>("MstLanguagesID")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdatedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("author")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("category")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("discription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("imagePath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("language")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("totalPages")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("MstLanguagesID");

                    b.ToTable("TbBooks");
                });

            modelBuilder.Entity("BookStoreMvcCoreWebApp.Data.BookGallery", b =>
                {
                    b.HasOne("BookStoreMvcCoreWebApp.Data.TbBooks", "Books")
                        .WithMany("bookGallery")
                        .HasForeignKey("BooksID");

                    b.Navigation("Books");
                });

            modelBuilder.Entity("BookStoreMvcCoreWebApp.Data.TbBooks", b =>
                {
                    b.HasOne("BookStoreMvcCoreWebApp.Data.MstLanguages", null)
                        .WithMany("TbBooks")
                        .HasForeignKey("MstLanguagesID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("BookStoreMvcCoreWebApp.Data.MstLanguages", b =>
                {
                    b.Navigation("TbBooks");
                });

            modelBuilder.Entity("BookStoreMvcCoreWebApp.Data.TbBooks", b =>
                {
                    b.Navigation("bookGallery");
                });
#pragma warning restore 612, 618
        }
    }
}
