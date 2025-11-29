using System.ComponentModel;
using Terraria.ModLoader.Config;

namespace MasterModeDropsOnOtherMode.Common.Configs;

public class ModConfig : Terraria.ModLoader.Config.ModConfig
{
    public override ConfigScope Mode => ConfigScope.ServerSide;

    [Header("DropCategories")]
    [DefaultValue(true)]
    [Label("Enable Pet Drops")]
    [Tooltip("If true, bosses will drop their master mode exclusive pets in other modes.")]
    public bool DropPets { get; set; }

    [DefaultValue(true)]
    [Label("Enable Light Pet Drops")]
    [Tooltip("If true, bosses will drop their master mode exclusive light pets in other modes.")]
    public bool DropLightPets { get; set; }
    
    [DefaultValue(true)]
    [Label("Enable Accessory Drops")]
    [Tooltip("If true, bosses will drop their master mode exclusive accessory in other modes.")]
    public bool DropAccessory { get; set; }
    
    
    [DefaultValue(true)]
    [Label("Enable Mount Drops")]
    [Tooltip("If true, bosses will drop their master mode exclusive mounts in other modes.")]
    public bool DropMounts { get; set; }

    [DefaultValue(true)]
    [Label("Enable Relic Drops")]
    [Tooltip("If true, bosses will drop their master mode exclusive relics in other modes.")]
    public bool DropRelics { get; set; }
}
