using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Funrniture.Content.Items.Placeable.Furniture.SetAdditions.Poufs
{
	public class StoolItem : ModItem
	{
		public override void SetDefaults() {
			Item.DefaultToPlaceableTile(ModContent.TileType<Tiles.Furniture.SetAdditions.Pouf>());
			Item.placeStyle = 0;
			Item.width = 16;
			Item.height = 18;
			Item.value = 60;
		}

		public override void AddRecipes() {
			CreateRecipe()
				.AddRecipeGroup(RecipeGroupID.Wood, 4)
				.AddTile(TileID.Sawmill)
				.Register();
		}
	}
}
