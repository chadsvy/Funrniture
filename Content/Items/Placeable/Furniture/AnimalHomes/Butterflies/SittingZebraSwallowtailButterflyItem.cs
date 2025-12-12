using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Funrniture.Content.Items.Placeable.Furniture.AnimalHomes.Butterflies
{
	public class SittingZebraSwallowtailButterflyItem : ModItem
	{
		public override void SetDefaults() {
			Item.DefaultToPlaceableTile(ModContent.TileType<Tiles.Furniture.AnimalHomes.Butterflies.SittingZebraSwallowtailButterfly>());
			Item.width = 26;
			Item.height = 24;
			Item.value = 1500;
		}

		public override void AddRecipes() {
			CreateRecipe()
                .AddIngredient(ItemID.ZebraSwallowtailButterfly)
				.AddTile(TileID.WorkBenches)
				.Register();
		}
	}
}
