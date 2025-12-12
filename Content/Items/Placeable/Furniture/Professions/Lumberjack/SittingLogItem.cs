using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Funrniture.Content.Items.Placeable.Furniture.Professions.Lumberjack
{
	public class SittingLogItem : ModItem
	{
		public override void SetDefaults() {
			Item.DefaultToPlaceableTile(ModContent.TileType<Tiles.Furniture.Professions.Lumberjack.SittingLog>());
			Item.width = 32;
			Item.height = 18;
			Item.value = 50;
		}

		public override void AddRecipes() {
			CreateRecipe()
                .AddRecipeGroup(RecipeGroupID.Wood, 6)
				.AddTile(TileID.Sawmill)
				.Register();
		}
	}
}
