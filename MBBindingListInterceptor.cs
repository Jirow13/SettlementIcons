using System;
using HarmonyLib;
using SandBox.ViewModelCollection.Nameplate;
using SettlementIcons.ViewModels;
using TaleWorlds.Engine;
using TaleWorlds.Library;

namespace SettlementIcons
{
	internal class MBBindingListInterceptor : MBBindingList<SettlementNameplateVM>
	{
		protected override void InsertItem(int index, SettlementNameplateVM item)
		{
			try
			{
				bool flag = item != null;
				if (flag)
				{
					Traverse traverse = Traverse.Create(item);
					GameEntity value = traverse.Field<GameEntity>("_entity").Value;
					Camera value2 = traverse.Field<Camera>("_mapCamera").Value;
					Action<Vec2, float> value3 = traverse.Field<Action<Vec2, float>>("_fastMoveCameraToPosition").Value;
					SettlementIconsNameplateVM item2 = new SettlementIconsNameplateVM(item.Settlement, value, value2, value3);
					base.InsertItem(index, item2);
				}
			}
			catch (Exception ex)
			{
				FileLog.Log(ex.ToString());
			}
		}
	}
}
