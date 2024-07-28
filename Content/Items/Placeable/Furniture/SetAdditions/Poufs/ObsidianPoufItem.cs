using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Funrniture.Content.Items.Placeable.Furniture.SetAdditions.Poufs
{
	public class ObsidianPoufItem : ModItem
	{
		public override void SetDefaults() {
			Item.DefaultToPlaceableTile(ModContent.TileType<Tiles.Furniture.SetAdditions.Pouf>());
			Item.placeStyle = 10;
			Item.width = 16;
			Item.height = 18;
			Item.value = 60;
		}

		public override void AddRecipes() {
			CreateRecipe()
				.AddIngredient(ItemID.Obsidian, 2)
				.AddIngredient(ItemID.Hellstone, 1)
				.AddIngredient(ItemID.Silk, 1)
				.AddTile(TileID.Sawmill)
				.Register();
		}
	}
}
