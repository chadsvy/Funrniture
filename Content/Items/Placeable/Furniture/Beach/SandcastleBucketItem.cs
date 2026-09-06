using Terraria;
using Terraria.Audio;
using Terraria.GameInput;
using Terraria.ID;
using Terraria.ModLoader;

namespace Funrniture.Content.Items.Placeable.Furniture
{
    public class SandcastleBucketItem : ModItem
    {
        private const int StyleAmount = 3;

        public override string Texture => "Funrniture/Content/Items/Placeable/Furniture/Beach/SandcastleBucketItem";

        public override void SetDefaults()
        {
            Item.DefaultToPlaceableTile(ModContent.TileType<Tiles.Furniture.SandcastleBucket>());
            Item.width = 26;
            Item.height = 22;
            Item.value = 10000;
        }

        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient(ItemID.SandcastleBucket)
                .AddTile(TileID.WorkBenches)
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
