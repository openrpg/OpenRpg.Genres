using OpenRpg.Core.Stats;
using OpenRpg.Genres.Types;

namespace OpenRpg.Genres.Extensions
{
    public static class StatExtensions
    {
        public static int Health(this IStatsVariables stats) => (int)stats.Get(StatsVariableTypes.Health);
        public static int MaxHealth(this IStatsVariables stats) => (int)stats.Get(StatsVariableTypes.MaxHealth);
        public static void Health(this IStatsVariables stats, int value) => stats[StatsVariableTypes.Health] = value;
        public static void MaxHealth(this IStatsVariables stats, int value) => stats[StatsVariableTypes.MaxHealth] = value;

        public static void HealthWithCheck(this IStatsVariables stats, int value)
        {
            if(value > stats.Get(StatsVariableTypes.MaxHealth))
            { stats[StatsVariableTypes.Health] = stats.Get(StatsVariableTypes.MaxHealth); }
            else if(value <= 0)
            { stats[StatsVariableTypes.Health] = 0; }
            else
            { stats[StatsVariableTypes.Health] = value; }
        }

        public static void AddHealth(this IStatsVariables stats, int change) => stats.HealthWithCheck(stats.Health() + change);
        public static void DeductHealth(this IStatsVariables stats, int change) => stats.HealthWithCheck(stats.Health() - change);
        
        public static float PureDamage(this IStatsVariables stats) => stats.Get(StatsVariableTypes.PureDamage);
        public static void PureDamage(this IStatsVariables stats, float value) => stats[StatsVariableTypes.PureDamage] = value;
        public static float PureDefense(this IStatsVariables stats) => stats.Get(StatsVariableTypes.PureDefense);
        public static void PureDefense(this IStatsVariables stats, float value) => stats[StatsVariableTypes.PureDefense] = value;
    }
}