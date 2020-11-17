using System;
using Helpers;
using TaleWorlds.CampaignSystem;
using TaleWorlds.ObjectSystem;

namespace SettlementIcons
{
	internal class SettlementIconState
	{
		public SettlementIconState()
		{
		}

		public SettlementIconState(Settlement settlement)
		{
			foreach (Hero hero in settlement.Notables)
			{
				bool flag = Settings.SettlementIcons.IsNobleTroopIconEnabled && HeroHelper.HeroShouldGiveEliteTroop(hero);
				if (flag)
				{
					this.IsPossibleNobleTroops = true;
				}
				bool flag2 = Settings.SettlementIcons.IsQuestIconEnabled && hero.Issue != null;
				if (flag2)
				{
					this.IsQuestAvailable = true;
				}
			}
			bool flag3 = Settings.SettlementIcons.IsTournamentIconEnabled && settlement.IsTown && Campaign.Current.TournamentManager.GetTournamentGame(settlement.Town) != null;
			if (flag3)
			{
				this.IsTournamentAvailable = true;
			}
			bool flag4 = Settings.SettlementIcons.IsResourceIconsEnabled && settlement.IsVillage && settlement.Village.VillageType != null;
			if (flag4)
			{
				string stringId = settlement.Village.VillageType.StringId;
				uint num = 0U;
				bool flag5 = stringId != null;
				if (flag5)
				{
					num = 2166136261U;
					string text = stringId;
					for (int i = 0; i < text.Length; i++)
					{
						num = ((uint)text[i] ^ num) * 16777619U;
					}
				}
				bool flag6 = num <= 1509806192U;
				if (flag6)
				{
					bool flag7 = num <= 612390094U;
					if (flag7)
					{
						bool flag8 = num <= 391430808U;
						if (flag8)
						{
							bool flag9 = num != 311137604U;
							if (flag9)
							{
								bool flag10 = num != 391430808U;
								if (!flag10)
								{
									bool flag11 = stringId != "swine_farm";
									if (!flag11)
									{
										this.IsSwine = true;
									}
								}
							}
							else
							{
								bool flag12 = stringId != "fisherman";
								if (!flag12)
								{
									this.IsFish = true;
								}
							}
						}
						else
						{
							bool flag13 = num != 447076191U;
							if (flag13)
							{
								bool flag14 = num != 584841567U;
								if (flag14)
								{
									bool flag15 = num != 612390094U;
									if (!flag15)
									{
										bool flag16 = stringId != "silk_plant";
										if (!flag16)
										{
											this.IsSilk = true;
										}
									}
								}
								else
								{
									bool flag17 = stringId != "iron_mine";
									if (!flag17)
									{
										this.IsIron = true;
									}
								}
							}
							else
							{
								bool flag18 = stringId != "desert_horse_ranch";
								if (!flag18)
								{
									this.IsHorse = true;
								}
							}
						}
					}
					else
					{
						bool flag19 = num <= 1077548801U;
						if (flag19)
						{
							bool flag20 = num != 778525754U;
							if (flag20)
							{
								bool flag21 = num != 1077548801U;
								if (!flag21)
								{
									bool flag22 = stringId != "trapper";
									if (!flag22)
									{
										this.IsHide = true;
									}
								}
							}
							else
							{
								bool flag23 = stringId != "battanian_horse_ranch";
								if (!flag23)
								{
									this.IsHorse = true;
								}
							}
						}
						else
						{
							bool flag24 = num != 1294988078U;
							if (flag24)
							{
								bool flag25 = num != 1323181873U;
								if (flag25)
								{
									bool flag26 = num != 1509806192U;
									if (!flag26)
									{
										bool flag27 = stringId != "europe_horse_ranch";
										if (!flag27)
										{
											this.IsHorse = true;
										}
									}
								}
								else
								{
									bool flag28 = stringId != "salt_mine";
									if (!flag28)
									{
										this.IsSalt = true;
									}
								}
							}
							else
							{
								bool flag29 = stringId != "silver_mine";
								if (!flag29)
								{
									this.IsSilver = true;
								}
							}
						}
					}
				}
				else
				{
					bool flag30 = num <= 3023816321U;
					if (flag30)
					{
						bool flag31 = num <= 1791522831U;
						if (flag31)
						{
							bool flag32 = num != 1770050989U;
							if (flag32)
							{
								bool flag33 = num != 1791522831U;
								if (!flag33)
								{
									bool flag34 = stringId != "cattle_farm";
									if (!flag34)
									{
										this.IsCattle = true;
									}
								}
							}
							else
							{
								bool flag35 = stringId != "lumberjack";
								if (!flag35)
								{
									this.IsHardwood = true;
								}
							}
						}
						else
						{
							bool flag36 = num != 2590604115U;
							if (flag36)
							{
								bool flag37 = num != 2685698454U;
								if (flag37)
								{
									bool flag38 = num != 3023816321U;
									if (!flag38)
									{
										bool flag39 = stringId != "wheat_farm";
										if (!flag39)
										{
											this.IsGrain = true;
										}
									}
								}
								else
								{
									bool flag40 = stringId != "olive_trees";
									if (!flag40)
									{
										this.IsOlive = true;
									}
								}
							}
							else
							{
								bool flag41 = stringId != "steppe_horse_ranch";
								if (!flag41)
								{
									this.IsHorse = true;
								}
							}
						}
					}
					else
					{
						bool flag42 = num <= 3979548289U;
						if (flag42)
						{
							bool flag43 = num != 3120777606U;
							if (flag43)
							{
								bool flag44 = num != 3979548289U;
								if (!flag44)
								{
									bool flag45 = stringId != "vineyard";
									if (!flag45)
									{
										this.IsGrape = true;
									}
								}
							}
							else
							{
								bool flag46 = stringId != "date_farm";
								if (!flag46)
								{
									this.IsDate = true;
								}
							}
						}
						else
						{
							bool flag47 = num != 4007472742U;
							if (flag47)
							{
								bool flag48 = num != 4200144624U;
								if (flag48)
								{
									bool flag49 = num != 4237788325U;
									if (!flag49)
									{
										bool flag50 = stringId != "sheep_farm";
										if (!flag50)
										{
											this.IsWool = true;
										}
									}
								}
								else
								{
									bool flag51 = stringId != "flax_plant";
									if (!flag51)
									{
										this.IsFlax = true;
									}
								}
							}
							else
							{
								bool flag52 = stringId != "clay_mine";
								if (!flag52)
								{
									this.IsClay = true;
								}
							}
						}
					}
				}
			}
		}

		public MBGUID SettlementId { get; set; }

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
	}
}
