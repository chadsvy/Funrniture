using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Funrniture.Content.Items.Placeable.Furniture.AnimalHomes
{
	public class ScarletMacawPerchItem : ModItem
	{
		public override void SetDefaults() {
			Item.DefaultToPlaceableTile(ModContent.TileType<Tiles.Furniture.AnimalHomes.ScarletMacawPerch>());
			Item.width = 24;
			Item.height = 38;
			Item.value = 750;
		}

		public override void AddRecipes() {
			CreateRecipe()
                .AddIngredient(ItemID.ScarletMacaw)
                .AddRecipeGroup(RecipeGroupID.Wood, 15)
				.AddTile(TileID.Sawmill)
				.Register();
		}
	}
}
