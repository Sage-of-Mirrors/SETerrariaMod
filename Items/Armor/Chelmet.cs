using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MagicStorage.Items.Armor
{
    [AutoloadEquip(EquipType.Head)]
    public class Chelmet : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Chest Helmet!"
                + "\n5% increased melee crit rate");
        }

        public override void SetDefaults()
        {
            item.width = 18;
            item.height = 18;
            item.value = 10000;
            item.rare = 2;
            item.defense = 5;
        }

        public override bool IsArmorSet(Item head, Item body, Item legs)
        {
            return body.type == mod.ItemType("Chestplate") && legs.type == mod.ItemType("Cheggings");
        }

        public override void UpdateEquip(Player player)
        {
            player.meleeCrit += 5;
        }

        public override void UpdateArmorSet(Player player)
        {
            player.setBonus = "\nYou can see treasure everywhere" + "\n25% increased melee speed";
            player.findTreasure = true;
            player.meleeSpeed *= 1.25f;

        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Chest, 1);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}