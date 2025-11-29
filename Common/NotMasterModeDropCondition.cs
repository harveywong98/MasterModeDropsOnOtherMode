using MasterModeDropsOnOtherMode.Common.Configs;
using Terraria;
using Terraria.GameContent.ItemDropRules;
using Terraria.ModLoader;

namespace MasterModeDropsOnOtherMode.Common;

public class NotMasterModeDropCondition(bool isForPet = false, bool isForLightPet = false, bool isForAccessory = false, bool isForMount = false, bool isForRelic = false)
    : IItemDropRuleCondition
{
    public bool CanDrop(DropAttemptInfo info)
    {
        return DoCheck();
    }

    public bool CanShowItemDropInUI()
    {
        return DoCheck();
    }

    public string GetConditionDescription()
    {
        // 在UI中显示的条件描述文本
        return "Drops in non-master modes if enabled in the config.";
    }

    private bool DoCheck()
    {
        if (Main.masterMode) return false;
        var config = ModContent.GetInstance<ModConfig>();
        if (isForPet && config.DropPets) return true;
        if (isForLightPet && config.DropLightPets) return true;
        if (isForAccessory && config.DropAccessory) return true;
        if (isForMount && config.DropMounts) return true;
        if (isForRelic && config.DropRelics) return true;
        return false;
    }
}