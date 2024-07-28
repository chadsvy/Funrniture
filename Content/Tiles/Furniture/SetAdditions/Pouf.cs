using Funrniture.Content.Items.Placeable.Furniture.SetAdditions.Poufs;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.Enums;
using Terraria.GameContent;
using Terraria.GameContent.ObjectInteractions;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ObjectData;

namespace Funrniture.Content.Tiles.Furniture.SetAdditions
{
    public class Pouf : ModTile
    {
        public override void SetStaticDefaults()
        {
            Main.tileFrameImportant[Type] = true;
            Main.tileNoAttach[Type] = true;
            Main.tileLavaDeath[Type] = true;
            TileID.Sets.HasOutlines[Type] = true;
            TileID.Sets.CanBeSatOnForNPCs[Type] = true; // Facilitates calling ModifySittingTargetInfo for NPCs
            TileID.Sets.CanBeSatOnForPlayers[Type] = true; // Facilitates calling ModifySittingTargetInfo for Players
            TileID.Sets.DisableSmartCursor[Type] = true;

            AddToArray(ref TileID.Sets.RoomNeeds.CountsAsChair);

            AdjTiles = [TileID.Chairs];

            TileObjectData.newTile.Width = 1;
            TileObjectData.newTile.Height = 1;
            TileObjectData.newTile.Origin = new Point16(0, 0);
            TileObjectData.newTile.AnchorBottom = new AnchorData(AnchorType.SolidTile, TileObjectData.newTile.Width, 0);
            TileObjectData.newTile.UsesCustomCanPlace = true;
            TileObjectData.newTile.CoordinateHeights = [18];
            TileObjectData.newTile.CoordinateWidth = 16;
            TileObjectData.newTile.CoordinatePadding = 2;
            TileObjectData.newTile.StyleHorizontal = true;
            TileObjectData.newTile.LavaDeath = true;

            //TileObjectData.newSubTile.CopyFrom(TileObjectData.newTile);
            //TileObjectData.newSubTile.AnchorValidTiles = new int[] { TileType<ExampleSand>() };
            //TileObjectData.addSubTile(1);

            TileObjectData.addTile(Type);

            AddMapEntry(new Color(148, 107, 80));

            DustType = DustID.WoodFurniture;
        }

        public override bool CreateDust(int i, int j, ref int type)
        {
            return base.CreateDust(i, j, ref type);
        }

        public override bool HasSmartInteract(int i, int j, SmartInteractScanSettings settings)
        {
            return settings.player.IsWithinSnappngRangeToTile(i, j, PlayerSittingHelper.ChairSittingMaxDistance); // Avoid being able to trigger it from long range
        }

        public override void ModifySittingTargetInfo(int i, int j, ref TileRestingInfo info)
        {
            // See ExampleChair in ExampleMod for comments on code.
            Tile tile = Framing.GetTileSafely(i, j);
            info.TargetDirection = info.RestingEntity.direction;
            info.AnchorTilePosition.X = i;
            info.AnchorTilePosition.Y = j;
            info.VisualOffset = new Vector2(-4, 2);
        }

        public override bool RightClick(int i, int j)
        {
            Player player = Main.LocalPlayer;

            if (player.IsWithinSnappngRangeToTile(i, j, PlayerSittingHelper.ChairSittingMaxDistance))
            { // Avoid being able to trigger it from long range
                player.GamepadEnableGrappleCooldown();
                player.sitting.SitDown(player, i, j);
            }

            return true;
        }

        public override void MouseOver(int i, int j)
        {
            Player player = Main.LocalPlayer;

            if (!player.IsWithinSnappngRangeToTile(i, j, PlayerSittingHelper.ChairSittingMaxDistance))
            { // Match condition in RightClick. Interaction should only show if clicking it does something
                return;
            }

            player.noThrow = 2;
            player.cursorItemIconEnabled = true;
            player.cursorItemIconID = GetCorrespondingItemType(i, j);

            if (Main.tile[i, j].TileFrameX / 18 < 1)
            {
                player.cursorItemIconReversed = true;
            }
        }

        private int GetCorrespondingItemType(int i, int j) => (Framing.GetTileSafely(i, j).TileFrameX / 18) switch
        {
            0 => ModContent.ItemType<StoolItem>(),
            1 => ModContent.ItemType<PoufItem>(),
            2 => ModContent.ItemType<EbonwoodPoufItem>(),
            3 => ModContent.ItemType<RichMahoganyPoufItem>(),
            4 => ModContent.ItemType<PearlwoodPoufItem>(),
            5 => ModContent.ItemType<ShadewoodPoufItem>(),
            6 => ModContent.ItemType<BlueDungeonPoufItem>(),
            7 => ModContent.ItemType<GreenDungeonPoufItem>(),
            8 => ModContent.ItemType<PinkDungeonPoufItem>(),
            9 => ModContent.ItemType<GoldenPoufItem>(),
            10 => ModContent.ItemType<ObsidianPoufItem>(),
            11 => ModContent.ItemType<BonePoufItem>(),
            12 => ModContent.ItemType<CactusPoufItem>(),
            13 => ModContent.ItemType<SpookyPoufItem>(),
            14 => ModContent.ItemType<SkywarePoufItem>(),
            15 => ModContent.ItemType<HoneyPoufItem>(),
            16 => ModContent.ItemType<SteampunkPoufItem>(),
            17 => ModContent.ItemType<MushroomPoufItem>(),
            18 => ModContent.ItemType<GlassPoufItem>(),
            19 => ModContent.ItemType<PumpkinPoufItem>(),
            20 => ModContent.ItemType<LihzahrdPoufItem>(),
            21 => ModContent.ItemType<PalmWoodPoufItem>(),
            22 => ModContent.ItemType<BorealWoodPoufItem>(),
            23 => ModContent.ItemType<SlimePoufItem>(),
            24 => ModContent.ItemType<FleshPoufItem>(),
            25 => ModContent.ItemType<FrozenPoufItem>(),
            26 => ModContent.ItemType<LivingWoodPoufItem>(),
            27 => ModContent.ItemType<MartianPoufItem>(),
            28 => ModContent.ItemType<MeteoritePoufItem>(),
            29 => ModContent.ItemType<GranitePoufItem>(),
            30 => ModContent.ItemType<MarblePoufItem>(),
            31 => ModContent.ItemType<CrystalPoufItem>(),
            32 => ModContent.ItemType<DynastyPoufItem>(),
            33 => ModContent.ItemType<SpiderPoufItem>(),
            34 => ModContent.ItemType<LesionPoufItem>(),
            35 => ModContent.ItemType<SolarPoufItem>(),
            36 => ModContent.ItemType<VortexPoufItem>(),
            37 => ModContent.ItemType<NebulaPoufItem>(),
            38 => ModContent.ItemType<StardustPoufItem>(),
            39 => ModContent.ItemType<SandstonePoufItem>(),
            40 => ModContent.ItemType<BambooPoufItem>(),
            42 => ModContent.ItemType<ReefPoufItem>(),
            43 => ModContent.ItemType<BalloonPoufItem>(),
            44 => ModContent.ItemType<AshWoodPoufItem>(),
            _ => ModContent.ItemType<StoolItem>()
        };
    }
}