using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Funrniture.Content.Items.Placeable.Furniture.AnimalHomes.Butterflies
{
	public class SittingUlyssesButterflyItem : ModItem
	{
		public override void SetDefaults() {
			Item.DefaultToPlaceableTile(ModContent.TileType<Tiles.Furniture.AnimalHomes.Butterflies.SittingUlyssesButterfly>());
			Item.width = 26;
			Item.height = 24;
			Item.value = 2000;
		}

		public override void AddRecipes() {
			CreateRecipe()
                .AddIngredient(ItemID.UlyssesButterfly)
				.AddTile(TileID.WorkBenches)
				.Register();
		}
	}
}
