using System.ComponentModel;
using Terraria.ModLoader.Config;

namespace MasterModeDropsOnOtherMode.Common.Configs;

// public class ModConfig : Terraria.ModLoader.Config.ModConfig
// {
//     public override ConfigScope Mode => ConfigScope.ServerSide;
//     
//     [Header("VanillaBossDrops")] // 配置界面中的标题
//     [Label("Enable Vanilla Boss Master Drops")]
//     [Tooltip("If true, vanilla bosses will drop their Master Mode items in non-Master worlds.")]
//     [DefaultValue(true)] // 默认开启
//     public bool EnableVanillaBossDrops { get; set; }
//     
//     
//     [Header("ModdedBossDrops")]
//     [Label("Enable Modded Boss Master Drops")]
//     [Tooltip("If true, bosses from supported mods will drop their Master Mode items in non-Master worlds.")]
//     [DefaultValue(true)]
//     public bool EnableModdedBossDrops { get; set; }
//     
//     [Label("Enable Redemption Drops")]
//     [Tooltip("A specific toggle for Redemption mod drops. Requires the master toggle above to be enabled.")]
//     [DefaultValue(true)]
//     public bool EnableRedemptionDrops { get; set; }
// }