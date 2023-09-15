using OpenRpg.Core.Stats.Entity;
using OpenRpg.Genres.Types;

namespace OpenRpg.Genres.Extensions
{
    public static class EntityStatVariableExtensions
    {
        public static int MaxHealth(this IEntityStatsVariables stats) => (int)stats.Get(GenreStatsVariableTypes.MaxHealth);
        public static void MaxHealth(this IEntityStatsVariables stats, int value) => stats[GenreStatsVariableTypes.MaxHealth] = value;
        
        public static float Damage(this IEntityStatsVariables stats) => stats.Get(GenreStatsVariableTypes.Damage);
        public static void Damage(this IEntityStatsVariables stats, float value) => stats[GenreStatsVariableTypes.Damage] = value;
        public static float Defense(this IEntityStatsVariables stats) => stats.Get(GenreStatsVariableTypes.Defense);
        public static void Defense(this IEntityStatsVariables stats, float value) => stats[GenreStatsVariableTypes.Defense] = value;
    }
}