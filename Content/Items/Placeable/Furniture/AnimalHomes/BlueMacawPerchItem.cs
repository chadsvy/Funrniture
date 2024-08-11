using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Funrniture.Content.Items.Placeable.Furniture.AnimalHomes
{
	public class BlueMacawPerchItem : ModItem
	{
		public override void SetDefaults() {
			Item.DefaultToPlaceableTile(ModContent.TileType<Tiles.Furniture.AnimalHomes.BlueMacawPerch>());
			Item.width = 24;
			Item.height = 36;
			Item.value = 750;
		}

		public override void AddRecipes() {
			CreateRecipe()
                .AddIngredient(ItemID.BlueMacaw)
                .AddRecipeGroup(RecipeGroupID.Wood, 15)
				.AddTile(TileID.Sawmill)
				.Register();
		}
	}
}
