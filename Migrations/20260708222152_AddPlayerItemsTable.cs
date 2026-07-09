using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Arcade_Game.Migrations
{
    /// <inheritdoc />
    public partial class AddPlayerItemsTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsEquipped",
                table: "ShopItems");

            migrationBuilder.DropColumn(
                name: "IsPurchased",
                table: "ShopItems");

            migrationBuilder.DropColumn(
                name: "ExtraLives",
                table: "PlayerProfiles");

            migrationBuilder.CreateTable(
                name: "PlayerItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    PlayerProfileId = table.Column<int>(type: "INTEGER", nullable: false),
                    ShopItemId = table.Column<int>(type: "INTEGER", nullable: false),
                    IsEquipped = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlayerItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PlayerItems_PlayerProfiles_PlayerProfileId",
                        column: x => x.PlayerProfileId,
                        principalTable: "PlayerProfiles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PlayerItems_ShopItems_ShopItemId",
                        column: x => x.ShopItemId,
                        principalTable: "ShopItems",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "ShopItems",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Category", "Name", "Price" },
                values: new object[] { "Theme", "Neon Background", 400 });

            migrationBuilder.UpdateData(
                table: "ShopItems",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Category", "Name", "Price" },
                values: new object[] { "Skin", "Spaceship 2", 500 });

            migrationBuilder.CreateIndex(
                name: "IX_PlayerItems_PlayerProfileId",
                table: "PlayerItems",
                column: "PlayerProfileId");

            migrationBuilder.CreateIndex(
                name: "IX_PlayerItems_ShopItemId",
                table: "PlayerItems",
                column: "ShopItemId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PlayerItems");

            migrationBuilder.AddColumn<bool>(
                name: "IsEquipped",
                table: "ShopItems",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsPurchased",
                table: "ShopItems",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "ExtraLives",
                table: "PlayerProfiles",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "ShopItems",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Category", "IsEquipped", "IsPurchased", "Name", "Price" },
                values: new object[] { "Skin", false, false, "Spaceship 2", 500 });

            migrationBuilder.UpdateData(
                table: "ShopItems",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "IsEquipped", "IsPurchased" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "ShopItems",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Category", "IsEquipped", "IsPurchased", "Name", "Price" },
                values: new object[] { "Theme", false, false, "Neon Background", 400 });

            migrationBuilder.UpdateData(
                table: "ShopItems",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "IsEquipped", "IsPurchased" },
                values: new object[] { false, false });
        }
    }
}
