using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MagicStorage.Items.Armor
{
	[AutoloadEquip(EquipType.Body)]
	public class Chestplate : ModItem
	{
		public override void SetStaticDefaults()
		{
			base.SetStaticDefaults();
			DisplayName.SetDefault("Chestplate");
			Tooltip.SetDefault("Get it? CHEST-plate?"
				+ "\n20% increased bad puns"
                + "\n10% increased melee damage");
		}

		public override void SetDefaults()
		{
			item.width = 18;
			item.height = 18;
			item.value = 10000;
			item.rare = 2;
			item.defense = 10;
		}

		public override void UpdateEquip(Player player)
		{
            player.meleeDamage *= 1.1f;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Chest, 3);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}