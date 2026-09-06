using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.Enums;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ObjectData;

namespace Funrniture.Content.Tiles.Furniture
{
    public class SandcastleBucket : ModTile
    {
        public override string Texture => "Funrniture/Content/Tiles/Furniture/Beach/SandcastleBucket";

        public override void SetStaticDefaults()
        {
            Main.tileFrameImportant[Type] = true;
            Main.tileNoAttach[Type] = true;

            TileObjectData.newTile.CopyFrom(TileObjectData.Style2x1);
            TileObjectData.newTile.CoordinateHeights = [
                22
            ];
            TileObjectData.newTile.DrawYOffset = -4;
            TileObjectData.newTile.AnchorBottom = new AnchorData(AnchorType.SolidTile | AnchorType.SolidWithTop | AnchorType.Table, TileObjectData.newTile.Width, 0);
            TileObjectData.newTile.LavaDeath = false;
            TileObjectData.newTile.StyleHorizontal = false;

            TileObjectData.newAlternate.CopyFrom(TileObjectData.newTile);
            TileObjectData.addAlternate(1);
            RegisterItemDrop(ModContent.ItemType<Items.Placeable.Furniture.SandcastleBucketItem>(), 1);

            TileObjectData.newAlternate.CopyFrom(TileObjectData.newTile);
            TileObjectData.addAlternate(2);
            RegisterItemDrop(ModContent.ItemType<Items.Placeable.Furniture.SandcastleBucketItem>(), 2);

            TileObjectData.addTile(Type);

            AddMapEntry(new Color(211, 71, 146));

            DustType = DustID.Ice_Pink;
        }

        public override void SetDrawPositions(int i, int j, ref int width, ref int offsetY, ref int height, ref short tileFrameX, ref short tileFrameY)
        {
            height = 22;
            offsetY = -4;
        }
    }
}