using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MoreRecipe.Items
{
    public class RegalGel : ModItem
    {
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Regal Gel");
			Tooltip.SetDefault("Used to craft King Slyme stuff");
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