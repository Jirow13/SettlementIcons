using System;
using System.Collections.Generic;
using System.Linq;
using SandBox.ViewModelCollection.Nameplate;
using TaleWorlds.CampaignSystem;
using TaleWorlds.Engine;
using TaleWorlds.Library;

namespace SettlementIcons.ViewModels
{
	public class SettlementIconsNameplateVM : SettlementNameplateVM
	{
		public SettlementIconsNameplateVM(Settlement settlement, GameEntity entity, Camera mapCamera, Action<Vec2, float> setCameraPosition) : base(settlement, entity, mapCamera, setCameraPosition)
		{
			bool flag = !base.Settlement.IsHideout();
			if (flag)
			{
				SettlementIconState value = new SettlementIconState(base.Settlement);
				bool flag2 = SettlementIconStateRepo.States.ContainsKey(base.Settlement.Id);
				if (flag2)
				{
					SettlementIconStateRepo.States.Remove(base.Settlement.Id);
				}
				SettlementIconStateRepo.States.Add(base.Settlement.Id, value);
				bool flag3 = base.Settlement.IsVillage && base.Settlement.Village.VillageType != null;
				if (flag3)
				{
					string stringId = base.Settlement.Village.VillageType.StringId;
				}
			}
		}

		public bool IsPossibleNobleTroops
		{
			get
			{
				return this._isPossibleNobleTroops;
			}
			set
			{
				bool flag = value != this._isPossibleNobleTroops;
				if (flag)
				{
					this._isPossibleNobleTroops = value;
					this.InsertOrRemoveNotification("IsPossibleNobleTroops", value);
				}
			}
		}

		public bool IsQuestAvailable
		{
			get
			{
				return this._isQuestAvailable;
			}
			set
			{
				bool flag = value != this._isQuestAvailable;
				if (flag)
				{
					this._isQuestAvailable = value;
					this.InsertOrRemoveNotification("IsQuestAvailable", value);
				}
			}
		}

		public bool IsTournamentAvailable
		{
			get
			{
				return this._isTournamentAvailable;
			}
			set
			{
				bool flag = value != this._isTournamentAvailable;
				if (flag)
				{
					this._isTournamentAvailable = value;
					this.InsertOrRemoveNotification("IsTournamentAvailable", value);
				}
			}
		}

		public bool IsFlax
		{
			get
			{
				return this._isFlax;
			}
			set
			{
				bool flag = value != this._isFlax;
				if (flag)
				{
					this._isFlax = value;
					this.InsertOrRemoveNotification("IsFlax", value);
				}
			}
		}

		public bool IsClay
		{
			get
			{
				return this._isClay;
			}
			set
			{
				bool flag = value != this._isClay;
				if (flag)
				{
					this._isClay = value;
					this.InsertOrRemoveNotification("IsClay", value);
				}
			}
		}

		public bool IsGrain
		{
			get
			{
				return this._isGrain;
			}
			set
			{
				bool flag = value != this._isGrain;
				if (flag)
				{
					this._isGrain = value;
					this.InsertOrRemoveNotification("IsGrain", value);
				}
			}
		}

		public bool IsGrape
		{
			get
			{
				return this._isGrape;
			}
			set
			{
				bool flag = value != this._isGrape;
				if (flag)
				{
					this._isGrape = value;
					this.InsertOrRemoveNotification("IsGrape", value);
				}
			}
		}

		public bool IsHardwood
		{
			get
			{
				return this._isHardwood;
			}
			set
			{
				bool flag = value != this._isHardwood;
				if (flag)
				{
					this._isHardwood = value;
					this.InsertOrRemoveNotification("IsHardwood", value);
				}
			}
		}

		public bool IsHide
		{
			get
			{
				return this._isHide;
			}
			set
			{
				bool flag = value != this._isHide;
				if (flag)
				{
					this._isHide = value;
					this.InsertOrRemoveNotification("IsHide", value);
				}
			}
		}

