using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

    public DbSet<Show> Shows { get; set; }

    public DbSet<Character> Characters { get; set; }

    public DbSet<Season> Seasons { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<Show>().HasData(
            new Show
            {
                Id = 1,
                Name = "DragonBall Z",
                Genre = Genre.Shonen,
                WhereToWatch = WhereToWatch.CrunchyRoll,
                ShowImageURL = "https://static.wikia.nocookie.net/p__/images/8/8e/Dbz_group.jpg/revision/latest?cb=20141002145405&path-prefix=protagonist"

            },

            new Show
            {
                Id = 2,
                Name = "Naruto",
                Genre = Genre.Shonen,
                WhereToWatch = WhereToWatch.Hulu,
                ShowImageURL = "https://static.wikia.nocookie.net/naruto/images/8/81/Vol72.png/revision/latest?cb=20210331141503"
            
            },

            new Show
            {
                Id = 3,
                Name = "Yona of The Dawn",
                Genre = Genre.Shoujo,
                WhereToWatch = WhereToWatch.Funimation,
                ShowImageURL = "http://prodimage.images-bn.com/pimages/9781421587813_p0_v1_s1200x630.jpg"
            },
            new Show
            {
                Id = 4,
                Name = "Demon Slayer",
                Genre = Genre.Shonen,
                WhereToWatch = WhereToWatch.Netflix,
                ShowImageURL = "https://d28hgpri8am2if.cloudfront.net/book_images/onix/cvr9781974704552/demon-slayer-kimetsu-no-yaiba-vol-10-9781974704552_hr.jpg"
            },
            new Show
            {
                Id = 5,
                Name = "Attack on Titan",
                Genre = Genre.Fantasy,
                WhereToWatch = WhereToWatch.CrunchyRoll,
                ShowImageURL = "https://images.squarespace-cdn.com/content/v1/571abd61e3214001fb3b9966/1631036388773-S5RTHBL1JMSWKM5CLDA2/Attack+on+Titan+-+Before+the+Fall+-+Spinoff+Manga"
            },
            new Show
            {
                Id = 6,
                Name = "My Hero Academia",
                Genre = Genre.Shonen,
                WhereToWatch = WhereToWatch.Funimation,
                ShowImageURL = "https://d28hgpri8am2if.cloudfront.net/book_images/onix/cvr9781421582696/my-hero-academia-vol-1-9781421582696_hr.jpg"
            },
            new Show
            {
                Id = 7,
                Name = "One Piece",
                Genre = Genre.Shonen,
                WhereToWatch = WhereToWatch.Netflix,
                ShowImageURL = "https://d28hgpri8am2if.cloudfront.net/book_images/onix/cvr9781974722891/one-piece-vol-97-9781974722891_hr.jpg"
            },
            new Show
            {
                Id = 8,
                Name = "Bleach",
                Genre = Genre.Shonen,
                WhereToWatch = WhereToWatch.Hulu,
                ShowImageURL = "https://d28hgpri8am2if.cloudfront.net/book_images/onix/cvr9781421510439/bleach-vol-19-9781421510439_hr.jpg"
            },
            new Show
            {
                Id = 9,
                Name = "Hunter x Hunter",
                Genre = Genre.Fantasy,
                WhereToWatch = WhereToWatch.Netflix,
                ShowImageURL = "https://upload.wikimedia.org/wikipedia/en/0/0f/Hunter_x_Hunter_cover_-_vol1.jpg"
            },
            new Show
            {
                Id = 10,
                Name = "Black Cover",
                Genre = Genre.Shonen,
                WhereToWatch = WhereToWatch.Funimation,
                ShowImageURL = "https://m.media-amazon.com/images/M/MV5BN2FlYjYxMTMtZGQzYy00OWU2LTkyYWMtNWJhODhmZmM0N2FhXkEyXkFqcGdeQXVyNjAwNDUxODI@._V1_FMjpg_UX1000_.jpg"
            },
            new Show
            {
                Id = 11,
                Name = "Yu-Gi-Oh!",
                Genre = Genre.Fantasy,
                WhereToWatch = WhereToWatch.Netflix,
                ShowImageURL = "https://d28hgpri8am2if.cloudfront.net/book_images/onix/cvr9781421579252/yu-gi-oh-3-in-1-edition-vol-2-9781421579252_hr.jpg"
            },
            new Show
            {
                Id = 12,
                Name = "Pokemon",
                Genre = Genre.Fantasy,
                WhereToWatch = WhereToWatch.CrunchyRoll,
                ShowImageURL = "https://static.wikia.nocookie.net/black60dragon/images/6/64/Pokémon.jpg/revision/latest?cb=20181202172826"
            },
            new Show
            {
                Id = 13,
                Name = "Jujutsu Kaisen",
                Genre = Genre.Shonen,
                WhereToWatch = WhereToWatch.Funimation,
                ShowImageURL = "https://static.wikia.nocookie.net/jujutsu-kaisen/images/0/0e/Volume_1.png/revision/latest?cb=20180719214641"
            },
            new Show
            {
                Id = 14,
                Name = "Zoids Chaotic Century",
                Genre = Genre.Mecha,
                WhereToWatch = WhereToWatch.CrunchyRoll,
                ShowImageURL = "https://pisces.bbystatic.com/image2/BestBuy_US/images/products/1413/14138186_sa.jpg"
            },
            new Show
            {
                Id = 15,
                Name = "One Punch Man",
                Genre = Genre.Fantasy,
                WhereToWatch = WhereToWatch.CrunchyRoll,
                ShowImageURL = "https://upload.wikimedia.org/wikipedia/en/c/c3/OnePunchMan_manga_cover.png"
            }

        );

        modelBuilder.Entity<Character>().HasData(
            new Character
            {
                Id = 1,
                CharacterImageURL = "https://dragonball.guru/wp-content/uploads/2021/01/goku-dragon-ball-guru.jpg",
                Name = "Goku",
                StrongestAttack = "Kamehameha",
                MainRival = "Vegeta",
                ShowId = 1
            },

            new Character
            {
                Id = 2,
                CharacterImageURL= "https://static.wikia.nocookie.net/naruto/images/d/d6/Naruto_Part_I.png/revision/latest/scale-to-width-down/1200?cb=20210223094656",
                Name = "Naruto",
                StrongestAttack = "Rasengan",
                MainRival = "Sasuke",
                ShowId = 2
            },

            new Character
            {
                Id = 3,
                CharacterImageURL="https://static.wikia.nocookie.net/p__/images/b/be/Yona.jpg/revision/latest?cb=20210602102733&path-prefix=protagonist",
                Name = "Yona",
                StrongestAttack = "Archery",
                MainRival = "Zoey",
                ShowId = 3
            },
            new Character
            {
                Id = 4,
                CharacterImageURL="https://images-wixmp-ed30a86b8c4ca887773594c2.wixmp.com/f/e7fef299-7dc1-43eb-85bd-12218f96803f/de2xrw2-3fcf7ee7-e62f-476a-877b-9db574cabda6.png?token=eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJzdWIiOiJ1cm46YXBwOjdlMGQxODg5ODIyNjQzNzNhNWYwZDQxNWVhMGQyNmUwIiwiaXNzIjoidXJuOmFwcDo3ZTBkMTg4OTgyMjY0MzczYTVmMGQ0MTVlYTBkMjZlMCIsIm9iaiI6W1t7InBhdGgiOiJcL2ZcL2U3ZmVmMjk5LTdkYzEtNDNlYi04NWJkLTEyMjE4Zjk2ODAzZlwvZGUyeHJ3Mi0zZmNmN2VlNy1lNjJmLTQ3NmEtODc3Yi05ZGI1NzRjYWJkYTYucG5nIn1dXSwiYXVkIjpbInVybjpzZXJ2aWNlOmZpbGUuZG93bmxvYWQiXX0.R88NtAsSUcqtFCFVoaB5Qgp7zMl2YqL3qk3tQNgOObE",
                Name = "tanjiro",
                StrongestAttack = "Dance of the Fire God",
                MainRival = "Muzan Kibutsuji",
                ShowId = 4
            },
            new Character
            {
                Id = 5,
                CharacterImageURL="https://static.wikia.nocookie.net/shingekinokyojin/images/3/3c/Eren_Jaeger_%28Anime%29_character_image_%28850%29.png/revision/latest?cb=20201228000236",
                Name = "Eren Yeager",
                StrongestAttack = "Founding titan form",
                MainRival = "Jean Kirstein",
                ShowId = 5
            },
            new Character
            {
                Id = 6,
                CharacterImageURL="https://www.nahsvikingsaga.org/wp-content/uploads/2020/11/DEKU.png",
                Name = "Izuku \"Deku\" Midoriya",
                StrongestAttack = "Delaware Detroit Smash",
                MainRival = "Katsuki Bakugo",
                ShowId = 6
            },
            new Character
            {
                Id = 7,
                CharacterImageURL="https://static.wikia.nocookie.net/onepiece/images/e/e5/Monkey_D._Luffy_Anime_Pre_Timeskip_Infobox.png/revision/latest?cb=20230218134949",
                Name = "Luffy",
                StrongestAttack = "Gum-Gum Monkey God Gun",
                MainRival = "Blackbeard",
                ShowId = 7
            },
            new Character
            {
                Id = 8,
                CharacterImageURL="https://static.wikia.nocookie.net/mcleodgaming/images/3/3e/Ichigo.png/revision/latest?cb=20200709232729",
                Name = "Ichigo",
                StrongestAttack = "Getsuga Tenshō",
                MainRival = "Sōsuke Aizen",
                ShowId = 8
            },
            new Character
            {
                Id = 9,
                CharacterImageURL="https://www.giantbomb.com/a/uploads/scale_small/2/27436/2722697-gon_freecss_2617.jpg",
                Name = "Gon",
                StrongestAttack = "Rock-Paper-Scissors (Rock)",
                MainRival = "Killua Zoldyck",
                ShowId = 9
            },
            new Character
            {
                Id = 10,
                CharacterImageURL="https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRvvZzLVq6oXM5AwfkwRsNTCEOxOK5OZcoZ_g&usqp=CAU",
                Name = "Asta",
                StrongestAttack = "Black Asta",
                MainRival = "Yuno",
                ShowId = 10
            },
            new Character
            {
                Id = 11,
                CharacterImageURL="https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcR_XEW5y-dD-I6R7KdD_0VGFdzK0JBkq0pzxQ&usqp=CAU",
                Name = "Yugi \"The Pharaoh\" Mutou ",
                StrongestAttack = "Dark Magician Attack",
                MainRival = "Seto Kaiba",
                ShowId = 11
            },
            new Character
            {
                Id = 12,
                CharacterImageURL="https://uploads-ssl.webflow.com/63851d467dc151a9f46a992b/638630e0b32ca1abefa9eb80_6256e4322354f3d35b2a268a_ash%2520ketchum%2520pose.jpeg",
                Name = "Ash Ketchum",
                StrongestAttack = "Volt Attack (Pikachu)",
                MainRival = "Gary Oak",
                ShowId = 12
            },
            new Character
            {
                Id = 13,
                CharacterImageURL="https://i.pinimg.com/originals/dc/eb/9d/dceb9d37b7f174925b3e0a562191e07b.jpg",
                Name = "Yuji Itadori",
                StrongestAttack = "Manji Kick",
                MainRival = "Aoi Todo",
                ShowId = 13
            },
            new Character
            {
                Id = 14,
                CharacterImageURL= "https://pisces.bbystatic.com/image2/BestBuy_US/images/products/1413/14138186_sa.jpg",
                Name = "Van Flyheight",
                StrongestAttack = "Laser Blades",
                MainRival = "Raven",
                ShowId = 14
            },
            new Character
            {
                Id = 15,
                CharacterImageURL= "https://static.wikia.nocookie.net/supermarioglitchy4/images/c/c3/Saitama_Profile.png/revision/latest?cb=20220521022745",
                Name = "Saitama",
                StrongestAttack = "Serious Table Flip",
                MainRival = "Boros",
                ShowId = 15
            }
        );

        modelBuilder.Entity<Season>().HasData(
            new Season
            {
                Id = 1,
                NumberOfSeasons = 9,
                EpisodeCount = 276,
                ShowId = 1
            },

            new Season
            {
                Id = 2,
                NumberOfSeasons = 26,
                EpisodeCount = 726,
                ShowId = 2
            },

            new Season
            {
                Id = 3,
                NumberOfSeasons = 1,
                EpisodeCount = 24,
                ShowId = 3
            },
            new Season
            {
                Id = 4,
                NumberOfSeasons = 2,
                EpisodeCount = 44,
                ShowId = 4
            },
            new Season
            {
                Id = 5,
                NumberOfSeasons = 4,
                EpisodeCount = 88,
                ShowId = 5
            },
            new Season
            {
                Id = 6,
                NumberOfSeasons = 6,
                EpisodeCount = 138,
                ShowId = 6
            },
            new Season
            {
                Id = 7,
                NumberOfSeasons = 20,
                EpisodeCount = 1053,
                ShowId = 7
            },
            new Season
            {
                Id = 8,
                NumberOfSeasons = 8,
                EpisodeCount = 366,
                ShowId = 8
            },
            new Season
            {
                Id = 9,
                NumberOfSeasons = 6,
                EpisodeCount = 148,
                ShowId = 9
            },
            new Season
            {
                Id = 10,
                NumberOfSeasons = 4,
                EpisodeCount = 170,
                ShowId = 10
            },
            new Season
            {
                Id = 11,
                NumberOfSeasons = 5,
                EpisodeCount = 224,
                ShowId = 11
            },
            new Season
            {
                Id = 12,
                NumberOfSeasons = 25,
                EpisodeCount = 1232,
                ShowId = 12
            },
            new Season
            {
                Id = 13,
                NumberOfSeasons = 24,
                EpisodeCount = 1,
                ShowId = 13
            },
            new Season
            {
                Id = 14,
                NumberOfSeasons = 2,
                EpisodeCount = 67,
                ShowId = 14
            },
            new Season
            {
                Id = 15,
                NumberOfSeasons = 2,
                EpisodeCount = 24,
                ShowId = 15
            }
        );

    }



}
