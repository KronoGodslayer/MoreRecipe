using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MoreRecipe.Items
{
    public class TheSeed : ModItem
    {
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("The seed");
			Tooltip.SetDefault("Used to craft Plantera stuff");
		}
        public override void SetDefaults()
        {
            item.width = 20;
            item.height = 20;
            item.maxStack = 999;
            item.value = 50;
            item.rare = 5;
        }
    }
}