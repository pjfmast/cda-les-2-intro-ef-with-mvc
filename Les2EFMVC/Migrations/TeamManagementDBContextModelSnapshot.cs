﻿// <auto-generated />
using System;
using Les2EFMVC.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Les2EFMVC.Migrations
{
    [DbContext(typeof(TeamManagementDBContext))]
    partial class TeamManagementDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Les2EFMVC.Models.Member", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("TeamId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TeamId");

                    b.ToTable("Members");

                    b.HasData(
                        new
                        {
                            Id = 1001,
                            Email = "henk@breda.nl",
                            Name = "Henk",
                            TeamId = 201
                        },
                        new
                        {
                            Id = 1002,
                            Email = "tim@breda.nl",
                            Name = "Tim",
                            TeamId = 201
                        },
                        new
                        {
                            Id = 1003,
                            Email = "robbert@breda.nl",
                            Name = "Robbert",
                            TeamId = 201
                        },
                        new
                        {
                            Id = 1004,
                            Email = "paul@breda.nl",
                            Name = "Paul",
                            TeamId = 201
                        },
                        new
                        {
                            Id = 1005,
                            Email = "Bart-Jan@breda.nl",
                            Name = "Niek",
                            TeamId = 201
                        },
                        new
                        {
                            Id = 1006,
                            Email = "Teun@breda.nl",
                            Name = "Teun",
                            TeamId = 201
                        },
                        new
                        {
                            Id = 1007,
                            Email = "bart@avans.nl",
                            Name = "Bart",
                            TeamId = 202
                        },
                        new
                        {
                            Id = 1008,
                            Email = "joris@avans.nl",
                            Name = "Joris",
                            TeamId = 202
                        },
                        new
                        {
                            Id = 1009,
                            Email = "danny@avans.nl",
                            Name = "Danny",
                            TeamId = 202
                        },
                        new
                        {
                            Id = 1010,
                            Email = "lars@avans.nl",
                            Name = "Lars",
                            TeamId = 202
                        },
                        new
                        {
                            Id = 1011,
                            Email = "rob@avans.nl",
                            Name = "Rob",
                            TeamId = 202
                        },
                        new
                        {
                            Id = 1012,
                            Email = "dennis@avans.nl",
                            Name = "Dennis",
                            TeamId = 202
                        },
                        new
                        {
                            Id = 1013,
                            Email = "daniel@avans.nl",
                            Name = "Daniël",
                            TeamId = 202
                        });
                });

            modelBuilder.Entity("Les2EFMVC.Models.Team", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Group")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Teams");

                    b.HasData(
                        new
                        {
                            Id = 201,
                            Group = "Groep-A",
                            Title = "Alpha Wolf Squadron"
                        },
                        new
                        {
                            Id = 202,
                            Group = "Groep-B",
                            Title = "Moviehub"
                        },
                        new
                        {
                            Id = 203,
                            Group = "Groep-H",
                            Title = "The Cool beans"
                        },
                        new
                        {
                            Id = 204,
                            Group = "Groep-1",
                            Title = "You snooze, you loose!"
                        },
                        new
                        {
                            Id = 205,
                            Group = "Groep-2",
                            Title = "Nachos"
                        },
                        new
                        {
                            Id = 206,
                            Group = "Groep-3",
                            Title = "3 front-end devs + 1 back-end dev"
                        },
                        new
                        {
                            Id = 207,
                            Group = "Groep-4",
                            Title = "Cinavas"
                        });
                });

            modelBuilder.Entity("Les2EFMVC.Models.Member", b =>
                {
                    b.HasOne("Les2EFMVC.Models.Team", "Team")
                        .WithMany("Enrolled")
                        .HasForeignKey("TeamId");

                    b.Navigation("Team");
                });

            modelBuilder.Entity("Les2EFMVC.Models.Team", b =>
                {
                    b.Navigation("Enrolled");
                });
#pragma warning restore 612, 618
        }
    }
}
