using Terraria;
using Terraria.Audio;
using Terraria.GameInput;
using Terraria.ID;
using Terraria.ModLoader;

namespace Funrniture.Content.Items.Placeable.Furniture
{
    public class SolarTabletItem : ModItem
    {
        private const int StyleAmount = 3;

        public override void SetDefaults()
        {
            Item.DefaultToPlaceableTile(ModContent.TileType<Tiles.Furniture.SolarTablet>());
            Item.width = 42;
            Item.height = 36;
            Item.value = 0;
        }

        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient(ItemID.LunarTabletFragment, 8) // I know it says "lunar" tablet, but I promise that this is for some reason the right constant.
                .AddTile(TileID.MythrilAnvil)
                .Register();

            CreateRecipe()
                .AddIngredient(ModContent.ItemType<SolarTabletSmallItem>(), 2)
                .AddTile(TileID.MythrilAnvil)
                .Register();
        }

        public override void HoldItem(Player player)
        {
            if (player.whoAmI != Main.myPlayer)
                return;

            if (PlayerInput.Triggers.JustPressed.Up)
            {
                Item.placeStyle++;

                if (Item.placeStyle >= StyleAmount)
                    Item.placeStyle = 0;

                SoundEngine.PlaySound(SoundID.MenuTick);
            }
            else if (PlayerInput.Triggers.JustPressed.Down)
            {
                Item.placeStyle--;

                if (Item.placeStyle < 0)
                    Item.placeStyle = StyleAmount - 1;

                SoundEngine.PlaySound(SoundID.MenuTick);
            }
        }
    }
}
