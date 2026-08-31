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

namespace Funrniture.Content.Tiles.Furniture.AnimalHomes.Pets
{
    public class GlommersStatue : ModTile
    {
        private Asset<Texture2D> glommerTexture;

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

            DustType = DustID.Granite;

            // Load glommer projectile texture
            const int glommerProjectileId = 957;
            Main.instance.LoadProjectile(glommerProjectileId);
            glommerTexture = TextureAssets.Projectile[glommerProjectileId];
        }

        public override void PostDraw(int i, int j, SpriteBatch spriteBatch)
        {
            Tile tile = Main.tile[i, j];

            if (!TileDrawing.IsVisible(tile) || tile.TileFrameX < 72 || tile.TileFrameY < 54)
            {
                return;
            }

            const int msInAnimation = (int)3e4;
            const int ticksInMillisecond = (int)1e4;
            var arbitraryAnimationOffset = (i + j) * 25;
            var millisecsPassed = (int)(((DateTime.Now.Ticks / ticksInMillisecond) + arbitraryAnimationOffset) % msInAnimation);

            const int msInVerticalMovement = 2000;
            const int maxHeightOffset = 10;
            var msPassedInVertMovement = millisecsPassed % msInVerticalMovement;
            int heightOffset = (int)(maxHeightOffset / 2 * Math.Sin(2 * Math.PI * msPassedInVertMovement / msInVerticalMovement));

            const int flyTime = 2500; // Milliseconds spent flying from one side to the other
            const int flyDistance = 48; // Length of the path flown, in pixels

            SpriteEffects effects = SpriteEffects.None;
            int posX = flyDistance;
            int direction = 1;

            // In the second half of the animation, Glommer moves left.
            if (millisecsPassed > msInAnimation / 2)
            {
                effects = SpriteEffects.FlipHorizontally;
                posX = 0;
                direction = -1;
            }

            var millisecsPassedInPhase = millisecsPassed % (msInAnimation / 2);
            if (millisecsPassedInPhase <= flyTime)
            {
                posX += direction * (-flyDistance + (flyDistance * millisecsPassedInPhase / flyTime));
            }

            const int spriteWidth = 56; // Width of sprite including empty space
            const int spriteHeight = 108;
            Vector2 spriteOffset = new Vector2(28, 54); // Distance from top-left of Glommer's sprite to Glommer's center
            Vector2 zero = Main.drawToScreen ? Vector2.Zero : new Vector2(Main.offScreenRange);

            int drawPosX = i * 16 - (int)Main.screenPosition.X - flyDistance + posX;
            int drawPosY = j * 16 - (int)Main.screenPosition.Y - 32 - heightOffset;
            const int millisecsPerFrame = 75;
            const int flyFrameAmount = 24;
            int frame = (millisecsPassedInPhase / millisecsPerFrame) % flyFrameAmount;
            int frameX = (int)Math.Floor((decimal)frame / 12);
            int frameY = frame % 12;
            var sourceRect = new Rectangle(frameX * spriteWidth, frameY * spriteHeight, spriteWidth, spriteHeight);

            spriteBatch.Draw(glommerTexture.Value, new Vector2(drawPosX, drawPosY) + zero - spriteOffset, sourceRect, Lighting.GetColor(i - 4 + (posX / 16), j), 0f, default, 1f, effects, 0f);
        }
    }
}