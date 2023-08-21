using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ProdajaSlika.Migrations
{
    /// <inheritdoc />
    public partial class initialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CanvasTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CanvasTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FrameTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FrameTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Pictures",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    CanvasTypeId = table.Column<int>(type: "int", nullable: false),
                    FrameTypeId = table.Column<int>(type: "int", nullable: false),
                    PictureHeight = table.Column<int>(type: "int", nullable: false),
                    PictureWidth = table.Column<int>(type: "int", nullable: false),
                    IsSpecialOffer = table.Column<bool>(type: "bit", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pictures", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Pictures_CanvasTypes_CanvasTypeId",
                        column: x => x.CanvasTypeId,
                        principalTable: "CanvasTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Pictures_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Pictures_FrameTypes_FrameTypeId",
                        column: x => x.FrameTypeId,
                        principalTable: "FrameTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ShoppingCartItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PictureId = table.Column<int>(type: "int", nullable: false),
                    Amount = table.Column<int>(type: "int", nullable: false),
                    ShoppingCartId = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShoppingCartItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ShoppingCartItems_Pictures_PictureId",
                        column: x => x.PictureId,
                        principalTable: "Pictures",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "CanvasTypes",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "Kinesko platno, manje izražena tekstura", "Tanje platno" },
                    { 2, "Nemačko platno, izraženija tekstura", "Deblje platno" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "Mnogo je zaljubljenika u Beograd i za to svakako postoji mnogo dobrih razloga. Ovo je odličan način da na zid prenesete neke od najlepših kadrova iz srpske prestonice, koji su zabeleženi objektivom fotoaparata.", "Slike Beograda" },
                    { 2, "Mnogo je zaljubljenika u našu zemlju Srbiju i za to svakako postoji mnogo dobrih razloga. Ovo je odličan način da na zid prenesete neke od najlepših kadrova iz države Srbije, koji su zabeleženi objektivom fotoaparata.", "Slike Srbije" },
                    { 3, "Unesite šarm svetskih metropola u svoj enterijer. Digitalna štampa na platnu je najbolji način da zidove ulepšate slikama gradova sveta. Ulice Pariza, Londona ili Njujorka mogu da budu pred vašim očima čak i onda kada vi niste na njima.", "Gradovi sveta" },
                    { 4, "U vaš dom ili poslovni prostor unesite neverovatne kadrove kakve je moguće zabeležiti samo u prirodi. Prelepi predeli prirode nikoga ne ostavljaju ravnodušnim.", "Slike prirode" },
                    { 5, "Feng šui, što znači vetar i voda na kineskom jeziku, predstavlja drevnu kinesku praksu koja se bavi uređenjem prostora kako bi se postigla harmonija i balans između okoline i ljudske energije.", "Feng shui" },
                    { 6, "Crtež jeste baza svih vizelnih umetnosti, ali je crtež i sam po sebi jednako vredno umetničko delo. Velika imena u svetu umetnosti, iako često  upamćena po svojim slikama, iza sebe su ostavila i neke maestralne crteže. Ujedno, crteži su dokaz da umetničko delo sa jakom porukom može da bude stvoreno i na običnom parčetu hartije, uz pomoć grafitne olovke.", "Crtezi" },
                    { 7, "U vaš dom ili poslovni prostor unesite neverovatne kadrove kakve je moguće zabeležiti samo u prirodi. Životinje vekovima privlače pažnju ljudi i zadivljuju svojim osobinama i izgledom.", "Posteri zivotinja" },
                    { 8, "Stare mape sveta su danas jedan od omiljenih načina za uređenje enterijera kod svih ljubitelja putovanja, istrorije ili avanture. Uglavnom se koristi za kafiće, restorane i hotele, ali nije mali broj pustolova-amatera koji ih imaju na zidovima svojih soba.", "Stare mape sveta" },
                    { 9, "Dekorativne slike vam omogućavaju da povoljno uredite bilo koju prostoriju ili čitav objekat tako da dobije upečatljiv umetnički efekat. Ovo može biti i lep poklon za vaše prijatelje i njihov dom.", "Dekorativne slike" }
                });

            migrationBuilder.InsertData(
                table: "FrameTypes",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "", "Blind ram(2cm)" },
                    { 2, "", "Blind ram(3,5cm)" }
                });

            migrationBuilder.InsertData(
                table: "Pictures",
                columns: new[] { "Id", "CanvasTypeId", "CategoryId", "Description", "FrameTypeId", "ImageUrl", "IsSpecialOffer", "Name", "PictureHeight", "PictureWidth", "Price" },
                values: new object[,]
                {
                    { 1, 1, 1, "", 1, "https://uramljivanjeslika.rs/wp-content/uploads/2020/09/092-Saborna-crkva.jpg", false, "Saborna crkva", 60, 30, 1366m },
                    { 2, 2, 2, "", 1, "https://uramljivanjeslika.rs/wp-content/uploads/2020/09/001-Goluba%C4%8Dka-tvr%C4%91ava.jpg", false, "Golubačka tvrđava", 60, 60, 2670m },
                    { 3, 1, 3, "", 1, "https://uramljivanjeslika.rs/wp-content/uploads/2014/12/001-Pariz-1.jpg", true, "Pariz", 90, 90, 4627m },
                    { 4, 1, 5, "", 2, "https://uramljivanjeslika.rs/wp-content/uploads/2016/03/01-feng-shui.jpg", false, "Balans", 30, 30, 1283m },
                    { 5, 2, 4, "", 1, "https://uramljivanjeslika.rs/wp-content/uploads/2020/09/PRI-001.jpg", false, "Sunčana oluja", 55, 45, 2046m },
                    { 6, 1, 9, "", 2, "https://uramljivanjeslika.rs/wp-content/uploads/2020/09/DEK-007.jpg", false, "Love", 80, 20, 1811m },
                    { 7, 1, 8, "", 1, "https://uramljivanjeslika.rs/wp-content/uploads/2014/12/Stara-mapa-sveta-8.jpg", true, "Južna Amerika", 75, 35, 2089m },
                    { 8, 2, 7, "", 2, "https://uramljivanjeslika.rs/wp-content/uploads/2014/12/Gepard-7.jpg", false, "Gepard", 110, 50, 5053m },
                    { 9, 1, 6, "", 2, "https://uramljivanjeslika.rs/wp-content/uploads/2014/12/Agnes-Denes-The-Human-Argument1.jpg", false, "The Human Argument", 70, 45, 2827m },
                    { 10, 2, 5, "", 1, "https://uramljivanjeslika.rs/wp-content/uploads/2016/03/11-feng-shui.jpg", true, "Mirisna sveća", 95, 55, 4268m }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Pictures_CanvasTypeId",
                table: "Pictures",
                column: "CanvasTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Pictures_CategoryId",
                table: "Pictures",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Pictures_FrameTypeId",
                table: "Pictures",
                column: "FrameTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_ShoppingCartItems_PictureId",
                table: "ShoppingCartItems",
                column: "PictureId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ShoppingCartItems");

            migrationBuilder.DropTable(
                name: "Pictures");

            migrationBuilder.DropTable(
                name: "CanvasTypes");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "FrameTypes");
        }
    }
}
