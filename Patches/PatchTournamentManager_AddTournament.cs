using System;
using HarmonyLib;
using TaleWorlds.CampaignSystem;
using TaleWorlds.CampaignSystem.SandBox.Source.TournamentGames;

namespace SettlementIcons.Patches
{
	[HarmonyPatch(typeof(TournamentManager), "AddTournament")]
	internal class PatchTournamentManager_AddTournament
	{
		public static void Postfix(TournamentManager __instance, TournamentGame game)
		{
			bool flag = !Settings.SettlementIcons.IsTournamentIconEnabled;
			if (!flag)
			{
				bool flag2 = ((game != null) ? game.Town : null) == null;
				if (!flag2)
				{
					bool flag3 = SettlementIconStateRepo.States.ContainsKey(game.Town.Settlement.Id);
					if (flag3)
					{
						SettlementIconStateRepo.States[game.Town.Settlement.Id].IsTournamentAvailable = true;
					}
				}
			}
		}
	}
}
