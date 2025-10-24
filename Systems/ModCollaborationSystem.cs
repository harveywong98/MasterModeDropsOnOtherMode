using MasterModeDropsOnOtherMode.Common.Configs;
using MasterModeDropsOnOtherMode.Systems.Handlers;
using Terraria;
using Terraria.ModLoader;

namespace MasterModeDropsOnOtherMode.Systems;

public static class ModCollaborationSystem
{
    public static void ModifyLoot(NPC npc, NPCLoot npcLoot)
    {
        // var config = ModContent.GetInstance<ModConfig>();
        // if (config.EnableRedemptionDrops && ModLoader.HasMod("Redemption"))
        if (ModLoader.HasMod("Redemption")) RedemptionLootHandler.ModifyLoot(npc, npcLoot);
        if (ModLoader.HasMod("SOTS")) SotsLootHandler.ModifyLoot(npc, npcLoot);
    }
}