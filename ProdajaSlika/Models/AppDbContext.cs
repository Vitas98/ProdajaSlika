using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace ProdajaSlika.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Picture> Pictures { get; set; }
        public DbSet<CanvasType> CanvasTypes { get; set; }
        public DbSet<FrameType> FrameTypes { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<ShoppingCartItem> ShoppingCartItems { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //kreiranje kategorija
            modelBuilder.Entity<Category>().HasData(new Category { Id = 1, Name = "Slike Beograda", Description = "Mnogo je zaljubljenika u Beograd i za to svakako postoji mnogo dobrih razloga. Ovo je odličan način da na zid prenesete neke od najlepših kadrova iz srpske prestonice, koji su zabeleženi objektivom fotoaparata." });
            modelBuilder.Entity<Category>().HasData(new Category { Id = 2, Name = "Slike Srbije", Description = "Mnogo je zaljubljenika u našu zemlju Srbiju i za to svakako postoji mnogo dobrih razloga. Ovo je odličan način da na zid prenesete neke od najlepših kadrova iz države Srbije, koji su zabeleženi objektivom fotoaparata." });
            modelBuilder.Entity<Category>().HasData(new Category { Id = 3, Name = "Gradovi sveta", Description = "Unesite šarm svetskih metropola u svoj enterijer. Digitalna štampa na platnu je najbolji način da zidove ulepšate slikama gradova sveta. Ulice Pariza, Londona ili Njujorka mogu da budu pred vašim očima čak i onda kada vi niste na njima." });
            modelBuilder.Entity<Category>().HasData(new Category { Id = 4, Name = "Slike prirode", Description = "U vaš dom ili poslovni prostor unesite neverovatne kadrove kakve je moguće zabeležiti samo u prirodi. Prelepi predeli prirode nikoga ne ostavljaju ravnodušnim." });
            modelBuilder.Entity<Category>().HasData(new Category { Id = 5, Name = "Feng shui", Description = "Feng šui, što znači vetar i voda na kineskom jeziku, predstavlja drevnu kinesku praksu koja se bavi uređenjem prostora kako bi se postigla harmonija i balans između okoline i ljudske energije." });
            modelBuilder.Entity<Category>().HasData(new Category { Id = 6, Name = "Crtezi", Description = "Crtež jeste baza svih vizelnih umetnosti, ali je crtež i sam po sebi jednako vredno umetničko delo. Velika imena u svetu umetnosti, iako često  upamćena po svojim slikama, iza sebe su ostavila i neke maestralne crteže. Ujedno, crteži su dokaz da umetničko delo sa jakom porukom može da bude stvoreno i na običnom parčetu hartije, uz pomoć grafitne olovke." });
            modelBuilder.Entity<Category>().HasData(new Category { Id = 7, Name = "Posteri zivotinja", Description = "U vaš dom ili poslovni prostor unesite neverovatne kadrove kakve je moguće zabeležiti samo u prirodi. Životinje vekovima privlače pažnju ljudi i zadivljuju svojim osobinama i izgledom." });
            modelBuilder.Entity<Category>().HasData(new Category { Id = 8, Name = "Stare mape sveta", Description = "Stare mape sveta su danas jedan od omiljenih načina za uređenje enterijera kod svih ljubitelja putovanja, istrorije ili avanture. Uglavnom se koristi za kafiće, restorane i hotele, ali nije mali broj pustolova-amatera koji ih imaju na zidovima svojih soba." });
            modelBuilder.Entity<Category>().HasData(new Category { Id = 9, Name = "Dekorativne slike", Description = "Dekorativne slike vam omogućavaju da povoljno uredite bilo koju prostoriju ili čitav objekat tako da dobije upečatljiv umetnički efekat. Ovo može biti i lep poklon za vaše prijatelje i njihov dom." });

            //kreiranje vrsta
            modelBuilder.Entity<FrameType>().HasData(new FrameType { Id = 1, Name = "Blind ram(2cm)", Description = "" });
            modelBuilder.Entity<FrameType>().HasData(new FrameType { Id = 2, Name = "Blind ram(3,5cm)", Description = "" });


            modelBuilder.Entity<CanvasType>().HasData(new CanvasType { Id = 1, Name = "Tanje platno", Description = "Kinesko platno, manje izražena tekstura" });
            modelBuilder.Entity<CanvasType>().HasData(new CanvasType { Id = 2, Name = "Deblje platno", Description = "Nemačko platno, izraženija tekstura" });


            //kreiranje slika
            modelBuilder.Entity<Picture>().HasData(new Picture
            {
                Id = 1,
                Name = "Saborna crkva",
                Description = "",
                Price = 1366,
                ImageUrl = "https://uramljivanjeslika.rs/wp-content/uploads/2020/09/092-Saborna-crkva.jpg",
                IsSpecialOffer = false,
                CanvasTypeId = 1,
                FrameTypeId = 1,
                PictureHeight = 60,
                PictureWidth = 30,
                CategoryId = 1
            });

            modelBuilder.Entity<Picture>().HasData(new Picture
            {
                Id = 2,
                Name = "Golubačka tvrđava",
                Description = "",
                Price = 2670,
                ImageUrl = "https://uramljivanjeslika.rs/wp-content/uploads/2020/09/001-Goluba%C4%8Dka-tvr%C4%91ava.jpg",
                IsSpecialOffer = false,
                CanvasTypeId = 2,
                FrameTypeId = 1,
                PictureHeight = 60,
                PictureWidth = 60,
                CategoryId = 2
            });

            modelBuilder.Entity<Picture>().HasData(new Picture
            {
                Id = 3,
                Name = "Pariz",
                Description = "",
                Price = 4627,
                ImageUrl = "https://uramljivanjeslika.rs/wp-content/uploads/2014/12/001-Pariz-1.jpg",
                IsSpecialOffer = true,
                CanvasTypeId = 1,
                FrameTypeId = 1,
                PictureHeight = 90,
                PictureWidth = 90,
                CategoryId = 3
            });

            modelBuilder.Entity<Picture>().HasData(new Picture
            {
                Id = 4,
                Name = "Balans",
                Description = "",
                Price = 1283,
                ImageUrl = "https://uramljivanjeslika.rs/wp-content/uploads/2016/03/01-feng-shui.jpg",
                IsSpecialOffer = false,
                CanvasTypeId = 1,
                FrameTypeId = 2,
                PictureHeight = 30,
                PictureWidth = 30,
                CategoryId = 5
            });

            modelBuilder.Entity<Picture>().HasData(new Picture
            {
                Id = 5,
                Name = "Sunčana oluja",
                Description = "",
                Price = 2046,
                ImageUrl = "https://uramljivanjeslika.rs/wp-content/uploads/2020/09/PRI-001.jpg",
                IsSpecialOffer = false,
                CanvasTypeId = 2,
                FrameTypeId = 1,
                PictureHeight = 55,
                PictureWidth = 45,
                CategoryId = 4
            });

            modelBuilder.Entity<Picture>().HasData(new Picture
            {
                Id = 6,
                Name = "Love",
                Description = "",
                Price = 1811,
                ImageUrl = "https://uramljivanjeslika.rs/wp-content/uploads/2020/09/DEK-007.jpg",
                IsSpecialOffer = false,
                CanvasTypeId = 1,
                FrameTypeId = 2,
                PictureHeight = 80,
                PictureWidth = 20,
                CategoryId = 9
            });

            modelBuilder.Entity<Picture>().HasData(new Picture
            {
                Id = 7,
                Name = "Južna Amerika",
                Description = "",
                Price = 2089,
                ImageUrl = "https://uramljivanjeslika.rs/wp-content/uploads/2014/12/Stara-mapa-sveta-8.jpg",
                IsSpecialOffer = true,
                CanvasTypeId = 1,
                FrameTypeId = 1,
                PictureHeight = 75,
                PictureWidth = 35,
                CategoryId = 8
            });

            modelBuilder.Entity<Picture>().HasData(new Picture
            {
                Id = 8,
                Name = "Gepard",
                Description = "",
                Price = 5053,
                ImageUrl = "https://uramljivanjeslika.rs/wp-content/uploads/2014/12/Gepard-7.jpg",
                IsSpecialOffer = false,
                CanvasTypeId = 2,
                FrameTypeId = 2,
                PictureHeight = 110,
                PictureWidth = 50,
                CategoryId = 7
            });

            modelBuilder.Entity<Picture>().HasData(new Picture
            {
                Id = 9,
                Name = "The Human Argument",
                Description = "",
                Price = 2827,
                ImageUrl = "https://uramljivanjeslika.rs/wp-content/uploads/2014/12/Agnes-Denes-The-Human-Argument1.jpg",
                IsSpecialOffer = false,
                CanvasTypeId = 1,
                FrameTypeId = 2,
                PictureHeight = 70,
                PictureWidth = 45,
                CategoryId = 6
            });

            modelBuilder.Entity<Picture>().HasData(new Picture
            {
                Id = 10,
                Name = "Mirisna sveća",
                Description = "",
                Price = 4268,
                ImageUrl = "https://uramljivanjeslika.rs/wp-content/uploads/2016/03/11-feng-shui.jpg",
                IsSpecialOffer = true,
                CanvasTypeId = 2,
                FrameTypeId = 1,
                PictureHeight = 95,
                PictureWidth = 55,
                CategoryId = 5
            });
        }
    }
}
