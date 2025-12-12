using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Funrniture.Content.Items.Placeable.Furniture.Mounts
{
	public class GolfCartItem : ModItem
	{
		public override void SetDefaults() {
			Item.DefaultToPlaceableTile(ModContent.TileType<Tiles.Furniture.Mounts.GolfCart>());
			Item.width = 36;
			Item.height = 28;
			Item.value = 500000;
		}

		public override void AddRecipes() {
			CreateRecipe()
                .AddIngredient(ItemID.GolfCart)
				.Register();
		}
	}
}
