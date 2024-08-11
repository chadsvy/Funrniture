using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Funrniture.Content.Items.Placeable.Furniture.AnimalSkins
{
	public class SmallLeopardSkinItem : ModItem
	{
		public override void SetDefaults() {
			Item.DefaultToPlaceableTile(ModContent.TileType<Tiles.Furniture.AnimalSkins.SmallLeopardSkin>());
			Item.width = 28;
			Item.height = 22;
			Item.value = 5000;
		}

		public override void AddRecipes() {
			CreateRecipe(2)
				.AddIngredient(ItemID.LeopardSkin, 1)
				.AddTile(TileID.WorkBenches)
				.Register();
		}
	}
}
