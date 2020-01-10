﻿// <auto-generated />
using System;
using InstrumentStore.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace InstrumentStore.Data.Migrations
{
    [DbContext(typeof(StoreDbContext))]
    [Migration("20191208064410_init")]
    partial class init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("InstrumentStore.Core.Models.Branch", b =>
                {
                    b.Property<int>("BranchId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BranchName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.HasKey("BranchId");

                    b.HasIndex("CategoryId");

                    b.ToTable("Branches");
                });

            modelBuilder.Entity("InstrumentStore.Core.Models.Brand", b =>
                {
                    b.Property<int>("BrandId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BrandName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("BrandId");

                    b.ToTable("Brands");
                });

            modelBuilder.Entity("InstrumentStore.Core.Models.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CategoryName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("InstrumentStore.Core.Models.Customer", b =>
                {
                    b.Property<int>("CustomerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AddressLine1")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AddressLine2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ContactName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OrderPlace")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("OrderTotal")
                        .HasColumnType("int");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PostalCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("State")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CustomerId");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("InstrumentStore.Core.Models.Description", b =>
                {
                    b.Property<int>("DescriptionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("HtmlDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImgUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<string>("TextDescription")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DescriptionId");

                    b.HasIndex("ProductId")
                        .IsUnique();

                    b.ToTable("Descriptions");
                });

            modelBuilder.Entity("InstrumentStore.Core.Models.OrderDetail", b =>
                {
                    b.Property<int>("OrderDetailId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Comment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.Property<DateTime>("OrderDate")
                        .HasColumnType("datetime2");

                    b.Property<double>("PriceEach")
                        .HasColumnType("float");

                    b.Property<int>("QuantityOrdered")
                        .HasColumnType("int");

                    b.Property<DateTime>("RequiredDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ShippedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("OrderDetailId");

                    b.HasIndex("CustomerId");

                    b.ToTable("OrderDetails");
                });

            modelBuilder.Entity("InstrumentStore.Core.Models.Payment", b =>
                {
                    b.Property<int>("PaymentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("Amount")
                        .HasColumnType("float");

                    b.Property<string>("CustomerId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("CustomerId1")
                        .HasColumnType("int");

                    b.Property<DateTime>("PaymentDay")
                        .HasColumnType("datetime2");

                    b.HasKey("PaymentId");

                    b.HasIndex("CustomerId1");

                    b.ToTable("Payments");
                });

            modelBuilder.Entity("InstrumentStore.Core.Models.Piano.DigitalPiano", b =>
                {
                    b.Property<int>("DigitalPianoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AutoAccompaniment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BuiltInSongs")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DigitalEffects")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Dimensions")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IncludedAccessories")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Inputs")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Keyboard")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LessonFunction")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MIDI")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MaximumPolyphony")
                        .HasColumnType("int");

                    b.Property<string>("Metronome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OtherFunctions")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Outputs")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PowerConsumption")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PowerSupply")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Recorder")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Rhythms")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SamplingFunction")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SongExpansion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SoundSource")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Speakers")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SpecificationId")
                        .HasColumnType("int");

                    b.Property<string>("Tones")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TouchResponse")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DigitalPianoId");

                    b.HasIndex("SpecificationId")
                        .IsUnique();

                    b.ToTable("DigitalPianos");
                });

            modelBuilder.Entity("InstrumentStore.Core.Models.Piano.GrandPiano", b =>
                {
                    b.Property<int>("GrandPianoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Action")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Agraffes")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Beams")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Bridges")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Fallboard")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Hammers")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Keys")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MiddlePedal")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PinBlock")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Plate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ribs")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SoundBoard")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SpecificationId")
                        .HasColumnType("int");

                    b.Property<string>("Strings")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TuningPins")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Warranty")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("GrandPianoId");

                    b.HasIndex("SpecificationId")
                        .IsUnique();

                    b.ToTable("GrandPianos");
                });

            modelBuilder.Entity("InstrumentStore.Core.Models.Piano.UprightPiano", b =>
                {
                    b.Property<int>("UprightPianoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Action")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Agraffes")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BackPosts")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BlackKeySurfaces")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ContourBars")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DuplexScaling")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FrontCasters")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HammerFelts")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Lock")
                        .HasColumnType("bit");

                    b.Property<string>("Pedal")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("SoftFall")
                        .HasColumnType("bit");

                    b.Property<string>("Soundboard")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SpeakingLengthOfNo1String")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SpecificationId")
                        .HasColumnType("int");

                    b.Property<string>("WhiteKeySurfaces")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UprightPianoId");

                    b.HasIndex("SpecificationId")
                        .IsUnique();

                    b.ToTable("UprightPianos");
                });

            modelBuilder.Entity("InstrumentStore.Core.Models.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BranchId")
                        .HasColumnType("int");

                    b.Property<int>("BrandId")
                        .HasColumnType("int");

                    b.Property<bool>("Popularity")
                        .HasColumnType("bit");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<string>("ProductName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ProductId");

                    b.HasIndex("BranchId");

                    b.HasIndex("BrandId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("InstrumentStore.Core.Models.Quantity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("Quantities")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProductId")
                        .IsUnique();

                    b.ToTable("Quantities");
                });

            modelBuilder.Entity("InstrumentStore.Core.Models.ShoppingCartItem", b =>
                {
                    b.Property<int>("ShoppingCartItemId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("Amount")
                        .HasColumnType("float");

                    b.Property<int>("OrderDetailId")
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.HasKey("ShoppingCartItemId");

                    b.HasIndex("OrderDetailId");

                    b.HasIndex("ProductId")
                        .IsUnique();

                    b.ToTable("CartItems");
                });

            modelBuilder.Entity("InstrumentStore.Core.Models.Specification", b =>
                {
                    b.Property<int>("SpecificationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Color")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Height")
                        .HasColumnType("int");

                    b.Property<int>("Length")
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<double>("Weight")
                        .HasColumnType("float");

                    b.Property<int>("Width")
                        .HasColumnType("int");

                    b.HasKey("SpecificationId");

                    b.HasIndex("ProductId")
                        .IsUnique();

                    b.ToTable("Specifications");
                });

            modelBuilder.Entity("InstrumentStore.Core.Models.Branch", b =>
                {
                    b.HasOne("InstrumentStore.Core.Models.Category", "Category")
                        .WithMany("Branches")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("InstrumentStore.Core.Models.Description", b =>
                {
                    b.HasOne("InstrumentStore.Core.Models.Product", "Product")
                        .WithOne("Description")
                        .HasForeignKey("InstrumentStore.Core.Models.Description", "ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("InstrumentStore.Core.Models.OrderDetail", b =>
                {
                    b.HasOne("InstrumentStore.Core.Models.Customer", "Customer")
                        .WithMany("OrderDetails")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("InstrumentStore.Core.Models.Payment", b =>
                {
                    b.HasOne("InstrumentStore.Core.Models.Customer", "Customer")
                        .WithMany("Payments")
                        .HasForeignKey("CustomerId1");
                });

            modelBuilder.Entity("InstrumentStore.Core.Models.Piano.DigitalPiano", b =>
                {
                    b.HasOne("InstrumentStore.Core.Models.Specification", "Specification")
                        .WithOne("DigitalPiano")
                        .HasForeignKey("InstrumentStore.Core.Models.Piano.DigitalPiano", "SpecificationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("InstrumentStore.Core.Models.Piano.GrandPiano", b =>
                {
                    b.HasOne("InstrumentStore.Core.Models.Specification", "Specification")
                        .WithOne("GrandPiano")
                        .HasForeignKey("InstrumentStore.Core.Models.Piano.GrandPiano", "SpecificationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("InstrumentStore.Core.Models.Piano.UprightPiano", b =>
                {
                    b.HasOne("InstrumentStore.Core.Models.Specification", "Specification")
                        .WithOne("UprightPiano")
                        .HasForeignKey("InstrumentStore.Core.Models.Piano.UprightPiano", "SpecificationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("InstrumentStore.Core.Models.Product", b =>
                {
                    b.HasOne("InstrumentStore.Core.Models.Branch", "Branch")
                        .WithMany("Products")
                        .HasForeignKey("BranchId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("InstrumentStore.Core.Models.Brand", "Brand")
                        .WithMany("Products")
                        .HasForeignKey("BrandId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("InstrumentStore.Core.Models.Quantity", b =>
                {
                    b.HasOne("InstrumentStore.Core.Models.Product", "Product")
                        .WithOne("Quantity")
                        .HasForeignKey("InstrumentStore.Core.Models.Quantity", "ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("InstrumentStore.Core.Models.ShoppingCartItem", b =>
                {
                    b.HasOne("InstrumentStore.Core.Models.OrderDetail", "OrderDetail")
                        .WithMany("CartItems")
                        .HasForeignKey("OrderDetailId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("InstrumentStore.Core.Models.Product", "Product")
                        .WithOne("ShoppingCartItem")
                        .HasForeignKey("InstrumentStore.Core.Models.ShoppingCartItem", "ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("InstrumentStore.Core.Models.Specification", b =>
                {
                    b.HasOne("InstrumentStore.Core.Models.Product", "Product")
                        .WithOne("Specification")
                        .HasForeignKey("InstrumentStore.Core.Models.Specification", "ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}