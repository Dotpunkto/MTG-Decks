using Microsoft.EntityFrameworkCore.Migrations;

namespace MTG_Decks.Server.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ImageUris",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Small = table.Column<string>(type: "TEXT", nullable: true),
                    Normal = table.Column<string>(type: "TEXT", nullable: true),
                    LLarge = table.Column<string>(type: "TEXT", nullable: true),
                    PNG = table.Column<string>(type: "TEXT", nullable: true),
                    Art_crop = table.Column<string>(type: "TEXT", nullable: true),
                    Border_crop = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ImageUris", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Legalities",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Standard = table.Column<string>(type: "TEXT", nullable: true),
                    Future = table.Column<string>(type: "TEXT", nullable: true),
                    Historic = table.Column<string>(type: "TEXT", nullable: true),
                    Gladiator = table.Column<string>(type: "TEXT", nullable: true),
                    Pioneer = table.Column<string>(type: "TEXT", nullable: true),
                    Modern = table.Column<string>(type: "TEXT", nullable: true),
                    Legacy = table.Column<string>(type: "TEXT", nullable: true),
                    Pauper = table.Column<string>(type: "TEXT", nullable: true),
                    Vintage = table.Column<string>(type: "TEXT", nullable: true),
                    Penny = table.Column<string>(type: "TEXT", nullable: true),
                    Commander = table.Column<string>(type: "TEXT", nullable: true),
                    Brawl = table.Column<string>(type: "TEXT", nullable: true),
                    Duel = table.Column<string>(type: "TEXT", nullable: true),
                    Oldschool = table.Column<string>(type: "TEXT", nullable: true),
                    Premodern = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Legalities", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Prices",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    USD = table.Column<string>(type: "TEXT", nullable: true),
                    Usd_foil = table.Column<string>(type: "TEXT", nullable: true),
                    EUR = table.Column<string>(type: "TEXT", nullable: true),
                    Eur_foil = table.Column<string>(type: "TEXT", nullable: true),
                    TIX = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Prices", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "PurchaseUris",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Tcgplayer = table.Column<string>(type: "TEXT", nullable: true),
                    Cardmarket = table.Column<string>(type: "TEXT", nullable: true),
                    Cardhoarder = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PurchaseUris", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "RelatedUris",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Gatherer = table.Column<string>(type: "TEXT", nullable: true),
                    Tcgplayer_decks = table.Column<string>(type: "TEXT", nullable: true),
                    Edhrec = table.Column<string>(type: "TEXT", nullable: true),
                    Mtgtop8 = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RelatedUris", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UserName = table.Column<string>(type: "TEXT", nullable: false),
                    Password = table.Column<string>(type: "TEXT", nullable: false),
                    Mail = table.Column<string>(type: "TEXT", nullable: false),
                    Role = table.Column<string>(type: "TEXT", nullable: true),
                    Token = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Card",
                columns: table => new
                {
                    ID = table.Column<string>(type: "TEXT", nullable: false),
                    Object = table.Column<string>(type: "TEXT", nullable: true),
                    Oracle_id = table.Column<string>(type: "TEXT", nullable: true),
                    Mtgo_id = table.Column<int>(type: "INTEGER", nullable: false),
                    Mtgo_foil_id = table.Column<int>(type: "INTEGER", nullable: false),
                    Tcgplayer_id = table.Column<int>(type: "INTEGER", nullable: false),
                    Cardmarket_id = table.Column<int>(type: "INTEGER", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    Lang = table.Column<string>(type: "TEXT", nullable: true),
                    Released_at = table.Column<string>(type: "TEXT", nullable: true),
                    URI = table.Column<string>(type: "TEXT", nullable: true),
                    Scryfall_uri = table.Column<string>(type: "TEXT", nullable: true),
                    Layout = table.Column<string>(type: "TEXT", nullable: true),
                    Highres_image = table.Column<bool>(type: "INTEGER", nullable: false),
                    Image_urisID = table.Column<int>(type: "INTEGER", nullable: true),
                    Mana_cost = table.Column<string>(type: "TEXT", nullable: true),
                    CMC = table.Column<float>(type: "REAL", nullable: false),
                    Type_line = table.Column<string>(type: "TEXT", nullable: true),
                    Oracle_text = table.Column<string>(type: "TEXT", nullable: true),
                    Power = table.Column<string>(type: "TEXT", nullable: true),
                    Toughness = table.Column<string>(type: "TEXT", nullable: true),
                    LegalitiesID = table.Column<int>(type: "INTEGER", nullable: true),
                    Reserved = table.Column<bool>(type: "INTEGER", nullable: false),
                    Foil = table.Column<bool>(type: "INTEGER", nullable: false),
                    Nonfoil = table.Column<bool>(type: "INTEGER", nullable: false),
                    Oversized = table.Column<bool>(type: "INTEGER", nullable: false),
                    Promo = table.Column<bool>(type: "INTEGER", nullable: false),
                    Reprint = table.Column<bool>(type: "INTEGER", nullable: false),
                    Variation = table.Column<bool>(type: "INTEGER", nullable: false),
                    Set = table.Column<string>(type: "TEXT", nullable: true),
                    Set_type = table.Column<string>(type: "TEXT", nullable: true),
                    Set_search_uri = table.Column<string>(type: "TEXT", nullable: true),
                    Scryfall_set_uri = table.Column<string>(type: "TEXT", nullable: true),
                    Rulings_uri = table.Column<string>(type: "TEXT", nullable: true),
                    Prints_search_uri = table.Column<string>(type: "TEXT", nullable: true),
                    Collector_number = table.Column<string>(type: "TEXT", nullable: true),
                    Digital = table.Column<bool>(type: "INTEGER", nullable: false),
                    Rarity = table.Column<string>(type: "TEXT", nullable: true),
                    Flavor_text = table.Column<string>(type: "TEXT", nullable: true),
                    Card_back_id = table.Column<string>(type: "TEXT", nullable: true),
                    Artist = table.Column<string>(type: "TEXT", nullable: true),
                    Illustration_id = table.Column<string>(type: "TEXT", nullable: true),
                    Border_color = table.Column<string>(type: "TEXT", nullable: true),
                    Frame = table.Column<string>(type: "TEXT", nullable: true),
                    Full_art = table.Column<bool>(type: "INTEGER", nullable: false),
                    Textless = table.Column<bool>(type: "INTEGER", nullable: false),
                    Booster = table.Column<bool>(type: "INTEGER", nullable: false),
                    Story_spotlight = table.Column<bool>(type: "INTEGER", nullable: false),
                    Edhrec_rank = table.Column<int>(type: "INTEGER", nullable: false),
                    PricesID = table.Column<int>(type: "INTEGER", nullable: true),
                    Related_urisID = table.Column<int>(type: "INTEGER", nullable: true),
                    Purchase_urisID = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Card", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Card_ImageUris_Image_urisID",
                        column: x => x.Image_urisID,
                        principalTable: "ImageUris",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Card_Legalities_LegalitiesID",
                        column: x => x.LegalitiesID,
                        principalTable: "Legalities",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Card_Prices_PricesID",
                        column: x => x.PricesID,
                        principalTable: "Prices",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Card_PurchaseUris_Purchase_urisID",
                        column: x => x.Purchase_urisID,
                        principalTable: "PurchaseUris",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Card_RelatedUris_Related_urisID",
                        column: x => x.Related_urisID,
                        principalTable: "RelatedUris",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Artist_ids",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Artist_id = table.Column<string>(type: "TEXT", nullable: true),
                    CardsID = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Artist_ids", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Artist_ids_Card_CardsID",
                        column: x => x.CardsID,
                        principalTable: "Card",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Color_identity",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Color = table.Column<string>(type: "TEXT", nullable: true),
                    CardID = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Color_identity", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Color_identity_Card_CardID",
                        column: x => x.CardID,
                        principalTable: "Card",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Colors",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Color = table.Column<string>(type: "TEXT", nullable: true),
                    CardID = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Colors", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Colors_Card_CardID",
                        column: x => x.CardID,
                        principalTable: "Card",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Games",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Game = table.Column<string>(type: "TEXT", nullable: true),
                    CardID = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Games", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Games_Card_CardID",
                        column: x => x.CardID,
                        principalTable: "Card",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Keywords",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Keyword = table.Column<string>(type: "TEXT", nullable: true),
                    CardID = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Keywords", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Keywords_Card_CardID",
                        column: x => x.CardID,
                        principalTable: "Card",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MultiverseIDS",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    MultiverseID = table.Column<int>(type: "INTEGER", nullable: false),
                    CardID = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MultiverseIDS", x => x.ID);
                    table.ForeignKey(
                        name: "FK_MultiverseIDS_Card_CardID",
                        column: x => x.CardID,
                        principalTable: "Card",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Produced_mana",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Mana = table.Column<string>(type: "TEXT", nullable: true),
                    CardID = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Produced_mana", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Produced_mana_Card_CardID",
                        column: x => x.CardID,
                        principalTable: "Card",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Artist_ids_CardsID",
                table: "Artist_ids",
                column: "CardsID");

            migrationBuilder.CreateIndex(
                name: "IX_Card_Image_urisID",
                table: "Card",
                column: "Image_urisID");

            migrationBuilder.CreateIndex(
                name: "IX_Card_LegalitiesID",
                table: "Card",
                column: "LegalitiesID");

            migrationBuilder.CreateIndex(
                name: "IX_Card_PricesID",
                table: "Card",
                column: "PricesID");

            migrationBuilder.CreateIndex(
                name: "IX_Card_Purchase_urisID",
                table: "Card",
                column: "Purchase_urisID");

            migrationBuilder.CreateIndex(
                name: "IX_Card_Related_urisID",
                table: "Card",
                column: "Related_urisID");

            migrationBuilder.CreateIndex(
                name: "IX_Color_identity_CardID",
                table: "Color_identity",
                column: "CardID");

            migrationBuilder.CreateIndex(
                name: "IX_Colors_CardID",
                table: "Colors",
                column: "CardID");

            migrationBuilder.CreateIndex(
                name: "IX_Games_CardID",
                table: "Games",
                column: "CardID");

            migrationBuilder.CreateIndex(
                name: "IX_Keywords_CardID",
                table: "Keywords",
                column: "CardID");

            migrationBuilder.CreateIndex(
                name: "IX_MultiverseIDS_CardID",
                table: "MultiverseIDS",
                column: "CardID");

            migrationBuilder.CreateIndex(
                name: "IX_Produced_mana_CardID",
                table: "Produced_mana",
                column: "CardID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Artist_ids");

            migrationBuilder.DropTable(
                name: "Color_identity");

            migrationBuilder.DropTable(
                name: "Colors");

            migrationBuilder.DropTable(
                name: "Games");

            migrationBuilder.DropTable(
                name: "Keywords");

            migrationBuilder.DropTable(
                name: "MultiverseIDS");

            migrationBuilder.DropTable(
                name: "Produced_mana");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "Card");

            migrationBuilder.DropTable(
                name: "ImageUris");

            migrationBuilder.DropTable(
                name: "Legalities");

            migrationBuilder.DropTable(
                name: "Prices");

            migrationBuilder.DropTable(
                name: "PurchaseUris");

            migrationBuilder.DropTable(
                name: "RelatedUris");
        }
    }
}
