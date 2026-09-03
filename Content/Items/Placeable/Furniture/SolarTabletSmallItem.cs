using System;
using Terraria;
using Terraria.Audio;
using Terraria.GameInput;
using Terraria.ID;
using Terraria.ModLoader;

namespace Funrniture.Content.Items.Placeable.Furniture
{
    public class SolarTabletSmallItem : ModItem
    {
        private const int StyleAmount = 4;

        public override void SetDefaults()
        {
            Item.DefaultToPlaceableTile(ModContent.TileType<Tiles.Furniture.SolarTabletSmall>());
            Item.width = 36;
            Item.height = 32;
            Item.value = 0;
        }

        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient(ItemID.LunarTabletFragment, 4)
                .AddTile(TileID.MythrilAnvil)
                .Register();
        }

        // Duplicate of SolarTabletItem.HoldItem
        public override void HoldItem(Player player)
        {
            if (player.whoAmI != Main.myPlayer)
                return;

            if (player.direction < 0 && Item.placeStyle % 2 == 1)
            {
                Item.placeStyle = Math.Max(Item.placeStyle - 1, 0);
            }
            else if (player.direction > 0 && Item.placeStyle % 2 == 0)
            {
                Item.placeStyle = Math.Min(Item.placeStyle + 1, 3);
            }

            if (PlayerInput.Triggers.JustPressed.Up)
            {
                Item.placeStyle = (Item.placeStyle + 2) % StyleAmount;

                SoundEngine.PlaySound(SoundID.MenuTick);
            }
            else if (PlayerInput.Triggers.JustPressed.Down)
            {
                Item.placeStyle -= 2;

                if (Item.placeStyle < 0)
                    Item.placeStyle = Item.placeStyle % 2 == 0 ? StyleAmount - 2 : StyleAmount - 1;

                SoundEngine.PlaySound(SoundID.MenuTick);
            }
        }
    }
}
