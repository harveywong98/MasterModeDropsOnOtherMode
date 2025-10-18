using Terraria;
using Terraria.GameContent.ItemDropRules;

namespace MasterModeDropsOnOtherMode.Common;

public class PartnerDownCondition(int partnerNpcId) : IItemDropRuleCondition
{
    public bool CanDrop(DropAttemptInfo info)
    {
        return !NPC.AnyNPCs(partnerNpcId);
    }

    public bool CanShowItemDropInUI()
    {
        return true;
    }

    public string GetConditionDescription()
    {
        return "Drops when the boss is fully defeated";
    }
}