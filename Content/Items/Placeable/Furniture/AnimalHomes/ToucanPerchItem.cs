using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Funrniture.Content.Items.Placeable.Furniture.AnimalHomes
{
	public class ToucanPerchItem : ModItem
	{
		public override void SetDefaults() {
			Item.DefaultToPlaceableTile(ModContent.TileType<Tiles.Furniture.AnimalHomes.ToucanPerch>());
			Item.width = 32;
			Item.height = 18;
			Item.value = 750;
		}

		public override void AddRecipes() {
			CreateRecipe()
                .AddIngredient(ItemID.Toucan)
                .AddRecipeGroup(RecipeGroupID.Wood, 15)
				.AddTile(TileID.Sawmill)
				.Register();
		}
	}
}
