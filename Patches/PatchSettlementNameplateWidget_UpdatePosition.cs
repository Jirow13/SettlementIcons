using System;
using HarmonyLib;
using TaleWorlds.MountAndBlade.GauntletUI.Widgets.Map;
using TaleWorlds.MountAndBlade.GauntletUI.Widgets.Nameplate;

namespace SettlementIcons.Patches
{
	[HarmonyPatch(typeof(SettlementNameplateWidget), "UpdatePosition")]
	public class PatchSettlementNameplateWidget_UpdatePosition
	{
		private static bool Prefix(SettlementNameplateWidget __instance)
		{
			SettlementNameplateItemWidget value = Traverse.Create(__instance).Field<SettlementNameplateItemWidget>("_currentNameplate").Value;
			bool flag = value.MapEventVisualWidget == null;
			if (flag)
			{
				value.MapEventVisualWidget = new MapEventVisualWidget(__instance.Context);
			}
			return true;
		}

		private static Exception Finalizer(Exception __exception)
		{
			bool flag = __exception != null;
			if (flag)
			{
				FileLog.Log(__exception.ToString());
			}
			return null;
		}
	}
}
