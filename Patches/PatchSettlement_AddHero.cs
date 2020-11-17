using System;
using HarmonyLib;
using TaleWorlds.CampaignSystem;

namespace SettlementIcons.Patches
{
	[HarmonyPatch(typeof(Settlement), "AddHero")]
	internal class PatchSettlement_AddHero
	{
		public static void Postfix(Settlement __instance, Hero individual)
		{
			bool flag = !Settings.SettlementIcons.IsQuestIconEnabled;
			if (!flag)
			{
				bool flag2 = individual.Issue == null;
				if (!flag2)
				{
					bool flag3 = SettlementIconStateRepo.States.ContainsKey(__instance.Id);
					if (flag3)
					{
						SettlementIconStateRepo.States[__instance.Id].IsQuestAvailable = true;
					}
				}
			}
		}
	}
}
