﻿// <auto-generated />
using System;
using MVCHotel.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace MVCHotel.Migrations
{
    [DbContext(typeof(ReservationContext))]
    [Migration("20250319224259_AddIndexToReservationName")]
    partial class AddIndexToReservationName
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("MVCHotel.Models.Reservation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("AptSuite")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("apt_suite");

                    b.Property<DateTime>("ArrivalTime")
                        .HasColumnType("date")
                        .HasColumnName("arrival_time");

                    b.Property<string>("BirthDay")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("birth_day");

                    b.Property<int>("BreakFast")
                        .HasColumnType("int")
                        .HasColumnName("break_fast");

                    b.Property<string>("CardCvc")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nchar(10)")
                        .HasColumnName("card_cvc")
                        .IsFixedLength();

                    b.Property<string>("CardExp")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("card_exp");

                    b.Property<string>("CardNumber")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("card_number");

                    b.Property<string>("CardType")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nchar(10)")
                        .HasColumnName("card_type")
                        .IsFixedLength();

                    b.Property<bool>("CheckIn")
                        .HasColumnType("bit")
                        .HasColumnName("check_in");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("city");

                    b.Property<bool>("Cleaning")
                        .HasColumnType("bit")
                        .HasColumnName("cleaning");

                    b.Property<int>("Dinner")
                        .HasColumnType("int")
                        .HasColumnName("dinner");

                    b.Property<string>("EmailAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("email_address");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("first_name");

                    b.Property<int>("FoodBill")
                        .HasColumnType("int")
                        .HasColumnName("food_bill");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("gender");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("last_name");

                    b.Property<DateTime>("LeavingTime")
                        .HasColumnType("date")
                        .HasColumnName("leaving_time");

                    b.Property<int>("Lunch")
                        .HasColumnType("int")
                        .HasColumnName("lunch");

                    b.Property<int>("NumberGuest")
                        .HasColumnType("int")
                        .HasColumnName("number_guest");

                    b.Property<string>("PaymentType")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nchar(10)")
                        .HasColumnName("payment_type")
                        .IsFixedLength();

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("phone_number");

                    b.Property<string>("RoomFloor")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nchar(10)")
                        .HasColumnName("room_floor")
                        .IsFixedLength();

                    b.Property<string>("RoomNumber")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nchar(10)")
                        .HasColumnName("room_number")
                        .IsFixedLength();

                    b.Property<string>("RoomType")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nchar(10)")
                        .HasColumnName("room_type")
                        .IsFixedLength();

                    b.Property<bool>("SSurprise")
                        .HasColumnType("bit")
                        .HasColumnName("s_surprise");

                    b.Property<string>("State")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("state");

                    b.Property<string>("StreetAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("street_address");

                    b.Property<bool>("SupplyStatus")
                        .HasColumnType("bit")
                        .HasColumnName("supply_status");

                    b.Property<double>("TotalBill")
                        .HasColumnType("float")
                        .HasColumnName("total_bill");

                    b.Property<bool>("Towel")
                        .HasColumnType("bit")
                        .HasColumnName("towel");

                    b.Property<string>("ZipCode")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nchar(10)")
                        .HasColumnName("zip_code")
                        .IsFixedLength();

                    b.HasKey("Id")
                        .HasName("PK__tmp_ms_x__3214EC070939E04D");

                    b.HasIndex("FirstName");

                    b.ToTable("reservation", (string)null);
                });
#pragma warning restore 612, 618
        }
    }
}
