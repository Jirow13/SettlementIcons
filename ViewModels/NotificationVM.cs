using System;
using System.Collections.Generic;
using TaleWorlds.Library;

namespace SettlementIcons.ViewModels
{
	public class NotificationVM : ViewModel
	{
		public bool IsPossibleNobleTroops { get; set; }

		public bool IsQuestAvailable { get; set; }

		public bool IsTournamentAvailable { get; set; }

		public bool IsFlax { get; set; }

		public bool IsClay { get; set; }

		public bool IsGrain { get; set; }

		public bool IsGrape { get; set; }

		public bool IsHardwood { get; set; }

		public bool IsHide { get; set; }

		public bool IsHorse { get; set; }

		public bool IsIron { get; set; }

		public bool IsLeather { get; set; }

		public bool IsOlive { get; set; }

		public bool IsSilk { get; set; }

		public bool IsWool { get; set; }

		public bool IsCattle { get; set; }

		public bool IsSilver { get; set; }

		public bool IsFish { get; set; }

		public bool IsDate { get; set; }

		public bool IsSwine { get; set; }

		public bool IsSalt { get; set; }

		public int SortIndex { get; set; }

		public static NotificationVM FromPropertyName(string propertyName)
		{
			NotificationVM notificationVM = new NotificationVM();
			typeof(NotificationVM).GetProperty(propertyName).SetValue(notificationVM, true);
			notificationVM.SortIndex = NotificationVM.NotificationSortIndex[propertyName];
			return notificationVM;
		}

		public static Dictionary<string, int> NotificationSortIndex = new Dictionary<string, int>
		{
			{
				"IsPossibleNobleTroops",
				0
			},
			{
				"IsTournamentAvailable",
				1
			},
			{
				"IsQuestAvailable",
				2
			},
			{
				"IsFlax",
				1
			},
			{
				"IsClay",
				1
			},
			{
				"IsGrain",
				1
			},
			{
				"IsGrape",
				1
			},
			{
				"IsHardwood",
				1
			},
			{
				"IsHide",
				1
			},
			{
				"IsHorse",
				1
			},
			{
				"IsIron",
				1
			},
			{
				"IsLeather",
				1
			},
			{
				"IsOlive",
				1
			},
			{
				"IsSilk",
				1
			},
			{
				"IsWool",
				1
			},
			{
				"IsCattle",
				1
			},
			{
				"IsSilver",
				1
			},
			{
				"IsFish",
				1
			},
			{
				"IsDate",
				1
			},
			{
				"IsSwine",
				1
			},
			{
				"IsSalt",
				1
			}
		};
	}
}
