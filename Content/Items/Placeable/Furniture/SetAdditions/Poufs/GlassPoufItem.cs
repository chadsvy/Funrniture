using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Funrniture.Content.Items.Placeable.Furniture.SetAdditions.Poufs
{
	public class GlassPoufItem : ModItem
	{
		public override void SetDefaults() {
			Item.DefaultToPlaceableTile(ModContent.TileType<Tiles.Furniture.SetAdditions.Pouf>());
			Item.placeStyle = 18;
			Item.width = 16;
			Item.height = 18;
			Item.value = 60;
		}

		public override void AddRecipes() {
			CreateRecipe()
				.AddIngredient(ItemID.Glass, 3)
				.AddIngredient(ItemID.Silk, 1)
				.AddTile(TileID.GlassKiln)
				.Register();
		}
	}
}
