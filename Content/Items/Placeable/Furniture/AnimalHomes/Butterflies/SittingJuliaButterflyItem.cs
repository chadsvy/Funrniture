using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Funrniture.Content.Items.Placeable.Furniture.AnimalHomes.Butterflies
{
	public class SittingJuliaButterflyItem : ModItem
	{
		public override void SetDefaults() {
			Item.DefaultToPlaceableTile(ModContent.TileType<Tiles.Furniture.AnimalHomes.Butterflies.SittingJuliaButterfly>());
			Item.width = 26;
			Item.height = 24;
			Item.value = 3000;
		}

		public override void AddRecipes() {
			CreateRecipe()
                .AddIngredient(ItemID.JuliaButterfly)
				.AddTile(TileID.WorkBenches)
				.Register();
		}
	}
}
