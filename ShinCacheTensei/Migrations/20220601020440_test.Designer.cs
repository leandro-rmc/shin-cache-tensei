﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ShinCacheTensei.Data;

namespace ShinCacheTensei.Migrations
{
    [DbContext(typeof(ShinCacheTenseiContext))]
    [Migration("20220601020440_test")]
    partial class test
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ShinCacheTensei.Entities.Demon", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Level")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Race")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("RecruitingMethodId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RecruitingMethodId");

                    b.ToTable("Demons");
                });

            modelBuilder.Entity("ShinCacheTensei.Entities.DemonSkill", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("DemonId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("DemonId");

                    b.ToTable("DemonSkill");
                });

            modelBuilder.Entity("ShinCacheTensei.Entities.RecruitingMethod", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("RecruitingMethod");
                });

            modelBuilder.Entity("ShinCacheTensei.Entities.Demon", b =>
                {
                    b.HasOne("ShinCacheTensei.Entities.RecruitingMethod", "RecruitingMethod")
                        .WithMany()
                        .HasForeignKey("RecruitingMethodId");

                    b.Navigation("RecruitingMethod");
                });

            modelBuilder.Entity("ShinCacheTensei.Entities.DemonSkill", b =>
                {
                    b.HasOne("ShinCacheTensei.Entities.Demon", null)
                        .WithMany("DemonSkills")
                        .HasForeignKey("DemonId");
                });

            modelBuilder.Entity("ShinCacheTensei.Entities.Demon", b =>
                {
                    b.Navigation("DemonSkills");
                });
#pragma warning restore 612, 618
        }
    }
}
