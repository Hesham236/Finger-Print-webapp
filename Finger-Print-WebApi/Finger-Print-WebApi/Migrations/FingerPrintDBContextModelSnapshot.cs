﻿// <auto-generated />
using System;
using Finger_Print_WebApi.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FingerPrintWebApi.Migrations
{
    [DbContext(typeof(FingerPrintDBContext))]
    partial class FingerPrintDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Finger_Print_WebApi.Models.Domain.Attendance", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<int>("Employee_id")
                        .HasColumnType("int");

                    b.Property<DateTime>("date")
                        .HasColumnType("datetime2");

                    b.Property<TimeSpan>("in_time")
                        .HasColumnType("time");

                    b.Property<TimeSpan>("out_time")
                        .HasColumnType("time");

                    b.HasKey("id");

                    b.HasIndex("Employee_id");

                    b.ToTable("Attendances");
                });

            modelBuilder.Entity("Finger_Print_WebApi.Models.Domain.Contract", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("end_date")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("start_date")
                        .HasColumnType("datetime2");

                    b.Property<string>("type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Contracts");
                });

            modelBuilder.Entity("Finger_Print_WebApi.Models.Domain.Department", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Departments");
                });

            modelBuilder.Entity("Finger_Print_WebApi.Models.Domain.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Contract_id")
                        .HasColumnType("int");

                    b.Property<int>("Dept_id")
                        .HasColumnType("int");

                    b.Property<string>("address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("dob")
                        .HasColumnType("datetime2");

                    b.Property<string>("education")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("government")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("job_description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("martial_status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("milatary_service_status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("national_id")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("num_children")
                        .HasColumnType("int");

                    b.Property<string>("phone_number")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("photo")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("religion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("social_insurance")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("Contract_id");

                    b.HasIndex("Dept_id");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("Finger_Print_WebApi.Models.Domain.Mission", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Employee_id")
                        .HasColumnType("int");

                    b.Property<int>("Mtype_id")
                        .HasColumnType("int");

                    b.Property<int>("allowance")
                        .HasColumnType("int");

                    b.Property<string>("description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("end_date")
                        .HasColumnType("datetime2");

                    b.Property<string>("purpose")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("start_date")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("Employee_id");

                    b.HasIndex("Mtype_id");

                    b.ToTable("Missions");
                });

            modelBuilder.Entity("Finger_Print_WebApi.Models.Domain.Mtype", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Mtypes");
                });

            modelBuilder.Entity("Finger_Print_WebApi.Models.Domain.Permission", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Employee_id")
                        .HasColumnType("int");

                    b.Property<int>("Ptype_id")
                        .HasColumnType("int");

                    b.Property<DateTime>("date")
                        .HasColumnType("datetime2");

                    b.Property<string>("number")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<TimeSpan>("time")
                        .HasColumnType("time");

                    b.HasKey("Id");

                    b.HasIndex("Employee_id");

                    b.HasIndex("Ptype_id");

                    b.ToTable("Permissions");
                });

            modelBuilder.Entity("Finger_Print_WebApi.Models.Domain.Ptype", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Ptypes");
                });

            modelBuilder.Entity("Finger_Print_WebApi.Models.Domain.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("authority")
                        .HasColumnType("bit");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Finger_Print_WebApi.Models.Domain.Vacation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Employee_id")
                        .HasColumnType("int");

                    b.Property<int>("VType_id")
                        .HasColumnType("int");

                    b.Property<DateTime>("end_date")
                        .HasColumnType("datetime2");

                    b.Property<string>("notes")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("start_date")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("Employee_id");

                    b.HasIndex("VType_id");

                    b.ToTable("Vacations");
                });

            modelBuilder.Entity("Finger_Print_WebApi.Models.Domain.Vtype", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Vtypes");
                });

            modelBuilder.Entity("Finger_Print_WebApi.Models.Domain.Attendance", b =>
                {
                    b.HasOne("Finger_Print_WebApi.Models.Domain.Employee", "Employee")
                        .WithMany("Attendances")
                        .HasForeignKey("Employee_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("Finger_Print_WebApi.Models.Domain.Employee", b =>
                {
                    b.HasOne("Finger_Print_WebApi.Models.Domain.Contract", "Contract")
                        .WithMany("Employees")
                        .HasForeignKey("Contract_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Finger_Print_WebApi.Models.Domain.Department", "Department")
                        .WithMany("Employees")
                        .HasForeignKey("Dept_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Contract");

                    b.Navigation("Department");
                });

            modelBuilder.Entity("Finger_Print_WebApi.Models.Domain.Mission", b =>
                {
                    b.HasOne("Finger_Print_WebApi.Models.Domain.Employee", "Employee")
                        .WithMany("Missions")
                        .HasForeignKey("Employee_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Finger_Print_WebApi.Models.Domain.Mtype", "Mtype")
                        .WithMany("Missions")
                        .HasForeignKey("Mtype_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employee");

                    b.Navigation("Mtype");
                });

            modelBuilder.Entity("Finger_Print_WebApi.Models.Domain.Permission", b =>
                {
                    b.HasOne("Finger_Print_WebApi.Models.Domain.Employee", "Employee")
                        .WithMany("Permissions")
                        .HasForeignKey("Employee_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Finger_Print_WebApi.Models.Domain.Ptype", "Ptype")
                        .WithMany("Permissions")
                        .HasForeignKey("Ptype_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employee");

                    b.Navigation("Ptype");
                });

            modelBuilder.Entity("Finger_Print_WebApi.Models.Domain.Vacation", b =>
                {
                    b.HasOne("Finger_Print_WebApi.Models.Domain.Employee", "Employee")
                        .WithMany("Vacations")
                        .HasForeignKey("Employee_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Finger_Print_WebApi.Models.Domain.Vtype", "Vtype")
                        .WithMany("Vacations")
                        .HasForeignKey("VType_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employee");

                    b.Navigation("Vtype");
                });

            modelBuilder.Entity("Finger_Print_WebApi.Models.Domain.Contract", b =>
                {
                    b.Navigation("Employees");
                });

            modelBuilder.Entity("Finger_Print_WebApi.Models.Domain.Department", b =>
                {
                    b.Navigation("Employees");
                });

            modelBuilder.Entity("Finger_Print_WebApi.Models.Domain.Employee", b =>
                {
                    b.Navigation("Attendances");

                    b.Navigation("Missions");

                    b.Navigation("Permissions");

                    b.Navigation("Vacations");
                });

            modelBuilder.Entity("Finger_Print_WebApi.Models.Domain.Mtype", b =>
                {
                    b.Navigation("Missions");
                });

            modelBuilder.Entity("Finger_Print_WebApi.Models.Domain.Ptype", b =>
                {
                    b.Navigation("Permissions");
                });

            modelBuilder.Entity("Finger_Print_WebApi.Models.Domain.Vtype", b =>
                {
                    b.Navigation("Vacations");
                });
#pragma warning restore 612, 618
        }
    }
}
