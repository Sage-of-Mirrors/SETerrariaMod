using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Localization;

namespace MagicStorage.Items
{
    public class MagicChest : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Magic Chest");
            Tooltip.SetDefault("A user-friendly magical chest that makes storing and finding items that are stored much easier.");
        }

        public override void SetDefaults()
        {
            item.width = 26;
            item.height = 22;
            item.maxStack = 99;
            item.useTurn = true;
            item.autoReuse = true;
            item.useAnimation = 15;
            item.useTime = 10;
            item.useStyle = 1;
            item.consumable = true;
            item.rare = 5;
            item.value = Item.buyPrice(0, 6, 0, 0);
            item.createTile = mod.TileType("MagicChest");
            item.placeStyle = 1;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Chest);
            recipe.AddIngredient(mod.ItemType("Chestium"));
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}