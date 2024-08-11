using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Funrniture.Content.Items.Placeable.Furniture.AnimalHomes
{
	public class CardinalPerchItem : ModItem
	{
		public override void SetDefaults() {
			Item.DefaultToPlaceableTile(ModContent.TileType<Tiles.Furniture.AnimalHomes.CardinalPerch>());
			Item.width = 24;
			Item.height = 18;
			Item.value = 500;
		}

		public override void AddRecipes() {
			CreateRecipe()
                .AddIngredient(ItemID.Cardinal)
                .AddRecipeGroup(RecipeGroupID.Wood, 15)
				.AddTile(TileID.Sawmill)
				.Register();
		}
	}
}