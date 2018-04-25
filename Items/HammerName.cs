using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MagicStorage.Items
{
    public class HammerName : ModItem
    {
        public override void SetStaticDefaults()
        {
            //item.name = "Chest Hammer";
            Tooltip.SetDefault("This is a hammer made from a chest");
        }
        public override void SetDefaults()
        {
            item.damage = 10;
            item.melee = true;
            item.width = 32;
            item.height = 32;
            item.useTime = 25;
            item.useAnimation = 25;
            item.hammer = 30;
            item.useStyle = 1;
            item.knockBack = 6;
            item.value = 100;
            item.rare = 2;
            item.UseSound = SoundID.Item1;
            item.autoReuse = true;
            item.useTurn = true;

        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Wood, 10);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}