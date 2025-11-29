using MasterModeDropsOnOtherMode.Common.Utilities;
using Terraria;
using Terraria.ModLoader;

namespace MasterModeDropsOnOtherMode.Systems.Handlers;

public static class RedemptionLootHandler
{
    public static void ModifyLoot(NPC npc, NPCLoot npcLoot)
    {
        var redemptionMod = ModLoader.GetMod("Redemption");

        // 无上鸡皇，就是一个蛋
        if (ModdedLootUtils.ProcessBossLoot(npc, npcLoot, redemptionMod, "FowlEmperor", (loot, mod) =>
            {
                ModdedLootUtils.AddModItemDrop(loot, mod, "EggPet", ModdedLootUtils.DropType.Pet, 4);
                ModdedLootUtils.AddModItemDrop(loot, mod, "FowlEmperorRelic", ModdedLootUtils.DropType.Relic);
            })) return;
        // 凤头鹦鹉，鸡毛
        if (ModdedLootUtils.ProcessBossLoot(npc, npcLoot, redemptionMod, "Cockatrice", (loot, mod) =>
            {
                ModdedLootUtils.AddModItemDrop(loot, mod, "FowlFeather", ModdedLootUtils.DropType.Pet, 4);
                ModdedLootUtils.AddModItemDrop(loot, mod, "CockatriceRelic", ModdedLootUtils.DropType.Relic);
            })) return;
        // 波山，辣鸡腿
        if (ModdedLootUtils.ProcessBossLoot(npc, npcLoot, redemptionMod, "Basan", (loot, mod) =>
            {
                ModdedLootUtils.AddModItemDrop(loot, mod, "SpicyDrumstick", ModdedLootUtils.DropType.LightPet, 4);
                ModdedLootUtils.AddModItemDrop(loot, mod, "BasanRelic", ModdedLootUtils.DropType.Relic);
            })) return;
        // 索恩，荆棘花束
        if (ModdedLootUtils.ProcessBossLoot(npc, npcLoot, redemptionMod, "Thorn", (loot, mod) =>
            {
                ModdedLootUtils.AddModItemDrop(loot, mod, "BouquetOfThorns", ModdedLootUtils.DropType.Pet, 4);
                ModdedLootUtils.AddModItemDrop(loot, mod, "ThornRelic", ModdedLootUtils.DropType.Relic);
            })) return;
        // 埃尔汗，唱反调的人
        if (ModdedLootUtils.ProcessBossLoot(npc, npcLoot, redemptionMod, "Erhan", (loot, mod) =>
            {
                ModdedLootUtils.AddModItemDrop(loot, mod, "DevilsAdvocate", ModdedLootUtils.DropType.Pet, 4);
                ModdedLootUtils.AddModItemDrop(loot, mod, "ErhanRelic", ModdedLootUtils.DropType.Relic);
            })) return;
        // 守夜人，奥西的衣领
        if (ModdedLootUtils.ProcessBossLoot(npc, npcLoot, redemptionMod, "Keeper", (loot, mod) =>
            {
                ModdedLootUtils.AddModItemDrop(loot, mod, "OcciesCollar", ModdedLootUtils.DropType.Pet, 4);
                ModdedLootUtils.AddModItemDrop(loot, mod, "KeeperRelic", ModdedLootUtils.DropType.Relic);
            })) return;
        // 挖骨者，RaggedPatch
        if (ModdedLootUtils.ProcessBossLoot(npc, npcLoot, redemptionMod, "SkullDigger", (loot, mod) =>
            {
                ModdedLootUtils.AddModItemDrop(loot, mod, "RaggedPatch", ModdedLootUtils.DropType.Pet, 4);
                ModdedLootUtils.AddModItemDrop(loot, mod, "SkullDiggerRelic", ModdedLootUtils.DropType.Relic);
            })) return;
        // 鹰冠石巨人，石偶
        if (ModdedLootUtils.ProcessBossLoot(npc, npcLoot, redemptionMod, "EaglecrestGolem", (loot, mod) =>
            {
                ModdedLootUtils.AddModItemDrop(loot, mod, "StonePuppet", ModdedLootUtils.DropType.Pet, 4);
                ModdedLootUtils.AddModItemDrop(loot, mod, "EaglecrestGolemRelic", ModdedLootUtils.DropType.Relic);
            })) return;
        // 感染之种，可爱的畸胎瘤
        if (ModdedLootUtils.ProcessBossLoot(npc, npcLoot, redemptionMod, "SoI", (loot, mod) =>
            {
                ModdedLootUtils.AddModItemDrop(loot, mod, "CuddlyTeratoma", ModdedLootUtils.DropType.Pet, 4);
                ModdedLootUtils.AddModItemDrop(loot, mod, "SoIRelic", ModdedLootUtils.DropType.Relic);
            })) return;
        // 卡拉维亚
        if (ModdedLootUtils.ProcessBossLoot(npc, npcLoot, redemptionMod, "Calavia",
                (loot, mod) =>
                {
                    ModdedLootUtils.AddModItemDrop(loot, mod, "CalaviaRelic", ModdedLootUtils.DropType.Relic);
                })) return;
        // 弑君者Ⅲ，弑君者投影仪
        if (ModdedLootUtils.ProcessBossLoot(npc, npcLoot, redemptionMod, "KS3", (loot, mod) =>
            {
                ModdedLootUtils.AddModItemDrop(loot, mod, "SlayerProjector", ModdedLootUtils.DropType.Pet, 4);
                ModdedLootUtils.AddModItemDrop(loot, mod, "KS3Relic", ModdedLootUtils.DropType.Relic);
            })) return;
        // 欧米茄一号原型机，迷你斩切者。物品由 OmegaCleaver 掉落
        if (ModdedLootUtils.ProcessBossLoot(npc, npcLoot, redemptionMod, "OmegaCleaver", (loot, mod) =>
            {
                ModdedLootUtils.AddModItemDrop(loot, mod, "CleaverHandle", ModdedLootUtils.DropType.Pet, 4);
                ModdedLootUtils.AddModItemDrop(loot, mod, "CleaverRelic", ModdedLootUtils.DropType.Relic);
            })) return;
        // 欧米茄二号原型机，动力钻头
        if (ModdedLootUtils.ProcessBossLoot(npc, npcLoot, redemptionMod, "Gigapora", (loot, mod) =>
            {
                ModdedLootUtils.AddModItemDrop(loot, mod, "PowerDrill", ModdedLootUtils.DropType.Pet, 4);
                ModdedLootUtils.AddModItemDrop(loot, mod, "GigaporaRelic", ModdedLootUtils.DropType.Relic);
            }))
            return;
        // 欧米茄三号原型机，烤面包机
        if (ModdedLootUtils.ProcessBossLoot(npc, npcLoot, redemptionMod, "OO", (loot, mod) =>
            {
                ModdedLootUtils.AddModItemDrop(loot, mod, "ToasterPet", ModdedLootUtils.DropType.Pet, 4);
                ModdedLootUtils.AddModItemDrop(loot, mod, "OORelic", ModdedLootUtils.DropType.Relic);
            })) return;
        // 零号病患，异辉血症
        if (ModdedLootUtils.ProcessBossLoot(npc, npcLoot, redemptionMod, "PZ", (loot, mod) =>
            {
                ModdedLootUtils.AddModItemDrop(loot, mod, "Xenoemia", ModdedLootUtils.DropType.LightPet, 4);
                ModdedLootUtils.AddModItemDrop(loot, mod, "PZRelic", ModdedLootUtils.DropType.Relic);
            })) return;
        // 乌戈，乌贡拉津
        if (ModdedLootUtils.ProcessBossLoot(npc, npcLoot, redemptionMod, "Ukko", (loot, mod) =>
            {
                ModdedLootUtils.AddModItemDrop(loot, mod, "JyrinaMount", ModdedLootUtils.DropType.Mount, 4);
                ModdedLootUtils.AddModItemDrop(loot, mod, "UkkoRelic", ModdedLootUtils.DropType.Relic);
            })) return;
        // 埃卡
        if (ModdedLootUtils.ProcessBossLoot(npc, npcLoot, redemptionMod, "Akka",
                (loot, mod) =>
                {
                    ModdedLootUtils.AddModItemDrop(loot, mod, "AkkaRelic", ModdedLootUtils.DropType.Relic);
                })) return;
        // 涅布琉斯，镀金帽子
        if (ModdedLootUtils.ProcessBossLoot(npc, npcLoot, redemptionMod, "Nebuleus", (loot, mod) =>
            {
                ModdedLootUtils.AddModItemDrop(loot, mod, "GildedBonnet", ModdedLootUtils.DropType.Pet, 4);
                ModdedLootUtils.AddModItemDrop(loot, mod, "NebRelic", ModdedLootUtils.DropType.Relic);
            })) return;
    }
}