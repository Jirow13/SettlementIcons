using System;
using HarmonyLib;
using TaleWorlds.CampaignSystem;

namespace SettlementIcons.Patches
{
	[HarmonyPatch(typeof(Settlement), "RemoveHero")]
	internal class PatchSettlement_RemoveHero
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
						bool isQuestAvailable = false;
						foreach (Hero hero in __instance.Notables)
						{
							bool flag4 = hero.Issue != null;
							if (flag4)
							{
								isQuestAvailable = true;
								break;
							}
						}
						SettlementIconStateRepo.States[__instance.Id].IsQuestAvailable = isQuestAvailable;
					}
				}
			}
		}
	}
}
