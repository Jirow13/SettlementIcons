using System;
using HarmonyLib;
using TaleWorlds.CampaignSystem;

namespace SettlementIcons.Patches
{
	[HarmonyPatch(typeof(Hero), "OnIssueCreatedForHero")]
	internal class PatchHero_OnIssueCreatedForHero
	{
		public static void Postfix(Hero __instance)
		{
			bool flag = !Settings.SettlementIcons.IsQuestIconEnabled;
			if (!flag)
			{
				Settlement currentSettlement = __instance.CurrentSettlement;
				bool flag2 = currentSettlement == null;
				if (!flag2)
				{
					bool flag3 = SettlementIconStateRepo.States.ContainsKey(currentSettlement.Id);
					if (flag3)
					{
						SettlementIconStateRepo.States[currentSettlement.Id].IsQuestAvailable = true;
					}
				}
			}
		}
	}
}
