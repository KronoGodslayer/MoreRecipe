using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MoreRecipe.Items
{
    public class GoldenBone : ModItem
    {
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Golden Bone");
			Tooltip.SetDefault("Used to craft Skeletron stuff");
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