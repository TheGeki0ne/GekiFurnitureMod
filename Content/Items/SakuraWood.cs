using Terraria.ModLoader;
using Terraria.ID;
using Terraria;
using Microsoft.Xna.Framework;
using Terraria.IO;
using Terraria.ModLoader.Utilities;

namespace Source.Content.Items
{
    internal class SakuraWood : ModItem
    {
        public override void SetDefaults()
        {
            Item.width = 24;
            Item.height = 22;

            Item.maxStack = Item.CommonMaxStack;
            Item.value = Item.buyPrice(0);
        }
        public override void SetStaticDefaults()
        {
            // DisplayName.SetDefault("Sakura Wood");

            Item.ResearchUnlockCount = 100;

        }
    }
}