		public bool IsHorse
		{
			get
			{
				return this._isHorse;
			}
			set
			{
				bool flag = value != this._isHorse;
				if (flag)
				{
					this._isHorse = value;
					this.InsertOrRemoveNotification("IsHorse", value);
				}
			}
		}

		public bool IsIron
		{
			get
			{
				return this._isIron;
			}
			set
			{
				bool flag = value != this._isIron;
				if (flag)
				{
					this._isIron = value;
					this.InsertOrRemoveNotification("IsIron", value);
				}
			}
		}

		public bool IsLeather
		{
			get
			{
				return this._isLeather;
			}
			set
			{
				bool flag = value != this._isLeather;
				if (flag)
				{
					this._isLeather = value;
					this.InsertOrRemoveNotification("IsLeather", value);
				}
			}
		}

		public bool IsOlive
		{
			get
			{
				return this._isOlive;
			}
			set
			{
				bool flag = value != this._isOlive;
				if (flag)
				{
					this._isOlive = value;
					this.InsertOrRemoveNotification("IsOlive", value);
				}
			}
		}

		public bool IsSilk
		{
			get
			{
				return this._isSilk;
			}
			set
			{
				bool flag = value != this._isSilk;
				if (flag)
				{
					this._isSilk = value;
					this.InsertOrRemoveNotification("IsSilk", value);
				}
			}
		}

		public bool IsWool
		{
			get
			{
				return this._isWool;
			}
			set
			{
				bool flag = value != this._isWool;
				if (flag)
				{
					this._isWool = value;
					this.InsertOrRemoveNotification("IsWool", value);
				}
			}
		}

		public bool IsCattle
		{
			get
			{
				return this._isCattle;
			}
			set
			{
				bool flag = value != this._isCattle;
				if (flag)
				{
					this._isCattle = value;
					this.InsertOrRemoveNotification("IsCattle", value);
				}
			}
		}

		public bool IsSilver
		{
			get
			{
				return this._isSilver;
			}
			set
			{
				bool flag = value != this._isSilver;
				if (flag)
				{
					this._isSilver = value;
					this.InsertOrRemoveNotification("IsSilver", value);
				}
			}
		}

		public bool IsFish
		{
			get
			{
				return this._isFish;
			}
			set
			{
				bool flag = value != this._isFish;
				if (flag)
				{
					this._isFish = value;
					this.InsertOrRemoveNotification("IsFish", value);
				}
			}
		}

		public bool IsDate
		{
			get
			{
				return this._isDate;
			}
			set
			{
				bool flag = value != this._isDate;
				if (flag)
				{
					this._isDate = value;
					this.InsertOrRemoveNotification("IsDate", value);
				}
			}
		}

		public bool IsSwine
		{
			get
			{
				return this._isSwine;
			}
			set
			{
				bool flag = value != this._isSwine;
				if (flag)
				{
					this._isSwine = value;
					this.InsertOrRemoveNotification("IsSwine", value);
				}
			}
		}

		public bool IsSalt
		{
			get
			{
				return this._isSalt;
			}
			set
			{
				bool flag = value != this._isSalt;
				if (flag)
				{
					this._isSalt = value;
					this.InsertOrRemoveNotification("IsSalt", value);
				}
			}
		}

		public MBBindingList<NotificationVM> Notifications
		{
			get
			{
				return this._notifications;
			}
			set
			{
				bool flag = value != this._notifications;
				if (flag)
				{
					this._notifications = value;
					base.OnPropertyChanged("Notifications");
				}
			}
		}

		private SettlementIconsNameplateVM.NotificationComparer _notificationsComparer { get; } = new SettlementIconsNameplateVM.NotificationComparer();

