using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Funrniture.Content.Items.Placeable.Furniture.AnimalHomes.Butterflies
{
	public class SittingRedAdmiralButterflyItem : ModItem
	{
		public override void SetDefaults() {
			Item.DefaultToPlaceableTile(ModContent.TileType<Tiles.Furniture.AnimalHomes.Butterflies.SittingRedAdmiralButterfly>());
			Item.width = 26;
			Item.height = 24;
			Item.value = 4000;
		}

		public override void AddRecipes() {
			CreateRecipe()
                .AddIngredient(ItemID.RedAdmiralButterfly)
				.AddTile(TileID.WorkBenches)
				.Register();
		}
	}
}
