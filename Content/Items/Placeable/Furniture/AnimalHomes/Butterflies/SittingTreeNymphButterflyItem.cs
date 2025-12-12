using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Funrniture.Content.Items.Placeable.Furniture.AnimalHomes.Butterflies
{
	public class SittingTreeNymphButterflyItem : ModItem
	{
		public override void SetDefaults() {
			Item.DefaultToPlaceableTile(ModContent.TileType<Tiles.Furniture.AnimalHomes.Butterflies.SittingTreeNymphButterfly>());
			Item.width = 26;
			Item.height = 24;
			Item.value = 10000;
		}

		public override void AddRecipes() {
			CreateRecipe()
                .AddIngredient(ItemID.TreeNymphButterfly)
				.AddTile(TileID.WorkBenches)
				.Register();
		}
	}
}
