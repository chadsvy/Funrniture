using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.Enums;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ObjectData;

namespace Funrniture.Content.Tiles.Furniture
{
    public class ChumBucket : ModTile
    {
        public override void SetStaticDefaults()
        {
            Main.tileFrameImportant[Type] = true;
            Main.tileNoAttach[Type] = true;

            TileObjectData.newTile.CopyFrom(TileObjectData.Style1x1);
            TileObjectData.newTile.CoordinateHeights = [
                20
            ];
            TileObjectData.newTile.DrawYOffset = -2;
            TileObjectData.newTile.AnchorBottom = new AnchorData(AnchorType.SolidTile | AnchorType.SolidWithTop | AnchorType.Table, TileObjectData.newTile.Width, 0);
            TileObjectData.newTile.LavaDeath = false;

            TileObjectData.addTile(Type);

            AddMapEntry(new Color(216, 83, 60));

            DustType = DustID.Blood;
            HitSound = new Terraria.Audio.SoundStyle("Terraria/Sounds/Item_167") // Queen Slime Queenly Smash
            {
                MaxInstances = 1,
                PitchRange = (-.5f, .5f),
                Volume = 1f
            };
        }

        public override void SetDrawPositions(int i, int j, ref int width, ref int offsetY, ref int height, ref short tileFrameX, ref short tileFrameY)
        {
            height = 20;
            offsetY = -2;
        }
    }
}