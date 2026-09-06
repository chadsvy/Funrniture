using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Funrniture.Content.Items.Placeable.Furniture.Beach
{
    public class BeachBallItem : ModItem
    {
        public override void SetDefaults()
        {
            Item.DefaultToPlaceableTile(ModContent.TileType<Tiles.Furniture.Beach.BeachBall>());
            Item.width = 32;
            Item.height = 32;
            Item.value = 4;
        }

        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient(ItemID.BeachBall)
                .AddTile(TileID.WorkBenches)
                .Register();
        }
    }
}
