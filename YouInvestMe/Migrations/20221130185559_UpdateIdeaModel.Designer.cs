﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using YouInvestMe.Data;

#nullable disable

namespace YouInvestMe.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20221130185559_UpdateIdeaModel")]
    partial class UpdateIdeaModel
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("YouInvestMe.Models.Idea", b =>
                {
                    b.Property<int>("IdeaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Abstract")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Currency")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("ExpiriesDate")
                        .HasColumnType("datetime");

                    b.Property<string>("Instruments")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("ProductType")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("PublishedDate")
                        .HasColumnType("datetime");

                    b.Property<string>("Region")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("IdeaId");

                    b.ToTable("Idea");
                });

            modelBuilder.Entity("YouInvestMe.Models.Client", b =>
            {
                b.Property<int>("ClientId")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int");

                b.Property<string>("Name")
                    .IsRequired()
                    .HasColumnType("longtext");

                b.Property<string>("Region")
                    .IsRequired()
                    .HasColumnType("longtext");

                b.Property<int>("RiskValue")
                    .HasColumnType("int");

                b.Property<string>("Description")
                    .IsRequired()
                    .HasColumnType("longtext");

                b.HasKey("ClientId");

                b.ToTable("Client");
            });
#pragma warning restore 612, 618
        }
    }
}
