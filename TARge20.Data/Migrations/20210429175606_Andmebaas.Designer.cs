// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TARge20.Data;

namespace TARge20.Data.Migrations
{
    [DbContext(typeof(TARge20DbContext))]
    [Migration("20210429175606_Andmebaas")]
    partial class Andmebaas
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.4")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("TARge20.Core.Domain.Ametinimetused", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Kommentaar")
                        .HasColumnType("int");

                    b.Property<int>("Nimetus")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Ametinimetused");
                });

            modelBuilder.Entity("TARge20.Core.Domain.Employee", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Isikukood")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Kommentaar")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Kontaktaadress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Kontakttelefon")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("PalvedId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("VihjedId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("PalvedId");

                    b.HasIndex("VihjedId");

                    b.ToTable("Employee");
                });

            modelBuilder.Entity("TARge20.Core.Domain.Haiguslehe_tyyp", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Kommentaar")
                        .HasColumnType("int");

                    b.Property<int>("Nimetus")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Haiguslehe_tyyp");
                });

            modelBuilder.Entity("TARge20.Core.Domain.Haiguslehed", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("EmployeeId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Haiguslehe_algus")
                        .HasColumnType("int");

                    b.Property<int>("Haiguslehe_l6pp")
                        .HasColumnType("int");

                    b.Property<Guid?>("Haiguslehe_tyypId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Haiguslehe_tyyp_Id")
                        .HasColumnType("int");

                    b.Property<int>("Kommentaar")
                        .HasColumnType("int");

                    b.Property<int>("Tootaja_Id")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("EmployeeId");

                    b.HasIndex("Haiguslehe_tyypId");

                    b.ToTable("Haiguslehed");
                });

            modelBuilder.Entity("TARge20.Core.Domain.Harukontor", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Aadress")
                        .HasColumnType("int");

                    b.Property<int>("Email")
                        .HasColumnType("int");

                    b.Property<int>("Kommentaar")
                        .HasColumnType("int");

                    b.Property<int>("Telefoninumber")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Harukontor");
                });

            modelBuilder.Entity("TARge20.Core.Domain.Laenutatav_ese", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Eseme_nimi")
                        .HasColumnType("int");

                    b.Property<int>("Kommentaar")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Laenutatav_ese");
                });

            modelBuilder.Entity("TARge20.Core.Domain.Laenutuskord", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("EmployeeId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("Laenutatav_eseId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Laenutatav_ese_Id")
                        .HasColumnType("int");

                    b.Property<int>("Laenutuse_algus")
                        .HasColumnType("int");

                    b.Property<int>("Laenutuse_l6pp")
                        .HasColumnType("int");

                    b.Property<int>("Tootaja_Id")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("EmployeeId");

                    b.HasIndex("Laenutatav_eseId");

                    b.ToTable("Laenutuskord");
                });

            modelBuilder.Entity("TARge20.Core.Domain.Ligipaasuloa_tyyp", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Kommentaar")
                        .HasColumnType("int");

                    b.Property<int>("Ligipaas")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Ligipaasuloa_tyyp");
                });

            modelBuilder.Entity("TARge20.Core.Domain.Ligipaasuluba", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("EmployeeId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Ligipaasu_algus")
                        .HasColumnType("int");

                    b.Property<int>("Ligipaasu_lopp")
                        .HasColumnType("int");

                    b.Property<Guid?>("Ligipaasuloa_tyypId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Ligipaasuloa_tyyp_Id")
                        .HasColumnType("int");

                    b.Property<int>("Tootaja_Id")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("EmployeeId");

                    b.HasIndex("Ligipaasuloa_tyypId");

                    b.ToTable("Ligipaasuluba");
                });

            modelBuilder.Entity("TARge20.Core.Domain.Palved", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Kommentaar")
                        .HasColumnType("int");

                    b.Property<int>("Kuupaev")
                        .HasColumnType("int");

                    b.Property<int>("Saaja_Id")
                        .HasColumnType("int");

                    b.Property<int>("Saatja_Id")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Palved");
                });

            modelBuilder.Entity("TARge20.Core.Domain.Puhkuse_tyyp", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Kommentaar")
                        .HasColumnType("int");

                    b.Property<int>("Nimetus")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Puhkuse_tyyp");
                });

            modelBuilder.Entity("TARge20.Core.Domain.Puhkused", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("EmployeeId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Kommentaar")
                        .HasColumnType("int");

                    b.Property<int>("Puhkuse_algus")
                        .HasColumnType("int");

                    b.Property<int>("Puhkuse_l6pp")
                        .HasColumnType("int");

                    b.Property<Guid?>("Puhkuse_tyypId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Puhkuse_tyyp_Id")
                        .HasColumnType("int");

                    b.Property<int>("Tootaja_Id")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("EmployeeId");

                    b.HasIndex("Puhkuse_tyypId");

                    b.ToTable("Puhkused");
                });

            modelBuilder.Entity("TARge20.Core.Domain.T66suhe", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Ametinimetus_Id")
                        .HasColumnType("int");

                    b.Property<Guid?>("AmetinimetusedId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("HarukontorId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Harukontori_Id")
                        .HasColumnType("int");

                    b.Property<int>("Koormus")
                        .HasColumnType("int");

                    b.Property<int>("Tool_alates")
                        .HasColumnType("int");

                    b.Property<int>("Tool_kuni")
                        .HasColumnType("int");

                    b.Property<int>("Tootaja_Id")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AmetinimetusedId");

                    b.HasIndex("HarukontorId");

                    b.ToTable("T66suhe");
                });

            modelBuilder.Entity("TARge20.Core.Domain.Tervisekontrollid", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("EmployeeId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Kellaaeg")
                        .HasColumnType("int");

                    b.Property<int>("Kommentaar")
                        .HasColumnType("int");

                    b.Property<int>("Kuupaev")
                        .HasColumnType("int");

                    b.Property<int>("Tootaja_Id")
                        .HasColumnType("int");

                    b.Property<int>("Tulemus")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("EmployeeId");

                    b.ToTable("Tervisekontrollid");
                });

            modelBuilder.Entity("TARge20.Core.Domain.Tootaja_laps", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Eesnimi")
                        .HasColumnType("int");

                    b.Property<Guid?>("EmployeeId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Kommentaar")
                        .HasColumnType("int");

                    b.Property<int>("Perekonnanimi")
                        .HasColumnType("int");

                    b.Property<int>("Synniaeg")
                        .HasColumnType("int");

                    b.Property<int>("Tootaja_id")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("EmployeeId");

                    b.ToTable("Tootaja_laps");
                });

            modelBuilder.Entity("TARge20.Core.Domain.Vihjed", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Kommentaar")
                        .HasColumnType("int");

                    b.Property<int>("Kuupaev")
                        .HasColumnType("int");

                    b.Property<int>("Saaja_id")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Vihjed");
                });

            modelBuilder.Entity("TARge20.Core.Domain.Employee", b =>
                {
                    b.HasOne("TARge20.Core.Domain.Palved", "Palved")
                        .WithMany()
                        .HasForeignKey("PalvedId");

                    b.HasOne("TARge20.Core.Domain.Vihjed", "Vihjed")
                        .WithMany()
                        .HasForeignKey("VihjedId");

                    b.Navigation("Palved");

                    b.Navigation("Vihjed");
                });

            modelBuilder.Entity("TARge20.Core.Domain.Haiguslehed", b =>
                {
                    b.HasOne("TARge20.Core.Domain.Employee", "Employee")
                        .WithMany()
                        .HasForeignKey("EmployeeId");

                    b.HasOne("TARge20.Core.Domain.Haiguslehe_tyyp", "Haiguslehe_tyyp")
                        .WithMany()
                        .HasForeignKey("Haiguslehe_tyypId");

                    b.Navigation("Employee");

                    b.Navigation("Haiguslehe_tyyp");
                });

            modelBuilder.Entity("TARge20.Core.Domain.Laenutuskord", b =>
                {
                    b.HasOne("TARge20.Core.Domain.Employee", "Employee")
                        .WithMany()
                        .HasForeignKey("EmployeeId");

                    b.HasOne("TARge20.Core.Domain.Laenutatav_ese", "Laenutatav_ese")
                        .WithMany()
                        .HasForeignKey("Laenutatav_eseId");

                    b.Navigation("Employee");

                    b.Navigation("Laenutatav_ese");
                });

            modelBuilder.Entity("TARge20.Core.Domain.Ligipaasuluba", b =>
                {
                    b.HasOne("TARge20.Core.Domain.Employee", "Employee")
                        .WithMany()
                        .HasForeignKey("EmployeeId");

                    b.HasOne("TARge20.Core.Domain.Ligipaasuloa_tyyp", "Ligipaasuloa_tyyp")
                        .WithMany()
                        .HasForeignKey("Ligipaasuloa_tyypId");

                    b.Navigation("Employee");

                    b.Navigation("Ligipaasuloa_tyyp");
                });

            modelBuilder.Entity("TARge20.Core.Domain.Puhkused", b =>
                {
                    b.HasOne("TARge20.Core.Domain.Employee", "Employee")
                        .WithMany()
                        .HasForeignKey("EmployeeId");

                    b.HasOne("TARge20.Core.Domain.Puhkuse_tyyp", "Puhkuse_tyyp")
                        .WithMany()
                        .HasForeignKey("Puhkuse_tyypId");

                    b.Navigation("Employee");

                    b.Navigation("Puhkuse_tyyp");
                });

            modelBuilder.Entity("TARge20.Core.Domain.T66suhe", b =>
                {
                    b.HasOne("TARge20.Core.Domain.Ametinimetused", "Ametinimetused")
                        .WithMany()
                        .HasForeignKey("AmetinimetusedId");

                    b.HasOne("TARge20.Core.Domain.Harukontor", "Harukontor")
                        .WithMany()
                        .HasForeignKey("HarukontorId");

                    b.Navigation("Ametinimetused");

                    b.Navigation("Harukontor");
                });

            modelBuilder.Entity("TARge20.Core.Domain.Tervisekontrollid", b =>
                {
                    b.HasOne("TARge20.Core.Domain.Employee", "Employee")
                        .WithMany()
                        .HasForeignKey("EmployeeId");

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("TARge20.Core.Domain.Tootaja_laps", b =>
                {
                    b.HasOne("TARge20.Core.Domain.Employee", "Employee")
                        .WithMany()
                        .HasForeignKey("EmployeeId");

                    b.Navigation("Employee");
                });
#pragma warning restore 612, 618
        }
    }
}
