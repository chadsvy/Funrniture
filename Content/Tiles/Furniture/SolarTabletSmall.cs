using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.DataStructures;
using Terraria.Enums;
using Terraria.GameContent.Drawing;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ObjectData;

namespace Funrniture.Content.Tiles.Furniture
{
    public class SolarTabletSmall : ModTile
    {
        public override void SetStaticDefaults()
        {
            Main.tileFrameImportant[Type] = true;
            Main.tileNoAttach[Type] = true;

            TileObjectData.newTile.CopyFrom(TileObjectData.Style2x2);
            TileObjectData.newTile.CoordinateHeights = [
                16,
                18
            ];
            TileObjectData.newTile.CoordinateWidth = 20;
            TileObjectData.newTile.DrawXOffset = -2;
            TileObjectData.newTile.AnchorBottom = new AnchorData(AnchorType.SolidTile | AnchorType.SolidWithTop | AnchorType.Table, TileObjectData.newTile.Width, 0);
            TileObjectData.newTile.LavaDeath = false;
            TileObjectData.newTile.StyleHorizontal = true;
            TileObjectData.newTile.StyleWrapLimit = 2;

            TileObjectData.newAlternate.CopyFrom(TileObjectData.newTile);
            TileObjectData.newAlternate.Direction = TileObjectDirection.PlaceRight;
            TileObjectData.addAlternate(1);
            RegisterItemDrop(ModContent.ItemType<Items.Placeable.Furniture.SolarTabletSmallItem>(), 1);

            TileObjectData.newAlternate.CopyFrom(TileObjectData.newTile);
            TileObjectData.addAlternate(2);
            RegisterItemDrop(ModContent.ItemType<Items.Placeable.Furniture.SolarTabletSmallItem>(), 2);

            TileObjectData.newAlternate.CopyFrom(TileObjectData.newTile);
            TileObjectData.newAlternate.Direction = TileObjectDirection.PlaceRight;
            TileObjectData.addAlternate(3);
            RegisterItemDrop(ModContent.ItemType<Items.Placeable.Furniture.SolarTabletSmallItem>(), 3);

            TileObjectData.addTile(Type);

            AddMapEntry(new Color(122, 46, 6));

            DustType = DustID.Lihzahrd;
        }

        // Is this really the best way to draw a piece of furniture with an X-axis offset?
        public override bool PreDraw(int i, int j, SpriteBatch spriteBatch)
        {
            Tile tile = Main.tile[i, j];

            if (!TileDrawing.IsVisible(tile))
            {
                return true;
            }

            Vector2 zero = Main.drawToScreen ? Vector2.Zero : new Vector2(Main.offScreenRange);
            var position = new Vector2(i * 16 - (int)Main.screenPosition.X - 4, j * 16 - (int)Main.screenPosition.Y) + zero;
            var rectHeight = tile.TileFrameY % 38 == 0 ? 16 : 18;

            spriteBatch.Draw(Mod.Assets.Request<Texture2D>("Content/Tiles/Furniture/SolarTabletSmall").Value, position, new Rectangle(tile.TileFrameX, tile.TileFrameY, 20, rectHeight), Lighting.GetColor(i, j), 0f, default, 1f, SpriteEffects.None, 0f);

            return false;
        }
    }
}