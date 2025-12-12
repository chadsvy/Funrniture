using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Funrniture.Content.Items.Placeable.Furniture.AnimalHomes.Butterflies
{
	public class SittingPurpleEmperorButterflyItem : ModItem
	{
		public override void SetDefaults() {
			Item.DefaultToPlaceableTile(ModContent.TileType<Tiles.Furniture.AnimalHomes.Butterflies.SittingPurpleEmperorButterfly>());
			Item.width = 26;
			Item.height = 24;
			Item.value = 7500;
		}

		public override void AddRecipes() {
			CreateRecipe()
                .AddIngredient(ItemID.PurpleEmperorButterfly)
				.AddTile(TileID.WorkBenches)
				.Register();
		}
	}
}
