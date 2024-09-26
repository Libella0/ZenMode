using HarmonyLib;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace ZenMode
{
    public static class Patcher
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        static public MethodInfo MI(Delegate func) => func.GetMethodInfo();
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        static public HarmonyMethod HM(Delegate func) => new(MI(func));
    }
}
