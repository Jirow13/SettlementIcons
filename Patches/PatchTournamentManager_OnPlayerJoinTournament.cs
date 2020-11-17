using System;
using HarmonyLib;
using TaleWorlds.CampaignSystem;
using TaleWorlds.CampaignSystem.SandBox.Source.TournamentGames;

namespace SettlementIcons.Patches
{
	[HarmonyPatch(typeof(TournamentManager), "OnPlayerJoinTournament")]
	internal class PatchTournamentManager_OnPlayerJoinTournament
	{
		public static void Postfix(TournamentManager __instance, Type gameType, Settlement settlement)
		{
			bool flag = !Settings.SettlementIcons.IsTournamentIconEnabled;
			if (!flag)
			{
				bool flag2 = settlement == null;
				if (!flag2)
				{
					bool flag3 = SettlementIconStateRepo.States.ContainsKey(settlement.Id);
					if (flag3)
					{
						SettlementIconStateRepo.States[settlement.Id].IsTournamentAvailable = false;
					}
				}
			}
		}
	}
}
