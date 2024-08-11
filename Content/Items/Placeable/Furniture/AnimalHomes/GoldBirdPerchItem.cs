using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Funrniture.Content.Items.Placeable.Furniture.AnimalHomes
{
	public class GoldBirdPerchItem : ModItem
	{
		public override void SetDefaults() {
			Item.DefaultToPlaceableTile(ModContent.TileType<Tiles.Furniture.AnimalHomes.GoldBirdPerch>());
			Item.width = 24;
			Item.height = 18;
			Item.value = 10000;
		}

		public override void AddRecipes() {
			CreateRecipe()
                .AddIngredient(ItemID.GoldBird)
                .AddRecipeGroup(RecipeGroupID.Wood, 15)
				.AddTile(TileID.Sawmill)
				.Register();
		}
	}
}
