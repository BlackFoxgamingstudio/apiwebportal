﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebAPI.Models;

namespace WebAPI.Migrations.Project
{
    [DbContext(typeof(ProjectContext))]
    partial class ProjectContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.2-servicing-10034")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WebAPI.Models.ProjectDetail", b =>
                {
                    b.Property<int>("PId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("varchar(8000)");

                    b.Property<string>("Project")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Sourcename")
                        .IsRequired()
                        .HasColumnType("varchar(8000)");

                    b.Property<string>("docurl")
                        .IsRequired()
                        .HasColumnType("varchar(8000)");

                    b.Property<string>("imageurl")
                        .IsRequired()
                        .HasColumnType("varchar(8000)");

                    b.HasKey("PId");

                    b.ToTable("ProjectDetails");
                });
#pragma warning restore 612, 618
        }
    }
}
