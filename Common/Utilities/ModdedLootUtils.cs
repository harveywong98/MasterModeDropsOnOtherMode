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
    
    public enum DropType
    {
        Pet,
        LightPet,
        Accessory,
        Mount,
        Relic,
    }

    public static void AddModItemDrop(NPCLoot npcLoot, Mod mod, string itemName, DropType dropType, int chanceDenominator = 1)
    {
        if (!mod.TryFind<ModItem>(itemName, out var item)) return;
        IItemDropRuleCondition condition;
        switch (dropType)
        {
            case DropType.Pet:
                condition = new NotMasterModeDropCondition(isForPet: true);
                break;
            case DropType.LightPet:
                condition = new NotMasterModeDropCondition(isForLightPet: true);
                break;
            case DropType.Accessory:
                condition = new NotMasterModeDropCondition(isForAccessory: true);
                break;
            case DropType.Mount:
                condition = new NotMasterModeDropCondition(isForMount: true);
                break;
            case DropType.Relic:
                condition = new NotMasterModeDropCondition(isForRelic: true);
                break;
            default:
                return;
        }
        npcLoot.Add(ItemDropRule.ByCondition(condition, item.Type, chanceDenominator));
    }
}