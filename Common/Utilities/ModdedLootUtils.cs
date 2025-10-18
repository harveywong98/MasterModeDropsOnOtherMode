using System;
using Terraria;
using Terraria.GameContent.ItemDropRules;
using Terraria.ModLoader;

namespace MasterModeDropsOnOtherMode.Common.Utilities;

public static class ModdedLootUtils
{
    public static bool ProcessBossLoot(NPC npc, NPCLoot npcLoot, Mod mod, string bossClassName,
        Action<NPCLoot, Mod> dropLogicAction)
    {
        if (mod.TryFind<ModNPC>(bossClassName, out var bossNpc) && npc.type == bossNpc.Type)
        {
            dropLogicAction(npcLoot, mod);
            return true;
        }

        return false;
    }

    public static void AddModItemDrop(NPCLoot npcLoot, Mod mod, string itemName, int chanceDenominator = 1)
    {
        if (mod.TryFind<ModItem>(itemName, out var item))
            npcLoot.Add(ItemDropRule.ByCondition(new Conditions.NotMasterMode(), item.Type, chanceDenominator));
    }

    public static void AddModItemDrop(IItemDropRule rule, Mod mod, string itemName, int chanceDenominator = 1)
    {
        if (mod.TryFind<ModItem>(itemName, out var item))
            rule.OnSuccess(ItemDropRule.ByCondition(new Conditions.NotMasterMode(), item.Type, chanceDenominator));
    }

    public static void AddPairedBossLoot(NPCLoot npcLoot, Mod mod, int partnerNpcId, string petItemName,
        string relicItemName)
    {
        var rule = new LeadingConditionRule(new PartnerDownCondition(partnerNpcId));

        AddModItemDrop(rule, mod, petItemName, 4);
        AddModItemDrop(rule, mod, relicItemName);

        npcLoot.Add(rule);
    }
}