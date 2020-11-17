using System;
using System.Collections.Generic;
using TaleWorlds.ObjectSystem;

namespace SettlementIcons
{
	internal class SettlementIconStateRepo
	{
		public static Dictionary<MBGUID, SettlementIconState> States { get; set; } = new Dictionary<MBGUID, SettlementIconState>();
	}
}
