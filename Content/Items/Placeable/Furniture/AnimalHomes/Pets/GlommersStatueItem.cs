using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Funrniture.Content.Items.Placeable.Furniture.AnimalHomes.Pets
{
	public class GlommersStatueItem : ModItem
	{
		public override void SetDefaults() {
			Item.DefaultToPlaceableTile(ModContent.TileType<Tiles.Furniture.AnimalHomes.Pets.GlommersStatue>());
			Item.width = 56;
			Item.height = 44;
			Item.value = 50000;
		}

		public override void AddRecipes() {
			CreateRecipe()
				.AddIngredient(ItemID.GlommerPetItem)
				.AddIngredient(ItemID.Granite, 15)
				.AddTile(TileID.HeavyWorkBench)
				.Register();
		}
	}
}
