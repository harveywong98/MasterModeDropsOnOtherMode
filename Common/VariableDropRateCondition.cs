using Terraria;
using Terraria.GameContent.ItemDropRules;

namespace MasterModeDropsOnOtherMode.Common;

public class VariableDropRateCondition(double minRate, double maxRate) : IItemDropRuleCondition
{
    public bool CanDrop(DropAttemptInfo info)
    {
        if (Main.masterMode || info.IsInSimulation) return false;

        var actualDropChance = minRate + (maxRate - minRate) * info.rng.NextDouble();

        return info.rng.NextDouble() < actualDropChance;
    }

    public bool CanShowItemDropInUI()
    {
        return true;
    }

    public string GetConditionDescription()
    {
        var minPercent = (int)(minRate * 100);
        var maxPercent = (int)(maxRate * 100);
        return $"{minPercent}% to {maxPercent}% chance";
    }
}