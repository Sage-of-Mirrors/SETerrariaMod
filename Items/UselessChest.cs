using Terraria.ID;
using Terraria.ModLoader;

namespace MagicStorage.Items
{
	public class UselessChest : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Decorative Chest");
			Tooltip.SetDefault("A chest for decoration. It doesn't open.");
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
            item.value = 500;
            item.createTile = mod.TileType("UselessChest");
        }

        public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Wood, 10);
            recipe.AddIngredient(ItemID.IronBar, 5);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
