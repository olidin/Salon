﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using Salon.Models;
using System;

namespace Salon.Migrations
{
    [DbContext(typeof(SalonContext))]
    [Migration("20180222204055_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Salon.Models.Customer", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Address_1");

                    b.Property<string>("Address_2");

                    b.Property<string>("City");

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.Property<string>("Neighborhood");

                    b.Property<string>("State");

                    b.Property<int>("ZipCode");

                    b.HasKey("ID");

                    b.ToTable("Customer");
                });
#pragma warning restore 612, 618
        }
    }
}
