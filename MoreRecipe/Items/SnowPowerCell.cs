using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MoreRecipe.Items
{
    public class SnowPowerCell : ModItem
    {
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Snow Power Cell");
			Tooltip.SetDefault("Used to make frost moon boss item");
		}
        public override void SetDefaults()
        {
            item.width = 20;
            item.height = 20;
            item.maxStack = 999;
            item.value = 25000;
            item.rare = 7;
        }
    }
}