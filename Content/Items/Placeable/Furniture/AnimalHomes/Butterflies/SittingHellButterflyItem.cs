using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Funrniture.Content.Items.Placeable.Furniture.AnimalHomes.Butterflies
{
	public class SittingHellButterflyItem : ModItem
	{
		public override void SetDefaults() {
			Item.DefaultToPlaceableTile(ModContent.TileType<Tiles.Furniture.AnimalHomes.Butterflies.SittingHellButterfly>());
			Item.width = 26;
			Item.height = 24;
			Item.value = 2000;
		}

		public override void AddRecipes() {
			CreateRecipe()
                .AddIngredient(ItemID.HellButterfly)
				.AddTile(TileID.WorkBenches)
				.Register();
		}
	}
}
