using System;
using MasterModeDropsOnOtherMode.Common;
using Terraria;
using Terraria.GameContent.ItemDropRules;
using Terraria.ID;
using Terraria.ModLoader;

namespace MasterModeDropsOnOtherMode.Systems;

public static class VanillaLootSystem
{
    public static void ModifyLoot(NPC npc, NPCLoot npcLoot)
    {
        if (Array.IndexOf([NPCID.EaterofWorldsBody, NPCID.EaterofWorldsHead, NPCID.EaterofWorldsTail],
                npc.type) > -1)
        {
            LeadingConditionRule leadingConditionRule = new(new Conditions.LegacyHack_IsABoss());
            leadingConditionRule.OnSuccess(ItemDropRule.ByCondition(new NotMasterModeDropCondition(isForPet: true), ItemID.EaterOfWorldsPetItem));
            leadingConditionRule.OnSuccess(ItemDropRule.ByCondition(new NotMasterModeDropCondition(isForRelic: true), ItemID.EaterofWorldsMasterTrophy));
            npcLoot.Add(leadingConditionRule);
        }
        else if (Array.IndexOf([NPCID.TheDestroyerBody, NPCID.TheDestroyer, NPCID.TheDestroyerTail],
                     npc.type) > -1)
        {
            LeadingConditionRule leadingConditionRule = new(new Conditions.LegacyHack_IsABoss());
            leadingConditionRule.OnSuccess(ItemDropRule.ByCondition(new NotMasterModeDropCondition(isForPet: true), ItemID.DestroyerPetItem));
            leadingConditionRule.OnSuccess(ItemDropRule.ByCondition(new NotMasterModeDropCondition(isForRelic: true), ItemID.DestroyerMasterTrophy));
            npcLoot.Add(leadingConditionRule);
        }
        else if (npc.type is NPCID.Retinazer or NPCID.Spazmatism)
        {
            var leadingConditionRule = new LeadingConditionRule(new Conditions.MissingTwin());
            leadingConditionRule.OnSuccess(ItemDropRule.ByCondition(new NotMasterModeDropCondition(isForPet: true),  ItemID.TwinsPetItem));
            leadingConditionRule.OnSuccess(ItemDropRule.ByCondition(new NotMasterModeDropCondition(isForRelic: true),  ItemID.TwinsMasterTrophy));
            npcLoot.Add(leadingConditionRule);
        }

        switch (npc.type)
        {
            case NPCID.KingSlime:
                npcLoot.Add(ItemDropRule.ByCondition(new NotMasterModeDropCondition(isForPet: true), ItemID.KingSlimePetItem));
                npcLoot.Add(ItemDropRule.ByCondition(new NotMasterModeDropCondition(isForRelic: true), ItemID.KingSlimeMasterTrophy));
                break;
            case NPCID.EyeofCthulhu:
                npcLoot.Add(ItemDropRule.ByCondition(new NotMasterModeDropCondition(isForPet: true),  ItemID.EyeOfCthulhuPetItem));
                npcLoot.Add(ItemDropRule.ByCondition(new NotMasterModeDropCondition(isForRelic: true), ItemID.EyeofCthulhuMasterTrophy));
                break;
            case NPCID.BrainofCthulhu:
                npcLoot.Add(ItemDropRule.ByCondition(new NotMasterModeDropCondition(isForPet: true), ItemID.BrainOfCthulhuPetItem));
                npcLoot.Add(ItemDropRule.ByCondition(new NotMasterModeDropCondition(isForRelic: true), ItemID.BrainofCthulhuMasterTrophy));
                break;
            case NPCID.QueenBee:
                npcLoot.Add(ItemDropRule.ByCondition(new NotMasterModeDropCondition(isForPet: true), ItemID.QueenBeePetItem));
                npcLoot.Add(ItemDropRule.ByCondition(new NotMasterModeDropCondition(isForRelic: true), ItemID.QueenBeeMasterTrophy));
                break;
            case NPCID.SkeletronHead:
                npcLoot.Add(ItemDropRule.ByCondition(new NotMasterModeDropCondition(isForPet: true), ItemID.SkeletronPetItem));
                npcLoot.Add(ItemDropRule.ByCondition(new NotMasterModeDropCondition(isForRelic: true), ItemID.SkeletronMasterTrophy));
                break;
            case NPCID.Deerclops:
                npcLoot.Add(ItemDropRule.ByCondition(new NotMasterModeDropCondition(isForPet: true), ItemID.DeerclopsPetItem));
                npcLoot.Add(ItemDropRule.ByCondition(new NotMasterModeDropCondition(isForRelic: true), ItemID.DeerclopsMasterTrophy));
                break;
            case NPCID.WallofFlesh:
                npcLoot.Add(ItemDropRule.ByCondition(new NotMasterModeDropCondition(isForRelic: true),  ItemID.WallofFleshMasterTrophy));
                npcLoot.Add(ItemDropRule.ByCondition(new NotMasterModeDropCondition(isForMount: true), ItemID.WallOfFleshGoatMountItem));
                break;
            case NPCID.QueenSlimeBoss:
                npcLoot.Add(ItemDropRule.ByCondition(new NotMasterModeDropCondition(isForPet: true),  ItemID.QueenSlimePetItem));
                npcLoot.Add(ItemDropRule.ByCondition(new NotMasterModeDropCondition(isForRelic: true), ItemID.QueenSlimeMasterTrophy));
                break;
            case NPCID.TheDestroyer:
                break;
            case NPCID.SkeletronPrime:
                npcLoot.Add(ItemDropRule.ByCondition(new NotMasterModeDropCondition(isForPet: true),  ItemID.SkeletronPrimePetItem));
                npcLoot.Add(ItemDropRule.ByCondition(new NotMasterModeDropCondition(isForRelic: true), ItemID.SkeletronPrimeMasterTrophy));
                break;
            case NPCID.Plantera:
                npcLoot.Add(ItemDropRule.ByCondition(new NotMasterModeDropCondition(isForPet: true),  ItemID.PlanteraPetItem));
                npcLoot.Add(ItemDropRule.ByCondition(new NotMasterModeDropCondition(isForRelic: true), ItemID.PlanteraMasterTrophy));
                break;
            // 光之女皇
            case NPCID.HallowBoss:
                npcLoot.Add(ItemDropRule.ByCondition(new NotMasterModeDropCondition(isForLightPet: true),  ItemID.FairyQueenPetItem));
                npcLoot.Add(ItemDropRule.ByCondition(new NotMasterModeDropCondition(isForRelic: true), ItemID.FairyQueenMasterTrophy));
                break;
            // 石巨人
            case NPCID.Golem:
                npcLoot.Add(ItemDropRule.ByCondition(new NotMasterModeDropCondition(isForLightPet: true),  ItemID.GolemPetItem));
                npcLoot.Add(ItemDropRule.ByCondition(new NotMasterModeDropCondition(isForRelic: true), ItemID.GolemMasterTrophy));
                break;
            case NPCID.DukeFishron:
                npcLoot.Add(ItemDropRule.ByCondition(new NotMasterModeDropCondition(isForPet: true),  ItemID.DukeFishronPetItem));
                npcLoot.Add(ItemDropRule.ByCondition(new NotMasterModeDropCondition(isForRelic: true), ItemID.DukeFishronMasterTrophy));
                break;
            case NPCID.CultistBoss:
                npcLoot.Add(ItemDropRule.ByCondition(new NotMasterModeDropCondition(isForPet: true),  ItemID.LunaticCultistPetItem));
                npcLoot.Add(ItemDropRule.ByCondition(new NotMasterModeDropCondition(isForRelic: true), ItemID.LunaticCultistMasterTrophy));
                break;
            case NPCID.MoonLordCore:
                npcLoot.Add(ItemDropRule.ByCondition(new NotMasterModeDropCondition(isForPet: true),  ItemID.MoonLordPetItem));
                npcLoot.Add(ItemDropRule.ByCondition(new NotMasterModeDropCondition(isForRelic: true), ItemID.MoonLordMasterTrophy));
                break;
            case NPCID.DD2DarkMageT1:
                npcLoot.Add(ItemDropRule.ByCondition(new NotMasterModeDropCondition(isForMount: true), ItemID.DarkMageBookMountItem, 4));
                break;
            case NPCID.DD2DarkMageT3:
                npcLoot.Add(ItemDropRule.ByCondition(new NotMasterModeDropCondition(isForMount: true), ItemID.DarkMageBookMountItem, 4));
                npcLoot.Add(ItemDropRule.ByCondition(new NotMasterModeDropCondition(isForRelic: true), ItemID.DarkMageMasterTrophy));
                break;
            case NPCID.DD2OgreT3:
                npcLoot.Add(ItemDropRule.ByCondition(new NotMasterModeDropCondition(isForPet: true),  ItemID.DD2OgrePetItem));
                npcLoot.Add(ItemDropRule.ByCondition(new NotMasterModeDropCondition(isForRelic: true), ItemID.OgreMasterTrophy));
                break;
            case NPCID.DD2Betsy:
                npcLoot.Add(ItemDropRule.ByCondition(new NotMasterModeDropCondition(isForPet: true),  ItemID.DD2BetsyPetItem));
                npcLoot.Add(ItemDropRule.ByCondition(new NotMasterModeDropCondition(isForRelic: true), ItemID.BetsyMasterTrophy));
                break;
            case NPCID.MourningWood:
                npcLoot.Add(ItemDropRule.ByCondition(new NotMasterModeDropCondition(isForRelic: true), ItemID.MourningWoodMasterTrophy));
                npcLoot.Add(ItemDropRule.ByCondition(
                    new VariableDropRateCondition(0.0625, 0.25),
                    ItemID.SpookyWoodMountItem
                ));
                break;
            // 南瓜王
            case NPCID.Pumpking:
                npcLoot.Add(ItemDropRule.ByCondition(new NotMasterModeDropCondition(isForLightPet: true),  ItemID.PumpkingPetItem));
                npcLoot.Add(ItemDropRule.ByCondition(new NotMasterModeDropCondition(isForRelic: true), ItemID.PumpkingMasterTrophy));
                break;
            case NPCID.Everscream:
                npcLoot.Add(ItemDropRule.ByCondition(new NotMasterModeDropCondition(isForPet: true),  ItemID.EverscreamPetItem));
                npcLoot.Add(ItemDropRule.ByCondition(new NotMasterModeDropCondition(isForRelic: true), ItemID.EverscreamMasterTrophy));
                break;
            case NPCID.IceQueen:
                npcLoot.Add(ItemDropRule.ByCondition(new NotMasterModeDropCondition(isForPet: true),  ItemID.IceQueenPetItem));
                npcLoot.Add(ItemDropRule.ByCondition(new NotMasterModeDropCondition(isForRelic: true), ItemID.IceQueenMasterTrophy));
                break;
            case NPCID.SantaNK1:
                npcLoot.Add(ItemDropRule.ByCondition(new NotMasterModeDropCondition(isForMount: true), ItemID.SantankMountItem));
                npcLoot.Add(ItemDropRule.ByCondition(new NotMasterModeDropCondition(isForRelic: true), ItemID.SantankMasterTrophy));
                break;
            case NPCID.PirateShip:
                npcLoot.Add(ItemDropRule.ByCondition(new NotMasterModeDropCondition(isForRelic: true), ItemID.FlyingDutchmanMasterTrophy));
                npcLoot.Add(ItemDropRule.ByCondition(new NotMasterModeDropCondition(isForMount: true), ItemID.PirateShipMountItem));
                break;
            case NPCID.MartianSaucerCore:
                npcLoot.Add(ItemDropRule.ByCondition(new NotMasterModeDropCondition(isForPet: true),  ItemID.MartianPetItem));
                npcLoot.Add(ItemDropRule.ByCondition(new NotMasterModeDropCondition(isForRelic: true), ItemID.UFOMasterTrophy));
                break;
        }
    }
}