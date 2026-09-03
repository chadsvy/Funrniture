using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Funrniture.Content.Items.Placeable.Furniture
{
	public class ChumBucketItem : ModItem
	{
        public override void SetDefaults() {
			Item.DefaultToPlaceableTile(ModContent.TileType<Tiles.Furniture.ChumBucket>());
			Item.width = 16;
			Item.height = 20;
			Item.value = 500;
			Item.UseSound = SoundID.Item167; // Queen Slime Queenly Smash
		}

		public override void AddRecipes() {
			CreateRecipe()
				.AddIngredient(ItemID.ChumBucket)
                .AddTile(TileID.WorkBenches)
                .Register();
		}
	}
}
