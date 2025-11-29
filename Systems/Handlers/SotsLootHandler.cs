using MasterModeDropsOnOtherMode.Common.Utilities;
using Terraria;
using Terraria.ModLoader;

namespace MasterModeDropsOnOtherMode.Systems.Handlers;

public class SotsLootHandler
{
    public static void ModifyLoot(NPC npc, NPCLoot npcLoot)
    {
        var sotsMod = ModLoader.GetMod("SOTS");

        // 荧灯娥
        if (ModdedLootUtils.ProcessBossLoot(npc, npcLoot, sotsMod, "Glowmoth",
                (loot, mod) =>
                {
                    ModdedLootUtils.AddModItemDrop(loot, mod, "GlowmothRelic", ModdedLootUtils.DropType.Relic);
                })) return;
        // 腐蚀之粉
        if (ModdedLootUtils.ProcessBossLoot(npc, npcLoot, sotsMod, "PutridPinkyPhase2",
                (loot, mod) =>
                {
                    ModdedLootUtils.AddModItemDrop(loot, mod, "PutridPinkyRelic", ModdedLootUtils.DropType.Relic);
                })) return;
        // 法老咒魔
        if (ModdedLootUtils.ProcessBossLoot(npc, npcLoot, sotsMod, "PharaohsCurse",
                (loot, mod) =>
                {
                    ModdedLootUtils.AddModItemDrop(loot, mod, "PharaohsCurseRelic", ModdedLootUtils.DropType.Relic);
                })) return;
        // 掘地重蝎
        if (ModdedLootUtils.ProcessBossLoot(npc, npcLoot, sotsMod, "Excavator",
                (loot, mod) =>
                {
                    ModdedLootUtils.AddModItemDrop(loot, mod, "ExcavatorRelic", ModdedLootUtils.DropType.Relic);
                })) return;
        // 启示异械
        if (ModdedLootUtils.ProcessBossLoot(npc, npcLoot, sotsMod, "TheAdvisorHead", (loot, mod) =>
            {
                ModdedLootUtils.AddModItemDrop(loot, mod, "OtherworldlyServiceDevice",
                    ModdedLootUtils.DropType.LightPet, 4);
                ModdedLootUtils.AddModItemDrop(loot, mod, "AdvisorRelic", ModdedLootUtils.DropType.Relic);
            })) return;
        // 极北灾星
        if (ModdedLootUtils.ProcessBossLoot(npc, npcLoot, sotsMod, "NewPolaris",
                (loot, mod) =>
                {
                    ModdedLootUtils.AddModItemDrop(loot, mod, "PolarisRelic", ModdedLootUtils.DropType.Relic);
                })) return;
        // 辉光圣魂
        if (ModdedLootUtils.ProcessBossLoot(npc, npcLoot, sotsMod, "Lux", (loot, mod) =>
            {
                ModdedLootUtils.AddModItemDrop(loot, mod, "LuxBall", ModdedLootUtils.DropType.Accessory, 4);
                ModdedLootUtils.AddModItemDrop(loot, mod, "LuxRelic", ModdedLootUtils.DropType.Relic);
            })) return;
        // 亚空骇蟒
        if (ModdedLootUtils.ProcessBossLoot(npc, npcLoot, sotsMod, "SubspaceSerpentHead",
                (loot, mod) =>
                {
                    ModdedLootUtils.AddModItemDrop(loot, mod, "SubspaceSerpentRelic", ModdedLootUtils.DropType.Relic);
                })) return;
    }
}