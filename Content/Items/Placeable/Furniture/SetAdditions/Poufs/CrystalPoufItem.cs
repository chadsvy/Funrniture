using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Funrniture.Content.Items.Placeable.Furniture.SetAdditions.Poufs
{
	public class CrystalPoufItem : ModItem
	{
		public override void SetDefaults() {
			Item.DefaultToPlaceableTile(ModContent.TileType<Tiles.Furniture.SetAdditions.Pouf>());
			Item.placeStyle = 31;
			Item.width = 16;
			Item.height = 18;
			Item.value = 60;
		}

		public override void AddRecipes() {
			CreateRecipe()
				.AddIngredient(ItemID.CrystalBlock, 7)
				.AddIngredient(ItemID.Silk, 1)
				.AddTile(TileID.Sawmill)
				.Register();
		}
	}
}
