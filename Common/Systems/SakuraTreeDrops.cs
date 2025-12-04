
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
    internal class GlobalTreeDrops : GlobalTile
    {

        public override bool CanDrop(int i, int j, int Type)
        {
            if (Type == TileID.VanityTreeSakura)
            {
                Item.NewItem(WorldGen.GetItemSource_FromTileBreak(i, j), i * 16, j * 16, 16, 16, ModContent.ItemType<SakuraWood>());
                return false;
            }
            return base.CanDrop(i, j, Type);

            
        }
        

    }



}
