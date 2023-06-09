﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AnimeFinder.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230315182032_ShowCharaSeasonUpdate4")]
    partial class ShowCharaSeasonUpdate4
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0-preview.1.23111.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Character", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CharacterImageURL")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MainRival")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ShowId")
                        .HasColumnType("int");

                    b.Property<string>("StrongestAttack")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ShowId");

                    b.ToTable("Characters");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CharacterImageURL = "https://dragonball.guru/wp-content/uploads/2021/01/goku-dragon-ball-guru.jpg",
                            MainRival = "Vegeta",
                            Name = "Goku",
                            ShowId = 1,
                            StrongestAttack = "Kamehameha"
                        },
                        new
                        {
                            Id = 2,
                            CharacterImageURL = "https://static.wikia.nocookie.net/naruto/images/d/d6/Naruto_Part_I.png/revision/latest/scale-to-width-down/1200?cb=20210223094656",
                            MainRival = "Sasuke",
                            Name = "Naruto",
                            ShowId = 2,
                            StrongestAttack = "Rasengan"
                        },
                        new
                        {
                            Id = 3,
                            CharacterImageURL = "https://static.wikia.nocookie.net/p__/images/b/be/Yona.jpg/revision/latest?cb=20210602102733&path-prefix=protagonist",
                            MainRival = "Zoey",
                            Name = "Yona",
                            ShowId = 3,
                            StrongestAttack = "Archery"
                        },
                        new
                        {
                            Id = 4,
                            CharacterImageURL = "https://images-wixmp-ed30a86b8c4ca887773594c2.wixmp.com/f/e7fef299-7dc1-43eb-85bd-12218f96803f/de2xrw2-3fcf7ee7-e62f-476a-877b-9db574cabda6.png?token=eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJzdWIiOiJ1cm46YXBwOjdlMGQxODg5ODIyNjQzNzNhNWYwZDQxNWVhMGQyNmUwIiwiaXNzIjoidXJuOmFwcDo3ZTBkMTg4OTgyMjY0MzczYTVmMGQ0MTVlYTBkMjZlMCIsIm9iaiI6W1t7InBhdGgiOiJcL2ZcL2U3ZmVmMjk5LTdkYzEtNDNlYi04NWJkLTEyMjE4Zjk2ODAzZlwvZGUyeHJ3Mi0zZmNmN2VlNy1lNjJmLTQ3NmEtODc3Yi05ZGI1NzRjYWJkYTYucG5nIn1dXSwiYXVkIjpbInVybjpzZXJ2aWNlOmZpbGUuZG93bmxvYWQiXX0.R88NtAsSUcqtFCFVoaB5Qgp7zMl2YqL3qk3tQNgOObE",
                            MainRival = "Muzan Kibutsuji",
                            Name = "tanjiro",
                            ShowId = 4,
                            StrongestAttack = "Dance of the Fire God"
                        },
                        new
                        {
                            Id = 5,
                            CharacterImageURL = "https://static.wikia.nocookie.net/shingekinokyojin/images/3/3c/Eren_Jaeger_%28Anime%29_character_image_%28850%29.png/revision/latest?cb=20201228000236",
                            MainRival = "Jean Kirstein",
                            Name = "Eren Yeager",
                            ShowId = 5,
                            StrongestAttack = "Founding titan form"
                        },
                        new
                        {
                            Id = 6,
                            CharacterImageURL = "https://www.nahsvikingsaga.org/wp-content/uploads/2020/11/DEKU.png",
                            MainRival = "Katsuki Bakugo",
                            Name = "Izuku \"Deku\" Midoriya",
                            ShowId = 6,
                            StrongestAttack = "Delaware Detroit Smash"
                        },
                        new
                        {
                            Id = 7,
                            CharacterImageURL = "https://static.wikia.nocookie.net/onepiece/images/e/e5/Monkey_D._Luffy_Anime_Pre_Timeskip_Infobox.png/revision/latest?cb=20230218134949",
                            MainRival = "Blackbeard",
                            Name = "Luffy",
                            ShowId = 7,
                            StrongestAttack = "Gum-Gum Monkey God Gun"
                        },
                        new
                        {
                            Id = 8,
                            CharacterImageURL = "https://static.wikia.nocookie.net/mcleodgaming/images/3/3e/Ichigo.png/revision/latest?cb=20200709232729",
                            MainRival = "Sōsuke Aizen",
                            Name = "Ichigo",
                            ShowId = 8,
                            StrongestAttack = "Getsuga Tenshō"
                        },
                        new
                        {
                            Id = 9,
                            CharacterImageURL = "https://www.giantbomb.com/a/uploads/scale_small/2/27436/2722697-gon_freecss_2617.jpg",
                            MainRival = "Killua Zoldyck",
                            Name = "Gon",
                            ShowId = 9,
                            StrongestAttack = "Rock-Paper-Scissors (Rock)"
                        },
                        new
                        {
                            Id = 10,
                            CharacterImageURL = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRvvZzLVq6oXM5AwfkwRsNTCEOxOK5OZcoZ_g&usqp=CAU",
                            MainRival = "Yuno",
                            Name = "Asta",
                            ShowId = 10,
                            StrongestAttack = "Black Asta"
                        },
                        new
                        {
                            Id = 11,
                            CharacterImageURL = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcR_XEW5y-dD-I6R7KdD_0VGFdzK0JBkq0pzxQ&usqp=CAU",
                            MainRival = "Seto Kaiba",
                            Name = "Yugi \"The Pharaoh\" Mutou ",
                            ShowId = 11,
                            StrongestAttack = "Dark Magician Attack"
                        },
                        new
                        {
                            Id = 12,
                            CharacterImageURL = "https://uploads-ssl.webflow.com/63851d467dc151a9f46a992b/638630e0b32ca1abefa9eb80_6256e4322354f3d35b2a268a_ash%2520ketchum%2520pose.jpeg",
                            MainRival = "Gary Oak",
                            Name = "Ash Ketchum",
                            ShowId = 12,
                            StrongestAttack = "Volt Attack (Pikachu)"
                        },
                        new
                        {
                            Id = 13,
                            CharacterImageURL = "https://i.pinimg.com/originals/dc/eb/9d/dceb9d37b7f174925b3e0a562191e07b.jpg",
                            MainRival = "Aoi Todo",
                            Name = "Yuji Itadori",
                            ShowId = 13,
                            StrongestAttack = "Manji Kick"
                        },
                        new
                        {
                            Id = 14,
                            CharacterImageURL = "https://pisces.bbystatic.com/image2/BestBuy_US/images/products/1413/14138186_sa.jpg",
                            MainRival = "Raven",
                            Name = "Van Flyheight",
                            ShowId = 14,
                            StrongestAttack = "Laser Blades"
                        },
                        new
                        {
                            Id = 15,
                            CharacterImageURL = "https://static.wikia.nocookie.net/supermarioglitchy4/images/c/c3/Saitama_Profile.png/revision/latest?cb=20220521022745",
                            MainRival = "Boros",
                            Name = "Saitama",
                            ShowId = 15,
                            StrongestAttack = "Serious Table Flip"
                        });
                });

            modelBuilder.Entity("Season", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("EpisodeCount")
                        .HasColumnType("int");

                    b.Property<int>("NumberOfSeasons")
                        .HasColumnType("int");

                    b.Property<int>("ShowId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ShowId");

                    b.ToTable("Seasons");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            EpisodeCount = 276,
                            NumberOfSeasons = 9,
                            ShowId = 1
                        },
                        new
                        {
                            Id = 2,
                            EpisodeCount = 726,
                            NumberOfSeasons = 26,
                            ShowId = 2
                        },
                        new
                        {
                            Id = 3,
                            EpisodeCount = 24,
                            NumberOfSeasons = 1,
                            ShowId = 3
                        },
                        new
                        {
                            Id = 4,
                            EpisodeCount = 44,
                            NumberOfSeasons = 2,
                            ShowId = 4
                        },
                        new
                        {
                            Id = 5,
                            EpisodeCount = 88,
                            NumberOfSeasons = 4,
                            ShowId = 5
                        },
                        new
                        {
                            Id = 6,
                            EpisodeCount = 138,
                            NumberOfSeasons = 6,
                            ShowId = 6
                        },
                        new
                        {
                            Id = 7,
                            EpisodeCount = 1053,
                            NumberOfSeasons = 20,
                            ShowId = 7
                        },
                        new
                        {
                            Id = 8,
                            EpisodeCount = 366,
                            NumberOfSeasons = 8,
                            ShowId = 8
                        },
                        new
                        {
                            Id = 9,
                            EpisodeCount = 148,
                            NumberOfSeasons = 6,
                            ShowId = 9
                        },
                        new
                        {
                            Id = 10,
                            EpisodeCount = 170,
                            NumberOfSeasons = 4,
                            ShowId = 10
                        },
                        new
                        {
                            Id = 11,
                            EpisodeCount = 224,
                            NumberOfSeasons = 5,
                            ShowId = 11
                        },
                        new
                        {
                            Id = 12,
                            EpisodeCount = 1232,
                            NumberOfSeasons = 25,
                            ShowId = 12
                        },
                        new
                        {
                            Id = 13,
                            EpisodeCount = 1,
                            NumberOfSeasons = 24,
                            ShowId = 13
                        },
                        new
                        {
                            Id = 14,
                            EpisodeCount = 67,
                            NumberOfSeasons = 2,
                            ShowId = 14
                        },
                        new
                        {
                            Id = 15,
                            EpisodeCount = 24,
                            NumberOfSeasons = 2,
                            ShowId = 15
                        });
                });

            modelBuilder.Entity("Show", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Genre")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ShowImageURL")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Shows");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Genre = 0,
                            Name = "DragonBall Z",
                            ShowImageURL = "https://static.wikia.nocookie.net/p__/images/8/8e/Dbz_group.jpg/revision/latest?cb=20141002145405&path-prefix=protagonist"
                        },
                        new
                        {
                            Id = 2,
                            Genre = 0,
                            Name = "Naruto",
                            ShowImageURL = "https://static.wikia.nocookie.net/naruto/images/8/81/Vol72.png/revision/latest?cb=20210331141503"
                        },
                        new
                        {
                            Id = 3,
                            Genre = 1,
                            Name = "Yona of The Dawn",
                            ShowImageURL = "http://prodimage.images-bn.com/pimages/9781421587813_p0_v1_s1200x630.jpg"
                        },
                        new
                        {
                            Id = 4,
                            Genre = 0,
                            Name = "Demon Slayer",
                            ShowImageURL = "https://d28hgpri8am2if.cloudfront.net/book_images/onix/cvr9781974704552/demon-slayer-kimetsu-no-yaiba-vol-10-9781974704552_hr.jpg"
                        },
                        new
                        {
                            Id = 5,
                            Genre = 3,
                            Name = "Attack on Titan",
                            ShowImageURL = "https://images.squarespace-cdn.com/content/v1/571abd61e3214001fb3b9966/1631036388773-S5RTHBL1JMSWKM5CLDA2/Attack+on+Titan+-+Before+the+Fall+-+Spinoff+Manga"
                        },
                        new
                        {
                            Id = 6,
                            Genre = 0,
                            Name = "My Hero Academia",
                            ShowImageURL = "https://d28hgpri8am2if.cloudfront.net/book_images/onix/cvr9781421582696/my-hero-academia-vol-1-9781421582696_hr.jpg"
                        },
                        new
                        {
                            Id = 7,
                            Genre = 0,
                            Name = "One Piece",
                            ShowImageURL = "https://d28hgpri8am2if.cloudfront.net/book_images/onix/cvr9781974722891/one-piece-vol-97-9781974722891_hr.jpg"
                        },
                        new
                        {
                            Id = 8,
                            Genre = 0,
                            Name = "Bleach",
                            ShowImageURL = "https://d28hgpri8am2if.cloudfront.net/book_images/onix/cvr9781421510439/bleach-vol-19-9781421510439_hr.jpg"
                        },
                        new
                        {
                            Id = 9,
                            Genre = 3,
                            Name = "Hunter x Hunter",
                            ShowImageURL = "https://upload.wikimedia.org/wikipedia/en/0/0f/Hunter_x_Hunter_cover_-_vol1.jpg"
                        },
                        new
                        {
                            Id = 10,
                            Genre = 0,
                            Name = "Black Cover",
                            ShowImageURL = "https://m.media-amazon.com/images/M/MV5BN2FlYjYxMTMtZGQzYy00OWU2LTkyYWMtNWJhODhmZmM0N2FhXkEyXkFqcGdeQXVyNjAwNDUxODI@._V1_FMjpg_UX1000_.jpg"
                        },
                        new
                        {
                            Id = 11,
                            Genre = 3,
                            Name = "Yu-Gi-Oh!",
                            ShowImageURL = "https://d28hgpri8am2if.cloudfront.net/book_images/onix/cvr9781421579252/yu-gi-oh-3-in-1-edition-vol-2-9781421579252_hr.jpg"
                        },
                        new
                        {
                            Id = 12,
                            Genre = 3,
                            Name = "Pokemon",
                            ShowImageURL = "https://static.wikia.nocookie.net/black60dragon/images/6/64/Pokémon.jpg/revision/latest?cb=20181202172826"
                        },
                        new
                        {
                            Id = 13,
                            Genre = 0,
                            Name = "Jujutsu Kaisen",
                            ShowImageURL = "https://static.wikia.nocookie.net/jujutsu-kaisen/images/0/0e/Volume_1.png/revision/latest?cb=20180719214641"
                        },
                        new
                        {
                            Id = 14,
                            Genre = 2,
                            Name = "Zoids Chaotic Century",
                            ShowImageURL = "https://pisces.bbystatic.com/image2/BestBuy_US/images/products/1413/14138186_sa.jpg"
                        },
                        new
                        {
                            Id = 15,
                            Genre = 3,
                            Name = "One Punch Man",
                            ShowImageURL = "https://upload.wikimedia.org/wikipedia/en/c/c3/OnePunchMan_manga_cover.png"
                        });
                });

            modelBuilder.Entity("Character", b =>
                {
                    b.HasOne("Show", "Show")
                        .WithMany("Characters")
                        .HasForeignKey("ShowId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Show");
                });

            modelBuilder.Entity("Season", b =>
                {
                    b.HasOne("Show", "Show")
                        .WithMany("Seasons")
                        .HasForeignKey("ShowId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Show");
                });

            modelBuilder.Entity("Show", b =>
                {
                    b.Navigation("Characters");

                    b.Navigation("Seasons");
                });
#pragma warning restore 612, 618
        }
    }
}
