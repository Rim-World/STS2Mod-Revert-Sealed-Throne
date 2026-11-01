using HarmonyLib;
using MegaCrit.Sts2.Core.Entities.Cards;
using MegaCrit.Sts2.Core.Models.Cards;

namespace RevertTheSealedThrone.Patches;

/// <summary>
/// 将封印王座（The Sealed Throne）的升级效果从 v0.107.1+ 的「费用 -1」
/// 回调为 v0.106 及之前的「添加固有（Innate）」。
/// 107 与 111 中该卡 OnUpgrade 均为 EnergyCost.UpgradeBy(-1)，一补丁通吃。
/// </summary>
[HarmonyPatch(typeof(TheSealedThrone), "OnUpgrade")]
public static class SealedThroneUpgradePatch
{
    public static bool Prefix(TheSealedThrone __instance)
    {
        if (SealedThroneShapeGuard.IsSupported() && !__instance.Keywords.Contains(CardKeyword.Innate))
        {
            __instance.AddKeyword(CardKeyword.Innate);
            return false;
        }
        return true;
    }
}