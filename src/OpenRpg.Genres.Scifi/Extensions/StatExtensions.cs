using OpenRpg.Core.Stats.Entity;
using OpenRpg.Genres.Scifi.Types;

namespace OpenRpg.Genres.Scifi.Extensions
{
    public static class EntityStatExtensions
    {
        public static float PhysicalDamage(this IEntityStatsVariables stats) => stats.Get(ScifiStatsVariableTypes.PhysicalDamage);
        public static float BallisticDamage(this IEntityStatsVariables stats) => stats.Get(ScifiStatsVariableTypes.BallisticDamage);
        public static float ExplosiveDamage(this IEntityStatsVariables stats) => stats.Get(ScifiStatsVariableTypes.ExplosiveDamage);
        public static float IonDamage(this IEntityStatsVariables stats) => stats.Get(ScifiStatsVariableTypes.IonDamage);
        public static float LaserDamage(this IEntityStatsVariables stats) => stats.Get(ScifiStatsVariableTypes.LaserDamage);
        public static void PhysicalDamage(this IEntityStatsVariables stats, float value) => stats[ScifiStatsVariableTypes.PhysicalDamage] = value;
        public static void BallisticDamage(this IEntityStatsVariables stats, float value) => stats[ScifiStatsVariableTypes.BallisticDamage] = value;
        public static void ExplosiveDamage(this IEntityStatsVariables stats, float value) => stats[ScifiStatsVariableTypes.ExplosiveDamage] = value;
        public static void IonDamage(this IEntityStatsVariables stats, float value) => stats[ScifiStatsVariableTypes.IonDamage] = value;
        public static void LaserDamage(this IEntityStatsVariables stats, float value) => stats[ScifiStatsVariableTypes.LaserDamage] = value;
        
        public static float PhysicalDefense(this IEntityStatsVariables stats) => stats.Get(ScifiStatsVariableTypes.PhysicalDefense);
        public static float BallisticDefense(this IEntityStatsVariables stats) => stats.Get(ScifiStatsVariableTypes.BallisticDefense);
        public static float ExplosiveDefense(this IEntityStatsVariables stats) => stats.Get(ScifiStatsVariableTypes.ExplosiveDefense);
        public static float IonDefense(this IEntityStatsVariables stats) => stats.Get(ScifiStatsVariableTypes.IonDefense);
        public static float LaserDefense(this IEntityStatsVariables stats) => stats.Get(ScifiStatsVariableTypes.LaserDefense);
        public static void PhysicalDefense(this IEntityStatsVariables stats, float value) => stats[ScifiStatsVariableTypes.PhysicalDefense] = value;
        public static void BallisticDefense(this IEntityStatsVariables stats, float value) => stats[ScifiStatsVariableTypes.BallisticDefense] = value;
        public static void ExplosiveDefense(this IEntityStatsVariables stats, float value) => stats[ScifiStatsVariableTypes.ExplosiveDefense] = value;
        public static void IonDefense(this IEntityStatsVariables stats, float value) => stats[ScifiStatsVariableTypes.IonDefense] = value;
        public static void LaserDefense(this IEntityStatsVariables stats, float value) => stats[ScifiStatsVariableTypes.LaserDefense] = value;
    }
}