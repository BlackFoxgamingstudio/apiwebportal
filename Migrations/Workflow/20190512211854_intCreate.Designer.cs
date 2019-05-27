﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebAPI.Models;

namespace WebAPI.Migrations.Workflow
{
    [DbContext(typeof(WorkflowContext))]
    [Migration("20190512211854_intCreate")]
    partial class intCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.2-servicing-10034")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WebAPI.Models.WorkflowDetail", b =>
                {
                    b.Property<int>("WFId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("varchar(8000)");

                    b.Property<string>("Sourcename")
                        .IsRequired()
                        .HasColumnType("varchar(8000)");

                    b.Property<string>("Workflow")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("docurl")
                        .IsRequired()
                        .HasColumnType("varchar(8000)");

                    b.Property<string>("imageurl")
                        .IsRequired()
                        .HasColumnType("varchar(8000)");

                    b.HasKey("WFId");

                    b.ToTable("WorkflowDetails");
                });
#pragma warning restore 612, 618
        }
    }
}
