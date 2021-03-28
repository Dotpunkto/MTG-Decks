using Microsoft.EntityFrameworkCore.Migrations;

namespace MTG_Decks.Server.Migrations
{
    public partial class Migration2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MultiverseIDS_Card_CardID",
                table: "MultiverseIDS");

            migrationBuilder.DropTable(
                name: "Artist_ids");

            migrationBuilder.DropTable(
                name: "Color_identity");

            migrationBuilder.DropTable(
                name: "Produced_mana");

            migrationBuilder.DropIndex(
                name: "IX_MultiverseIDS_CardID",
                table: "MultiverseIDS");

            migrationBuilder.DropColumn(
                name: "CardID",
                table: "MultiverseIDS");

            migrationBuilder.RenameColumn(
                name: "MultiverseID",
                table: "MultiverseIDS",
                newName: "Multiverse_ids");

            migrationBuilder.AddColumn<int>(
                name: "CardsID",
                table: "MultiverseIDS",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CardID",
                table: "Keywords",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CardID",
                table: "Games",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CardID",
                table: "Colors",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ID",
                table: "Card",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "TEXT")
                .Annotation("Sqlite:Autoincrement", true);

            migrationBuilder.CreateTable(
                name: "ArtistIDS",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Artist_id = table.Column<string>(type: "TEXT", nullable: true),
                    CardsID = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArtistIDS", x => x.ID);
                    table.ForeignKey(
                        name: "FK_ArtistIDS_Card_CardsID",
                        column: x => x.CardsID,
                        principalTable: "Card",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ColorIdentity",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Color = table.Column<string>(type: "TEXT", nullable: true),
                    CardID = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ColorIdentity", x => x.ID);
                    table.ForeignKey(
                        name: "FK_ColorIdentity_Card_CardID",
                        column: x => x.CardID,
                        principalTable: "Card",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ProducedMana",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Mana = table.Column<string>(type: "TEXT", nullable: true),
                    CardID = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProducedMana", x => x.ID);
                    table.ForeignKey(
                        name: "FK_ProducedMana_Card_CardID",
                        column: x => x.CardID,
                        principalTable: "Card",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_MultiverseIDS_CardsID",
                table: "MultiverseIDS",
                column: "CardsID");

            migrationBuilder.CreateIndex(
                name: "IX_ArtistIDS_CardsID",
                table: "ArtistIDS",
                column: "CardsID");

            migrationBuilder.CreateIndex(
                name: "IX_ColorIdentity_CardID",
                table: "ColorIdentity",
                column: "CardID");

            migrationBuilder.CreateIndex(
                name: "IX_ProducedMana_CardID",
                table: "ProducedMana",
                column: "CardID");

            migrationBuilder.AddForeignKey(
                name: "FK_MultiverseIDS_Card_CardsID",
                table: "MultiverseIDS",
                column: "CardsID",
                principalTable: "Card",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MultiverseIDS_Card_CardsID",
                table: "MultiverseIDS");

            migrationBuilder.DropTable(
                name: "ArtistIDS");

            migrationBuilder.DropTable(
                name: "ColorIdentity");

            migrationBuilder.DropTable(
                name: "ProducedMana");

            migrationBuilder.DropIndex(
                name: "IX_MultiverseIDS_CardsID",
                table: "MultiverseIDS");

            migrationBuilder.DropColumn(
                name: "CardsID",
                table: "MultiverseIDS");

            migrationBuilder.RenameColumn(
                name: "Multiverse_ids",
                table: "MultiverseIDS",
                newName: "MultiverseID");

            migrationBuilder.AddColumn<string>(
                name: "CardID",
                table: "MultiverseIDS",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CardID",
                table: "Keywords",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CardID",
                table: "Games",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CardID",
                table: "Colors",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ID",
                table: "Card",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER")
                .OldAnnotation("Sqlite:Autoincrement", true);

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
                    CardID = table.Column<string>(type: "TEXT", nullable: true),
                    Color = table.Column<string>(type: "TEXT", nullable: true)
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
                name: "Produced_mana",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CardID = table.Column<string>(type: "TEXT", nullable: true),
                    Mana = table.Column<string>(type: "TEXT", nullable: true)
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
                name: "IX_MultiverseIDS_CardID",
                table: "MultiverseIDS",
                column: "CardID");

            migrationBuilder.CreateIndex(
                name: "IX_Artist_ids_CardsID",
                table: "Artist_ids",
                column: "CardsID");

            migrationBuilder.CreateIndex(
                name: "IX_Color_identity_CardID",
                table: "Color_identity",
                column: "CardID");

            migrationBuilder.CreateIndex(
                name: "IX_Produced_mana_CardID",
                table: "Produced_mana",
                column: "CardID");

            migrationBuilder.AddForeignKey(
                name: "FK_MultiverseIDS_Card_CardID",
                table: "MultiverseIDS",
                column: "CardID",
                principalTable: "Card",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
