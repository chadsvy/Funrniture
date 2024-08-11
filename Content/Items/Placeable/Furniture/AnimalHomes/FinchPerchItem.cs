using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Funrniture.Content.Items.Placeable.Furniture.AnimalHomes
{
	public class FinchPerchItem : ModItem
	{
		public override void SetDefaults() {
			Item.DefaultToPlaceableTile(ModContent.TileType<Tiles.Furniture.AnimalHomes.FinchPerch>());
			Item.width = 24;
			Item.height = 16;
			Item.value = 1000;
		}

		public override void AddRecipes() {
			CreateRecipe()
                .AddIngredient(ItemID.BabyBirdStaff)
                .AddRecipeGroup(RecipeGroupID.Wood, 15)
				.AddTile(TileID.Sawmill)
				.Register();
		}
	}
}
