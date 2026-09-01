using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Funrniture.Content.Items.Placeable.Furniture
{
	public class BucketItem : ModItem
	{
        public override void SetDefaults() {
			Item.DefaultToPlaceableTile(ModContent.TileType<Tiles.Furniture.Bucket>());
			Item.width = 16;
			Item.height = 16;
			Item.value = 900; // 2 Lead Bars
			Item.UseSound = Tiles.Furniture.Bucket.ClangSound;
		}

		public override void AddRecipes() {
			CreateRecipe()
				.AddRecipeGroup(RecipeGroupID.IronBar, 2)
                .AddTile(TileID.Anvils)
                .Register();
		}
	}
}
