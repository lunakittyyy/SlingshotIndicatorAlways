using HarmonyLib;

namespace SlingshotIndicatorAlways.Patches
{
    [HarmonyPatch(typeof(SlingshotLifeIndicator))]
    [HarmonyPatch("LateUpdate", MethodType.Normal)]
    internal class IndicatorPatch
    {
        private static bool Prefix(SlingshotLifeIndicator __instance)
        {
            if (!(GorillaGameManager.instance is GorillaBattleManager))
            {
                __instance.indicator1.SetActive(true);
                __instance.indicator2.SetActive(true);
                __instance.indicator3.SetActive(true);
                return false;
            }
            return true;
        }
    }
}
