﻿// <auto-generated />
using System;
using Appointment.Infrastructure.Database.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Appointment.Infrastructure.Database.Migrations
{
    [DbContext(typeof(AppointmentDbContext))]
    [Migration("20231002095426_SeedDoctorType")]
    partial class SeedDoctorType
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Appointment.Domain.Core.AggregatesModel.AppointmentAggregate.Appointment", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("DoctorId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("PatientId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("DoctorId");

                    b.HasIndex("PatientId");

                    b.ToTable("Appointments", "Appointment");
                });

            modelBuilder.Entity("Appointment.Domain.Core.AggregatesModel.ClinicAggregate.Clinic", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("EndDay")
                        .HasColumnType("int");

                    b.Property<TimeSpan>("EndTime")
                        .HasColumnType("time");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("StartDay")
                        .HasColumnType("int");

                    b.Property<TimeSpan>("StartTime")
                        .HasColumnType("time");

                    b.HasKey("Id");

                    b.ToTable("Clinics", "Appointment");

                    b.HasData(
                        new
                        {
                            Id = new Guid("c17c0d98-df43-491e-83d2-039f0e2148b6"),
                            Description = "KarizmaClinic is a test project on related to Karizma company, which was implemented by Zahra Kiani.",
                            EndDay = 3,
                            EndTime = new TimeSpan(0, 18, 0, 0, 0),
                            Name = "KarizmaClinic",
                            StartDay = 6,
                            StartTime = new TimeSpan(0, 9, 0, 0, 0)
                        });
                });

            modelBuilder.Entity("Appointment.Domain.Core.AggregatesModel.DoctorAggregate.Doctor", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("DoctorTypeId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Mobile")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Doctors", "Appointment");
                });

            modelBuilder.Entity("Appointment.Domain.Core.AggregatesModel.DoctorTypeAggregate.DoctorType", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<TimeSpan>("MaxDurationAppointmentTime")
                        .HasColumnType("time");

                    b.Property<int>("MaxOverlap")
                        .HasColumnType("int");

                    b.Property<TimeSpan>("MinDurationAppointmentTime")
                        .HasColumnType("time");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("DoctorTypes", "Appointment");

                    b.HasData(
                        new
                        {
                            Id = new Guid("fb92b7ef-4b57-49bb-87b4-86ac3dba0e70"),
                            Description = "General Doctor",
                            MaxDurationAppointmentTime = new TimeSpan(0, 0, 15, 0, 0),
                            MaxOverlap = 2,
                            MinDurationAppointmentTime = new TimeSpan(0, 0, 5, 0, 0),
                            Title = "General"
                        },
                        new
                        {
                            Id = new Guid("3be242d6-6b44-41a4-ac50-5f35f39c71a2"),
                            Description = "Specialist Doctor",
                            MaxDurationAppointmentTime = new TimeSpan(0, 0, 30, 0, 0),
                            MaxOverlap = 3,
                            MinDurationAppointmentTime = new TimeSpan(0, 0, 10, 0, 0),
                            Title = "Specialist"
                        });
                });

            modelBuilder.Entity("Appointment.Domain.Core.AggregatesModel.PatientAggregate.Patient", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Mobile")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Patients", "Appointment");
                });

            modelBuilder.Entity("Appointment.Domain.Core.AggregatesModel.AppointmentAggregate.Appointment", b =>
                {
                    b.HasOne("Appointment.Domain.Core.AggregatesModel.DoctorAggregate.Doctor", null)
                        .WithMany("Appointments")
                        .HasForeignKey("DoctorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Appointment.Domain.Core.AggregatesModel.PatientAggregate.Patient", null)
                        .WithMany("Appointments")
                        .HasForeignKey("PatientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.OwnsOne("Appointment.Domain.Core.AggregatesModel.AppointmentAggregate.ValueObjects.AppointmentTime", "AppointmentTime", b1 =>
                        {
                            b1.Property<Guid>("AppointmentId")
                                .HasColumnType("uniqueidentifier");

                            b1.Property<TimeSpan>("DurationTime")
                                .HasColumnType("time");

                            b1.Property<DateTime>("EndTime")
                                .HasColumnType("datetime2");

                            b1.Property<DateTime>("StartTime")
                                .HasColumnType("datetime2");

                            b1.HasKey("AppointmentId");

                            b1.ToTable("Appointments", "Appointment");

                            b1.WithOwner()
                                .HasForeignKey("AppointmentId");
                        });

                    b.Navigation("AppointmentTime")
                        .IsRequired();
                });

            modelBuilder.Entity("Appointment.Domain.Core.AggregatesModel.DoctorAggregate.Doctor", b =>
                {
                    b.OwnsMany("Appointment.Domain.Core.AggregatesModel.DoctorAggregate.DailySchedule", "WeeklySchedule", b1 =>
                        {
                            b1.Property<Guid>("DoctorId")
                                .HasColumnType("uniqueidentifier");

                            b1.Property<Guid>("Id")
                                .ValueGeneratedOnAdd()
                                .HasColumnType("uniqueidentifier");

                            b1.Property<DateTime>("Date")
                                .HasColumnType("datetime2");

                            b1.Property<TimeSpan>("EndTime")
                                .HasColumnType("time");

                            b1.Property<TimeSpan>("StartTime")
                                .HasColumnType("time");

                            b1.HasKey("DoctorId", "Id");

                            b1.ToTable("DoctorDailySchedules", "Appointment");

                            b1.WithOwner()
                                .HasForeignKey("DoctorId");
                        });

                    b.OwnsOne("Appointment.Domain.Core.AggregatesModel.DoctorAggregate.ValueObjects.PersonalInfo", "Info", b1 =>
                        {
                            b1.Property<Guid>("DoctorId")
                                .HasColumnType("uniqueidentifier");

                            b1.Property<string>("FirstName")
                                .IsRequired()
                                .HasMaxLength(50)
                                .HasColumnType("nvarchar(50)");

                            b1.Property<string>("LastName")
                                .IsRequired()
                                .HasMaxLength(50)
                                .HasColumnType("nvarchar(50)");

                            b1.Property<string>("Prefix")
                                .HasColumnType("nvarchar(max)");

                            b1.HasKey("DoctorId");

                            b1.ToTable("Doctors", "Appointment");

                            b1.WithOwner()
                                .HasForeignKey("DoctorId");
                        });

                    b.Navigation("Info")
                        .IsRequired();

                    b.Navigation("WeeklySchedule");
                });

            modelBuilder.Entity("Appointment.Domain.Core.AggregatesModel.PatientAggregate.Patient", b =>
                {
                    b.OwnsOne("Appointment.Domain.Core.AggregatesModel.PatientAggregate.ValueObject.PersonalInfo", "Info", b1 =>
                        {
                            b1.Property<Guid>("PatientId")
                                .HasColumnType("uniqueidentifier");

                            b1.Property<string>("FirstName")
                                .IsRequired()
                                .HasMaxLength(50)
                                .HasColumnType("nvarchar(50)");

                            b1.Property<string>("LastName")
                                .IsRequired()
                                .HasMaxLength(50)
                                .HasColumnType("nvarchar(50)");

                            b1.Property<string>("NationalCode")
                                .IsRequired()
                                .HasMaxLength(10)
                                .HasColumnType("nvarchar(10)");

                            b1.HasKey("PatientId");

                            b1.ToTable("Patients", "Appointment");

                            b1.WithOwner()
                                .HasForeignKey("PatientId");
                        });

                    b.Navigation("Info")
                        .IsRequired();
                });

            modelBuilder.Entity("Appointment.Domain.Core.AggregatesModel.DoctorAggregate.Doctor", b =>
                {
                    b.Navigation("Appointments");
                });

            modelBuilder.Entity("Appointment.Domain.Core.AggregatesModel.PatientAggregate.Patient", b =>
                {
                    b.Navigation("Appointments");
                });
#pragma warning restore 612, 618
        }
    }
}
