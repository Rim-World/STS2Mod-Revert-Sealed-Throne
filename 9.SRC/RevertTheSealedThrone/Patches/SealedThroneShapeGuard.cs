using System.Reflection;
using MegaCrit.Sts2.Core.Entities.Cards;
using MegaCrit.Sts2.Core.Logging;
using MegaCrit.Sts2.Core.Models;
using MegaCrit.Sts2.Core.Models.Cards;

namespace RevertTheSealedThrone.Patches;

/// <summary>
/// 形状守卫：确认当前版本的封印王座仍是受支持形态
/// （能量费 1 / 星费 3 / 能力 / 先古稀有度 / 基础版不含固有）。
/// 若未来版本再次改动该卡，所有补丁自动失效并 Log 警告，避免破坏游戏。
/// </summary>
public static class SealedThroneShapeGuard
{
    private static readonly PropertyInfo? CanonicalEnergyCostProp =
        typeof(CardModel).GetProperty("CanonicalEnergyCost",
            BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);

    private static bool? _supported;

    private static bool _warned;

    public static bool IsSupported()
    {
        if (_supported.HasValue)
        {
            return _supported.Value;
        }

        bool ok = false;
        try
        {
            TheSealedThrone card = ModelDb.Card<TheSealedThrone>();
            ok = CanonicalEnergyCostProp != null
                && CanonicalEnergyCostProp.GetValue(card) is int canonicalCost && canonicalCost == 1
                && card.CanonicalStarCost == 3
                && card.Type == CardType.Power
                && card.Rarity == CardRarity.Ancient
                && !card.Keywords.Contains(CardKeyword.Innate);
            _supported = ok;
        }
        catch
        {
            // ModelDb 尚未就绪时暂不拦截，下次访问再评估
            return true;
        }

        if (!ok)
        {
            MarkUnsupported("The Sealed Throne shape differs from the supported version");
        }

        return ok;
    }

    private static void MarkUnsupported(string reason)
    {
        _supported = false;
        if (!_warned)
        {
            _warned = true;
            Log.Warn($"{ModEntry.ModId}: {reason}; patches are disabled.");
        }
    }
}