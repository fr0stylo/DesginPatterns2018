﻿// <auto-generated />
using GameAPI.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace GameAPI.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20181025141958_FixedClassesRelations")]
    partial class FixedClassesRelations
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("GameAPI.Models.Baloon", b =>
                {
                    b.Property<int>("BaloonId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("AttackPlayer1");

                    b.Property<bool>("AttackPlayer2");

                    b.Property<int>("GameId");

                    b.Property<string>("Type");

                    b.HasKey("BaloonId");

                    b.HasIndex("GameId");

                    b.ToTable("Baloons");
                });

            modelBuilder.Entity("GameAPI.Models.Game", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.HasKey("Id");

                    b.ToTable("Games");
                });

            modelBuilder.Entity("GameAPI.Models.Player", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("GameId");

                    b.Property<int>("HealthPoints");

                    b.Property<int>("MoneyPoints");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.HasIndex("GameId");

                    b.ToTable("Players");
                });

            modelBuilder.Entity("GameAPI.Models.Tower", b =>
                {
                    b.Property<int>("TowerId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("DefendPlayer1");

                    b.Property<bool>("DefendPlayer2");

                    b.Property<int>("GameId");

                    b.Property<string>("Type");

                    b.HasKey("TowerId");

                    b.HasIndex("GameId");

                    b.ToTable("Towers");
                });

            modelBuilder.Entity("GameAPI.Models.Baloon", b =>
                {
                    b.HasOne("GameAPI.Models.Game", "Game")
                        .WithMany("Baloons")
                        .HasForeignKey("GameId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("GameAPI.Models.Player", b =>
                {
                    b.HasOne("GameAPI.Models.Game", "Game")
                        .WithMany("Players")
                        .HasForeignKey("GameId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("GameAPI.Models.Tower", b =>
                {
                    b.HasOne("GameAPI.Models.Game", "Game")
                        .WithMany("Towers")
                        .HasForeignKey("GameId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
