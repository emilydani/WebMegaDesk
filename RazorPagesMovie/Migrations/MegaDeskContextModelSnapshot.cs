﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MegaDesk.Models;

namespace MegaDesk.Migrations
{
    [DbContext(typeof(MegaDeskContext))]
    partial class MegaDeskContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MegaDesk.Models.Quote", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);


                    b.Property<string>("name");
                    b.Property<double>("width");
                    b.Property<double>("depth");
                    b.Property<int>("numOfDrawers");
                    b.Property<decimal>("price");
                    b.Property<string>("material");
                    b.Property<string>("rushOrd");
                    b.Property<DateTime>("DateAdded");
                    b.HasKey("ID");
                    b.ToTable("name");
                });
#pragma warning restore 612, 618
        }
    }
}
