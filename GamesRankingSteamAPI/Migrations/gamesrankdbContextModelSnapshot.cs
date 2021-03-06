﻿// <auto-generated />
using System;
using GamesRankingSteamAPI.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace GamesRankingSteamAPI.Migrations
{
    [DbContext(typeof(gamesrankdbContext))]
    partial class gamesrankdbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("GamesRankingSteamAPI.Models.Genres", b =>
                {
                    b.Property<long>("GenreId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(60)")
                        .HasMaxLength(60);

                    b.HasKey("GenreId")
                        .HasName("PRIMARY");

                    b.ToTable("genres");
                });

            modelBuilder.Entity("GamesRankingSteamAPI.Models.Top10populargames", b =>
                {
                    b.Property<long?>("GameId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<double?>("Rating")
                        .HasColumnType("double");

                    b.Property<int?>("RatingCount")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("varchar(150)")
                        .HasMaxLength(150);

                    b.Property<DateTime?>("Updated")
                        .HasColumnType("date");

                    b.HasKey("GameId")
                        .HasName("PRIMARY");

                    b.ToTable("top10populargames");
                });

            modelBuilder.Entity("GamesRankingSteamAPI.Models.Top15interestinggames", b =>
                {
                    b.Property<long?>("GameId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<DateTime?>("FirstReleaseDate")
                        .HasColumnType("date");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("varchar(150)")
                        .HasMaxLength(150);

                    b.Property<DateTime?>("Updated")
                        .HasColumnType("date");

                    b.Property<string>("Url")
                        .HasColumnName("URL")
                        .HasColumnType("varchar(150)")
                        .HasMaxLength(150);

                    b.HasKey("GameId")
                        .HasName("PRIMARY");

                    b.ToTable("top15interestinggames");
                });

            modelBuilder.Entity("GamesRankingSteamAPI.Models.Top15interestinggamesHasGenres", b =>
                {
                    b.Property<long?>("Top15interestinggamesGameId")
                        .HasColumnName("top15interestinggames_GameId")
                        .HasColumnType("bigint");

                    b.Property<long?>("GenresGenreId")
                        .HasColumnName("genres_GenreId")
                        .HasColumnType("bigint");

                    b.HasKey("Top15interestinggamesGameId", "GenresGenreId")
                        .HasName("PRIMARY");

                    b.HasIndex("GenresGenreId")
                        .HasName("fk_top15interestinggames_has_genres_genres1_idx");

                    b.HasIndex("Top15interestinggamesGameId")
                        .HasName("fk_top15interestinggames_has_genres_top15interestinggames_idx");

                    b.ToTable("top15interestinggames_has_genres");
                });

            modelBuilder.Entity("GamesRankingSteamAPI.Models.Top15interestinggamesHasGenres", b =>
                {
                    b.HasOne("GamesRankingSteamAPI.Models.Genres", "GenresGenre")
                        .WithMany("Top15interestinggamesHasGenres")
                        .HasForeignKey("GenresGenreId")
                        .HasConstraintName("fk_top15interestinggames_has_genres_genres1")
                        .IsRequired();

                    b.HasOne("GamesRankingSteamAPI.Models.Top15interestinggames", "Top15interestinggamesGame")
                        .WithMany("Top15interestinggamesHasGenres")
                        .HasForeignKey("Top15interestinggamesGameId")
                        .HasConstraintName("fk_top15interestinggames_has_genres_top15interestinggames")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
