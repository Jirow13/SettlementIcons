using System;
using Newtonsoft.Json;

namespace SettlementIcons
{
	internal class SettlementIconSettings
	{
		[JsonProperty]
		public bool IsRangeRestricted { get; private set; }

		[JsonProperty]
		public bool IsNobleTroopIconEnabled { get; private set; } = true;

		[JsonProperty]
		public bool IsQuestIconEnabled { get; private set; } = true;

		[JsonProperty]
		public bool IsTournamentIconEnabled { get; private set; } = true;

		[JsonProperty]
		public bool IsResourceIconsEnabled { get; private set; }
	}
}
