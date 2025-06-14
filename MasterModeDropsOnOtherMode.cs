using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.GameContent.ItemDropRules;
using Terraria.ID;
using Terraria.ModLoader;

namespace MasterModeDropsOnOtherMode
{
	// Please read https://github.com/tModLoader/tModLoader/wiki/Basic-tModLoader-Modding-Guide#mod-skeleton-contents for more information about the various files in a mod.
	public class MasterModeDropsOnOtherMode : Mod
	{
		public override void Load() {}

		public override void Unload() {}
	}
	
	public class MyGlobalNpc : GlobalNPC
	{
		public override void ModifyNPCLoot(NPC npc, NPCLoot npcLoot) {
			// First, we need to check the npc.type to see if the code is running for the vanilla NPCwe want to change

			if (Main.GameModeInfo.IsExpertMode)
			{
				return;
			}
			
			if (System.Array.IndexOf([NPCID.EaterofWorldsBody, NPCID.EaterofWorldsHead, NPCID.EaterofWorldsTail], npc.type) > -1)
			{
				LeadingConditionRule leadingConditionRule = new(new Conditions.LegacyHack_IsABoss());
				leadingConditionRule.OnSuccess(ItemDropRule.Common(ItemID.EaterOfWorldsPetItem));
				leadingConditionRule.OnSuccess(ItemDropRule.Common(ItemID.EaterofWorldsMasterTrophy));
				npcLoot.Add(leadingConditionRule);
			} else if (System.Array.IndexOf([NPCID.TheDestroyerBody, NPCID.TheDestroyer, NPCID.TheDestroyerTail], npc.type) > -1) {
				LeadingConditionRule leadingConditionRule = new(new Conditions.LegacyHack_IsABoss());
				leadingConditionRule.OnSuccess(ItemDropRule.Common(ItemID.DestroyerPetItem));
				leadingConditionRule.OnSuccess(ItemDropRule.Common(ItemID.DestroyerMasterTrophy));
				npcLoot.Add(leadingConditionRule);
			} else if (npc.type is NPCID.Retinazer or NPCID.Spazmatism) {
				var leadingConditionRule = new LeadingConditionRule(new Conditions.MissingTwin());
				leadingConditionRule.OnSuccess(ItemDropRule.Common(ItemID.TwinsPetItem));
				leadingConditionRule.OnSuccess(ItemDropRule.Common(ItemID.TwinsMasterTrophy));
				npcLoot.Add(leadingConditionRule);
			}
			
			switch (npc.type)
			{
				case NPCID.KingSlime:
					npcLoot.Add(ItemDropRule.Common(ItemID.KingSlimePetItem));
					npcLoot.Add(ItemDropRule.Common(ItemID.KingSlimeMasterTrophy));
					break;
				case NPCID.EyeofCthulhu:
					npcLoot.Add(ItemDropRule.Common(ItemID.EyeOfCthulhuPetItem));
					npcLoot.Add(ItemDropRule.Common(ItemID.EyeofCthulhuMasterTrophy));
					break;
				case NPCID.BrainofCthulhu:
					npcLoot.Add(ItemDropRule.Common(ItemID.BrainOfCthulhuPetItem));
					npcLoot.Add(ItemDropRule.Common(ItemID.BrainofCthulhuMasterTrophy));
					break;
				case NPCID.QueenBee:
					npcLoot.Add(ItemDropRule.Common(ItemID.QueenBeePetItem));
					npcLoot.Add(ItemDropRule.Common(ItemID.QueenBeeMasterTrophy));
					break;
				case NPCID.SkeletronHead:
					npcLoot.Add(ItemDropRule.Common(ItemID.SkeletronPetItem));
					npcLoot.Add(ItemDropRule.Common(ItemID.SkeletronMasterTrophy));
					break;
				case NPCID.Deerclops:
					npcLoot.Add(ItemDropRule.Common(ItemID.DeerclopsPetItem));
					npcLoot.Add(ItemDropRule.Common(ItemID.DeerclopsMasterTrophy));
					break;
				case NPCID.WallofFlesh:
					npcLoot.Add(ItemDropRule.Common(ItemID.WallofFleshMasterTrophy));
					npcLoot.Add(ItemDropRule.Common(ItemID.WallOfFleshGoatMountItem));
					break;
				case NPCID.QueenSlimeBoss:
					npcLoot.Add(ItemDropRule.Common(ItemID.QueenSlimePetItem));
					npcLoot.Add(ItemDropRule.Common(ItemID.QueenSlimeMasterTrophy));
					break;
				case NPCID.TheDestroyer:
					break;
				case NPCID.SkeletronPrime:
					npcLoot.Add(ItemDropRule.Common(ItemID.SkeletronPrimePetItem));
					npcLoot.Add(ItemDropRule.Common(ItemID.SkeletronPrimeMasterTrophy));
					break;
				case NPCID.Plantera:
					npcLoot.Add(ItemDropRule.Common(ItemID.PlanteraPetItem));
					npcLoot.Add(ItemDropRule.Common(ItemID.PlanteraMasterTrophy));
					break;
				case NPCID.HallowBoss:
					npcLoot.Add(ItemDropRule.Common(ItemID.FairyQueenPetItem));
					npcLoot.Add(ItemDropRule.Common(ItemID.FairyQueenMasterTrophy));
					break;
				case NPCID.Golem:
					npcLoot.Add(ItemDropRule.Common(ItemID.GolemPetItem));
					npcLoot.Add(ItemDropRule.Common(ItemID.GolemMasterTrophy));
					break;
				case NPCID.DukeFishron:
					npcLoot.Add(ItemDropRule.Common(ItemID.DukeFishronPetItem));
					npcLoot.Add(ItemDropRule.Common(ItemID.DukeFishronMasterTrophy));
					break;
				case NPCID.CultistBoss:
					npcLoot.Add(ItemDropRule.Common(ItemID.LunaticCultistPetItem));
					npcLoot.Add(ItemDropRule.Common(ItemID.LunaticCultistMasterTrophy));
					break;
				case NPCID.MoonLordCore:
					npcLoot.Add(ItemDropRule.Common(ItemID.MoonLordPetItem));
					npcLoot.Add(ItemDropRule.Common(ItemID.MoonLordMasterTrophy));
					break;
				case NPCID.DD2DarkMageT1:
					npcLoot.Add(ItemDropRule.Common(ItemID.DarkMageBookMountItem,4));
					break;
				case NPCID.DD2DarkMageT3:
					npcLoot.Add(ItemDropRule.Common(ItemID.DarkMageBookMountItem,4));
					npcLoot.Add(ItemDropRule.Common(ItemID.DarkMageMasterTrophy));
					break;
				case NPCID.DD2OgreT3:
					npcLoot.Add(ItemDropRule.Common(ItemID.DD2OgrePetItem));
					npcLoot.Add(ItemDropRule.Common(ItemID.OgreMasterTrophy));
					break;
				case NPCID.DD2Betsy:
					npcLoot.Add(ItemDropRule.Common(ItemID.DD2BetsyPetItem));
					npcLoot.Add(ItemDropRule.Common(ItemID.BetsyMasterTrophy));
					break;
				case NPCID.MourningWood:
					npcLoot.Add(ItemDropRule.Common(ItemID.MourningWoodMasterTrophy));
					npcLoot.Add(ItemDropRule.Common(ItemID.SpookyWoodMountItem,4));
					break;
				case NPCID.Pumpking:
					npcLoot.Add(ItemDropRule.Common(ItemID.PumpkingPetItem));
					npcLoot.Add(ItemDropRule.Common(ItemID.PumpkingMasterTrophy));
					break;
				case NPCID.Everscream:
					npcLoot.Add(ItemDropRule.Common(ItemID.EverscreamPetItem));
					npcLoot.Add(ItemDropRule.Common(ItemID.EverscreamMasterTrophy));
					break;
				case NPCID.IceQueen:
					npcLoot.Add(ItemDropRule.Common(ItemID.IceQueenPetItem));
					npcLoot.Add(ItemDropRule.Common(ItemID.IceQueenMasterTrophy));
					break;
				case NPCID.SantaNK1:
					npcLoot.Add(ItemDropRule.Common(ItemID.SantankMountItem));
					npcLoot.Add(ItemDropRule.Common(ItemID.SantankMasterTrophy));
					break;
				case NPCID.PirateShip:
					npcLoot.Add(ItemDropRule.Common(ItemID.FlyingDutchmanMasterTrophy));
					npcLoot.Add(ItemDropRule.Common(ItemID.PirateShipMountItem));
					break;
				case NPCID.MartianSaucerCore:
					npcLoot.Add(ItemDropRule.Common(ItemID.MartianPetItem));
					npcLoot.Add(ItemDropRule.Common(ItemID.UFOMasterTrophy));
					break;
			}
		}
	}
}
