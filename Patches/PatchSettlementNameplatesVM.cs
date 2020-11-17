using System;
using HarmonyLib;
using SandBox.ViewModelCollection.Nameplate;
using TaleWorlds.Engine;
using TaleWorlds.Library;

namespace SettlementIcons.Patches
{
	[HarmonyPatch(typeof(SettlementNameplatesVM), MethodType.Constructor, new Type[]
	{
		typeof(Camera),
		typeof(Action<Vec2, float>)
	})]
	public class PatchSettlementNameplatesVM
	{
		public static void Postfix(SettlementNameplatesVM __instance)
		{
			MBBindingListInterceptor nameplates = new MBBindingListInterceptor();
			__instance.Nameplates = nameplates;
		}
	}
}
