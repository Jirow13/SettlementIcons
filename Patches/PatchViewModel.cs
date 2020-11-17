using System;
using System.Reflection;
using HarmonyLib;
using SandBox.ViewModelCollection.Nameplate;
using TaleWorlds.Library;

namespace SettlementIcons.Patches
{
	[HarmonyPatch(typeof(ViewModel), "ExecuteCommand")]
	internal class PatchViewModel
	{
		public static void Postfix(ViewModel __instance, string commandName, object[] parameters)
		{
			Type type = __instance.GetType();
			bool flag = !type.IsSubclassOf(typeof(SettlementNameplateVM));
			if (!flag)
			{
				MethodInfo method = type.GetMethod(commandName, BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
				bool flag2 = method != null;
				if (!flag2)
				{
					method = typeof(SettlementNameplateVM).GetMethod(commandName, BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
					bool flag3 = method != null;
					if (flag3)
					{
						bool flag4 = method.GetParameters().Length == parameters.Length;
						if (flag4)
						{
							object[] array = new object[parameters.Length];
							ParameterInfo[] parameters2 = method.GetParameters();
							for (int i = 0; i < parameters.Length; i++)
							{
								object obj = parameters[i];
								Type parameterType = parameters2[i].ParameterType;
								array[i] = obj;
								string text = obj as string;
								bool flag5 = text != null && parameterType != typeof(string);
								if (flag5)
								{
									object obj2 = PatchViewModel.ConvertValueTo(text, parameterType);
									array[i] = obj2;
								}
							}
							method.InvokeWithLog(__instance, array);
						}
						else
						{
							bool flag6 = method.GetParameters().Length == 0;
							if (flag6)
							{
								method.InvokeWithLog(__instance, Array.Empty<object>());
							}
						}
					}
				}
			}
		}

		private static object ConvertValueTo(string value, Type parameterType)
		{
			object result = null;
			bool flag = parameterType == typeof(string);
			if (flag)
			{
				result = value;
			}
			else
			{
				bool flag2 = parameterType == typeof(int);
				if (flag2)
				{
					result = Convert.ToInt32(value);
				}
				else
				{
					bool flag3 = parameterType == typeof(float);
					if (flag3)
					{
						result = Convert.ToSingle(value);
					}
				}
			}
			return result;
		}
	}
}
