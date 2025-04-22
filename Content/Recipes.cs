using Funrniture.Content.Items.Placeable.Furniture.AnimalHomes;
using Funrniture.Content.Items.Placeable.Furniture.AnimalSkins;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Funrniture.Content
{
    public class Recipes : ModSystem
    {
        public override void AddRecipes()
        {
            // De-crafting Animal skins
            _ = Recipe.Create(ItemID.LeopardSkin, 1)
                .AddIngredient(ModContent.ItemType<SmallLeopardSkinItem>(), 2)
                .DisableDecraft()
                .Register();

            // De-crafting Animal homes
            _ = Recipe.Create(ItemID.Bird, 1)
                .AddIngredient(ModContent.ItemType<BirdPerchItem>())
                .DisableDecraft()
                .Register();

            _ = Recipe.Create(ItemID.BlueJay, 1)
                .AddIngredient(ModContent.ItemType<BlueJayPerchItem>())
                .DisableDecraft()
                .Register();

            _ = Recipe.Create(ItemID.BlueMacaw, 1)
                .AddIngredient(ModContent.ItemType<BlueMacawPerchItem>())
                .DisableDecraft()
                .Register();

            _ = Recipe.Create(ItemID.Cardinal, 1)
                .AddIngredient(ModContent.ItemType<CardinalPerchItem>())
                .DisableDecraft()
                .Register();

            _ = Recipe.Create(ItemID.BabyBirdStaff, 1)
                .AddIngredient(ModContent.ItemType<FinchPerchItem>())
                .DisableDecraft()
                .Register();

            _ = Recipe.Create(ItemID.GoldBird, 1)
                .AddIngredient(ModContent.ItemType<GoldBirdPerchItem>())
                .DisableDecraft()
                .Register();

            _ = Recipe.Create(ItemID.GrayCockatiel, 1)
                .AddIngredient(ModContent.ItemType<GrayCockatielPerchItem>())
                .DisableDecraft()
                .Register();

            _ = Recipe.Create(ItemID.Owl, 1)
                .AddIngredient(ModContent.ItemType<OwlPerchItem>())
                .DisableDecraft()
                .Register();

            _ = Recipe.Create(ItemID.ParrotCracker, 1)
                .AddIngredient(ModContent.ItemType<ParrotPerchItem>())
                .DisableDecraft()
                .Register();

            _ = Recipe.Create(ItemID.ScarletMacaw, 1)
                .AddIngredient(ModContent.ItemType<ScarletMacawPerchItem>())
                .DisableDecraft()
                .Register();

            _ = Recipe.Create(ItemID.Toucan, 1)
                .AddIngredient(ModContent.ItemType<ToucanPerchItem>())
                .DisableDecraft()
                .Register();

            _ = Recipe.Create(ItemID.YellowCockatiel, 1)
                .AddIngredient(ModContent.ItemType<YellowCockatielPerchItem>())
                .DisableDecraft()
                .Register();

            _ = Recipe.Create(ItemID.RavenStaff, 1)
                .AddIngredient(ModContent.ItemType<RavenPerchItem>())
                .DisableDecraft()
                .Register();

            _ = Recipe.Create(ItemID.ReleaseDoves, 1)
                .AddIngredient(ModContent.ItemType<DovePerchItem>())
                .DisableDecraft()
                .Register();

            _ = Recipe.Create(ItemID.PigPetItem, 1)
                .AddIngredient(ModContent.ItemType<PigmanHouseItem>())
                .DisableDecraft()
                .Register();
        }
    }
}
