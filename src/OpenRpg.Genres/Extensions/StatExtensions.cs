using OpenRpg.Core.Stats.Variables;
using OpenRpg.Genres.Types;

namespace OpenRpg.Genres.Extensions
{
    public static class StatExtensions
    {
        public static int MaxHealth(this IStatsVariables stats) => (int)stats.Get(GenreStatsVariableTypes.MaxHealth);
        public static void MaxHealth(this IStatsVariables stats, int value) => stats[GenreStatsVariableTypes.MaxHealth] = value;
        
        public static float Damage(this IStatsVariables stats) => stats.Get(GenreStatsVariableTypes.Damage);
        public static void Damage(this IStatsVariables stats, float value) => stats[GenreStatsVariableTypes.Damage] = value;
        public static float Defense(this IStatsVariables stats) => stats.Get(GenreStatsVariableTypes.Defense);
        public static void Defense(this IStatsVariables stats, float value) => stats[GenreStatsVariableTypes.Defense] = value;
    }
}