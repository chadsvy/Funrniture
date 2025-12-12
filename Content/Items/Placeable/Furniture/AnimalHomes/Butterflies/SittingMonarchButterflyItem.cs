using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Funrniture.Content.Items.Placeable.Furniture.AnimalHomes.Butterflies
{
	public class SittingMonarchButterflyItem : ModItem
	{
		public override void SetDefaults() {
			Item.DefaultToPlaceableTile(ModContent.TileType<Tiles.Furniture.AnimalHomes.Butterflies.SittingMonarchButterfly>());
			Item.width = 26;
			Item.height = 24;
			Item.value = 500;
		}

		public override void AddRecipes() {
			CreateRecipe()
                .AddIngredient(ItemID.MonarchButterfly)
				.AddTile(TileID.WorkBenches)
				.Register();
		}
	}
}
