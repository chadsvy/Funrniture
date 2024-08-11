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
                .Register();

            // De-crafting Animal homes
            _ = Recipe.Create(ItemID.Bird, 1)
                .AddIngredient(ModContent.ItemType<BirdPerchItem>())
                .Register();

            _ = Recipe.Create(ItemID.BlueJay, 1)
                .AddIngredient(ModContent.ItemType<BlueJayPerchItem>())
                .Register();

            _ = Recipe.Create(ItemID.BlueMacaw, 1)
                .AddIngredient(ModContent.ItemType<BlueMacawPerchItem>())
                .Register();

            _ = Recipe.Create(ItemID.Cardinal, 1)
                .AddIngredient(ModContent.ItemType<CardinalPerchItem>())
                .Register();

            _ = Recipe.Create(ItemID.BabyBirdStaff, 1)
                .AddIngredient(ModContent.ItemType<FinchPerchItem>())
                .Register();

            _ = Recipe.Create(ItemID.GoldBird, 1)
                .AddIngredient(ModContent.ItemType<GoldBirdPerchItem>())
                .Register();

            _ = Recipe.Create(ItemID.GrayCockatiel, 1)
                .AddIngredient(ModContent.ItemType<GrayCockatielPerchItem>())
                .Register();

            _ = Recipe.Create(ItemID.Owl, 1)
                .AddIngredient(ModContent.ItemType<OwlPerchItem>())
                .Register();

            _ = Recipe.Create(ItemID.ParrotCracker, 1)
                .AddIngredient(ModContent.ItemType<ParrotPerchItem>())
                .Register();

            _ = Recipe.Create(ItemID.ScarletMacaw, 1)
                .AddIngredient(ModContent.ItemType<ScarletMacawPerchItem>())
                .Register();

            _ = Recipe.Create(ItemID.Toucan, 1)
                .AddIngredient(ModContent.ItemType<ToucanPerchItem>())
                .Register();

            _ = Recipe.Create(ItemID.YellowCockatiel, 1)
                .AddIngredient(ModContent.ItemType<YellowCockatielPerchItem>())
                .Register();
        }
    }
}
