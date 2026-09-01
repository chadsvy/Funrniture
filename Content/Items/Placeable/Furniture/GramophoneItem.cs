using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Funrniture.Content.Items.Placeable.Furniture
{
	public class GramophoneItem : ModItem
	{
        public override void SetDefaults() {
			Item.DefaultToPlaceableTile(ModContent.TileType<Tiles.Furniture.Gramophone>());
			Item.width = 28;
			Item.height = 34;
			Item.value = 10000;
		}

		public override void AddRecipes() {
			CreateRecipe()
                .AddRecipeGroup(Recipes.RecipeGroupCopperBar, 3)
                .AddRecipeGroup(RecipeGroupID.Wood, 6)
				.AddTile(TileID.Anvils)
				.Register();
		}
	}
}
