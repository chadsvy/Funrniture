using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Funrniture.Content.Items.Placeable.Furniture.AnimalHomes
{
	public class ParrotPerchItem : ModItem
	{
		public override void SetDefaults() {
			Item.DefaultToPlaceableTile(ModContent.TileType<Tiles.Furniture.AnimalHomes.ParrotPerch>());
			Item.width = 26;
			Item.height = 32;
			Item.value = 750;
		}

		public override void AddRecipes() {
			CreateRecipe()
                .AddIngredient(ItemID.ParrotCracker)
                .AddRecipeGroup(RecipeGroupID.Wood, 15)
				.AddTile(TileID.Sawmill)
				.Register();
		}
	}
}
