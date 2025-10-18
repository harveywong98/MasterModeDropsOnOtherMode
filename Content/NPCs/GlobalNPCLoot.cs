using MasterModeDropsOnOtherMode.Systems;
using Terraria;
using Terraria.ModLoader;

namespace MasterModeDropsOnOtherMode.Content.NPCs;

public class GlobalNpcLoot : GlobalNPC
{
    public override void ModifyNPCLoot(NPC npc, NPCLoot npcLoot)
    {
        VanillaLootSystem.ModifyLoot(npc, npcLoot);
        ModCollaborationSystem.ModifyLoot(npc, npcLoot);
    }
}