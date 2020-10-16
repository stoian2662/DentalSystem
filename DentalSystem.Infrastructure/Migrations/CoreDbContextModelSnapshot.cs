﻿// <auto-generated />
using System;
using DentalSystem.Infrastructure.Common.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DentalSystem.Infrastructure.Migrations
{
    [DbContext(typeof(CoreDbContext))]
    partial class CoreDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.0-rc.1.20451.13");

            modelBuilder.Entity("DentalSystem.Domain.Core.AppointmentScheduling.Models.Appointment", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<Guid>("DentalTeamId")
                        .HasColumnType("TEXT");

                    b.Property<Guid>("PatientId")
                        .HasColumnType("TEXT");

                    b.Property<Guid>("RoomId")
                        .HasColumnType("TEXT");

                    b.Property<int>("TreatmentType")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("DentalTeamId");

                    b.HasIndex("PatientId");

                    b.HasIndex("RoomId");

                    b.ToTable("Appointment");
                });

            modelBuilder.Entity("DentalSystem.Domain.Core.AppointmentScheduling.Models.Client", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Client");
                });

            modelBuilder.Entity("DentalSystem.Domain.Core.AppointmentScheduling.Models.DentalTeam", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("DentalTeam");
                });

            modelBuilder.Entity("DentalSystem.Domain.Core.AppointmentScheduling.Models.DentalWorker", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<Guid>("DentalTeamId")
                        .HasColumnType("TEXT");

                    b.Property<int>("JobType")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("DentalTeamId");

                    b.ToTable("DentalWorker");
                });

            modelBuilder.Entity("DentalSystem.Domain.Core.AppointmentScheduling.Models.Patient", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<Guid>("ClientId")
                        .HasColumnType("TEXT");

                    b.Property<int>("Gender")
                        .ValueGeneratedOnUpdateSometimes()
                        .HasColumnType("INTEGER")
                        .HasColumnName("Gender");

                    b.HasKey("Id");

                    b.HasIndex("ClientId")
                        .IsUnique();

                    b.ToTable("Patient");
                });

            modelBuilder.Entity("DentalSystem.Domain.Core.AppointmentScheduling.Models.Room", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Room");
                });

            modelBuilder.Entity("DentalSystem.Domain.Core.ClientPatientManagement.Models.Client", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("Client");
                });

            modelBuilder.Entity("DentalSystem.Domain.Core.ClientPatientManagement.Models.Patient", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("TEXT");

                    b.Property<Guid>("ClientId")
                        .HasColumnType("TEXT");

                    b.Property<int>("Gender")
                        .ValueGeneratedOnUpdateSometimes()
                        .HasColumnType("INTEGER")
                        .HasColumnName("Gender");

                    b.HasKey("Id");

                    b.HasIndex("ClientId")
                        .IsUnique();

                    b.ToTable("Patient");
                });

            modelBuilder.Entity("DentalSystem.Domain.Payments.Models.Client", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("TEXT");

                    b.Property<string>("EmailAddress")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Client");
                });

            modelBuilder.Entity("DentalSystem.Domain.Payments.Models.CreditCard", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("CvcCode")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTimeOffset>("ExpirationDate")
                        .HasColumnType("TEXT");

                    b.Property<Guid>("HolderId")
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsMain")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Number")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("HolderId");

                    b.ToTable("CreditCard");
                });

            modelBuilder.Entity("DentalSystem.Domain.Payments.Models.Payment", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<Guid>("ClientId")
                        .HasColumnType("TEXT");

                    b.Property<Guid?>("CreditCardId")
                        .HasColumnType("TEXT");

                    b.Property<int>("PaymentMethod")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("ClientId");

                    b.HasIndex("CreditCardId");

                    b.ToTable("Payment");
                });

            modelBuilder.Entity("DentalSystem.Infrastructure.Identity.User", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("INTEGER");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("TEXT");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("TEXT");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("INTEGER");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("TEXT");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("INTEGER");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ClaimType")
                        .HasColumnType("TEXT");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("TEXT");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ClaimType")
                        .HasColumnType("TEXT");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("TEXT");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("TEXT");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("TEXT");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("TEXT");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("TEXT");

                    b.Property<string>("RoleId")
                        .HasColumnType("TEXT");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("TEXT");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<string>("Value")
                        .HasColumnType("TEXT");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("DentalSystem.Domain.Core.AppointmentScheduling.Models.Appointment", b =>
                {
                    b.HasOne("DentalSystem.Domain.Core.AppointmentScheduling.Models.DentalTeam", "DentalTeam")
                        .WithMany()
                        .HasForeignKey("DentalTeamId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("DentalSystem.Domain.Core.AppointmentScheduling.Models.Patient", "Patient")
                        .WithMany()
                        .HasForeignKey("PatientId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("DentalSystem.Domain.Core.AppointmentScheduling.Models.Room", "Room")
                        .WithMany()
                        .HasForeignKey("RoomId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.OwnsOne("DentalSystem.Domain.Common.Models.DateTimeRange", "TimeRange", b1 =>
                        {
                            b1.Property<Guid>("AppointmentId")
                                .HasColumnType("TEXT");

                            b1.Property<DateTimeOffset>("End")
                                .HasColumnType("TEXT");

                            b1.Property<DateTimeOffset>("Start")
                                .HasColumnType("TEXT");

                            b1.HasKey("AppointmentId");

                            b1.ToTable("Appointment");

                            b1.WithOwner()
                                .HasForeignKey("AppointmentId");
                        });

                    b.Navigation("DentalTeam");

                    b.Navigation("Patient");

                    b.Navigation("Room");

                    b.Navigation("TimeRange")
                        .IsRequired();
                });

            modelBuilder.Entity("DentalSystem.Domain.Core.AppointmentScheduling.Models.Client", b =>
                {
                    b.HasOne("DentalSystem.Domain.Core.ClientPatientManagement.Models.Client", null)
                        .WithOne()
                        .HasForeignKey("DentalSystem.Domain.Core.AppointmentScheduling.Models.Client", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.OwnsOne("DentalSystem.Domain.Common.Models.FullName", "FullName", b1 =>
                        {
                            b1.Property<Guid>("ClientId")
                                .HasColumnType("TEXT");

                            b1.Property<string>("FirstName")
                                .IsRequired()
                                .ValueGeneratedOnUpdateSometimes()
                                .HasColumnType("TEXT");

                            b1.Property<string>("LastName")
                                .IsRequired()
                                .ValueGeneratedOnUpdateSometimes()
                                .HasColumnType("TEXT");

                            b1.HasKey("ClientId");

                            b1.ToTable("Client");

                            b1.WithOwner()
                                .HasForeignKey("ClientId");
                        });

                    b.Navigation("FullName")
                        .IsRequired();
                });

            modelBuilder.Entity("DentalSystem.Domain.Core.AppointmentScheduling.Models.DentalWorker", b =>
                {
                    b.HasOne("DentalSystem.Domain.Core.AppointmentScheduling.Models.DentalTeam", "DentalTeam")
                        .WithMany("Participants")
                        .HasForeignKey("DentalTeamId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.OwnsOne("DentalSystem.Domain.Common.Models.FullName", "FullName", b1 =>
                        {
                            b1.Property<Guid>("DentalWorkerId")
                                .HasColumnType("TEXT");

                            b1.Property<string>("FirstName")
                                .IsRequired()
                                .HasColumnType("TEXT");

                            b1.Property<string>("LastName")
                                .IsRequired()
                                .HasColumnType("TEXT");

                            b1.HasKey("DentalWorkerId");

                            b1.ToTable("DentalWorker");

                            b1.WithOwner()
                                .HasForeignKey("DentalWorkerId");
                        });

                    b.Navigation("DentalTeam");

                    b.Navigation("FullName")
                        .IsRequired();
                });

            modelBuilder.Entity("DentalSystem.Domain.Core.AppointmentScheduling.Models.Patient", b =>
                {
                    b.HasOne("DentalSystem.Domain.Core.AppointmentScheduling.Models.Client", "Client")
                        .WithOne("Patient")
                        .HasForeignKey("DentalSystem.Domain.Core.AppointmentScheduling.Models.Patient", "ClientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Client");
                });

            modelBuilder.Entity("DentalSystem.Domain.Core.ClientPatientManagement.Models.Client", b =>
                {
                    b.HasOne("DentalSystem.Infrastructure.Identity.User", null)
                        .WithOne("Client")
                        .HasForeignKey("DentalSystem.Domain.Core.ClientPatientManagement.Models.Client", "UserId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.OwnsOne("DentalSystem.Domain.Core.ClientPatientManagement.Models.PhoneNumber", "PhoneNumber", b1 =>
                        {
                            b1.Property<Guid>("ClientId")
                                .HasColumnType("TEXT");

                            b1.Property<string>("Number")
                                .IsRequired()
                                .HasColumnType("TEXT");

                            b1.HasKey("ClientId");

                            b1.ToTable("Client");

                            b1.WithOwner()
                                .HasForeignKey("ClientId");
                        });

                    b.OwnsOne("DentalSystem.Domain.Common.Models.FullName", "FullName", b1 =>
                        {
                            b1.Property<Guid>("ClientId")
                                .HasColumnType("TEXT");

                            b1.Property<string>("FirstName")
                                .IsRequired()
                                .ValueGeneratedOnUpdateSometimes()
                                .HasColumnType("TEXT");

                            b1.Property<string>("LastName")
                                .IsRequired()
                                .ValueGeneratedOnUpdateSometimes()
                                .HasColumnType("TEXT");

                            b1.HasKey("ClientId");

                            b1.ToTable("Client");

                            b1.WithOwner()
                                .HasForeignKey("ClientId");
                        });

                    b.Navigation("FullName")
                        .IsRequired();

                    b.Navigation("PhoneNumber")
                        .IsRequired();
                });

            modelBuilder.Entity("DentalSystem.Domain.Core.ClientPatientManagement.Models.Patient", b =>
                {
                    b.HasOne("DentalSystem.Domain.Core.ClientPatientManagement.Models.Client", "Client")
                        .WithOne("Patient")
                        .HasForeignKey("DentalSystem.Domain.Core.ClientPatientManagement.Models.Patient", "ClientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DentalSystem.Domain.Core.AppointmentScheduling.Models.Patient", null)
                        .WithOne()
                        .HasForeignKey("DentalSystem.Domain.Core.ClientPatientManagement.Models.Patient", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Client");
                });

            modelBuilder.Entity("DentalSystem.Domain.Payments.Models.Client", b =>
                {
                    b.HasOne("DentalSystem.Domain.Core.ClientPatientManagement.Models.Client", null)
                        .WithOne()
                        .HasForeignKey("DentalSystem.Domain.Payments.Models.Client", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.OwnsOne("DentalSystem.Domain.Common.Models.FullName", "FullName", b1 =>
                        {
                            b1.Property<Guid>("ClientId")
                                .HasColumnType("TEXT");

                            b1.Property<string>("FirstName")
                                .IsRequired()
                                .HasColumnType("TEXT");

                            b1.Property<string>("LastName")
                                .IsRequired()
                                .HasColumnType("TEXT");

                            b1.HasKey("ClientId");

                            b1.ToTable("Client");

                            b1.WithOwner()
                                .HasForeignKey("ClientId");
                        });

                    b.Navigation("FullName")
                        .IsRequired();
                });

            modelBuilder.Entity("DentalSystem.Domain.Payments.Models.CreditCard", b =>
                {
                    b.HasOne("DentalSystem.Domain.Payments.Models.Client", "Holder")
                        .WithMany("CreditCards")
                        .HasForeignKey("HolderId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Holder");
                });

            modelBuilder.Entity("DentalSystem.Domain.Payments.Models.Payment", b =>
                {
                    b.HasOne("DentalSystem.Domain.Payments.Models.Client", "Client")
                        .WithMany("Payments")
                        .HasForeignKey("ClientId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("DentalSystem.Domain.Payments.Models.CreditCard", "CreditCard")
                        .WithMany()
                        .HasForeignKey("CreditCardId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.OwnsOne("DentalSystem.Domain.Payments.Models.Money", "Amount", b1 =>
                        {
                            b1.Property<Guid>("PaymentId")
                                .HasColumnType("TEXT");

                            b1.Property<int>("Currency")
                                .HasColumnType("INTEGER");

                            b1.Property<decimal>("Value")
                                .HasColumnType("TEXT")
                                .HasColumnName("Amount");

                            b1.HasKey("PaymentId");

                            b1.ToTable("Payment");

                            b1.WithOwner()
                                .HasForeignKey("PaymentId");
                        });

                    b.Navigation("Amount")
                        .IsRequired();

                    b.Navigation("Client");

                    b.Navigation("CreditCard");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("DentalSystem.Infrastructure.Identity.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("DentalSystem.Infrastructure.Identity.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DentalSystem.Infrastructure.Identity.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("DentalSystem.Infrastructure.Identity.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DentalSystem.Domain.Core.AppointmentScheduling.Models.Client", b =>
                {
                    b.Navigation("Patient")
                        .IsRequired();
                });

            modelBuilder.Entity("DentalSystem.Domain.Core.AppointmentScheduling.Models.DentalTeam", b =>
                {
                    b.Navigation("Participants");
                });

            modelBuilder.Entity("DentalSystem.Domain.Core.ClientPatientManagement.Models.Client", b =>
                {
                    b.Navigation("Patient")
                        .IsRequired();
                });

            modelBuilder.Entity("DentalSystem.Domain.Payments.Models.Client", b =>
                {
                    b.Navigation("CreditCards");

                    b.Navigation("Payments");
                });

            modelBuilder.Entity("DentalSystem.Infrastructure.Identity.User", b =>
                {
                    b.Navigation("Client");
                });
#pragma warning restore 612, 618
        }
    }
}
