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
            leadingConditionRule.OnSuccess(ItemDropRule.ByCondition(new Conditions.NotMasterMode(), ItemID.EaterOfWorldsPetItem));
            leadingConditionRule.OnSuccess(ItemDropRule.ByCondition(new Conditions.NotMasterMode(), ItemID.EaterofWorldsMasterTrophy));
            npcLoot.Add(leadingConditionRule);
        }
        else if (Array.IndexOf([NPCID.TheDestroyerBody, NPCID.TheDestroyer, NPCID.TheDestroyerTail],
                     npc.type) > -1)
        {
            LeadingConditionRule leadingConditionRule = new(new Conditions.LegacyHack_IsABoss());
            leadingConditionRule.OnSuccess(ItemDropRule.ByCondition(new Conditions.NotMasterMode(), ItemID.DestroyerPetItem));
            leadingConditionRule.OnSuccess(ItemDropRule.ByCondition(new Conditions.NotMasterMode(), ItemID.DestroyerMasterTrophy));
            npcLoot.Add(leadingConditionRule);
        }
        else if (npc.type is NPCID.Retinazer or NPCID.Spazmatism)
        {
            var leadingConditionRule = new LeadingConditionRule(new Conditions.MissingTwin());
            leadingConditionRule.OnSuccess(ItemDropRule.ByCondition(new Conditions.NotMasterMode(), ItemID.TwinsPetItem));
            leadingConditionRule.OnSuccess(ItemDropRule.ByCondition(new Conditions.NotMasterMode(), ItemID.TwinsMasterTrophy));
            npcLoot.Add(leadingConditionRule);
        }

        switch (npc.type)
        {
            case NPCID.KingSlime:
                npcLoot.Add(ItemDropRule.ByCondition(new Conditions.NotMasterMode(), ItemID.KingSlimePetItem));
                npcLoot.Add(ItemDropRule.ByCondition(new Conditions.NotMasterMode(), ItemID.KingSlimeMasterTrophy));
                break;
            case NPCID.EyeofCthulhu:
                npcLoot.Add(ItemDropRule.ByCondition(new Conditions.NotMasterMode(), ItemID.EyeOfCthulhuPetItem));
                npcLoot.Add(ItemDropRule.ByCondition(new Conditions.NotMasterMode(), ItemID.EyeofCthulhuMasterTrophy));
                break;
            case NPCID.BrainofCthulhu:
                npcLoot.Add(ItemDropRule.ByCondition(new Conditions.NotMasterMode(), ItemID.BrainOfCthulhuPetItem));
                npcLoot.Add(ItemDropRule.ByCondition(new Conditions.NotMasterMode(),
                    ItemID.BrainofCthulhuMasterTrophy));
                break;
            case NPCID.QueenBee:
                npcLoot.Add(ItemDropRule.ByCondition(new Conditions.NotMasterMode(), ItemID.QueenBeePetItem));
                npcLoot.Add(ItemDropRule.ByCondition(new Conditions.NotMasterMode(), ItemID.QueenBeeMasterTrophy));
                break;
            case NPCID.SkeletronHead:
                npcLoot.Add(ItemDropRule.ByCondition(new Conditions.NotMasterMode(), ItemID.SkeletronPetItem));
                npcLoot.Add(ItemDropRule.ByCondition(new Conditions.NotMasterMode(), ItemID.SkeletronMasterTrophy));
                break;
            case NPCID.Deerclops:
                npcLoot.Add(ItemDropRule.ByCondition(new Conditions.NotMasterMode(), ItemID.DeerclopsPetItem));
                npcLoot.Add(ItemDropRule.ByCondition(new Conditions.NotMasterMode(), ItemID.DeerclopsMasterTrophy));
                break;
            case NPCID.WallofFlesh:
                npcLoot.Add(ItemDropRule.ByCondition(new Conditions.NotMasterMode(), ItemID.WallofFleshMasterTrophy));
                npcLoot.Add(ItemDropRule.ByCondition(new Conditions.NotMasterMode(), ItemID.WallOfFleshGoatMountItem));
                break;
            case NPCID.QueenSlimeBoss:
                npcLoot.Add(ItemDropRule.ByCondition(new Conditions.NotMasterMode(), ItemID.QueenSlimePetItem));
                npcLoot.Add(ItemDropRule.ByCondition(new Conditions.NotMasterMode(), ItemID.QueenSlimeMasterTrophy));
                break;
            case NPCID.TheDestroyer:
                break;
            case NPCID.SkeletronPrime:
                npcLoot.Add(ItemDropRule.ByCondition(new Conditions.NotMasterMode(), ItemID.SkeletronPrimePetItem));
                npcLoot.Add(ItemDropRule.ByCondition(new Conditions.NotMasterMode(),
                    ItemID.SkeletronPrimeMasterTrophy));
                break;
            case NPCID.Plantera:
                npcLoot.Add(ItemDropRule.ByCondition(new Conditions.NotMasterMode(), ItemID.PlanteraPetItem));
                npcLoot.Add(ItemDropRule.ByCondition(new Conditions.NotMasterMode(), ItemID.PlanteraMasterTrophy));
                break;
            case NPCID.HallowBoss:
                npcLoot.Add(ItemDropRule.ByCondition(new Conditions.NotMasterMode(), ItemID.FairyQueenPetItem));
                npcLoot.Add(ItemDropRule.ByCondition(new Conditions.NotMasterMode(), ItemID.FairyQueenMasterTrophy));
                break;
            case NPCID.Golem:
                npcLoot.Add(ItemDropRule.ByCondition(new Conditions.NotMasterMode(), ItemID.GolemPetItem));
                npcLoot.Add(ItemDropRule.ByCondition(new Conditions.NotMasterMode(), ItemID.GolemMasterTrophy));
                break;
            case NPCID.DukeFishron:
                npcLoot.Add(ItemDropRule.ByCondition(new Conditions.NotMasterMode(), ItemID.DukeFishronPetItem));
                npcLoot.Add(ItemDropRule.ByCondition(new Conditions.NotMasterMode(), ItemID.DukeFishronMasterTrophy));
                break;
            case NPCID.CultistBoss:
                npcLoot.Add(ItemDropRule.ByCondition(new Conditions.NotMasterMode(), ItemID.LunaticCultistPetItem));
                npcLoot.Add(ItemDropRule.ByCondition(new Conditions.NotMasterMode(),
                    ItemID.LunaticCultistMasterTrophy));
                break;
            case NPCID.MoonLordCore:
                npcLoot.Add(ItemDropRule.ByCondition(new Conditions.NotMasterMode(), ItemID.MoonLordPetItem));
                npcLoot.Add(ItemDropRule.ByCondition(new Conditions.NotMasterMode(), ItemID.MoonLordMasterTrophy));
                break;
            case NPCID.DD2DarkMageT1:
                npcLoot.Add(ItemDropRule.ByCondition(new Conditions.NotMasterMode(), ItemID.DarkMageBookMountItem, 4));
                break;
            case NPCID.DD2DarkMageT3:
                npcLoot.Add(ItemDropRule.ByCondition(new Conditions.NotMasterMode(), ItemID.DarkMageBookMountItem, 4));
                npcLoot.Add(ItemDropRule.ByCondition(new Conditions.NotMasterMode(), ItemID.DarkMageMasterTrophy));
                break;
            case NPCID.DD2OgreT3:
                npcLoot.Add(ItemDropRule.ByCondition(new Conditions.NotMasterMode(), ItemID.DD2OgrePetItem));
                npcLoot.Add(ItemDropRule.ByCondition(new Conditions.NotMasterMode(), ItemID.OgreMasterTrophy));
                break;
            case NPCID.DD2Betsy:
                npcLoot.Add(ItemDropRule.ByCondition(new Conditions.NotMasterMode(), ItemID.DD2BetsyPetItem));
                npcLoot.Add(ItemDropRule.ByCondition(new Conditions.NotMasterMode(), ItemID.BetsyMasterTrophy));
                break;
            case NPCID.MourningWood:
                npcLoot.Add(ItemDropRule.ByCondition(new Conditions.NotMasterMode(), ItemID.MourningWoodMasterTrophy));
                npcLoot.Add(ItemDropRule.ByCondition(
                    new VariableDropRateCondition(0.0625, 0.25),
                    ItemID.SpookyWoodMountItem
                ));
                break;
            case NPCID.Pumpking:
                npcLoot.Add(ItemDropRule.ByCondition(new Conditions.NotMasterMode(), ItemID.PumpkingPetItem));
                npcLoot.Add(ItemDropRule.ByCondition(new Conditions.NotMasterMode(), ItemID.PumpkingMasterTrophy));
                break;
            case NPCID.Everscream:
                npcLoot.Add(ItemDropRule.ByCondition(new Conditions.NotMasterMode(), ItemID.EverscreamPetItem));
                npcLoot.Add(ItemDropRule.ByCondition(new Conditions.NotMasterMode(), ItemID.EverscreamMasterTrophy));
                break;
            case NPCID.IceQueen:
                npcLoot.Add(ItemDropRule.ByCondition(new Conditions.NotMasterMode(), ItemID.IceQueenPetItem));
                npcLoot.Add(ItemDropRule.ByCondition(new Conditions.NotMasterMode(), ItemID.IceQueenMasterTrophy));
                break;
            case NPCID.SantaNK1:
                npcLoot.Add(ItemDropRule.ByCondition(new Conditions.NotMasterMode(), ItemID.SantankMountItem));
                npcLoot.Add(ItemDropRule.ByCondition(new Conditions.NotMasterMode(), ItemID.SantankMasterTrophy));
                break;
            case NPCID.PirateShip:
                npcLoot.Add(ItemDropRule.ByCondition(new Conditions.NotMasterMode(),
                    ItemID.FlyingDutchmanMasterTrophy));
                npcLoot.Add(ItemDropRule.ByCondition(new Conditions.NotMasterMode(), ItemID.PirateShipMountItem));
                break;
            case NPCID.MartianSaucerCore:
                npcLoot.Add(ItemDropRule.ByCondition(new Conditions.NotMasterMode(), ItemID.MartianPetItem));
                npcLoot.Add(ItemDropRule.ByCondition(new Conditions.NotMasterMode(), ItemID.UFOMasterTrophy));
                break;
        }
    }
}