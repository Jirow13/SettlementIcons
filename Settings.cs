using System;
using System.IO;
using Newtonsoft.Json;
using TaleWorlds.Library;

namespace SettlementIcons
{
	internal class Settings
	{
		public static SettlementIconSettings SettlementIcons { get; set; }

		public static void Load()
		{
			string path = BasePath.Name + "Modules/SettlementIcons/ModuleData/settings.json";
			bool flag = !File.Exists(path);
			if (flag)
			{
				string contents = JsonConvert.SerializeObject(new SettlementIconSettings());
				File.WriteAllText(path, contents);
			}
			Settings.SettlementIcons = JsonConvert.DeserializeObject<SettlementIconSettings>(File.ReadAllText(path));
		}
	}
}
