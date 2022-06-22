using OpenRpg.Core.Stats.Variables;
using OpenRpg.Genres.Types;

namespace OpenRpg.Genres.Extensions
{
    public static class StatExtensions
    {
        public static int MaxHealth(this IStatsVariables stats) => (int)stats.Get(StatsVariableTypes.MaxHealth);
        public static void MaxHealth(this IStatsVariables stats, int value) => stats[StatsVariableTypes.MaxHealth] = value;
        
        public static float Damage(this IStatsVariables stats) => stats.Get(StatsVariableTypes.Damage);
        public static void Damage(this IStatsVariables stats, float value) => stats[StatsVariableTypes.Damage] = value;
        public static float Defense(this IStatsVariables stats) => stats.Get(StatsVariableTypes.Defense);
        public static void Defense(this IStatsVariables stats, float value) => stats[StatsVariableTypes.Defense] = value;
    }
}