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
    public class UnicornStick : ModTile
    {
        public override void SetStaticDefaults()
        {
            Main.tileFrameImportant[Type] = true;
            Main.tileNoAttach[Type] = true;

            TileObjectData.newTile.CopyFrom(TileObjectData.Style2xX);
            TileObjectData.newTile.Height = 3;
            TileObjectData.newTile.Origin = new Point16(0, 2);
            TileObjectData.newTile.Direction = TileObjectDirection.PlaceLeft;
            TileObjectData.newTile.CoordinateHeights = [16, 16, 18];
            TileObjectData.newTile.CoordinateWidth = 20;
            TileObjectData.newTile.DrawXOffset = -2;
            TileObjectData.newTile.CoordinatePadding = 2;
            TileObjectData.newTile.StyleHorizontal = true;
            TileObjectData.newTile.StyleMultiplier = 2;

            TileObjectData.newAlternate.CopyFrom(TileObjectData.newTile);
            TileObjectData.newAlternate.Direction = TileObjectDirection.PlaceRight;
            TileObjectData.addAlternate(1);

            TileObjectData.addTile(Type);

            AddMapEntry(new Color(148, 107, 80));

            DustType = DustID.WoodFurniture;
        }

        // TODO Near duplicate of SolarTabletSmall.PreDraw
        public override bool PreDraw(int i, int j, SpriteBatch spriteBatch)
        {
            Tile tile = Main.tile[i, j];

            if (!TileDrawing.IsVisible(tile))
            {
                return true;
            }

            Vector2 zero = Main.drawToScreen ? Vector2.Zero : new Vector2(Main.offScreenRange);
            var position = new Vector2(i * 16 - (int)Main.screenPosition.X - 4, j * 16 - (int)Main.screenPosition.Y) + zero;
            var rectHeight = tile.TileFrameY % 36 == 0 ? 16 : 18;

            spriteBatch.Draw(Mod.Assets.Request<Texture2D>("Content/Tiles/Furniture/UnicornStick").Value, position, new Rectangle(tile.TileFrameX, tile.TileFrameY, 20, rectHeight), Lighting.GetColor(i, j), 0f, default, 1f, SpriteEffects.None, 0f);

            return false;
        }
    }
}