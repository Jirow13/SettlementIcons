using System;
using HarmonyLib;
using TaleWorlds.CampaignSystem;

namespace SettlementIcons.Patches
{
	[HarmonyPatch(typeof(Hero), "OnIssueDeactivatedForHero")]
	internal class PatchHero_OnIssueDeactivatedForHero
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
						bool isQuestAvailable = false;
						foreach (Hero hero in currentSettlement.Notables)
						{
							bool flag4 = hero.Issue != null;
							if (flag4)
							{
								isQuestAvailable = true;
								break;
							}
						}
						SettlementIconStateRepo.States[currentSettlement.Id].IsQuestAvailable = isQuestAvailable;
					}
				}
			}
		}
	}
}
