using System;
using System.Reflection;
using HarmonyLib;
using MegaCrit.Sts2.Core.Logging;
using MegaCrit.Sts2.Core.Modding;

namespace RevertTheSealedThrone;

[ModInitializer("ModLoaded")]
public static class ModEntry
{
    public const string ModId = "RevertTheSealedThrone";

    private static Harmony? _harmony;

    public static void ModLoaded()
    {
        try
        {
            Log.Info($"{ModId}: loading...");
            _harmony = new Harmony(ModId);
            _harmony.PatchAll(Assembly.GetExecutingAssembly());
            Log.Info($"{ModId}: Harmony patches applied (The Sealed Throne upgrade -> Innate)");
        }
        catch (Exception e)
        {
            Log.Error($"{ModId}: failed to apply patches: {e}");
        }
    }
}