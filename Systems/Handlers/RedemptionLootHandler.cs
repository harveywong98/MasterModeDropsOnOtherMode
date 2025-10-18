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
                ModdedLootUtils.AddModItemDrop(loot, mod, "EggPet", 4);
                ModdedLootUtils.AddModItemDrop(loot, mod, "FowlEmperorRelic");
            })) return;
        // 凤头鹦鹉，鸡毛
        if (ModdedLootUtils.ProcessBossLoot(npc, npcLoot, redemptionMod, "Cockatrice", (loot, mod) =>
            {
                ModdedLootUtils.AddModItemDrop(loot, mod, "FowlFeather", 4);
                ModdedLootUtils.AddModItemDrop(loot, mod, "CockatriceRelic");
            })) return;
        // 波山，辣鸡腿
        if (ModdedLootUtils.ProcessBossLoot(npc, npcLoot, redemptionMod, "Basan", (loot, mod) =>
            {
                ModdedLootUtils.AddModItemDrop(loot, mod, "SpicyDrumstick", 4);
                ModdedLootUtils.AddModItemDrop(loot, mod, "BasanRelic");
            })) return;
        // 索恩，荆棘花束
        if (ModdedLootUtils.ProcessBossLoot(npc, npcLoot, redemptionMod, "Thorn", (loot, mod) =>
            {
                ModdedLootUtils.AddModItemDrop(loot, mod, "BouquetOfThorns", 4);
                ModdedLootUtils.AddModItemDrop(loot, mod, "ThornRelic");
            })) return;
        // 埃尔汗，唱反调的人
        if (ModdedLootUtils.ProcessBossLoot(npc, npcLoot, redemptionMod, "Erhan", (loot, mod) =>
            {
                ModdedLootUtils.AddModItemDrop(loot, mod, "DevilsAdvocate", 4);
                ModdedLootUtils.AddModItemDrop(loot, mod, "ErhanRelic");
            })) return;
        // 守夜人，奥西的衣领
        if (ModdedLootUtils.ProcessBossLoot(npc, npcLoot, redemptionMod, "Keeper", (loot, mod) =>
            {
                ModdedLootUtils.AddModItemDrop(loot, mod, "OcciesCollar", 4);
                ModdedLootUtils.AddModItemDrop(loot, mod, "KeeperRelic");
            })) return;
        // 挖骨者，RaggedPatch
        if (ModdedLootUtils.ProcessBossLoot(npc, npcLoot, redemptionMod, "SkullDigger", (loot, mod) =>
            {
                ModdedLootUtils.AddModItemDrop(loot, mod, "RaggedPatch", 4);
                ModdedLootUtils.AddModItemDrop(loot, mod, "SkullDiggerRelic");
            })) return;
        // 鹰冠石巨人，石偶
        if (ModdedLootUtils.ProcessBossLoot(npc, npcLoot, redemptionMod, "EaglecrestGolem", (loot, mod) =>
            {
                ModdedLootUtils.AddModItemDrop(loot, mod, "StonePuppet", 4);
                ModdedLootUtils.AddModItemDrop(loot, mod, "EaglecrestGolemRelic");
            })) return;
        // 感染之种，可爱的畸胎瘤
        if (ModdedLootUtils.ProcessBossLoot(npc, npcLoot, redemptionMod, "SoI", (loot, mod) =>
            {
                ModdedLootUtils.AddModItemDrop(loot, mod, "CuddlyTeratoma", 4);
                ModdedLootUtils.AddModItemDrop(loot, mod, "SoIRelic");
            })) return;
        // 卡拉维亚
        if (ModdedLootUtils.ProcessBossLoot(npc, npcLoot, redemptionMod, "Calavia",
                (loot, mod) => { ModdedLootUtils.AddModItemDrop(loot, mod, "CalaviaRelic"); })) return;
        // 弑君者Ⅲ，弑君者投影仪
        if (ModdedLootUtils.ProcessBossLoot(npc, npcLoot, redemptionMod, "KS3", (loot, mod) =>
            {
                ModdedLootUtils.AddModItemDrop(loot, mod, "SlayerProjector", 4);
                ModdedLootUtils.AddModItemDrop(loot, mod, "KS3Relic");
            })) return;
        // 欧米茄一号原型机，迷你斩切者。物品由 OmegaCleaver 掉落
        if (ModdedLootUtils.ProcessBossLoot(npc, npcLoot, redemptionMod, "OmegaCleaver", (loot, mod) =>
            {
                ModdedLootUtils.AddModItemDrop(loot, mod, "CleaverHandle", 4);
                ModdedLootUtils.AddModItemDrop(loot, mod, "CleaverRelic");
            }))
        // 欧米茄二号原型机，动力钻头
        if (ModdedLootUtils.ProcessBossLoot(npc, npcLoot, redemptionMod, "Gigapora", (loot, mod) =>
            {
                ModdedLootUtils.AddModItemDrop(loot, mod, "PowerDrill", 4);
                ModdedLootUtils.AddModItemDrop(loot, mod, "GigaporaRelic");
            })) return;
        // 欧米茄三号原型机，烤面包机
        if (ModdedLootUtils.ProcessBossLoot(npc, npcLoot, redemptionMod, "OO", (loot, mod) =>
            {
                ModdedLootUtils.AddModItemDrop(loot, mod, "ToasterPet", 4);
                ModdedLootUtils.AddModItemDrop(loot, mod, "OORelic");
            })) return;
        // 零号病患，异辉血症
        if (ModdedLootUtils.ProcessBossLoot(npc, npcLoot, redemptionMod, "PZ", (loot, mod) =>
            {
                ModdedLootUtils.AddModItemDrop(loot, mod, "Xenoemia", 4);
                ModdedLootUtils.AddModItemDrop(loot, mod, "PZRelic");
            })) return;
        // 乌戈，乌贡拉津
        if (ModdedLootUtils.ProcessBossLoot(npc, npcLoot, redemptionMod, "Ukko", (loot, mod) =>
            {
                ModdedLootUtils.AddModItemDrop(loot, mod, "JyrinaMount", 4);
                ModdedLootUtils.AddModItemDrop(loot, mod, "UkkoRelic");
            })) return;
        // 埃卡
        if (ModdedLootUtils.ProcessBossLoot(npc, npcLoot, redemptionMod, "Akka",
                (loot, mod) => { ModdedLootUtils.AddModItemDrop(loot, mod, "AkkaRelic"); })) return;
        // 涅布琉斯，镀金帽子
        if (ModdedLootUtils.ProcessBossLoot(npc, npcLoot, redemptionMod, "Nebuleus", (loot, mod) =>
            {
                ModdedLootUtils.AddModItemDrop(loot, mod, "GildedBonnet", 4);
                ModdedLootUtils.AddModItemDrop(loot, mod, "NebRelic");
            })) return;
    }
}