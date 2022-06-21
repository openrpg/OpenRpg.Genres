using OpenRpg.Core.Stats.Variables;
using OpenRpg.Genres.Types;

namespace OpenRpg.Genres.Extensions
{
    public static class StatExtensions
    {
        public static int MaxHealth(this IStatsVariables stats) => (int)stats.Get(StatsVariableTypes.MaxHealth);
        public static void MaxHealth(this IStatsVariables stats, int value) => stats[StatsVariableTypes.MaxHealth] = value;
        
        public static float PureDamage(this IStatsVariables stats) => stats.Get(StatsVariableTypes.Damage);
        public static void PureDamage(this IStatsVariables stats, float value) => stats[StatsVariableTypes.Damage] = value;
        public static float PureDefense(this IStatsVariables stats) => stats.Get(StatsVariableTypes.Defense);
        public static void PureDefense(this IStatsVariables stats, float value) => stats[StatsVariableTypes.Defense] = value;
    }
}