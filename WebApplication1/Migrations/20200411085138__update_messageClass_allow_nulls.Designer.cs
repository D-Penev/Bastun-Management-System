﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApplication1.Data;

namespace BMS.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20200411085138__update_messageClass_allow_nulls")]
    partial class _update_messageClass_allow_nulls
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BMS.Data.Models.Aircraft", b =>
                {
                    b.Property<int>("AircraftId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AircraftBaggageHoldId")
                        .HasColumnType("int");

                    b.Property<int>("AircraftCabinId")
                        .HasColumnType("int");

                    b.Property<string>("AircraftRegistration")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("FuelFormId")
                        .HasColumnType("int");

                    b.Property<bool>("IsAicraftContainerized")
                        .HasColumnType("bit");

                    b.Property<int>("OutboundFlightId")
                        .HasColumnType("int");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.Property<string>("Version")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("WeightFormId")
                        .HasColumnType("int");

                    b.HasKey("AircraftId");

                    b.HasIndex("OutboundFlightId")
                        .IsUnique();

                    b.ToTable("Aircraft");
                });

            modelBuilder.Entity("BMS.Data.Models.AircraftBaggageHold", b =>
                {
                    b.Property<int>("BaggageHoldId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AircraftId")
                        .HasColumnType("int");

                    b.Property<int>("CompartmentFiveCapacity")
                        .HasColumnType("int");

                    b.Property<int>("CompartmentFiveTotalWeight")
                        .HasColumnType("int");

                    b.Property<int>("CompartmentFourCapacity")
                        .HasColumnType("int");

                    b.Property<int>("CompartmentFourTotalWeight")
                        .HasColumnType("int");

                    b.Property<int>("CompartmentOneCapacity")
                        .HasColumnType("int");

                    b.Property<int>("CompartmentOneTotalWeight")
                        .HasColumnType("int");

                    b.Property<int>("CompartmentThreeCapacity")
                        .HasColumnType("int");

                    b.Property<int>("CompartmentThreeTotalWeight")
                        .HasColumnType("int");

                    b.Property<int>("CompartmentTwoCapacity")
                        .HasColumnType("int");

                    b.Property<int>("CompartmentTwoTotalWeight")
                        .HasColumnType("int");

                    b.HasKey("BaggageHoldId");

                    b.HasIndex("AircraftId")
                        .IsUnique();

                    b.ToTable("AircraftBaggageHolds");
                });

            modelBuilder.Entity("BMS.Data.Models.AircraftCabin", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AircraftId")
                        .HasColumnType("int");

                    b.Property<int>("ZoneAlphaCapacity")
                        .HasColumnType("int");

                    b.Property<int>("ZoneBravoCapacity")
                        .HasColumnType("int");

                    b.Property<int>("ZoneCharlieCapacity")
                        .HasColumnType("int");

                    b.Property<int>("ZoneDeltaCapacity")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AircraftId")
                        .IsUnique();

                    b.ToTable("AircraftCabins");
                });

            modelBuilder.Entity("BMS.Data.Models.ArrivalMovement", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateOfMovement")
                        .HasColumnType("datetime2");

                    b.Property<int>("InboundFlightId")
                        .HasColumnType("int");

                    b.Property<DateTime>("OnBlockTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("SupplementaryInformation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("TouchdownTime")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("InboundFlightId")
                        .IsUnique();

                    b.ToTable("ArrivalMovements");
                });

            modelBuilder.Entity("BMS.Data.Models.Container", b =>
                {
                    b.Property<int>("ContainerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ContainerInfoId")
                        .HasColumnType("int");

                    b.Property<int>("ContainerPieces")
                        .HasColumnType("int");

                    b.Property<int>("OutboundFlightId")
                        .HasColumnType("int");

                    b.HasKey("ContainerId");

                    b.HasIndex("OutboundFlightId");

                    b.ToTable("Containers");
                });

            modelBuilder.Entity("BMS.Data.Models.ContainerInfo", b =>
                {
                    b.Property<int>("ContainerInfoId")
                        .HasColumnType("int");

                    b.Property<int>("ContainerId")
                        .HasColumnType("int");

                    b.Property<string>("ContainerNumberAndType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ContainerPalletMessageId")
                        .HasColumnType("int");

                    b.Property<string>("ContainerPosition")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ContainerTotalWeight")
                        .HasColumnType("int");

                    b.Property<int?>("UniloadContainerMessageId")
                        .HasColumnType("int");

                    b.HasKey("ContainerInfoId");

                    b.HasIndex("ContainerPalletMessageId");

                    b.HasIndex("UniloadContainerMessageId");

                    b.ToTable("ContainerInfos");
                });

            modelBuilder.Entity("BMS.Data.Models.DepartureMovement", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateOfMovement")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("OffBlockTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("OutboundFlightId")
                        .HasColumnType("int");

                    b.Property<string>("SupplementaryInformation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("TakeoffTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("TotalPAX")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("OutboundFlightId")
                        .IsUnique();

                    b.ToTable("DepartureMovements");
                });

            modelBuilder.Entity("BMS.Data.Models.FuelForm", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AircraftId")
                        .HasColumnType("int");

                    b.Property<double>("BlockFuel")
                        .HasColumnType("float");

                    b.Property<string>("CrewConfiguration")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("DryOperatingIndex")
                        .HasColumnType("float");

                    b.Property<double>("DryOperatingWeight")
                        .HasColumnType("float");

                    b.Property<string>("PilotInCommand")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("TaxiFuel")
                        .HasColumnType("float");

                    b.Property<double>("TripFuel")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("AircraftId")
                        .IsUnique();

                    b.ToTable("FuelForms");
                });

            modelBuilder.Entity("BMS.Data.Models.InboundFlight", b =>
                {
                    b.Property<int>("FlightId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ArrivalMovementId")
                        .HasColumnType("int");

                    b.Property<string>("FlightNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Origin")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("STA")
                        .HasColumnType("datetime2");

                    b.HasKey("FlightId");

                    b.ToTable("InboundFlights");
                });

            modelBuilder.Entity("BMS.Data.Models.Messages.Message", b =>
                {
                    b.Property<int>("MessageId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("InboundFlightId")
                        .HasColumnType("int");

                    b.Property<int?>("OutboundFlightId")
                        .HasColumnType("int");

                    b.HasKey("MessageId");

                    b.HasIndex("InboundFlightId");

                    b.HasIndex("OutboundFlightId");

                    b.ToTable("Messages");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Message");
                });

            modelBuilder.Entity("BMS.Data.Models.OutboundFlight", b =>
                {
                    b.Property<int>("FlightId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AircraftId")
                        .HasColumnType("int");

                    b.Property<int>("BookedPax")
                        .HasColumnType("int");

                    b.Property<int>("DepartureMovementId")
                        .HasColumnType("int");

                    b.Property<string>("Destination")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FlightNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HandlingStation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("STD")
                        .HasColumnType("datetime2");

                    b.HasKey("FlightId");

                    b.ToTable("OutboundFlights");
                });

            modelBuilder.Entity("BMS.Data.Models.Passenger", b =>
                {
                    b.Property<int>("PaxId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<int?>("AircraftCabinId")
                        .HasColumnType("int");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Gender")
                        .HasColumnType("int");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nationality")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PassportNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Weight")
                        .HasColumnType("int");

                    b.HasKey("PaxId");

                    b.HasIndex("AircraftCabinId");

                    b.ToTable("Passengers");
                });

            modelBuilder.Entity("BMS.Data.Models.Suitcase", b =>
                {
                    b.Property<string>("SuitcaseId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("PassengerPaxId")
                        .HasColumnType("int");

                    b.Property<int>("PaxId")
                        .HasColumnType("int");

                    b.Property<int>("Weight")
                        .HasColumnType("int");

                    b.HasKey("SuitcaseId");

                    b.HasIndex("PassengerPaxId");

                    b.ToTable("Suitcases");
                });

            modelBuilder.Entity("BMS.Data.WeightForm", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("AircraftBasicWeight")
                        .HasColumnType("float");

                    b.Property<int>("AircraftId")
                        .HasColumnType("int");

                    b.Property<double>("MaximumLandingWeight")
                        .HasColumnType("float");

                    b.Property<double>("MaximumTakeoffWeight")
                        .HasColumnType("float");

                    b.Property<double>("MaximumZeroFuelWeight")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("AircraftId")
                        .IsUnique();

                    b.ToTable("WeightForms");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("BMS.Data.Models.Messages.ContainerPalletMessage", b =>
                {
                    b.HasBaseType("BMS.Data.Models.Messages.Message");

                    b.Property<int>("ContainerInfoId")
                        .HasColumnType("int");

                    b.HasDiscriminator().HasValue("ContainerPalletMessage");
                });

            modelBuilder.Entity("BMS.Data.Models.Messages.LoadDistributionMessage", b =>
                {
                    b.HasBaseType("BMS.Data.Models.Messages.Message");

                    b.Property<string>("CrewConfiguration")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PAXChildren")
                        .HasColumnType("int");

                    b.Property<int>("PAXFemale")
                        .HasColumnType("int");

                    b.Property<int>("PAXInfants")
                        .HasColumnType("int");

                    b.Property<int>("PAXMale")
                        .HasColumnType("int");

                    b.Property<int>("TTLWeightInCPT1")
                        .HasColumnType("int");

                    b.Property<int>("TTLWeightInCPT2")
                        .HasColumnType("int");

                    b.Property<int>("TTLWeightInCPT4")
                        .HasColumnType("int");

                    b.Property<int>("TTLWeightInCPT5")
                        .HasColumnType("int");

                    b.Property<int>("TTlWeightINCPT3")
                        .HasColumnType("int");

                    b.Property<int>("TotalBaggagePieces")
                        .HasColumnType("int");

                    b.Property<int>("TotalCargo")
                        .HasColumnType("int");

                    b.Property<int>("TotalPax")
                        .HasColumnType("int");

                    b.Property<int>("TotalWeightInAllCompartments")
                        .HasColumnType("int");

                    b.HasDiscriminator().HasValue("LoadDistributionMessage");
                });

            modelBuilder.Entity("BMS.Data.Models.Messages.UniloadContainerMessage", b =>
                {
                    b.HasBaseType("BMS.Data.Models.Messages.Message");

                    b.HasDiscriminator().HasValue("UniloadContainerMessage");
                });

            modelBuilder.Entity("BMS.Data.Models.Aircraft", b =>
                {
                    b.HasOne("BMS.Data.Models.OutboundFlight", "OutboundFlight")
                        .WithOne("Aircraft")
                        .HasForeignKey("BMS.Data.Models.Aircraft", "OutboundFlightId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("BMS.Data.Models.AircraftBaggageHold", b =>
                {
                    b.HasOne("BMS.Data.Models.Aircraft", "Aircraft")
                        .WithOne("BaggageHold")
                        .HasForeignKey("BMS.Data.Models.AircraftBaggageHold", "AircraftId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });

            modelBuilder.Entity("BMS.Data.Models.AircraftCabin", b =>
                {
                    b.HasOne("BMS.Data.Models.Aircraft", "Aircraft")
                        .WithOne("Cabin")
                        .HasForeignKey("BMS.Data.Models.AircraftCabin", "AircraftId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });

            modelBuilder.Entity("BMS.Data.Models.ArrivalMovement", b =>
                {
                    b.HasOne("BMS.Data.Models.InboundFlight", "InboundFlight")
                        .WithOne("ArrivalMovement")
                        .HasForeignKey("BMS.Data.Models.ArrivalMovement", "InboundFlightId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });

            modelBuilder.Entity("BMS.Data.Models.Container", b =>
                {
                    b.HasOne("BMS.Data.Models.OutboundFlight", "OutboundFlight")
                        .WithMany("OutboundContainers")
                        .HasForeignKey("OutboundFlightId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("BMS.Data.Models.ContainerInfo", b =>
                {
                    b.HasOne("BMS.Data.Models.Container", "Container")
                        .WithOne("ContainerInfo")
                        .HasForeignKey("BMS.Data.Models.ContainerInfo", "ContainerInfoId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("BMS.Data.Models.Messages.ContainerPalletMessage", "ContainerPalletMessage")
                        .WithMany("ContainerInfo")
                        .HasForeignKey("ContainerPalletMessageId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("BMS.Data.Models.Messages.UniloadContainerMessage", "UniloadContainerMessage")
                        .WithMany("ContainerInfo")
                        .HasForeignKey("UniloadContainerMessageId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("BMS.Data.Models.DepartureMovement", b =>
                {
                    b.HasOne("BMS.Data.Models.OutboundFlight", "OutboundFlight")
                        .WithOne("DepartureMovement")
                        .HasForeignKey("BMS.Data.Models.DepartureMovement", "OutboundFlightId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("BMS.Data.Models.FuelForm", b =>
                {
                    b.HasOne("BMS.Data.Models.Aircraft", "Aircraft")
                        .WithOne("FuelForm")
                        .HasForeignKey("BMS.Data.Models.FuelForm", "AircraftId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });

            modelBuilder.Entity("BMS.Data.Models.Messages.Message", b =>
                {
                    b.HasOne("BMS.Data.Models.InboundFlight", "InboundFlight")
                        .WithMany("InboundMessages")
                        .HasForeignKey("InboundFlightId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("BMS.Data.Models.OutboundFlight", "OutboundFlight")
                        .WithMany("OutboundMessages")
                        .HasForeignKey("OutboundFlightId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("BMS.Data.Models.Passenger", b =>
                {
                    b.HasOne("BMS.Data.Models.AircraftCabin", null)
                        .WithMany("Passengers")
                        .HasForeignKey("AircraftCabinId");
                });

            modelBuilder.Entity("BMS.Data.Models.Suitcase", b =>
                {
                    b.HasOne("BMS.Data.Models.Passenger", "Passenger")
                        .WithMany("Suitcases")
                        .HasForeignKey("PassengerPaxId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("BMS.Data.WeightForm", b =>
                {
                    b.HasOne("BMS.Data.Models.Aircraft", "Aircraft")
                        .WithOne("WeightForm")
                        .HasForeignKey("BMS.Data.WeightForm", "AircraftId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
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
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
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

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
