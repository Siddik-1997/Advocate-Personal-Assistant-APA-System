﻿// <auto-generated />
using System;
using AdvocatePersonalAssistantSystem.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AdvocatePersonalAssistantSystem.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20191203074606_Reminder1")]
    partial class Reminder1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.11-servicing-32099")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AdvocatePersonalAssistantSystem.Models.CaseProfile", b =>
                {
                    b.Property<int>("Case_Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .IsRequired();

                    b.Property<string>("CaseName")
                        .IsRequired();

                    b.Property<string>("ClientName")
                        .IsRequired();

                    b.Property<string>("Defendant")
                        .IsRequired();

                    b.Property<string>("Fee")
                        .IsRequired();

                    b.Property<DateTime?>("Hdate")
                        .IsRequired();

                    b.Property<DateTime?>("Idate")
                        .IsRequired();

                    b.Property<string>("Phone")
                        .IsRequired();

                    b.Property<string>("Plaintiff")
                        .IsRequired();

                    b.HasKey("Case_Id");

                    b.ToTable("CaseProfiles");
                });

            modelBuilder.Entity("AdvocatePersonalAssistantSystem.Models.CyberLaw", b =>
                {
                    b.Property<int>("Law_no")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("LDeails")
                        .IsRequired();

                    b.Property<string>("LawName")
                        .IsRequired();

                    b.Property<string>("Punishment")
                        .IsRequired();

                    b.HasKey("Law_no");

                    b.ToTable("CyberLaw");
                });

            modelBuilder.Entity("AdvocatePersonalAssistantSystem.Models.Login", b =>
                {
                    b.Property<string>("UserId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Pass")
                        .IsRequired();

                    b.HasKey("UserId");

                    b.ToTable("Login");
                });

            modelBuilder.Entity("AdvocatePersonalAssistantSystem.Models.Message", b =>
                {
                    b.Property<int>("M_Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Case_Id")
                        .IsRequired();

                    b.Property<DateTime>("Mdate");

                    b.Property<string>("Msg")
                        .IsRequired();

                    b.Property<string>("Phone")
                        .IsRequired();

                    b.HasKey("M_Id");

                    b.ToTable("Message");
                });

            modelBuilder.Entity("AdvocatePersonalAssistantSystem.Models.Registration", b =>
                {
                    b.Property<string>("UserId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Pass")
                        .IsRequired();

                    b.Property<string>("RePass")
                        .IsRequired();

                    b.HasKey("UserId");

                    b.ToTable("Registration");
                });

            modelBuilder.Entity("AdvocatePersonalAssistantSystem.Models.Reminder1", b =>
                {
                    b.Property<int>("SL_no")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Case_Id")
                        .IsRequired();

                    b.Property<DateTime>("Rdate");

                    b.Property<string>("rms")
                        .IsRequired();

                    b.HasKey("SL_no");

                    b.ToTable("Reminder1");
                });
#pragma warning restore 612, 618
        }
    }
}
