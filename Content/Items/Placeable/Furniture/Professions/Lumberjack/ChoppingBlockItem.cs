using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Funrniture.Content.Items.Placeable.Furniture.Professions.Lumberjack
{
	public class ChoppingBlockItem : ModItem
	{
		public override void SetDefaults() {
			Item.DefaultToPlaceableTile(ModContent.TileType<Tiles.Furniture.Professions.Lumberjack.ChoppingBlock>());
			Item.width = 32;
			Item.height = 30;
			Item.value = 150;
		}

		public override void AddRecipes() {
			CreateRecipe()
                .AddIngredient(ItemID.CopperAxe)
                .AddRecipeGroup(RecipeGroupID.Wood, 6)
				.AddTile(TileID.Sawmill)
				.Register();

			CreateRecipe()
                .AddIngredient(ItemID.TinAxe)
                .AddRecipeGroup(RecipeGroupID.Wood, 6)
                .AddTile(TileID.Sawmill)
                .Register();
		}
	}
}
