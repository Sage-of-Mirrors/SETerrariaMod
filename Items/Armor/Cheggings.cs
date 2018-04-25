using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MagicStorage.Items.Armor
{
	[AutoloadEquip(EquipType.Legs)]
	public class Cheggings : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Chest Leggings!"
				+ "\n5% increased movement speed"
                + "\n5% increased melee damage");
		}

		public override void SetDefaults()
		{
			item.width = 18;
			item.height = 18;
			item.value = 10000;
			item.rare = 2;
			item.defense = 7;
		}

		public override void UpdateEquip(Player player)
		{
			player.moveSpeed += 0.05f;
            player.meleeDamage *= 1.1f;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Chest, 2);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}