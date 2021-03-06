﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using organizer.Data;

namespace organizer.Migrations
{
    [DbContext(typeof(OrganizerContext))]
    [Migration("20191018092128_newId")]
    partial class newId
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("organizer.Data.Model.Day", b =>
                {
                    b.Property<DateTime>("Date");

                    b.HasKey("Date");

                    b.ToTable("Days");
                });

            modelBuilder.Entity("organizer.Data.Model.Task", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Date");

                    b.Property<string>("Title");

                    b.HasKey("Id");

                    b.HasIndex("Date");

                    b.ToTable("Tasks");
                });

            modelBuilder.Entity("organizer.Data.Model.Task", b =>
                {
                    b.HasOne("organizer.Data.Model.Day", "Day")
                        .WithMany("Tasks")
                        .HasForeignKey("Date")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
