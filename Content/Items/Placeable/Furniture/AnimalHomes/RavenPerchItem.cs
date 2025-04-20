using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Funrniture.Content.Items.Placeable.Furniture.AnimalHomes
{
	public class RavenPerchItem : ModItem
	{
		public override void SetDefaults() {
			Item.DefaultToPlaceableTile(ModContent.TileType<Tiles.Furniture.AnimalHomes.RavenPerch>());
			Item.width = 26;
			Item.height = 24;
			Item.value = 100000;
		}

		public override void AddRecipes() {
			CreateRecipe()
                .AddIngredient(ItemID.RavenStaff)
                .AddRecipeGroup(RecipeGroupID.Wood, 15)
				.AddTile(TileID.Sawmill)
				.Register();
		}
	}
}
