using System;
using HarmonyLib;
using XRL.World;
using XRL.World.Parts;
using XRL.World.Tinkering;

[HarmonyPatch(typeof(DataDisk))]
class DataDiskPatch
{
	[HarmonyPostfix]
	[HarmonyPatch("HandleEvent", new Type[] { typeof(GetDisplayNameEvent) })]
	static void RegisterPostFix(DataDisk __instance, GetDisplayNameEvent E)
	{
		if (TinkerData.RecipeKnown(__instance.Data))
		{
			E.AddBase("{{W|known}}");
		}
	}
}
