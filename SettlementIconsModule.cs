using System;
using System.Collections.Generic;
using System.Windows.Forms;
using HarmonyLib;
using TaleWorlds.Engine;
using TaleWorlds.Engine.GauntletUI;
using TaleWorlds.Library;
using TaleWorlds.MountAndBlade;
using TaleWorlds.TwoDimension;

namespace SettlementIcons
{
	public class SettlementIconsModule : MBSubModuleBase
	{
		protected override void OnSubModuleLoad()
		{
			base.OnSubModuleLoad();
			try
			{
				Settings.Load();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Failed to load SettlementIcons settings:\n" + ex.Message);
			}
			try
			{
				SpriteData spriteData = new SpriteData("siSpriteData");

				spriteData.Load(UIResourceManager.UIResourceDepot);
				// 1.5.4 - Commented out the SpriteData loading as it's handled by the TW engine now. 
				/*
				foreach (KeyValuePair<string, SpriteCategory> keyValuePair in spriteData.SpriteCategories)
				{
					UIResourceManager.SpriteData.SpriteCategories.Add(keyValuePair.Key, keyValuePair.Value);
					//MessageBox.Show("Pairs: " + keyValuePair.Key + " - " + keyValuePair.Value);
				}
				foreach (KeyValuePair<string, SpritePart> keyValuePair2 in spriteData.SpritePartNames)
				{
					UIResourceManager.SpriteData.SpritePartNames.Add(keyValuePair2.Key, keyValuePair2.Value);
				}
				foreach (KeyValuePair<string, Sprite> keyValuePair3 in spriteData.SpriteNames)
				{
					UIResourceManager.SpriteData.SpriteNames.Add(keyValuePair3.Key, keyValuePair3.Value);
				}
				*/
				UIResourceManager.SpriteData.SpriteCategories["ui_custom"].Load(UIResourceManager.ResourceContext, UIResourceManager.UIResourceDepot);
				UIResourceManager.SpriteData.SpriteCategories["ui_custom"].SpriteSheets.Clear();
				string folder = BasePath.Name + "/Modules/SettlementIcons/GUI/SpriteSheets/ui_custom/";
				TaleWorlds.TwoDimension.Texture item = new TaleWorlds.TwoDimension.Texture(new EngineTexture(TaleWorlds.Engine.Texture.LoadTextureFromPath("ui_custom_1.png", folder)));
				UIResourceManager.SpriteData.SpriteCategories["ui_custom"].SpriteSheets.Add(item);
			}
			catch (Exception ex2)
			{
				MessageBox.Show("Failed to load sprites " + ex2.Message);
			}
			try
			{
				new Harmony("com.rhokwar.bannerlord.settlementicons").PatchAll();
				bool isQuestIconEnabled = Settings.SettlementIcons.IsQuestIconEnabled;
				bool isTournamentIconEnabled = Settings.SettlementIcons.IsTournamentIconEnabled;
			}
			catch (Exception ex3)
			{
				Exception innerException = ex3.InnerException;
				MessageBox.Show("Failed to apply the SettlementIcons patch:\n" + ex3.Message + "\n" + ((innerException != null) ? innerException.Message : null));
			}
		}
	}
}
