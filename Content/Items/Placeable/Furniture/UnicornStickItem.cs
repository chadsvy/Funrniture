using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Funrniture.Content.Items.Placeable.Furniture
{
    public class UnicornStickItem : ModItem
    {
        private const int StyleAmount = 4;

        public override void SetDefaults()
        {
            Item.DefaultToPlaceableTile(ModContent.TileType<Tiles.Furniture.UnicornStick>());
            Item.width = 34;
            Item.height = 50;
            Item.value = 100;
        }

        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient(ItemID.UnicornonaStick)
                .AddTile(TileID.WorkBenches)
                .Register();
        }
    }
}
