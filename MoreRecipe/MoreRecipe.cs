using System;
using System.Collections.Generic;
using System.Linq;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MoreRecipe
{
	class MoreRecipe : Mod
	{
		public MoreRecipe()
		{
			Properties = new ModProperties()
            {
                Autoload = true,
                AutoloadGores = true,
                AutoloadSounds = true
            };
		}
		
		public override void AddRecipeGroups()
        {
			RecipeGroup group = new RecipeGroup(() => Lang.misc[37] + "Paint", new int[] { ItemID.RedPaint, ItemID.OrangePaint, ItemID.YellowPaint,  ItemID.LimePaint, ItemID.GreenPaint, ItemID.TealPaint, ItemID.CyanPaint, ItemID.SkyBluePaint, ItemID.BluePaint, ItemID.PurplePaint, ItemID.VioletPaint, ItemID.PinkPaint, ItemID.DeepRedPaint, ItemID.DeepOrangePaint, ItemID.DeepYellowPaint, ItemID.DeepLimePaint, ItemID.DeepGreenPaint, ItemID.DeepTealPaint, ItemID.DeepCyanPaint, ItemID.DeepSkyBluePaint, ItemID.DeepBluePaint, ItemID.DeepVioletPaint, ItemID.DeepPinkPaint, ItemID.BlackPaint, ItemID.WhitePaint, ItemID.GrayPaint, ItemID.WhitePaint, });
            RecipeGroup.RegisterGroup("MoreRecipe:Paint", group);
		}
		
		public override void AddRecipes()
		{
				ModRecipe recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.HallowedBar, 15);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.BrokenHeroSword);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddRecipeGroup("MoreRecipe:Paint");
				recipe.AddIngredient(ItemID.Wood, 20);
				recipe.AddTile(TileID.WorkBenches);
				recipe.SetResult(ItemID.TheLandofDeceivingLooks);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddRecipeGroup("MoreRecipe:Paint");
				recipe.AddIngredient(ItemID.Wood, 20);
				recipe.AddTile(TileID.WorkBenches);
				recipe.SetResult(ItemID.ColdWatersintheWhiteLand);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddRecipeGroup("MoreRecipe:Paint");
				recipe.AddIngredient(ItemID.Wood, 20);
				recipe.AddTile(TileID.WorkBenches);
				recipe.SetResult(ItemID.Daylight);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddRecipeGroup("MoreRecipe:Paint");
				recipe.AddIngredient(ItemID.Wood, 20);
				recipe.AddTile(TileID.WorkBenches);
				recipe.SetResult(ItemID.DeadlandComesAlive);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddRecipeGroup("MoreRecipe:Paint");
				recipe.AddIngredient(ItemID.Wood, 20);
				recipe.AddTile(TileID.WorkBenches);
				recipe.SetResult(ItemID.DoNotStepontheGrass);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddRecipeGroup("MoreRecipe:Paint");
				recipe.AddIngredient(ItemID.Wood, 20);
				recipe.AddTile(TileID.WorkBenches);
				recipe.SetResult(ItemID.EvilPresence);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddRecipeGroup("MoreRecipe:Paint");
				recipe.AddIngredient(ItemID.Wood, 20);
				recipe.AddTile(TileID.WorkBenches);
				recipe.SetResult(ItemID.FirstEncounter);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddRecipeGroup("MoreRecipe:Paint");
				recipe.AddIngredient(ItemID.Wood, 20);
				recipe.AddTile(TileID.WorkBenches);
				recipe.SetResult(ItemID.GoodMorning);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddRecipeGroup("MoreRecipe:Paint");
				recipe.AddIngredient(ItemID.Wood, 20);
				recipe.AddTile(TileID.WorkBenches);
				recipe.SetResult(ItemID.LightlessChasms);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddRecipeGroup("MoreRecipe:Paint");
				recipe.AddIngredient(ItemID.Wood, 20);
				recipe.AddTile(TileID.WorkBenches);
				recipe.SetResult(ItemID.PlaceAbovetheClouds);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddRecipeGroup("MoreRecipe:Paint");
				recipe.AddIngredient(ItemID.Wood, 20);
				recipe.AddTile(TileID.WorkBenches);
				recipe.SetResult(ItemID.SecretoftheSands);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddRecipeGroup("MoreRecipe:Paint");
				recipe.AddIngredient(ItemID.Wood, 20);
				recipe.AddTile(TileID.WorkBenches);
				recipe.SetResult(ItemID.SkyGuardian);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddRecipeGroup("MoreRecipe:Paint");
				recipe.AddIngredient(ItemID.Wood, 20);
				recipe.AddTile(TileID.WorkBenches);
				recipe.SetResult(ItemID.ThroughtheWindow);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddRecipeGroup("MoreRecipe:Paint");
				recipe.AddIngredient(ItemID.Wood, 20);
				recipe.AddTile(TileID.WorkBenches);
				recipe.SetResult(ItemID.UndergroundReward);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddRecipeGroup("MoreRecipe:Paint");
				recipe.AddIngredient(ItemID.Wood, 20);
				recipe.AddTile(TileID.WorkBenches);
				recipe.SetResult(ItemID.PaintingAcorns);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddRecipeGroup("MoreRecipe:Paint");
				recipe.AddIngredient(ItemID.Wood, 20);
				recipe.AddTile(TileID.WorkBenches);
				recipe.SetResult(ItemID.PaintingCastleMarsberg);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddRecipeGroup("MoreRecipe:Paint");
				recipe.AddIngredient(ItemID.Wood, 20);
				recipe.AddTile(TileID.WorkBenches);
				recipe.SetResult(ItemID.PaintingColdSnap);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddRecipeGroup("MoreRecipe:Paint");
				recipe.AddIngredient(ItemID.Wood, 20);
				recipe.AddTile(TileID.WorkBenches);
				recipe.SetResult(ItemID.PaintingCursedSaint);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddRecipeGroup("MoreRecipe:Paint");
				recipe.AddIngredient(ItemID.Wood, 20);
				recipe.AddTile(TileID.WorkBenches);
				recipe.SetResult(ItemID.PaintingMartiaLisa	);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddRecipeGroup("MoreRecipe:Paint");
				recipe.AddIngredient(ItemID.Wood, 20);
				recipe.AddTile(TileID.WorkBenches);
				recipe.SetResult(ItemID.MoonLordPainting);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddRecipeGroup("MoreRecipe:Paint");
				recipe.AddIngredient(ItemID.Wood, 20);
				recipe.AddTile(TileID.WorkBenches);
				recipe.SetResult(ItemID.PaintingTheSeason);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddRecipeGroup("MoreRecipe:Paint");
				recipe.AddIngredient(ItemID.Wood, 20);
				recipe.AddTile(TileID.WorkBenches);
				recipe.SetResult(ItemID.PaintingSnowfellas);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddRecipeGroup("MoreRecipe:Paint");
				recipe.AddIngredient(ItemID.Wood, 20);
				recipe.AddTile(TileID.WorkBenches);
				recipe.SetResult(ItemID.PaintingTheTruthIsUpThere);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddRecipeGroup("MoreRecipe:Paint");
				recipe.AddIngredient(ItemID.Wood, 20);
				recipe.AddTile(TileID.WorkBenches);
				recipe.SetResult(ItemID.AmericanExplosive);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddRecipeGroup("MoreRecipe:Paint");
				recipe.AddIngredient(ItemID.Wood, 20);
				recipe.AddTile(TileID.WorkBenches);
				recipe.SetResult(ItemID.CrownoDevoursHisLunch);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddRecipeGroup("MoreRecipe:Paint");
				recipe.AddIngredient(ItemID.Wood, 20);
				recipe.AddTile(TileID.WorkBenches);
				recipe.SetResult(ItemID.Discover);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddRecipeGroup("MoreRecipe:Paint");
				recipe.AddIngredient(ItemID.Wood, 20);
				recipe.AddTile(TileID.WorkBenches);
				recipe.SetResult(ItemID.FatherofSomeone);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddRecipeGroup("MoreRecipe:Paint");
				recipe.AddIngredient(ItemID.Wood, 20);
				recipe.AddTile(TileID.WorkBenches);
				recipe.SetResult(ItemID.FindingGold);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddRecipeGroup("MoreRecipe:Paint");
				recipe.AddIngredient(ItemID.Wood, 20);
				recipe.AddTile(TileID.WorkBenches);
				recipe.SetResult(ItemID.GloriousNight);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddRecipeGroup("MoreRecipe:Paint");
				recipe.AddIngredient(ItemID.Wood, 20);
				recipe.AddTile(TileID.WorkBenches);
				recipe.SetResult(ItemID.GuidePicasso);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddRecipeGroup("MoreRecipe:Paint");
				recipe.AddIngredient(ItemID.Wood, 20);
				recipe.AddTile(TileID.WorkBenches);
				recipe.SetResult(ItemID.Land);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddRecipeGroup("MoreRecipe:Paint");
				recipe.AddIngredient(ItemID.Wood, 20);
				recipe.AddTile(TileID.WorkBenches);
				recipe.SetResult(ItemID.TheMerchant);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddRecipeGroup("MoreRecipe:Paint");
				recipe.AddIngredient(ItemID.Wood, 20);
				recipe.AddTile(TileID.WorkBenches);
				recipe.SetResult(ItemID.NurseLisa);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddRecipeGroup("MoreRecipe:Paint");
				recipe.AddIngredient(ItemID.Wood, 20);
				recipe.AddTile(TileID.WorkBenches);
				recipe.SetResult(ItemID.OldMiner);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddRecipeGroup("MoreRecipe:Paint");
				recipe.AddIngredient(ItemID.Wood, 20);
				recipe.AddTile(TileID.WorkBenches);
				recipe.SetResult(ItemID.RareEnchantment);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddRecipeGroup("MoreRecipe:Paint");
				recipe.AddIngredient(ItemID.Wood, 20);
				recipe.AddTile(TileID.WorkBenches);
				recipe.SetResult(ItemID.Sunflowers);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddRecipeGroup("MoreRecipe:Paint");
				recipe.AddIngredient(ItemID.Wood, 20);
				recipe.AddTile(TileID.WorkBenches);
				recipe.SetResult(ItemID.TerrarianGothic);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddRecipeGroup("MoreRecipe:Paint");
				recipe.AddIngredient(ItemID.Wood, 20);
				recipe.AddTile(TileID.WorkBenches);
				recipe.SetResult(ItemID.Waldo);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddRecipeGroup("MoreRecipe:Paint");
				recipe.AddIngredient(ItemID.Wood, 20);
				recipe.AddTile(TileID.WorkBenches);
				recipe.SetResult(ItemID.BloodMoonRising);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddRecipeGroup("MoreRecipe:Paint");
				recipe.AddIngredient(ItemID.Wood, 20);
				recipe.AddTile(TileID.WorkBenches);
				recipe.SetResult(ItemID.BoneWarp);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddRecipeGroup("MoreRecipe:Paint");
				recipe.AddIngredient(ItemID.Wood, 20);
				recipe.AddTile(TileID.WorkBenches);
				recipe.SetResult(ItemID.TheCreationoftheGuide);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddRecipeGroup("MoreRecipe:Paint");
				recipe.AddIngredient(ItemID.Wood, 20);
				recipe.AddTile(TileID.WorkBenches);
				recipe.SetResult(ItemID.TheCursedMan);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddRecipeGroup("MoreRecipe:Paint");
				recipe.AddIngredient(ItemID.Wood, 20);
				recipe.AddTile(TileID.WorkBenches);
				recipe.SetResult(ItemID.TheDestroyer);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddRecipeGroup("MoreRecipe:Paint");
				recipe.AddIngredient(ItemID.Wood, 20);
				recipe.AddTile(TileID.WorkBenches);
				recipe.SetResult(ItemID.Dryadisque);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddRecipeGroup("MoreRecipe:Paint");
				recipe.AddIngredient(ItemID.Wood, 20);
				recipe.AddTile(TileID.WorkBenches);
				recipe.SetResult(ItemID.TheEyeSeestheEnd);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddRecipeGroup("MoreRecipe:Paint");
				recipe.AddIngredient(ItemID.Wood, 20);
				recipe.AddTile(TileID.WorkBenches);
				recipe.SetResult(ItemID.FacingtheCerebralMastermind);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddRecipeGroup("MoreRecipe:Paint");
				recipe.AddIngredient(ItemID.Wood, 20);
				recipe.AddTile(TileID.WorkBenches);
				recipe.SetResult(ItemID.GloryoftheFire);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddRecipeGroup("MoreRecipe:Paint");
				recipe.AddIngredient(ItemID.Wood, 20);
				recipe.AddTile(TileID.WorkBenches);
				recipe.SetResult(ItemID.GoblinsPlayingPoker);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddRecipeGroup("MoreRecipe:Paint");
				recipe.AddIngredient(ItemID.Wood, 20);
				recipe.AddTile(TileID.WorkBenches);
				recipe.SetResult(ItemID.GreatWave);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddRecipeGroup("MoreRecipe:Paint");
				recipe.AddIngredient(ItemID.Wood, 20);
				recipe.AddTile(TileID.WorkBenches);
				recipe.SetResult(ItemID.TheGuardiansGaze);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddRecipeGroup("MoreRecipe:Paint");
				recipe.AddIngredient(ItemID.Wood, 20);
				recipe.AddTile(TileID.WorkBenches);
				recipe.SetResult(ItemID.TheHangedMan);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddRecipeGroup("MoreRecipe:Paint");
				recipe.AddIngredient(ItemID.Wood, 20);
				recipe.AddTile(TileID.WorkBenches);
				recipe.SetResult(ItemID.Impact);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddRecipeGroup("MoreRecipe:Paint");
				recipe.AddIngredient(ItemID.Wood, 20);
				recipe.AddTile(TileID.WorkBenches);
				recipe.SetResult(ItemID.ThePersistencyofEyes);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddRecipeGroup("MoreRecipe:Paint");
				recipe.AddIngredient(ItemID.Wood, 20);
				recipe.AddTile(TileID.WorkBenches);
				recipe.SetResult(ItemID.PoweredbyBirds);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddRecipeGroup("MoreRecipe:Paint");
				recipe.AddIngredient(ItemID.Wood, 20);
				recipe.AddTile(TileID.WorkBenches);
				recipe.SetResult(ItemID.TheScreamer);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddRecipeGroup("MoreRecipe:Paint");
				recipe.AddIngredient(ItemID.Wood, 20);
				recipe.AddTile(TileID.WorkBenches);
				recipe.SetResult(ItemID.SkellingtonJSkellingsworth);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddRecipeGroup("MoreRecipe:Paint");
				recipe.AddIngredient(ItemID.Wood, 20);
				recipe.AddTile(TileID.WorkBenches);
				recipe.SetResult(ItemID.SparkyPainting);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddRecipeGroup("MoreRecipe:Paint");
				recipe.AddIngredient(ItemID.Wood, 20);
				recipe.AddTile(TileID.WorkBenches);
				recipe.SetResult(ItemID.SomethingEvilisWatchingYou);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddRecipeGroup("MoreRecipe:Paint");
				recipe.AddIngredient(ItemID.Wood, 20);
				recipe.AddTile(TileID.WorkBenches);
				recipe.SetResult(ItemID.StarryNight);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddRecipeGroup("MoreRecipe:Paint");
				recipe.AddIngredient(ItemID.Wood, 20);
				recipe.AddTile(TileID.WorkBenches);
				recipe.SetResult(ItemID.TrioSuperHeroes);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddRecipeGroup("MoreRecipe:Paint");
				recipe.AddIngredient(ItemID.Wood, 20);
				recipe.AddTile(TileID.WorkBenches);
				recipe.SetResult(ItemID.TheTwinsHaveAwoken);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddRecipeGroup("MoreRecipe:Paint");
				recipe.AddIngredient(ItemID.Wood, 20);
				recipe.AddTile(TileID.WorkBenches);
				recipe.SetResult(ItemID.UnicornCrossingtheHallows);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddRecipeGroup("MoreRecipe:Paint");
				recipe.AddIngredient(ItemID.Wood, 20);
				recipe.AddTile(TileID.WorkBenches);
				recipe.SetResult(ItemID.DarkSoulReaper);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddRecipeGroup("MoreRecipe:Paint");
				recipe.AddIngredient(ItemID.Wood, 20);
				recipe.AddTile(TileID.WorkBenches);
				recipe.SetResult(ItemID.Darkness);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddRecipeGroup("MoreRecipe:Paint");
				recipe.AddIngredient(ItemID.Wood, 20);
				recipe.AddTile(TileID.WorkBenches);
				recipe.SetResult(ItemID.DemonsEye);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddRecipeGroup("MoreRecipe:Paint");
				recipe.AddIngredient(ItemID.Wood, 20);
				recipe.AddTile(TileID.WorkBenches);
				recipe.SetResult(ItemID.FlowingMagma);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddRecipeGroup("MoreRecipe:Paint");
				recipe.AddIngredient(ItemID.Wood, 20);
				recipe.AddTile(TileID.WorkBenches);
				recipe.SetResult(ItemID.HandEarth);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddRecipeGroup("MoreRecipe:Paint");
				recipe.AddIngredient(ItemID.Wood, 20);
				recipe.AddTile(TileID.WorkBenches);
				recipe.SetResult(ItemID.ImpFace);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddRecipeGroup("MoreRecipe:Paint");
				recipe.AddIngredient(ItemID.Wood, 20);
				recipe.AddTile(TileID.WorkBenches);
				recipe.SetResult(ItemID.LakeofFire);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddRecipeGroup("MoreRecipe:Paint");
				recipe.AddIngredient(ItemID.Wood, 20);
				recipe.AddTile(TileID.WorkBenches);
				recipe.SetResult(ItemID.LivingGore);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddRecipeGroup("MoreRecipe:Paint");
				recipe.AddIngredient(ItemID.Wood, 20);
				recipe.AddTile(TileID.WorkBenches);
				recipe.SetResult(ItemID.OminousPresence);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddRecipeGroup("MoreRecipe:Paint");
				recipe.AddIngredient(ItemID.Wood, 20);
				recipe.AddTile(TileID.WorkBenches);
				recipe.SetResult(ItemID.ShiningMoon);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddRecipeGroup("MoreRecipe:Paint");
				recipe.AddIngredient(ItemID.Wood, 20);
				recipe.AddTile(TileID.WorkBenches);
				recipe.SetResult(ItemID.Skelehead);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddRecipeGroup("MoreRecipe:Paint");
				recipe.AddIngredient(ItemID.Wood, 20);
				recipe.AddTile(TileID.WorkBenches);
				recipe.SetResult(ItemID.TrappedGhost);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddRecipeGroup("MoreRecipe:Paint");
				recipe.AddIngredient(ItemID.Wood, 20);
				recipe.AddTile(TileID.WorkBenches);
				recipe.SetResult(ItemID.BitterHarvest);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddRecipeGroup("MoreRecipe:Paint");
				recipe.AddIngredient(ItemID.Wood, 20);
				recipe.AddTile(TileID.WorkBenches);
				recipe.SetResult(ItemID.BloodMoonCountess);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddRecipeGroup("MoreRecipe:Paint");
				recipe.AddIngredient(ItemID.Wood, 20);
				recipe.AddTile(TileID.WorkBenches);
				recipe.SetResult(ItemID.HallowsEve);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddRecipeGroup("MoreRecipe:Paint");
				recipe.AddIngredient(ItemID.Wood, 20);
				recipe.AddTile(TileID.WorkBenches);
				recipe.SetResult(ItemID.JackingSkeletron);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddRecipeGroup("MoreRecipe:Paint");
				recipe.AddIngredient(ItemID.Wood, 20);
				recipe.AddTile(TileID.WorkBenches);
				recipe.SetResult(ItemID.MorbidCuriosity);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddRecipeGroup("MoreRecipe:Paint");
				recipe.AddIngredient(ItemID.Wood, 20);
				recipe.AddTile(TileID.WorkBenches);
				recipe.SetResult(ItemID.PillaginMePixels);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.CopperOre);
				recipe.AddTile(TileID.WorkBenches);
				recipe.SetResult(ItemID.TinOre);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.TinOre);
				recipe.AddTile(TileID.WorkBenches);
				recipe.SetResult(ItemID.CopperOre);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.IronOre);
				recipe.AddTile(TileID.Anvils);
				recipe.SetResult(ItemID.LeadOre);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.SilverOre);
				recipe.AddTile(TileID.Anvils);
				recipe.SetResult(ItemID.TungstenOre);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.TungstenOre);
				recipe.AddTile(TileID.Anvils);
				recipe.SetResult(ItemID.SilverOre);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.GoldOre);
				recipe.AddTile(TileID.Anvils);
				recipe.SetResult(ItemID.PlatinumOre);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.PlatinumOre);
				recipe.AddTile(TileID.Anvils);
				recipe.SetResult(ItemID.GoldOre);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.DemoniteOre);
				recipe.AddTile(TileID.Anvils);
				recipe.SetResult(ItemID.CrimtaneOre);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.CrimtaneOre);
				recipe.AddTile(TileID.Anvils);
				recipe.SetResult(ItemID.DemoniteOre);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.CobaltOre);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.PalladiumOre);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.PalladiumOre);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.CobaltOre);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.OrichalcumOre);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.MythrilOre);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.MythrilOre);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.OrichalcumOre);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.AdamantiteOre);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.TitaniumOre);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.TitaniumOre);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.AdamantiteOre);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddRecipeGroup("IronBar", 5);
				recipe.AddTile(TileID.Anvils);
				recipe.SetResult(ItemID.Aglet);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.Amethyst);
				recipe.AddIngredient(ItemID.Vine, 3);
				recipe.AddTile(TileID.Anvils);
				recipe.SetResult(ItemID.AnkletoftheWind);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.BottledWater);
				recipe.AddIngredient(ItemID.Silk,5);
				recipe.AddTile(TileID.Anvils);
				recipe.SetResult(ItemID.BalloonPufferfish);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.Bottle);
				recipe.AddIngredient(ItemID.SnowBlock,20);
				recipe.AddIngredient(ItemID.IceBlock,20);
				recipe.AddTile(TileID.Anvils);
				recipe.SetResult(ItemID.BlizzardinaBottle);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddRecipeGroup("IronBar", 3);
				recipe.AddIngredient(ItemID.Silk,10);
				recipe.AddTile(TileID.Anvils);
				recipe.SetResult(ItemID.ClimbingClaws);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.Bottle);
				recipe.AddIngredient(ItemID.Cloud,10);
				recipe.AddTile(TileID.Anvils);
				recipe.SetResult(ItemID.CloudinaBottle);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddRecipeGroup("IronBar", 2);
				recipe.AddIngredient(ItemID.Silk,5);
				recipe.AddTile(TileID.Anvils);
				recipe.SetResult(ItemID.Flipper);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddRecipeGroup("IronBar", 5);
				recipe.AddIngredient(ItemID.Silk,12);
				recipe.AddTile(TileID.Anvils);
				recipe.SetResult(ItemID.FlurryBoots);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.Silk,25);
				recipe.AddTile(TileID.Anvils);
				recipe.SetResult(ItemID.FlyingCarpet);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.Silk,20);
				recipe.AddTile(TileID.Anvils);
				recipe.SetResult(ItemID.FrogLeg);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddRecipeGroup("IronBar", 5);
				recipe.AddIngredient(ItemID.Silk,12);
				recipe.AddTile(TileID.Anvils);
				recipe.SetResult(ItemID.HermesBoots);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddRecipeGroup("IronBar", 5);
				recipe.AddIngredient(ItemID.Silk,12);
				recipe.AddTile(TileID.Anvils);
				recipe.SetResult(ItemID.IceSkates);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.LavaBucket);
				recipe.AddIngredient(ItemID.Silk,5);
				recipe.AddTile(TileID.Anvils);
				recipe.SetResult(ItemID.LavaCharm);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddRecipeGroup("IronBar", 5);
				recipe.AddIngredient(ItemID.Cloud,10);
				recipe.AddTile(TileID.Anvils);
				recipe.SetResult(ItemID.LuckyHorseshoe);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.Bottle);
				recipe.AddIngredient(ItemID.SandBlock,35);
				recipe.AddTile(TileID.Anvils);
				recipe.SetResult(ItemID.SandstorminaBottle);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.Silk,20);
				recipe.AddTile(TileID.Anvils);
				recipe.SetResult(ItemID.ShinyRedBalloon);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddRecipeGroup("IronBar", 3);
				recipe.AddIngredient(ItemID.Silk,10);
				recipe.AddTile(TileID.Anvils);
				recipe.SetResult(ItemID.ShoeSpikes);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.Silk,20);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.Tabi);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddRecipeGroup("IronBar", 3);
				recipe.AddIngredient(ItemID.Silk,10);
				recipe.AddTile(TileID.Anvils);
				recipe.SetResult(ItemID.WaterWalkingBoots);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddRecipeGroup("IronBar", 10);
				recipe.AddTile(TileID.Anvils);
				recipe.SetResult(ItemID.DepthMeter);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.GoldBar,10);
				recipe.AddTile(TileID.Anvils);
				recipe.SetResult(ItemID.Compass);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddRecipeGroup("IronBar", 20);
				recipe.AddTile(TileID.Anvils);
				recipe.SetResult(ItemID.MetalDetector);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddRecipeGroup("IronBar", 15);
				recipe.AddIngredient(ItemID.GoldBar,5);
				recipe.AddTile(TileID.Anvils);
				recipe.SetResult(ItemID.TallyCounter);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddRecipeGroup("IronBar", 10);
				recipe.AddTile(TileID.Anvils);
				recipe.SetResult(ItemID.Radar);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.Ruby);
				recipe.AddIngredient(ItemID.Silk,10);
				recipe.AddTile(TileID.Anvils);
				recipe.SetResult(ItemID.BandofRegeneration);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.Sapphire);
				recipe.AddIngredient(ItemID.Silk,10);
				recipe.AddTile(TileID.Anvils);
				recipe.SetResult(ItemID.BandofStarpower);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.Sapphire);
				recipe.AddIngredient(ItemID.Vine,10);
				recipe.AddTile(TileID.Anvils);
				recipe.SetResult(ItemID.NaturesGift);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.Ruby);
				recipe.AddIngredient(ItemID.PixieDust,10);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.PhilosophersStone);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.Silk, 15);
				recipe.AddIngredient(ItemID.PixieDust,5);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.AdhesiveBandage);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddRecipeGroup("IronBar", 15);
				recipe.AddIngredient(ItemID.PixieDust,5);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.ArmorBracing);
				recipe.AddRecipe();
			
				recipe = new ModRecipe(this);
				recipe.AddRecipeGroup("IronBar", 15);
				recipe.AddIngredient(ItemID.PixieDust,5);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.ArmorPolish);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.Stinger,5);
				recipe.AddIngredient(ItemID.Vine,10);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.Bezoar);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.Silk,20);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.BlackBelt);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.Silk,20);
				recipe.AddIngredient(ItemID.PixieDust,5);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.Blindfold);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.PixieDust,15);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.MoonCharm);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.CobaltBar,15);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.CobaltShield);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddRecipeGroup("IronBar", 15);
				recipe.AddIngredient(ItemID.PixieDust,5);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.CrossNecklace);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.LihzahrdBrick,5);
				recipe.AddIngredient(ItemID.PixieDust,10);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.EyeoftheGolem);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.PixieDust,5);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.FastClock);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddRecipeGroup("IronBar", 15);
				recipe.AddIngredient(ItemID.Vertebrae, 15);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.FleshKnuckles);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.IceBlock,25);
				recipe.AddIngredient(ItemID.PixieDust,10);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.FrozenTurtleShell);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.Silk,10);
				recipe.AddTile(TileID.Anvils);
				recipe.SetResult(ItemID.HandWarmer);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.WoodenArrow,25);
				recipe.AddIngredient(ItemID.Silk,10);
				recipe.AddIngredient(ItemID.PixieDust,5);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.MagicQuiver);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.StoneBlock,15);
				recipe.AddIngredient(ItemID.LavaBucket);
				recipe.AddIngredient(ItemID.PixieDust,5);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.MagmaStone);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddRecipeGroup("IronBar", 15);
				recipe.AddIngredient(ItemID.PixieDust,10);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.Megaphone);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.Silk,10);
				recipe.AddIngredient(ItemID.FallenStar);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.MoonStone);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddRecipeGroup("IronBar", 15);
				recipe.AddTile(TileID.Anvils);
				recipe.SetResult(ItemID.Nazar);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.StoneBlock,15);
				recipe.AddIngredient(ItemID.Obsidian, 10);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.ObsidianRose);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddRecipeGroup("IronBar", 15);
				recipe.AddIngredient(ItemID.PixieDust,10);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.PaladinsShield);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.GoldBar,10);
				recipe.AddIngredient(ItemID.Glass, 10);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.PocketMirror);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.RottenChunk,15);
				recipe.AddIngredient(ItemID.PixieDust,10);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.PutridScent);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.RottenChunk);
				recipe.AddTile(TileID.Anvils);
				recipe.SetResult(ItemID.Vertebrae);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.Vertebrae);
				recipe.AddTile(TileID.Anvils);
				recipe.SetResult(ItemID.RottenChunk);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.ShadowScale);
				recipe.AddTile(TileID.Anvils);
				recipe.SetResult(ItemID.TissueSample);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.TissueSample);
				recipe.AddTile(TileID.Anvils);
				recipe.SetResult(ItemID.ShadowScale);
				recipe.AddRecipe();
				
				
				recipe = new ModRecipe(this);
				recipe.AddRecipeGroup("IronBar", 5);
				recipe.AddTile(TileID.Anvils);
				recipe.SetResult(ItemID.Shackle);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.EbonstoneBlock);
				recipe.AddTile(TileID.Anvils);
				recipe.SetResult(ItemID.CrimstoneBlock);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.CrimstoneBlock);
				recipe.AddTile(TileID.Anvils);
				recipe.SetResult(ItemID.EbonstoneBlock);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.EbonsandBlock);
				recipe.AddTile(TileID.Anvils);
				recipe.SetResult(ItemID.CrimsandBlock);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.CrimsandBlock);
				recipe.AddTile(TileID.Anvils);
				recipe.SetResult(ItemID.EbonsandBlock);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.PurpleIceBlock);
				recipe.AddTile(TileID.Anvils);
				recipe.SetResult(ItemID.RedIceBlock);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.RedIceBlock);
				recipe.AddTile(TileID.Anvils);
				recipe.SetResult(ItemID.PurpleIceBlock);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.Vine,10);
				recipe.AddIngredient(ItemID.Silk, 10);
				recipe.AddTile(TileID.Anvils);
				recipe.SetResult(ItemID.FeralClaws);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddRecipeGroup("IronBar", 15);
				recipe.AddTile(TileID.Anvils);
				recipe.SetResult(ItemID.PanicNecklace);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddRecipeGroup("IronBar", 15);
				recipe.AddIngredient(ItemID.PixieDust,10);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.PaladinsShield);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.WarriorEmblem);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.SorcererEmblem);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.WarriorEmblem);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.SummonerEmblem);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.WarriorEmblem);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.RangerEmblem);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.SorcererEmblem);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.WarriorEmblem);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.SorcererEmblem);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.SummonerEmblem);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.SorcererEmblem);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.RangerEmblem);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.SummonerEmblem);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.RangerEmblem);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.SummonerEmblem);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.WarriorEmblem);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.SummonerEmblem);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.SorcererEmblem);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.RangerEmblem);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.WarriorEmblem);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.RangerEmblem);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.SorcererEmblem);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.RangerEmblem);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.SummonerEmblem);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddRecipeGroup("IronBar", 15);
				recipe.AddIngredient(ItemID.PixieDust,10);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.RifleScope);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddRecipeGroup("IronBar", 10);
				recipe.AddIngredient(ItemID.SharkFin,2);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.SharkToothNecklace);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.Silk,10);
				recipe.AddIngredient(ItemID.PixieDust,10);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.StarCloak);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.LihzahrdBrick,5);
				recipe.AddIngredient(ItemID.Silk,10);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.SunStone);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.PixieDust,5);
				recipe.AddIngredient(ItemID.Silk,10);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.TitanGlove);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.PixieDust,5);
				recipe.AddIngredient(ItemID.Silk,10);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.TrifoldMap);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.PixieDust,5);
				recipe.AddIngredient(ItemID.Vertebrae,10);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.Vitamins);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.PixieDust,5);
				recipe.AddIngredient(ItemID.RottenChunk,10);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.Vitamins);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.Silk,10);
				recipe.AddTile(TileID.Anvils);
				recipe.SetResult(ItemID.FlowerBoots);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.Gel,999);
				recipe.AddTile(TileID.Anvils);
				recipe.SetResult(ItemID.RoyalGel);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.IronBar);
				recipe.AddTile(TileID.Anvils);
				recipe.SetResult(ItemID.LeadBar);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.LeadBar);
				recipe.AddTile(TileID.Anvils);
				recipe.SetResult(ItemID.IronBar);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.SilverBar);
				recipe.AddTile(TileID.Anvils);
				recipe.SetResult(ItemID.TungstenBar);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.TungstenBar);
				recipe.AddTile(TileID.Anvils);
				recipe.SetResult(ItemID.SilverBar);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.GoldBar);
				recipe.AddTile(TileID.Anvils);
				recipe.SetResult(ItemID.PlatinumBar);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.PlatinumBar);
				recipe.AddTile(TileID.Anvils);
				recipe.SetResult(ItemID.GoldBar);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.PalladiumBar);
				recipe.AddTile(TileID.Anvils);
				recipe.SetResult(ItemID.CobaltBar);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.CobaltBar);
				recipe.AddTile(TileID.Anvils);
				recipe.SetResult(ItemID.PalladiumBar);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.OrichalcumBar);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.MythrilBar);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.MythrilBar);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.OrichalcumBar);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.OrichalcumBar);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.MythrilBar);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.TitaniumBar);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.AdamantiteBar);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.AdamantiteBar);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.TitaniumBar);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.CrimtaneBar);
				recipe.AddTile(TileID.Anvils);
				recipe.SetResult(ItemID.DemoniteBar);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.DemoniteBar);
				recipe.AddTile(TileID.Anvils);
				recipe.SetResult(ItemID.CrimtaneBar);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.TinBar);
				recipe.AddTile(TileID.Anvils);
				recipe.SetResult(ItemID.CopperBar);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.CopperBar);
				recipe.AddTile(TileID.Anvils);
				recipe.SetResult(ItemID.TinBar);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.Silk, 10);
				recipe.AddIngredient(ItemID.DefenderMedal);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.ApprenticeScarf);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddRecipeGroup("IronBar", 10);
				recipe.AddIngredient(ItemID.DefenderMedal);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.SquireShield);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.Silk, 10);
				recipe.AddIngredient(ItemID.DefenderMedal);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.HuntressBuckler);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.Silk, 10);
				recipe.AddIngredient(ItemID.DefenderMedal);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.MonkBelt);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.BeetleHusk);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.HerculesBeetle);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.Silk, 10);
				recipe.AddIngredient(ItemID.FallenStar, 3);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.DiscountCard);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.Silk, 10);
				recipe.AddIngredient(ItemID.FallenStar, 3);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.GoldRing);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.Glowstick, 30);
				recipe.AddTile(TileID.Anvils);
				recipe.SetResult(ItemID.JellyfishNecklace);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.GoldCoin);
				recipe.AddIngredient(ItemID.FallenStar, 3);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.LuckyCoin);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.CorruptSeeds);
				recipe.AddTile(TileID.WorkBenches);
				recipe.SetResult(ItemID.CrimsonSeeds);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.CrimsonSeeds);
				recipe.AddTile(TileID.WorkBenches);
				recipe.SetResult(ItemID.CorruptSeeds);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.BeeGun);
				recipe.AddTile(TileID.Anvils);
				recipe.SetResult(ItemID.BeeKeeper);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.BeeGun);
				recipe.AddTile(TileID.Anvils);
				recipe.SetResult(ItemID.BeesKnees);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.BeeKeeper);
				recipe.AddTile(TileID.Anvils);
				recipe.SetResult(ItemID.BeeGun);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.BeeKeeper);
				recipe.AddTile(TileID.Anvils);
				recipe.SetResult(ItemID.BeesKnees);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.BeesKnees);
				recipe.AddTile(TileID.Anvils);
				recipe.SetResult(ItemID.BeeKeeper);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.BeesKnees);
				recipe.AddTile(TileID.Anvils);
				recipe.SetResult(ItemID.BeeGun);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.BeeGun);
				recipe.AddTile(TileID.Anvils);
				recipe.SetResult(ItemID.BeeKeeper);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.BreakerBlade);
				recipe.AddTile(TileID.Anvils);
				recipe.SetResult(ItemID.ClockworkAssaultRifle);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.BreakerBlade);
				recipe.AddTile(TileID.Anvils);
				recipe.SetResult(ItemID.LaserRifle);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.ClockworkAssaultRifle);
				recipe.AddTile(TileID.Anvils);
				recipe.SetResult(ItemID.BreakerBlade);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.ClockworkAssaultRifle);
				recipe.AddTile(TileID.Anvils);
				recipe.SetResult(ItemID.LaserRifle);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.LaserRifle);
				recipe.AddTile(TileID.Anvils);
				recipe.SetResult(ItemID.ClockworkAssaultRifle);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.LaserRifle);
				recipe.AddTile(TileID.Anvils);
				recipe.SetResult(ItemID.BreakerBlade);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.PygmyStaff);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.GrenadeLauncher);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.PygmyStaff);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.VenusMagnum);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.PygmyStaff);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.NettleBurst);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.PygmyStaff);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.LeafBlower);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.PygmyStaff);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.FlowerPow);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.PygmyStaff);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.WaspGun);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.PygmyStaff);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.Seedler);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.GrenadeLauncher);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.PygmyStaff);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.GrenadeLauncher);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.VenusMagnum);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.GrenadeLauncher);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.NettleBurst);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.GrenadeLauncher);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.LeafBlower);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.GrenadeLauncher);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.FlowerPow);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.GrenadeLauncher);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.WaspGun);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.GrenadeLauncher);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.Seedler);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.VenusMagnum);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.GrenadeLauncher);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.VenusMagnum);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.NettleBurst);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.VenusMagnum);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.LeafBlower);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.VenusMagnum);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.FlowerPow);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.VenusMagnum);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.WaspGun);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.VenusMagnum);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.Seedler);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.VenusMagnum);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.PygmyStaff);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.NettleBurst);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.GrenadeLauncher);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.NettleBurst);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.VenusMagnum);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.NettleBurst);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.LeafBlower);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.NettleBurst);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.FlowerPow);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.NettleBurst);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.WaspGun);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.NettleBurst);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.Seedler);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.NettleBurst);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.PygmyStaff);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.LeafBlower);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.GrenadeLauncher);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.LeafBlower);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.VenusMagnum);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.LeafBlower);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.NettleBurst);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.LeafBlower);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.FlowerPow);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.LeafBlower);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.WaspGun);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.LeafBlower);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.Seedler);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.LeafBlower);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.PygmyStaff);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.FlowerPow);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.GrenadeLauncher);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.FlowerPow);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.VenusMagnum);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.FlowerPow);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.NettleBurst);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.FlowerPow);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.LeafBlower);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.FlowerPow);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.WaspGun);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.FlowerPow);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.Seedler);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.FlowerPow);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.PygmyStaff);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.WaspGun);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.GrenadeLauncher);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.WaspGun);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.VenusMagnum);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.WaspGun);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.NettleBurst);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.WaspGun);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.LeafBlower);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.WaspGun);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.FlowerPow);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.WaspGun);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.Seedler);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.WaspGun);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.PygmyStaff);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.Seedler);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.GrenadeLauncher);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.Seedler);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.VenusMagnum);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.Seedler);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.NettleBurst);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.Seedler);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.LeafBlower);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.Seedler);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.FlowerPow);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.Seedler);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.WaspGun);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.Seedler);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.PygmyStaff);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.Stynger);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.PossessedHatchet);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.Stynger);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.Picksaw);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.Stynger);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.HeatRay);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.Stynger);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.StaffofEarth);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.Stynger);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.GolemFist);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.PossessedHatchet);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.Stynger);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.PossessedHatchet);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.Picksaw);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.PossessedHatchet);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.HeatRay);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.PossessedHatchet);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.StaffofEarth);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.PossessedHatchet);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.GolemFist);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.Picksaw);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.Stynger);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.Picksaw);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.PossessedHatchet);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.Picksaw);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.HeatRay);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.Picksaw);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.StaffofEarth);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.Picksaw);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.GolemFist);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.HeatRay);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.Stynger);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.HeatRay);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.PossessedHatchet);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.HeatRay);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.Picksaw);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.HeatRay);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.StaffofEarth);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.HeatRay);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.GolemFist);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.StaffofEarth);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.Stynger);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.StaffofEarth);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.PossessedHatchet);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.StaffofEarth);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.Picksaw);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.StaffofEarth);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.HeatRay);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.StaffofEarth);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.GolemFist);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.GolemFist);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.Stynger);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.GolemFist);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.PossessedHatchet);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.GolemFist);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.Picksaw);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.GolemFist);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.HeatRay);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.GolemFist);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.StaffofEarth);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.BubbleGun);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.Flairon);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.BubbleGun);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.RazorbladeTyphoon);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.BubbleGun);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.TempestStaff);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.BubbleGun);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.Tsunami);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.Flairon);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.BubbleGun);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.Flairon);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.RazorbladeTyphoon);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.Flairon);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.TempestStaff);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.Flairon);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.Tsunami);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.RazorbladeTyphoon);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.BubbleGun);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.RazorbladeTyphoon);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.Flairon);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.RazorbladeTyphoon);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.TempestStaff);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.RazorbladeTyphoon);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.Tsunami);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.TempestStaff);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.BubbleGun);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.TempestStaff);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.Flairon);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.TempestStaff);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.RazorbladeTyphoon);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.TempestStaff);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.Tsunami);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.Tsunami);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.BubbleGun);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.Tsunami);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.Flairon);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.Tsunami);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.RazorbladeTyphoon);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.Tsunami);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.TempestStaff);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.PortalGun);
				recipe.AddTile(TileID.LunarCraftingStation);
				recipe.SetResult(ItemID.Meowmere);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.PortalGun);
				recipe.AddTile(TileID.LunarCraftingStation);
				recipe.SetResult(ItemID.Terrarian);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.PortalGun);
				recipe.AddTile(TileID.LunarCraftingStation);
				recipe.SetResult(ItemID.StarWrath);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.PortalGun);
				recipe.AddTile(TileID.LunarCraftingStation);
				recipe.SetResult(ItemID.SDMG);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.PortalGun);
				recipe.AddTile(TileID.LunarCraftingStation);
				recipe.SetResult(ItemID.FireworksLauncher);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.PortalGun);
				recipe.AddTile(TileID.LunarCraftingStation);
				recipe.SetResult(ItemID.LastPrism);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.PortalGun);
				recipe.AddTile(TileID.LunarCraftingStation);
				recipe.SetResult(ItemID.LunarFlareBook);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.PortalGun);
				recipe.AddTile(TileID.LunarCraftingStation);
				recipe.SetResult(ItemID.RainbowCrystalStaff);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.PortalGun);
				recipe.AddTile(TileID.LunarCraftingStation);
				recipe.SetResult(ItemID.MoonlordTurretStaff);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.Meowmere);
				recipe.AddTile(TileID.LunarCraftingStation);
				recipe.SetResult(ItemID.PortalGun);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.Meowmere);
				recipe.AddTile(TileID.LunarCraftingStation);
				recipe.SetResult(ItemID.Terrarian);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.Meowmere);
				recipe.AddTile(TileID.LunarCraftingStation);
				recipe.SetResult(ItemID.StarWrath);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.Meowmere);
				recipe.AddTile(TileID.LunarCraftingStation);
				recipe.SetResult(ItemID.SDMG);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.Meowmere);
				recipe.AddTile(TileID.LunarCraftingStation);
				recipe.SetResult(ItemID.FireworksLauncher);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.Meowmere);
				recipe.AddTile(TileID.LunarCraftingStation);
				recipe.SetResult(ItemID.LastPrism);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.Meowmere);
				recipe.AddTile(TileID.LunarCraftingStation);
				recipe.SetResult(ItemID.LunarFlareBook);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.Meowmere);
				recipe.AddTile(TileID.LunarCraftingStation);
				recipe.SetResult(ItemID.RainbowCrystalStaff);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.Meowmere);
				recipe.AddTile(TileID.LunarCraftingStation);
				recipe.SetResult(ItemID.MoonlordTurretStaff);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.Terrarian);
				recipe.AddTile(TileID.LunarCraftingStation);
				recipe.SetResult(ItemID.PortalGun);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.Terrarian);
				recipe.AddTile(TileID.LunarCraftingStation);
				recipe.SetResult(ItemID.Meowmere);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.Terrarian);
				recipe.AddTile(TileID.LunarCraftingStation);
				recipe.SetResult(ItemID.StarWrath);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.Terrarian);
				recipe.AddTile(TileID.LunarCraftingStation);
				recipe.SetResult(ItemID.SDMG);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.Terrarian);
				recipe.AddTile(TileID.LunarCraftingStation);
				recipe.SetResult(ItemID.FireworksLauncher);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.Terrarian);
				recipe.AddTile(TileID.LunarCraftingStation);
				recipe.SetResult(ItemID.LastPrism);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.Terrarian);
				recipe.AddTile(TileID.LunarCraftingStation);
				recipe.SetResult(ItemID.LunarFlareBook);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.Terrarian);
				recipe.AddTile(TileID.LunarCraftingStation);
				recipe.SetResult(ItemID.RainbowCrystalStaff);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.Terrarian);
				recipe.AddTile(TileID.LunarCraftingStation);
				recipe.SetResult(ItemID.MoonlordTurretStaff);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.StarWrath);
				recipe.AddTile(TileID.LunarCraftingStation);
				recipe.SetResult(ItemID.PortalGun);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.StarWrath);
				recipe.AddTile(TileID.LunarCraftingStation);
				recipe.SetResult(ItemID.Meowmere);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.StarWrath);
				recipe.AddTile(TileID.LunarCraftingStation);
				recipe.SetResult(ItemID.Terrarian);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.StarWrath);
				recipe.AddTile(TileID.LunarCraftingStation);
				recipe.SetResult(ItemID.SDMG);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.StarWrath);
				recipe.AddTile(TileID.LunarCraftingStation);
				recipe.SetResult(ItemID.FireworksLauncher);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.StarWrath);
				recipe.AddTile(TileID.LunarCraftingStation);
				recipe.SetResult(ItemID.LastPrism);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.StarWrath);
				recipe.AddTile(TileID.LunarCraftingStation);
				recipe.SetResult(ItemID.LunarFlareBook);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.StarWrath);
				recipe.AddTile(TileID.LunarCraftingStation);
				recipe.SetResult(ItemID.RainbowCrystalStaff);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.StarWrath);
				recipe.AddTile(TileID.LunarCraftingStation);
				recipe.SetResult(ItemID.MoonlordTurretStaff);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.SDMG);
				recipe.AddTile(TileID.LunarCraftingStation);
				recipe.SetResult(ItemID.PortalGun);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.SDMG);
				recipe.AddTile(TileID.LunarCraftingStation);
				recipe.SetResult(ItemID.Meowmere);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.SDMG);
				recipe.AddTile(TileID.LunarCraftingStation);
				recipe.SetResult(ItemID.Terrarian);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.SDMG);
				recipe.AddTile(TileID.LunarCraftingStation);
				recipe.SetResult(ItemID.StarWrath);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.SDMG);
				recipe.AddTile(TileID.LunarCraftingStation);
				recipe.SetResult(ItemID.FireworksLauncher);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.SDMG);
				recipe.AddTile(TileID.LunarCraftingStation);
				recipe.SetResult(ItemID.LastPrism);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.SDMG);
				recipe.AddTile(TileID.LunarCraftingStation);
				recipe.SetResult(ItemID.LunarFlareBook);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.SDMG);
				recipe.AddTile(TileID.LunarCraftingStation);
				recipe.SetResult(ItemID.RainbowCrystalStaff);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.SDMG);
				recipe.AddTile(TileID.LunarCraftingStation);
				recipe.SetResult(ItemID.MoonlordTurretStaff);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.FireworksLauncher);
				recipe.AddTile(TileID.LunarCraftingStation);
				recipe.SetResult(ItemID.PortalGun);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.FireworksLauncher);
				recipe.AddTile(TileID.LunarCraftingStation);
				recipe.SetResult(ItemID.Meowmere);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.FireworksLauncher);
				recipe.AddTile(TileID.LunarCraftingStation);
				recipe.SetResult(ItemID.Terrarian);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.FireworksLauncher);
				recipe.AddTile(TileID.LunarCraftingStation);
				recipe.SetResult(ItemID.StarWrath);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.FireworksLauncher);
				recipe.AddTile(TileID.LunarCraftingStation);
				recipe.SetResult(ItemID.SDMG);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.FireworksLauncher);
				recipe.AddTile(TileID.LunarCraftingStation);
				recipe.SetResult(ItemID.LastPrism);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.FireworksLauncher);
				recipe.AddTile(TileID.LunarCraftingStation);
				recipe.SetResult(ItemID.LunarFlareBook);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.FireworksLauncher);
				recipe.AddTile(TileID.LunarCraftingStation);
				recipe.SetResult(ItemID.RainbowCrystalStaff);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.FireworksLauncher);
				recipe.AddTile(TileID.LunarCraftingStation);
				recipe.SetResult(ItemID.MoonlordTurretStaff);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.LastPrism);
				recipe.AddTile(TileID.LunarCraftingStation);
				recipe.SetResult(ItemID.PortalGun);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.LastPrism);
				recipe.AddTile(TileID.LunarCraftingStation);
				recipe.SetResult(ItemID.Meowmere);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.LastPrism);
				recipe.AddTile(TileID.LunarCraftingStation);
				recipe.SetResult(ItemID.Terrarian);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.LastPrism);
				recipe.AddTile(TileID.LunarCraftingStation);
				recipe.SetResult(ItemID.StarWrath);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.LastPrism);
				recipe.AddTile(TileID.LunarCraftingStation);
				recipe.SetResult(ItemID.SDMG);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.LastPrism);
				recipe.AddTile(TileID.LunarCraftingStation);
				recipe.SetResult(ItemID.FireworksLauncher);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.LastPrism);
				recipe.AddTile(TileID.LunarCraftingStation);
				recipe.SetResult(ItemID.LunarFlareBook);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.LastPrism);
				recipe.AddTile(TileID.LunarCraftingStation);
				recipe.SetResult(ItemID.RainbowCrystalStaff);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.LastPrism);
				recipe.AddTile(TileID.LunarCraftingStation);
				recipe.SetResult(ItemID.MoonlordTurretStaff);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.LunarFlareBook);
				recipe.AddTile(TileID.LunarCraftingStation);
				recipe.SetResult(ItemID.PortalGun);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.LunarFlareBook);
				recipe.AddTile(TileID.LunarCraftingStation);
				recipe.SetResult(ItemID.Meowmere);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.LunarFlareBook);
				recipe.AddTile(TileID.LunarCraftingStation);
				recipe.SetResult(ItemID.Terrarian);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.LunarFlareBook);
				recipe.AddTile(TileID.LunarCraftingStation);
				recipe.SetResult(ItemID.StarWrath);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.LunarFlareBook);
				recipe.AddTile(TileID.LunarCraftingStation);
				recipe.SetResult(ItemID.SDMG);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.LunarFlareBook);
				recipe.AddTile(TileID.LunarCraftingStation);
				recipe.SetResult(ItemID.FireworksLauncher);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.LunarFlareBook);
				recipe.AddTile(TileID.LunarCraftingStation);
				recipe.SetResult(ItemID.LastPrism);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.LunarFlareBook);
				recipe.AddTile(TileID.LunarCraftingStation);
				recipe.SetResult(ItemID.RainbowCrystalStaff);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.LunarFlareBook);
				recipe.AddTile(TileID.LunarCraftingStation);
				recipe.SetResult(ItemID.MoonlordTurretStaff);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.RainbowCrystalStaff);
				recipe.AddTile(TileID.LunarCraftingStation);
				recipe.SetResult(ItemID.PortalGun);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.RainbowCrystalStaff);
				recipe.AddTile(TileID.LunarCraftingStation);
				recipe.SetResult(ItemID.Meowmere);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.RainbowCrystalStaff);
				recipe.AddTile(TileID.LunarCraftingStation);
				recipe.SetResult(ItemID.Terrarian);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.RainbowCrystalStaff);
				recipe.AddTile(TileID.LunarCraftingStation);
				recipe.SetResult(ItemID.StarWrath);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.RainbowCrystalStaff);
				recipe.AddTile(TileID.LunarCraftingStation);
				recipe.SetResult(ItemID.SDMG);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.RainbowCrystalStaff);
				recipe.AddTile(TileID.LunarCraftingStation);
				recipe.SetResult(ItemID.FireworksLauncher);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.RainbowCrystalStaff);
				recipe.AddTile(TileID.LunarCraftingStation);
				recipe.SetResult(ItemID.LastPrism);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.RainbowCrystalStaff);
				recipe.AddTile(TileID.LunarCraftingStation);
				recipe.SetResult(ItemID.LunarFlareBook);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.RainbowCrystalStaff);
				recipe.AddTile(TileID.LunarCraftingStation);
				recipe.SetResult(ItemID.MoonlordTurretStaff);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.MoonlordTurretStaff);
				recipe.AddTile(TileID.LunarCraftingStation);
				recipe.SetResult(ItemID.PortalGun);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.MoonlordTurretStaff);
				recipe.AddTile(TileID.LunarCraftingStation);
				recipe.SetResult(ItemID.Meowmere);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.MoonlordTurretStaff);
				recipe.AddTile(TileID.LunarCraftingStation);
				recipe.SetResult(ItemID.Terrarian);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.MoonlordTurretStaff);
				recipe.AddTile(TileID.LunarCraftingStation);
				recipe.SetResult(ItemID.StarWrath);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.MoonlordTurretStaff);
				recipe.AddTile(TileID.LunarCraftingStation);
				recipe.SetResult(ItemID.SDMG);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.MoonlordTurretStaff);
				recipe.AddTile(TileID.LunarCraftingStation);
				recipe.SetResult(ItemID.FireworksLauncher);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.MoonlordTurretStaff);
				recipe.AddTile(TileID.LunarCraftingStation);
				recipe.SetResult(ItemID.LastPrism);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.MoonlordTurretStaff);
				recipe.AddTile(TileID.LunarCraftingStation);
				recipe.SetResult(ItemID.LunarFlareBook);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.MoonlordTurretStaff);
				recipe.AddTile(TileID.LunarCraftingStation);
				recipe.SetResult(ItemID.RainbowCrystalStaff);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.FragmentVortex);
				recipe.AddTile(TileID.LunarCraftingStation);
				recipe.SetResult(ItemID.FragmentNebula);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.FragmentVortex);
				recipe.AddTile(TileID.LunarCraftingStation);
				recipe.SetResult(ItemID.FragmentSolar);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.FragmentVortex);
				recipe.AddTile(TileID.LunarCraftingStation);
				recipe.SetResult(ItemID.FragmentStardust);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.FragmentNebula);
				recipe.AddTile(TileID.LunarCraftingStation);
				recipe.SetResult(ItemID.FragmentVortex);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.FragmentNebula);
				recipe.AddTile(TileID.LunarCraftingStation);
				recipe.SetResult(ItemID.FragmentSolar);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.FragmentNebula);
				recipe.AddTile(TileID.LunarCraftingStation);
				recipe.SetResult(ItemID.FragmentStardust);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.FragmentSolar);
				recipe.AddTile(TileID.LunarCraftingStation);
				recipe.SetResult(ItemID.FragmentVortex);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.FragmentSolar);
				recipe.AddTile(TileID.LunarCraftingStation);
				recipe.SetResult(ItemID.FragmentNebula);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.FragmentSolar);
				recipe.AddTile(TileID.LunarCraftingStation);
				recipe.SetResult(ItemID.FragmentStardust);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.FragmentStardust);
				recipe.AddTile(TileID.LunarCraftingStation);
				recipe.SetResult(ItemID.FragmentVortex);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.FragmentStardust);
				recipe.AddTile(TileID.LunarCraftingStation);
				recipe.SetResult(ItemID.FragmentNebula);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.FragmentStardust);
				recipe.AddTile(TileID.LunarCraftingStation);
				recipe.SetResult(ItemID.FragmentSolar);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.SoulofSight);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.SoulofMight);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.SoulofSight);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.SoulofFright);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.SoulofMight);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.SoulofSight);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.SoulofMight);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.SoulofFright);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.SoulofFright);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.SoulofSight);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.SoulofFright);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.SoulofMight);
				recipe.AddRecipe();
				
				
				//version 0.2 : event boss and moom lord craftable items
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.CursedFlame);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.Ichor);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.Ichor);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.CursedFlame);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.CursedSapling);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.SpookyTwig);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.CursedSapling);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.SpookyHook);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.CursedSapling);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.NecromanticScroll);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.CursedSapling);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.StakeLauncher);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.SpookyTwig);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.CursedSapling);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.SpookyTwig);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.SpookyHook);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.SpookyTwig);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.NecromanticScroll);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.SpookyTwig);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.StakeLauncher);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.SpookyHook);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.CursedSapling);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.SpookyHook);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.SpookyTwig);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.SpookyHook);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.NecromanticScroll);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.SpookyHook);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.StakeLauncher);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.NecromanticScroll);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.CursedSapling);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.NecromanticScroll);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.SpookyTwig);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.NecromanticScroll);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.SpookyHook);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.NecromanticScroll);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.StakeLauncher);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.StakeLauncher);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.CursedSapling);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.StakeLauncher);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.SpookyTwig);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.StakeLauncher);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.SpookyHook);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.StakeLauncher);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.NecromanticScroll);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.SpookyWood, 30);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.StakeLauncher);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.SpookyWood, 30);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.CursedSapling);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.SpookyWood, 30);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.SpookyTwig);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.SpookyWood, 30);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.SpookyHook);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.SpookyWood, 30);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.NecromanticScroll);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.TheHorsemansBlade);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.BatScepter);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.TheHorsemansBlade);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.BlackFairyDust);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.TheHorsemansBlade);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.SpiderEgg);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.TheHorsemansBlade);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.RavenStaff);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.TheHorsemansBlade);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.CandyCornRifle);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.TheHorsemansBlade);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.JackOLanternLauncher);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.BatScepter);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.TheHorsemansBlade);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.BatScepter);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.BlackFairyDust);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.BatScepter);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.SpiderEgg);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.BatScepter);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.RavenStaff);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.BatScepter);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.CandyCornRifle);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.BatScepter);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.JackOLanternLauncher);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.BlackFairyDust);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.TheHorsemansBlade);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.BlackFairyDust);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.BatScepter);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.BlackFairyDust);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.SpiderEgg);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.BlackFairyDust);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.RavenStaff);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.BlackFairyDust);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.CandyCornRifle);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.BlackFairyDust);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.JackOLanternLauncher);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.SpiderEgg);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.TheHorsemansBlade);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.SpiderEgg);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.BatScepter);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.SpiderEgg);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.BlackFairyDust);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.SpiderEgg);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.RavenStaff);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.SpiderEgg);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.CandyCornRifle);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.SpiderEgg);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.JackOLanternLauncher);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.RavenStaff);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.TheHorsemansBlade);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.RavenStaff);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.BatScepter);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.RavenStaff);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.BlackFairyDust);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.RavenStaff);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.SpiderEgg);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.RavenStaff);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.CandyCornRifle);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.RavenStaff);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.JackOLanternLauncher);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.CandyCornRifle);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.TheHorsemansBlade);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.CandyCornRifle);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.BatScepter);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.CandyCornRifle);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.BlackFairyDust);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.CandyCornRifle);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.SpiderEgg);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.CandyCornRifle);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.RavenStaff);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.CandyCornRifle);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.JackOLanternLauncher);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.JackOLanternLauncher);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.TheHorsemansBlade);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.JackOLanternLauncher);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.BatScepter);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.JackOLanternLauncher);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.BlackFairyDust);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.JackOLanternLauncher);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.SpiderEgg);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.JackOLanternLauncher);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.RavenStaff);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.JackOLanternLauncher);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.CandyCornRifle);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.SpookyWood, 40);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.JackOLanternLauncher);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.SpookyWood, 40);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.TheHorsemansBlade);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.SpookyWood, 40);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.BatScepter);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.SpookyWood, 40);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.BlackFairyDust);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.SpookyWood, 40);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.SpiderEgg);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.SpookyWood, 40);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.RavenStaff);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.SpookyWood, 40);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.CandyCornRifle);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.ChristmasTreeSword);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.ChristmasHook);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.ChristmasTreeSword);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.Razorpine);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.ChristmasTreeSword);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.FestiveWings);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.ChristmasHook);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.ChristmasTreeSword);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.ChristmasHook);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.Razorpine);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.ChristmasHook);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.FestiveWings);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.Razorpine);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.ChristmasTreeSword);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.Razorpine);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.ChristmasHook);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.Razorpine);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.FestiveWings);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.FestiveWings);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.ChristmasTreeSword);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.FestiveWings);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.ChristmasHook);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.FestiveWings);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.Razorpine);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.EldMelter);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.ChainGun);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.ChainGun);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.EldMelter);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.SnowmanCannon);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.NorthPole);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.SnowmanCannon);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.BlizzardStaff);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.SnowmanCannon);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.BabyGrinchMischiefWhistle);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.SnowmanCannon);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.ReindeerBells);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.NorthPole);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.SnowmanCannon);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.NorthPole);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.BlizzardStaff);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.NorthPole);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.BabyGrinchMischiefWhistle);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.NorthPole);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.ReindeerBells);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.BlizzardStaff);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.SnowmanCannon);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.BlizzardStaff);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.NorthPole);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.BlizzardStaff);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.BabyGrinchMischiefWhistle);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.BlizzardStaff);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.ReindeerBells);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.BabyGrinchMischiefWhistle);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.SnowmanCannon);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.BabyGrinchMischiefWhistle);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.NorthPole);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.BabyGrinchMischiefWhistle);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.BlizzardStaff);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.BabyGrinchMischiefWhistle);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.ReindeerBells);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.ReindeerBells);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.SnowmanCannon);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.ReindeerBells);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.NorthPole);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.ReindeerBells);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.BlizzardStaff);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.ReindeerBells);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.BabyGrinchMischiefWhistle);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.CoinGun);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.LuckyCoin);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.CoinGun);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.LuckyCoin);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.CoinGun);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.DiscountCard);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.CoinGun);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.PirateStaff);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.CoinGun);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.GoldRing);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.CoinGun);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.Cutlass);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.LuckyCoin);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.CoinGun);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.LuckyCoin);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.DiscountCard);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.LuckyCoin);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.PirateStaff);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.LuckyCoin);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.GoldRing);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.LuckyCoin);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.Cutlass);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.DiscountCard);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.CoinGun);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.DiscountCard);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.LuckyCoin);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.DiscountCard);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.PirateStaff);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.DiscountCard);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.GoldRing);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.DiscountCard);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.Cutlass);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.PirateStaff);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.CoinGun);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.PirateStaff);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.LuckyCoin);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.PirateStaff);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.DiscountCard);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.PirateStaff);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.GoldRing);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.PirateStaff);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.Cutlass);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.GoldRing);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.CoinGun);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.GoldRing);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.LuckyCoin);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.GoldRing);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.DiscountCard);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.GoldRing);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.PirateStaff);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.GoldRing);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.Cutlass);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.Cutlass);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.CoinGun);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.Cutlass);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.LuckyCoin);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.Cutlass);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.DiscountCard);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.Cutlass);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.PirateStaff);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.Cutlass);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.GoldRing);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.Xenopopper);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.XenoStaff);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.Xenopopper);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.LaserMachinegun);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.Xenopopper);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.LaserDrill);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.Xenopopper);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.ElectrosphereLauncher);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.Xenopopper);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.ChargedBlasterCannon);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.Xenopopper);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.InfluxWaver);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.Xenopopper);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.CosmicCarKey);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.Xenopopper);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.AntiGravityHook);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.XenoStaff);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.Xenopopper);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.XenoStaff);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.LaserMachinegun);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.XenoStaff);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.LaserDrill);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.XenoStaff);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.ElectrosphereLauncher);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.XenoStaff);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.ChargedBlasterCannon);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.XenoStaff);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.InfluxWaver);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.XenoStaff);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.CosmicCarKey);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.XenoStaff);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.AntiGravityHook);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.LaserMachinegun);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.Xenopopper);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.LaserMachinegun);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.XenoStaff);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.LaserMachinegun);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.LaserDrill);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.LaserMachinegun);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.ElectrosphereLauncher);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.LaserMachinegun);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.ChargedBlasterCannon);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.LaserMachinegun);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.InfluxWaver);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.LaserMachinegun);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.CosmicCarKey);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.LaserMachinegun);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.AntiGravityHook);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.LaserDrill);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.Xenopopper);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.LaserDrill);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.XenoStaff);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.LaserDrill);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.LaserMachinegun);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.LaserDrill);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.ElectrosphereLauncher);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.LaserDrill);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.ChargedBlasterCannon);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.LaserDrill);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.InfluxWaver);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.LaserDrill);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.CosmicCarKey);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.LaserDrill);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.AntiGravityHook);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.ElectrosphereLauncher);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.Xenopopper);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.ElectrosphereLauncher);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.XenoStaff);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.ElectrosphereLauncher);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.LaserMachinegun);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.ElectrosphereLauncher);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.LaserDrill);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.ElectrosphereLauncher);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.ChargedBlasterCannon);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.ElectrosphereLauncher);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.InfluxWaver);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.ElectrosphereLauncher);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.CosmicCarKey);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.ElectrosphereLauncher);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.AntiGravityHook);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.ChargedBlasterCannon);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.Xenopopper);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.ChargedBlasterCannon);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.XenoStaff);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.ChargedBlasterCannon);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.LaserMachinegun);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.ChargedBlasterCannon);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.LaserDrill);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.ChargedBlasterCannon);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.ElectrosphereLauncher);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.ChargedBlasterCannon);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.InfluxWaver);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.ChargedBlasterCannon);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.CosmicCarKey);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.ChargedBlasterCannon);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.AntiGravityHook);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.InfluxWaver);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.Xenopopper);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.InfluxWaver);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.XenoStaff);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.InfluxWaver);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.LaserMachinegun);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.InfluxWaver);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.LaserDrill);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.InfluxWaver);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.ElectrosphereLauncher);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.InfluxWaver);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.ChargedBlasterCannon);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.InfluxWaver);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.CosmicCarKey);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.InfluxWaver);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.AntiGravityHook);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.CosmicCarKey);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.Xenopopper);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.CosmicCarKey);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.XenoStaff);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.CosmicCarKey);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.LaserMachinegun);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.CosmicCarKey);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.LaserDrill);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.CosmicCarKey);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.ElectrosphereLauncher);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.CosmicCarKey);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.ChargedBlasterCannon);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.CosmicCarKey);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.InfluxWaver);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.CosmicCarKey);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.AntiGravityHook);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.AntiGravityHook);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.Xenopopper);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.AntiGravityHook);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.XenoStaff);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.AntiGravityHook);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.LaserMachinegun);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.AntiGravityHook);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.LaserDrill);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.AntiGravityHook);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.ElectrosphereLauncher);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.AntiGravityHook);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.ChargedBlasterCannon);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.AntiGravityHook);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.InfluxWaver);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.AntiGravityHook);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.CosmicCarKey);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.MartianConduitPlating, 100);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.AntiGravityHook);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.MartianConduitPlating, 100);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.Xenopopper);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.MartianConduitPlating, 100);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.XenoStaff);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.MartianConduitPlating, 100);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.LaserMachinegun);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.MartianConduitPlating, 100);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.LaserDrill);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.MartianConduitPlating, 100);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.ElectrosphereLauncher);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.MartianConduitPlating, 100);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.ChargedBlasterCannon);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.MartianConduitPlating, 100);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.InfluxWaver);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.MartianConduitPlating, 100);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.CosmicCarKey);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.MartianConduitPlating, 100);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.BrainScrambler);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.LunarBar, 10);
				recipe.AddTile(TileID.LunarCraftingStation);
				recipe.SetResult(ItemID.Meowmere);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.LunarBar, 10);
				recipe.AddTile(TileID.LunarCraftingStation);
				recipe.SetResult(ItemID.Terrarian);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.LunarBar, 10);
				recipe.AddTile(TileID.LunarCraftingStation);
				recipe.SetResult(ItemID.StarWrath);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.LunarBar, 10);
				recipe.AddTile(TileID.LunarCraftingStation);
				recipe.SetResult(ItemID.SDMG);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.LunarBar, 10);
				recipe.AddTile(TileID.LunarCraftingStation);
				recipe.SetResult(ItemID.FireworksLauncher);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.LunarBar, 10);
				recipe.AddTile(TileID.LunarCraftingStation);
				recipe.SetResult(ItemID.LastPrism);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.LunarBar, 10);
				recipe.AddTile(TileID.LunarCraftingStation);
				recipe.SetResult(ItemID.LunarFlareBook);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.LunarBar, 10);
				recipe.AddTile(TileID.LunarCraftingStation);
				recipe.SetResult(ItemID.RainbowCrystalStaff);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.LunarBar, 10);
				recipe.AddTile(TileID.LunarCraftingStation);
				recipe.SetResult(ItemID.MoonlordTurretStaff);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.LunarBar, 10);
				recipe.AddTile(TileID.LunarCraftingStation);
				recipe.SetResult(ItemID.PortalGun);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.WarTable);
				recipe.AddTile(TileID.Anvils);
				recipe.SetResult(ItemID.WarTableBanner);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.WarTable);
				recipe.AddTile(TileID.Anvils);
				recipe.SetResult(ItemID.DD2PetDragon);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.WarTable);
				recipe.AddTile(TileID.Anvils);
				recipe.SetResult(ItemID.DD2PetGato);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.WarTableBanner);
				recipe.AddTile(TileID.Anvils);
				recipe.SetResult(ItemID.WarTable);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.WarTableBanner);
				recipe.AddTile(TileID.Anvils);
				recipe.SetResult(ItemID.DD2PetDragon);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.WarTableBanner);
				recipe.AddTile(TileID.Anvils);
				recipe.SetResult(ItemID.DD2PetGato);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.DD2PetDragon);
				recipe.AddTile(TileID.Anvils);
				recipe.SetResult(ItemID.WarTable);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.DD2PetDragon);
				recipe.AddTile(TileID.Anvils);
				recipe.SetResult(ItemID.WarTableBanner);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.DD2PetDragon);
				recipe.AddTile(TileID.Anvils);
				recipe.SetResult(ItemID.DD2PetGato);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.DD2PetGato);
				recipe.AddTile(TileID.Anvils);
				recipe.SetResult(ItemID.WarTable);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.DD2PetGato);
				recipe.AddTile(TileID.Anvils);
				recipe.SetResult(ItemID.WarTableBanner);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.ApprenticeScarf);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.SquireShield);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.ApprenticeScarf);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.HuntressBuckler);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.ApprenticeScarf);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.MonkBelt);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.ApprenticeScarf);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.BookStaff);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.ApprenticeScarf);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.DD2PhoenixBow);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.ApprenticeScarf);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.DD2SquireDemonSword);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.ApprenticeScarf);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.MonkStaffT1);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.ApprenticeScarf);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.MonkStaffT2);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.ApprenticeScarf);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.DD2PetGhost);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.SquireShield);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.ApprenticeScarf);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.SquireShield);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.HuntressBuckler);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.SquireShield);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.MonkBelt);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.SquireShield);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.BookStaff);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.SquireShield);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.DD2PhoenixBow);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.SquireShield);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.DD2SquireDemonSword);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.SquireShield);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.MonkStaffT1);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.SquireShield);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.MonkStaffT2);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.SquireShield);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.DD2PetGhost);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.HuntressBuckler);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.ApprenticeScarf);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.HuntressBuckler);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.SquireShield);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.HuntressBuckler);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.MonkBelt);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.HuntressBuckler);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.BookStaff);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.HuntressBuckler);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.DD2PhoenixBow);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.HuntressBuckler);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.DD2SquireDemonSword);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.HuntressBuckler);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.MonkStaffT1);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.HuntressBuckler);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.MonkStaffT2);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.HuntressBuckler);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.DD2PetGhost);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.MonkBelt);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.ApprenticeScarf);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.MonkBelt);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.SquireShield);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.MonkBelt);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.HuntressBuckler);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.MonkBelt);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.BookStaff);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.MonkBelt);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.DD2PhoenixBow);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.MonkBelt);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.DD2SquireDemonSword);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.MonkBelt);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.MonkStaffT1);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.MonkBelt);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.MonkStaffT2);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.MonkBelt);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.DD2PetGhost);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.BookStaff);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.ApprenticeScarf);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.BookStaff);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.SquireShield);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.BookStaff);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.HuntressBuckler);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.BookStaff);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.MonkBelt);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.BookStaff);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.DD2PhoenixBow);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.BookStaff);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.DD2SquireDemonSword);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.BookStaff);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.MonkStaffT1);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.BookStaff);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.MonkStaffT2);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.BookStaff);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.DD2PetGhost);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.DD2PhoenixBow);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.ApprenticeScarf);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.DD2PhoenixBow);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.SquireShield);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.DD2PhoenixBow);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.HuntressBuckler);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.DD2PhoenixBow);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.MonkBelt);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.DD2PhoenixBow);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.BookStaff);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.DD2PhoenixBow);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.DD2SquireDemonSword);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.DD2PhoenixBow);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.MonkStaffT1);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.DD2PhoenixBow);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.MonkStaffT2);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.DD2PhoenixBow);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.DD2PetGhost);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.DD2SquireDemonSword);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.ApprenticeScarf);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.DD2SquireDemonSword);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.SquireShield);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.DD2SquireDemonSword);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.HuntressBuckler);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.DD2SquireDemonSword);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.MonkBelt);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.DD2SquireDemonSword);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.DD2PhoenixBow);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.DD2SquireDemonSword);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.BookStaff);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.DD2SquireDemonSword);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.MonkStaffT1);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.DD2SquireDemonSword);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.MonkStaffT2);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.DD2SquireDemonSword);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.DD2PetGhost);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.MonkStaffT1);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.ApprenticeScarf);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.MonkStaffT1);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.SquireShield);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.MonkStaffT1);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.HuntressBuckler);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.MonkStaffT1);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.MonkBelt);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.MonkStaffT1);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.BookStaff);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.MonkStaffT1);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.DD2SquireDemonSword);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.MonkStaffT1);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.DD2PhoenixBow);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.MonkStaffT1);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.MonkStaffT2);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.MonkStaffT1);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.DD2PetGhost);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.MonkStaffT2);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.ApprenticeScarf);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.MonkStaffT2);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.SquireShield);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.MonkStaffT2);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.HuntressBuckler);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.MonkStaffT2);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.MonkBelt);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.MonkStaffT2);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.DD2PhoenixBow);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.MonkStaffT2);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.BookStaff);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.MonkStaffT2);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.MonkStaffT1);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.MonkStaffT2);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.DD2SquireDemonSword);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.MonkStaffT2);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.DD2PetGhost);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.DD2PetGhost);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.ApprenticeScarf);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.DD2PetGhost);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.SquireShield);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.DD2PetGhost);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.HuntressBuckler);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.DD2PetGhost);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.MonkBelt);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.DD2PetGhost);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.DD2PhoenixBow);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.DD2PetGhost);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.BookStaff);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.DD2PetGhost);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.MonkStaffT1);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.DD2PetGhost);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.DD2SquireDemonSword);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.DD2PetGhost);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.MonkStaffT2);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.DD2BetsyBow);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.MonkStaffT3);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.DD2BetsyBow);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.ApprenticeStaffT3);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.DD2BetsyBow);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.DD2SquireBetsySword);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.DD2BetsyBow);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.BetsyWings);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.MonkStaffT3);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.DD2BetsyBow);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.MonkStaffT3);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.ApprenticeStaffT3);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.MonkStaffT3);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.DD2SquireBetsySword);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.MonkStaffT3);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.BetsyWings);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.ApprenticeStaffT3);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.DD2BetsyBow);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.ApprenticeStaffT3);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.MonkStaffT3);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.ApprenticeStaffT3);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.DD2SquireBetsySword);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.ApprenticeStaffT3);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.BetsyWings);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.DD2SquireBetsySword);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.DD2BetsyBow);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.DD2SquireBetsySword);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.MonkStaffT3);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.DD2SquireBetsySword);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.ApprenticeStaffT3);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.DD2SquireBetsySword);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.BetsyWings);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.BetsyWings);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.DD2BetsyBow);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.BetsyWings);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.MonkStaffT3);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.BetsyWings);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.ApprenticeStaffT3);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.BetsyWings);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.DD2SquireBetsySword);
				recipe.AddRecipe();
				
				//verion 0.3 make craftable all boss item (moon lord, pumpin moon and martian madness already done)
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(null, "SnowPowerCell", 2);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.ChristmasHook);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(null, "SnowPowerCell", 2);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.ChristmasTreeSword);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(null, "SnowPowerCell", 2);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.Razorpine);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(null, "SnowPowerCell", 2);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.FestiveWings);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(null, "SnowPowerCell", 2);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.ChainGun);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(null, "SnowPowerCell", 2);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.EldMelter);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(null, "SnowPowerCell", 2);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.NorthPole);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(null, "SnowPowerCell", 2);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.BlizzardStaff);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(null, "SnowPowerCell", 2);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.BabyGrinchMischiefWhistle);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(null, "SnowPowerCell", 2);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.ReindeerBells);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(null, "SnowPowerCell", 2);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.SnowmanCannon);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(null, "ShinyGoldBar", 30);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.GoldenBathtub);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(null, "ShinyGoldBar", 30);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.GoldenBed);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(null, "ShinyGoldBar", 30);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.GoldenBookcase);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(null, "ShinyGoldBar", 30);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.GoldenCandelabra);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(null, "ShinyGoldBar", 30);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.GoldenCandle);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(null, "ShinyGoldBar", 30);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.GoldenChair);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(null, "ShinyGoldBar", 30);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.GoldenChest);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(null, "ShinyGoldBar", 30);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.GoldenChandelier);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(null, "ShinyGoldBar", 30);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.GoldenDoor);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(null, "ShinyGoldBar", 30);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.GoldenDresser);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(null, "ShinyGoldBar", 30);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.GoldenClock);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(null, "ShinyGoldBar", 30);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.GoldenLamp);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(null, "ShinyGoldBar", 30);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.GoldenLantern);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(null, "ShinyGoldBar", 30);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.GoldenPiano);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(null, "ShinyGoldBar", 30);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.GoldenSink);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(null, "ShinyGoldBar", 30);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.GoldenSofa);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(null, "ShinyGoldBar");
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.GoldenPlatform, 2);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(null, "ShinyGoldBar", 30);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.GoldenTable);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(null, "ShinyGoldBar", 30);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.GoldenToilet);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(null, "ShinyGoldBar", 30);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.GoldenWorkbench);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.GoldenPlatform, 2);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(null, "ShinyGoldBar");
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(null, "RegalGel");
				recipe.AddTile(TileID.Anvils);
				recipe.SetResult(ItemID.SlimySaddle);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(null, "RegalGel");
				recipe.AddTile(TileID.Anvils);
				recipe.SetResult(ItemID.NinjaHood);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(null, "RegalGel");
				recipe.AddTile(TileID.Anvils);
				recipe.SetResult(ItemID.NinjaShirt);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(null, "RegalGel");
				recipe.AddTile(TileID.Anvils);
				recipe.SetResult(ItemID.NinjaPants);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.NinjaHood);
				recipe.AddTile(TileID.Anvils);
				recipe.SetResult(ItemID.NinjaShirt);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.NinjaHood);
				recipe.AddTile(TileID.Anvils);
				recipe.SetResult(ItemID.NinjaPants);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.NinjaShirt);
				recipe.AddTile(TileID.Anvils);
				recipe.SetResult(ItemID.NinjaPants);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.NinjaShirt);
				recipe.AddTile(TileID.Anvils);
				recipe.SetResult(ItemID.NinjaHood);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.NinjaPants);
				recipe.AddTile(TileID.Anvils);
				recipe.SetResult(ItemID.NinjaShirt);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.NinjaPants);
				recipe.AddTile(TileID.Anvils);
				recipe.SetResult(ItemID.NinjaHood);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(null, "RegalGel");
				recipe.AddTile(TileID.Anvils);
				recipe.SetResult(ItemID.SlimeHook);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(null, "RegalGel");
				recipe.AddTile(TileID.Anvils);
				recipe.SetResult(ItemID.SlimeGun);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.Lens, 4);
				recipe.AddRecipeGroup("IronBar", 4);
				recipe.AddTile(TileID.Anvils);
				recipe.SetResult(ItemID.Binoculars);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.ShadowScale, 30);
				recipe.AddTile(TileID.Anvils);
				recipe.SetResult(ItemID.EatersBone);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.TissueSample, 30);
				recipe.AddTile(TileID.Anvils);
				recipe.SetResult(ItemID.BoneRattle);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.BeeWax, 12);
				recipe.AddTile(TileID.Anvils);
				recipe.SetResult(ItemID.BeeKeeper);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.BeeWax, 12);
				recipe.AddTile(TileID.Anvils);
				recipe.SetResult(ItemID.BeeGun);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.BeeWax, 12);
				recipe.AddTile(TileID.Anvils);
				recipe.SetResult(ItemID.BeesKnees);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.BeeWax, 12);
				recipe.AddTile(TileID.Anvils);
				recipe.SetResult(ItemID.HiveWand);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.BeeWax, 8);
				recipe.AddTile(TileID.Anvils);
				recipe.SetResult(ItemID.BeeHat);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.BeeWax, 8);
				recipe.AddTile(TileID.Anvils);
				recipe.SetResult(ItemID.BeeShirt);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.BeeWax, 8);
				recipe.AddTile(TileID.Anvils);
				recipe.SetResult(ItemID.BeePants);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.BeeHat);
				recipe.AddTile(TileID.Anvils);
				recipe.SetResult(ItemID.BeePants);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.BeeHat);
				recipe.AddTile(TileID.Anvils);
				recipe.SetResult(ItemID.BeeShirt);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.BeePants);
				recipe.AddTile(TileID.Anvils);
				recipe.SetResult(ItemID.BeeHat);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.BeePants);
				recipe.AddTile(TileID.Anvils);
				recipe.SetResult(ItemID.BeeShirt);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.BeeShirt);
				recipe.AddTile(TileID.Anvils);
				recipe.SetResult(ItemID.BeeHat);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.BeeShirt);
				recipe.AddTile(TileID.Anvils);
				recipe.SetResult(ItemID.BeePants);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.BeeWax, 12);
				recipe.AddTile(TileID.Anvils);
				recipe.SetResult(ItemID.HoneyComb);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.BeeWax, 12);
				recipe.AddTile(TileID.Anvils);
				recipe.SetResult(ItemID.Nectar);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.BeeWax, 12);
				recipe.AddTile(TileID.Anvils);
				recipe.SetResult(ItemID.HoneyedGoggles);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(null, "GoldenBone");
				recipe.AddTile(TileID.Anvils);
				recipe.SetResult(ItemID.SkeletronHand);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(null, "GoldenBone");
				recipe.AddTile(TileID.Anvils);
				recipe.SetResult(ItemID.BookofSkulls);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.BookofSkulls);
				recipe.AddTile(TileID.Anvils);
				recipe.SetResult(ItemID.SkeletronHand);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.SkeletronHand);
				recipe.AddTile(TileID.Anvils);
				recipe.SetResult(ItemID.BookofSkulls);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(null, "PieceofMeat");
				recipe.AddTile(TileID.Anvils);
				recipe.SetResult(ItemID.SorcererEmblem);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(null, "PieceofMeat");
				recipe.AddTile(TileID.Anvils);
				recipe.SetResult(ItemID.SummonerEmblem);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(null, "PieceofMeat");
				recipe.AddTile(TileID.Anvils);
				recipe.SetResult(ItemID.RangerEmblem);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(null, "PieceofMeat");
				recipe.AddTile(TileID.Anvils);
				recipe.SetResult(ItemID.WarriorEmblem);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(null, "PieceofMeat");
				recipe.AddTile(TileID.Anvils);
				recipe.SetResult(ItemID.LaserRifle);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(null, "PieceofMeat");
				recipe.AddTile(TileID.Anvils);
				recipe.SetResult(ItemID.BreakerBlade);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(null, "PieceofMeat");
				recipe.AddTile(TileID.Anvils);
				recipe.SetResult(ItemID.ClockworkAssaultRifle);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(null, "TheSeed");
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.GrenadeLauncher);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(null, "TheSeed");
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.VenusMagnum);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(null, "TheSeed");
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.NettleBurst);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(null, "TheSeed");
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.LeafBlower);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(null, "TheSeed");
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.FlowerPow);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(null, "TheSeed");
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.WaspGun);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(null, "TheSeed");
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.Seedler);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(null, "TheSeed");
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.PygmyStaff);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(null, "TheSeed");
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.Seedling);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(null, "TheSeed");
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.TheAxe);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(null, "TheSeed");
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.ThornHook);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.BeetleHusk, 2);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.PossessedHatchet);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.BeetleHusk, 2);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.Picksaw);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.BeetleHusk, 2);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.HeatRay);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.BeetleHusk, 2);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.StaffofEarth);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.BeetleHusk, 2);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.GolemFist);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.BeetleHusk, 2);
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.Stynger);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(null, "StrangeFish");
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.Flairon);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(null, "StrangeFish");
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.RazorbladeTyphoon);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(null, "StrangeFish");
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.TempestStaff);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(null, "StrangeFish");
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.Tsunami);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(null, "StrangeFish");
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.BubbleGun);
				recipe.AddRecipe();
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(null, "StrangeFish");
				recipe.AddTile(TileID.MythrilAnvil);
				recipe.SetResult(ItemID.FishronWings);
				recipe.AddRecipe();
				
				//version 0.3.5 fix some accessories recipe
				
				recipe = new ModRecipe(this);
				recipe.AddIngredient(ItemID.Vertebrae, 5);
				recipe.AddTile(TileID.WorkBenches);
				recipe.SetResult(ItemID.Leather);
				recipe.AddRecipe();
				
				
		}
		
	}
}
