using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.Enums;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ObjectData;

namespace Funrniture.Content.Tiles.Furniture
{
    public class Bucket : ModTile
    {
        // TODO probably move this to a more general class or something
        public static Terraria.Audio.SoundStyle ClangSound = new Terraria.Audio.SoundStyle("Terraria/Sounds/Item_145") // DrumCymbal2
        {
            MaxInstances = 1,
            PitchRange = (-1f, -.5f),
            Volume = .35f
        };

        public override void SetStaticDefaults()
        {
            Main.tileFrameImportant[Type] = true;
            Main.tileNoAttach[Type] = true;

            TileObjectData.newTile.CopyFrom(TileObjectData.Style1x1);
            TileObjectData.newTile.CoordinateHeights = [
                18
            ];
            TileObjectData.newTile.AnchorBottom = new AnchorData(AnchorType.SolidTile | AnchorType.SolidWithTop | AnchorType.Table, TileObjectData.newTile.Width, 0);
            TileObjectData.newTile.LavaDeath = false;
            TileObjectData.newTile.StyleHorizontal = true;

            TileObjectData.newAlternate.CopyFrom(TileObjectData.newTile);
            TileObjectData.newAlternate.CoordinateHeights = [
                24
            ];
            TileObjectData.newAlternate.DrawYOffset = -6;
            TileObjectData.newAlternate.AnchorBottom = AnchorData.Empty;
            TileObjectData.newAlternate.AnchorTop = new AnchorData(AnchorType.AlternateTile, TileObjectData.newTile.Width, 0);
            TileObjectData.newAlternate.AnchorAlternateTiles = [TileID.Rope, TileID.SilkRope, TileID.VineRope, TileID.WebRope];
            TileObjectData.newAlternate.LavaDeath = false;
            TileObjectData.addAlternate(1);
            RegisterItemDrop(ModContent.ItemType<Items.Placeable.Furniture.BucketItem>(), 1);

            TileObjectData.addTile(Type);

            AddMapEntry(new Color(109, 106, 120));

            DustType = DustID.Iron;
            HitSound = ClangSound;
        }

        public override void SetDrawPositions(int i, int j, ref int width, ref int offsetY, ref int height, ref short tileFrameX, ref short tileFrameY)
        {
            height = tileFrameX > 0 ? 24 : 18;
            offsetY = tileFrameX > 0 ? -6 : 0;
        }
    }
}