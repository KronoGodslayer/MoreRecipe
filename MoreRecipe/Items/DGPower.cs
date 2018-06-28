using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MoreRecipe.Items
{
	public class DGPower : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Dungeon Guardian's power");
			Tooltip.SetDefault("It make you technically a god, if your name is GodSlayer. P.S. It was made only for joke");
		}
		public override void SetDefaults()
		{
			item.width = 35;
			item.height = 30;
			item.accessory = true;
			item.defense = 200;
			item.lifeRegen = 200;
			item.value = 0;
			item.rare = -12;
        }
		
		public override void UpdateAccessory(Player player, bool hideVisual)
		{
			if(player.name == "GodSlayer" || player.name == "Kronos" )
			{
				item.defense = 9999;
				player.lifeRegen += 9799;
				player.statLifeMax2 += 10000;
				player.statManaMax2 += 400;
				player.manaRegen = 10000;
				player.meleeDamage *= 15;
				player.thrownDamage *= 50;
				player.rangedDamage *= 20;
				player.magicDamage *= 15;
				player.minionDamage *= 20;
				player.buffImmune[BuffID.Bleeding] = true;
				player.buffImmune[BuffID.Poisoned] = true;
				player.buffImmune[BuffID.OnFire] = true;
				player.buffImmune[BuffID.Venom] = true;
				player.buffImmune[BuffID.Darkness] = true;
				player.buffImmune[BuffID.Blackout] = true;
				player.buffImmune[BuffID.Silenced] = true;
				player.buffImmune[BuffID.Cursed] = true;
				player.buffImmune[BuffID.Confused] = true;
				player.buffImmune[BuffID.Slow] = true;
				player.buffImmune[BuffID.Weak] = true;
				player.buffImmune[BuffID.BrokenArmor] = true;
				player.buffImmune[BuffID.CursedInferno] = true;
				player.buffImmune[BuffID.Ichor] = true;
				player.buffImmune[BuffID.Chilled] = true;
				player.buffImmune[BuffID.Frozen] = true;
				player.buffImmune[BuffID.Webbed] = true;
				player.buffImmune[BuffID.Stoned] = true;
				player.buffImmune[BuffID.Obstructed] = true;
				player.buffImmune[BuffID.Electrified] = true;
				player.buffImmune[BuffID.Rabies] = true;
				player.buffImmune[BuffID.ManaSickness] = true;
				player.buffImmune[BuffID.ChaosState] = true;
				player.buffImmune[BuffID.Suffocation] = true;
				player.buffImmune[BuffID.Burning] = true;
				player.buffImmune[BuffID.NoBuilding] = true;
				
			}
			
		} 

        public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.BoneKey);
            recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
        }
	}
}
