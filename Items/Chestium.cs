using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Localization;

namespace MagicStorage.Items
{
    public class Chestium : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Chestium");
            Tooltip.SetDefault("A material specifically used to make the Magic Chest.");
        }

        public override void SetDefaults()
        {
            item.material = true;
            item.maxStack = 99;
            item.width = 16;
            item.height = 16;
            item.UseSound = SoundID.Item2;
            item.value = Item.buyPrice(0, 5, 0, 0);
            item.rare = 5;
        }
    }
}
