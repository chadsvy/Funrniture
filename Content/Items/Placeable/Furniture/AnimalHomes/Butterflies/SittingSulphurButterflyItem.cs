using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Funrniture.Content.Items.Placeable.Furniture.AnimalHomes.Butterflies
{
	public class SittingSulphurButterflyItem : ModItem
	{
		public override void SetDefaults() {
			Item.DefaultToPlaceableTile(ModContent.TileType<Tiles.Furniture.AnimalHomes.Butterflies.SittingSulphurButterfly>());
			Item.width = 26;
			Item.height = 24;
			Item.value = 1000;
		}

		public override void AddRecipes() {
			CreateRecipe()
                .AddIngredient(ItemID.SulphurButterfly)
				.AddTile(TileID.WorkBenches)
				.Register();
		}
	}
}
