using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Funrniture.Content.Items.Placeable.Furniture.AnimalHomes
{
	public class DovePerchItem : ModItem
	{
		public override void SetDefaults() {
			Item.DefaultToPlaceableTile(ModContent.TileType<Tiles.Furniture.AnimalHomes.DovePerch>());
			Item.width = 28;
			Item.height = 20;
			Item.value = 20;
		}

		public override void AddRecipes() {
			CreateRecipe()
                .AddIngredient(ItemID.ReleaseDoves)
                .AddRecipeGroup(RecipeGroupID.Wood, 15)
				.AddTile(TileID.Sawmill)
				.Register();
		}
	}
}
