﻿// <auto-generated />
using System;
using Entity_Framework2.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Entity_Framework2.Migrations
{
    [DbContext(typeof(ITIdbContext))]
    [Migration("20240819024443_Realtion3")]
    partial class Realtion3
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Entity_FrameWork2.Models.Course", b =>
                {
                    b.Property<int?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int?>("Id"));

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Duration")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TopId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Course", "dbo");
                });

            modelBuilder.Entity("Entity_FrameWork2.Models.Course_Inst", b =>
                {
                    b.Property<int>("CrsId")
                        .HasColumnType("int");

                    b.Property<string>("Evaluate")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("InstId")
                        .HasColumnType("int");

                    b.ToTable("Course_Inst", "dbo");
                });

            modelBuilder.Entity("Entity_FrameWork2.Models.Department", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 10L, 10);

                    b.Property<int>("DateOfCreation")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("int")
                        .HasComputedColumnSql("GETDATE()");

                    b.Property<int>("HiringDate")
                        .HasColumnType("int");

                    b.Property<int?>("InsId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("DeptName");

                    b.HasKey("Id");

                    b.ToTable("Deapartment", "dbo");
                });

            modelBuilder.Entity("Entity_FrameWork2.Models.Instructor", b =>
                {
                    b.Property<int?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int?>("Id"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Bonus")
                        .HasColumnType("money");

                    b.Property<int?>("DeptId")
                        .HasColumnType("int");

                    b.Property<double>("HourRate")
                        .HasColumnType("float");

                    b.Property<int?>("InsId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(80)
                        .HasColumnType("nvarchar(80)")
                        .HasAnnotation("MinLegth", 20);

                    b.Property<double>("Salary")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("InsId");

                    b.ToTable("Instructor", "dbo");
                });

            modelBuilder.Entity("Entity_FrameWork2.Models.StudCourse", b =>
                {
                    b.Property<string>("Grade")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("StudId")
                        .HasColumnType("int");

                    b.Property<int>("crsId")
                        .HasColumnType("int");

                    b.ToTable("StudCourse", "dbo");
                });

            modelBuilder.Entity("Entity_FrameWork2.Models.Topic", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Topic", "dbo");
                });

            modelBuilder.Entity("Entity_Framework2.Models.Student", b =>
                {
                    b.Property<int?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int?>("Id"), 20L, 20);

                    b.Property<string>("Address")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(100)
                        .HasColumnType("varchar")
                        .HasDefaultValue("Cairo");

                    b.Property<int?>("Age")
                        .HasColumnType("int");

                    b.Property<int>("DepId")
                        .HasColumnType("int");

                    b.Property<string>("Fname")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar");

                    b.Property<string>("LName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar");

                    b.HasKey("Id");

                    b.ToTable("Student", "dbo");
                });

            modelBuilder.Entity("Entity_FrameWork2.Models.Instructor", b =>
                {
                    b.HasOne("Entity_FrameWork2.Models.Department", null)
                        .WithMany("instructors")
                        .HasForeignKey("InsId");
                });

            modelBuilder.Entity("Entity_FrameWork2.Models.Department", b =>
                {
                    b.Navigation("instructors");
                });
#pragma warning restore 612, 618
        }
    }
}
