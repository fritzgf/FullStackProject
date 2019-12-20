﻿// <auto-generated />
using InventoryProjectsWebAPI.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace InventoryProjectsWebAPI.Migrations
{
    [DbContext(typeof(ProjectDetailContext))]
    partial class ProjectDetailContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("InventoryProjectsWebAPI.Models.ProjectDetail", b =>
                {
                    b.Property<int>("PMId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("EndDate")
                        .IsRequired()
                        .HasColumnType("varchar(5)");

                    b.Property<string>("ProjectName")
                        .IsRequired()
                        .HasColumnType("varchar(16)");

                    b.Property<string>("ProjectOwnerName")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("StartDate")
                        .IsRequired()
                        .HasColumnType("varchar(5)");

                    b.HasKey("PMId");

                    b.ToTable("ProjectDetails");
                });
#pragma warning restore 612, 618
        }
    }
}