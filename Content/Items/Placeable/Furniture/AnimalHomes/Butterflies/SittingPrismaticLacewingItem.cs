using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Funrniture.Content.Items.Placeable.Furniture.AnimalHomes.Butterflies
{
	public class SittingPrismaticLacewingItem : ModItem
	{
		public override void SetDefaults() {
			Item.DefaultToPlaceableTile(ModContent.TileType<Tiles.Furniture.AnimalHomes.Butterflies.SittingPrismaticLacewing>());
			Item.width = 26;
			Item.height = 24;
			Item.value = 50000;
		}

		public override void AddRecipes() {
			CreateRecipe()
                .AddIngredient(ItemID.EmpressButterfly)
				.AddTile(TileID.WorkBenches)
				.Register();
		}
	}
}
