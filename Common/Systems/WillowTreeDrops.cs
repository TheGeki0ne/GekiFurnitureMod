using Source.Content.Items;
using Terraria;
using Terraria.Audio;
using Terraria.Enums;
using Terraria.ID;
using Terraria.IO;
using Terraria.ModLoader;
using Terraria.ModLoader.Utilities;
using Terraria.DataStructures;


namespace Source.Common.Systems
{
    internal class WillowTreeDrops
    {
        internal class GlobalTreeDrops : GlobalTile
        {
            public override bool CanDrop(int x, int y, int Type)
            {

                if (Type == TileID.VanityTreeYellowWillow)
                {
                    Item.NewItem(WorldGen.GetItemSource_FromTileBreak(x, y), x * 16, y * 16, 16, 16, ModContent.ItemType<WillowWood>());
                    return false;
                }
                return base.CanDrop(x, y, Type);
            }


        }
    }
}