		private void InsertOrRemoveNotification(string propertyName, bool insert)
		{
			if (insert)
			{
				this.Notifications.Add(NotificationVM.FromPropertyName(propertyName));
				this.Notifications.Sort(this._notificationsComparer);
			}
			else
			{
				NotificationVM notificationVM = this.Notifications.SingleOrDefault((NotificationVM n) => (bool)typeof(NotificationVM).GetProperty(propertyName).GetValue(n));
				bool flag = notificationVM != null;
				if (flag)
				{
					this.Notifications.Remove(notificationVM);
				}
			}
		}

		public override void RefreshDynamicProperties(bool forceUpdate)
		{
			base.RefreshDynamicProperties(forceUpdate);
			bool flag = base.Settlement.IsHideout() || !SettlementIconStateRepo.States.ContainsKey(base.Settlement.Id);
			if (!flag)
			{
				bool flag2 = !Settings.SettlementIcons.IsRangeRestricted || base.Settlement.IsInspected;
				if (flag2)
				{
					SettlementIconState settlementIconState = SettlementIconStateRepo.States[base.Settlement.Id];
					this.IsPossibleNobleTroops = settlementIconState.IsPossibleNobleTroops;
					this.IsQuestAvailable = settlementIconState.IsQuestAvailable;
					this.IsTournamentAvailable = settlementIconState.IsTournamentAvailable;
					this.IsFlax = settlementIconState.IsFlax;
					this.IsClay = settlementIconState.IsClay;
					this.IsGrain = settlementIconState.IsGrain;
					this.IsGrape = settlementIconState.IsGrape;
					this.IsHardwood = settlementIconState.IsHardwood;
					this.IsHide = settlementIconState.IsHide;
					this.IsHorse = settlementIconState.IsHorse;
					this.IsIron = settlementIconState.IsIron;
					this.IsLeather = settlementIconState.IsLeather;
					this.IsOlive = settlementIconState.IsOlive;
					this.IsSilk = settlementIconState.IsSilk;
					this.IsWool = settlementIconState.IsWool;
					this.IsCattle = settlementIconState.IsCattle;
					this.IsSilver = settlementIconState.IsSilver;
					this.IsFish = settlementIconState.IsFish;
					this.IsDate = settlementIconState.IsDate;
					this.IsSwine = settlementIconState.IsSwine;
					this.IsSalt = settlementIconState.IsSalt;
				}
				else
				{
					this.IsPossibleNobleTroops = false;
					this.IsQuestAvailable = false;
					this.IsTournamentAvailable = false;
					this.IsFlax = false;
					this.IsClay = false;
					this.IsGrain = false;
					this.IsGrape = false;
					this.IsHardwood = false;
					this.IsHide = false;
					this.IsHorse = false;
					this.IsIron = false;
					this.IsLeather = false;
					this.IsOlive = false;
					this.IsSilk = false;
					this.IsWool = false;
					this.IsCattle = false;
					this.IsSilver = false;
					this.IsFish = false;
					this.IsDate = false;
					this.IsSwine = false;
					this.IsSalt = false;
				}
			}
		}

		private bool _isCattle;

		private bool _isClay;

		private bool _isDate;

		private bool _isFish;

		private bool _isFlax;

		private bool _isGrain;

		private bool _isGrape;

		private bool _isHardwood;

		private bool _isHide;

		private bool _isHorse;

		private bool _isIron;

		private bool _isLeather;

		private bool _isOlive;

		private bool _isPossibleNobleTroops;

		private bool _isQuestAvailable;

		private bool _isSalt;

		private bool _isSilk;

		private bool _isSilver;

		private bool _isSwine;

		private bool _isTournamentAvailable;

		private bool _isWool;

		private MBBindingList<NotificationVM> _notifications = new MBBindingList<NotificationVM>();

		private class NotificationComparer : IComparer<NotificationVM>
		{
			public int Compare(NotificationVM left, NotificationVM right)
			{
				return left.SortIndex.CompareTo(right.SortIndex);
			}
		}
	}
}
