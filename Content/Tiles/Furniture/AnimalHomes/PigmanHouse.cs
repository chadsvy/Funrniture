using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using System;
using Terraria;
using Terraria.GameContent;
using Terraria.GameContent.Drawing;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ObjectData;

namespace Funrniture.Content.Tiles.Furniture.AnimalHomes
{
    public class PigmanHouse : ModTile
    {
        private Asset<Texture2D> pigTexture;

        public override void SetStaticDefaults()
        {
            Main.tileFrameImportant[Type] = true;
            Main.tileNoAttach[Type] = true;

            TileObjectData.newTile.CopyFrom(TileObjectData.Style5x4);
            TileObjectData.newTile.CoordinateHeights = [
                16,
                16,
                16,
                18
            ];
            TileObjectData.newTile.DrawYOffset = 0;
            TileObjectData.newTile.LavaDeath = false;
            TileObjectData.addTile(Type);

            AddMapEntry(new Color(148, 107, 80));

            DustType = DustID.WoodFurniture;

            // Load pigman projectile texture
            const int pigProjectileId = 959;
            Main.instance.LoadProjectile(pigProjectileId);
            pigTexture = TextureAssets.Projectile[pigProjectileId];
        }

        public override void PostDraw(int i, int j, SpriteBatch spriteBatch)
        {
            Tile tile = Main.tile[i, j];

            if (!TileDrawing.IsVisible(tile) || tile.TileFrameX < 72 || tile.TileFrameY < 54)
            {
                return;
            }

            const int millisecsInAnimation = (int)3e4;
            const int ticksInMillisec = (int)1e4;
            var millisecsPassed = (int)((DateTime.Now.Ticks / ticksInMillisec) % millisecsInAnimation);

            const int walkTime = 2500; // Milliseconds spent walking from one side to the other
            const int walkDistance = 48; // In pixels

            SpriteEffects effects = SpriteEffects.None;
            int frame = 0;
            int pos = walkDistance;
            int direction = 1;

            if (millisecsPassed > millisecsInAnimation / 2)
            {
                effects = SpriteEffects.FlipHorizontally;
                pos = 0;
                direction = -1;
            }

            var millisecsPassedInPhase = millisecsPassed % (millisecsInAnimation / 2);

            if (millisecsPassedInPhase <= walkTime)
            {
                pos += direction * (-walkDistance + (walkDistance * millisecsPassedInPhase / walkTime));

                const int millisecsPerFrame = 250;
                const int walkFrameAmount = 8;
                frame = 1 + (millisecsPassedInPhase / millisecsPerFrame) % walkFrameAmount;
            }

            const int pigWidth = 54; // Width of sprite including empty space
            const int pigHeight = 64;
            Vector2 pigOffset = new Vector2(20, 60); // Distance from top-left of pig sprite to pig's feet
            Vector2 zero = Main.drawToScreen ? Vector2.Zero : new Vector2(Main.offScreenRange);

            spriteBatch.Draw(pigTexture.Value, new Vector2(i * 16 - (int)Main.screenPosition.X - walkDistance + pos, j * 16 - (int)Main.screenPosition.Y + 16) + zero - pigOffset, new Rectangle(0, frame * pigHeight, pigWidth, pigHeight), Lighting.GetColor(i - 4 + (pos / 16), j), 0f, default, 1f, effects, 0f);
        }
    }
}