using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Funrniture.Content.Items.Placeable.Furniture.AnimalHomes.Butterflies
{
	public class SittingGoldButterflyItem : ModItem
	{
		public override void SetDefaults() {
			Item.DefaultToPlaceableTile(ModContent.TileType<Tiles.Furniture.AnimalHomes.Butterflies.SittingGoldButterfly>());
			Item.width = 26;
			Item.height = 24;
			Item.value = 100000;
		}

		public override void AddRecipes() {
			CreateRecipe()
                .AddIngredient(ItemID.GoldButterfly)
				.AddTile(TileID.WorkBenches)
				.Register();
		}
	}
}
