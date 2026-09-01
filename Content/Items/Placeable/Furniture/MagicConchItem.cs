using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Funrniture.Content.Items.Placeable.Furniture
{
	public class MagicConchItem : ModItem
	{
        public override void SetDefaults() {
			Item.DefaultToPlaceableTile(ModContent.TileType<Tiles.Furniture.MagicConch>());
			Item.width = 32;
			Item.height = 26;
			Item.value = 10000;
		}

		public override void AddRecipes() {
			CreateRecipe()
                .AddIngredient(ItemID.MagicConch)
                .AddTile(TileID.WorkBenches)
                .Register();
		}
	}
}
