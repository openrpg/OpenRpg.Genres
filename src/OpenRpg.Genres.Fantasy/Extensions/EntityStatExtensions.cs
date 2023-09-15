using OpenRpg.Core.Stats.Entity;
using OpenRpg.Genres.Fantasy.Types;

namespace OpenRpg.Genres.Fantasy.Extensions
{
    public static class EntityStatExtensions
    {
        public static int Strength(this IEntityStatsVariables stats) => (int)stats.Get(FantasyStatsVariableTypes.Strength);
        public static int Dexterity(this IEntityStatsVariables stats) => (int)stats.Get(FantasyStatsVariableTypes.Dexterity);
        public static int Constitution(this IEntityStatsVariables stats) => (int)stats.Get(FantasyStatsVariableTypes.Constitution);
        public static int Intelligence(this IEntityStatsVariables stats) => (int)stats.Get(FantasyStatsVariableTypes.Intelligence);
        public static int Wisdom(this IEntityStatsVariables stats) => (int)stats.Get(FantasyStatsVariableTypes.Wisdom);
        public static int Charisma(this IEntityStatsVariables stats) => (int)stats.Get(FantasyStatsVariableTypes.Charisma);
        public static void Strength(this IEntityStatsVariables stats, int value) => stats[FantasyStatsVariableTypes.Strength] = value;
        public static void Dexterity(this IEntityStatsVariables stats, int value) => stats[FantasyStatsVariableTypes.Dexterity] = value;
        public static void Constitution(this IEntityStatsVariables stats, int value) => stats[FantasyStatsVariableTypes.Constitution] = value;
        public static void Intelligence(this IEntityStatsVariables stats, int value) => stats[FantasyStatsVariableTypes.Intelligence] = value;
        public static void Wisdom(this IEntityStatsVariables stats, int value) => stats[FantasyStatsVariableTypes.Wisdom] = value;
        public static void Charisma(this IEntityStatsVariables stats, int value) => stats[FantasyStatsVariableTypes.Charisma] = value;

        public static void MaxMagic(this IEntityStatsVariables stats, int value) => stats[FantasyStatsVariableTypes.MaxMagic] = value;
        public static int MaxMagic(this IEntityStatsVariables stats) => (int)stats.Get(FantasyStatsVariableTypes.MaxMagic);
        
        public static float IceDamage(this IEntityStatsVariables stats) => stats.Get(FantasyStatsVariableTypes.IceDamage);
        public static float FireDamage(this IEntityStatsVariables stats) => stats.Get(FantasyStatsVariableTypes.FireDamage);
        public static float WindDamage(this IEntityStatsVariables stats) => stats.Get(FantasyStatsVariableTypes.WindDamage);
        public static float EarthDamage(this IEntityStatsVariables stats) => stats.Get(FantasyStatsVariableTypes.EarthDamage);
        public static float LightDamage(this IEntityStatsVariables stats) => stats.Get(FantasyStatsVariableTypes.LightDamage);
        public static float DarkDamage(this IEntityStatsVariables stats) => stats.Get(FantasyStatsVariableTypes.DarkDamage);
        public static float SlashingDamage(this IEntityStatsVariables stats) => stats.Get(FantasyStatsVariableTypes.SlashingDamage);
        public static float BluntDamage(this IEntityStatsVariables stats) => stats.Get(FantasyStatsVariableTypes.BluntDamage);
        public static float PiercingDamage(this IEntityStatsVariables stats) => stats.Get(FantasyStatsVariableTypes.PiercingDamage);
        public static float UnarmedDamage(this IEntityStatsVariables stats) => stats.Get(FantasyStatsVariableTypes.UnarmedDamage);
        public static void IceDamage(this IEntityStatsVariables stats, float value) => stats[FantasyStatsVariableTypes.IceDamage] = value;
        public static void FireDamage(this IEntityStatsVariables stats, float value) => stats[FantasyStatsVariableTypes.FireDamage] = value;
        public static void WindDamage(this IEntityStatsVariables stats, float value) => stats[FantasyStatsVariableTypes.WindDamage] = value;
        public static void EarthDamage(this IEntityStatsVariables stats, float value) => stats[FantasyStatsVariableTypes.EarthDamage] = value;
        public static void LightDamage(this IEntityStatsVariables stats, float value) => stats[FantasyStatsVariableTypes.LightDamage] = value;
        public static void DarkDamage(this IEntityStatsVariables stats, float value) => stats[FantasyStatsVariableTypes.DarkDamage] = value;
        public static void SlashingDamage(this IEntityStatsVariables stats, float value) => stats[FantasyStatsVariableTypes.SlashingDamage] = value;
        public static void BluntDamage(this IEntityStatsVariables stats, float value) => stats[FantasyStatsVariableTypes.BluntDamage] = value;
        public static void PiercingDamage(this IEntityStatsVariables stats, float value) => stats[FantasyStatsVariableTypes.PiercingDamage] = value;
        public static void UnarmedDamage(this IEntityStatsVariables stats, float value) => stats[FantasyStatsVariableTypes.UnarmedDamage] = value;
        
        public static float IceDefense(this IEntityStatsVariables stats) => stats.Get(FantasyStatsVariableTypes.IceDefense);
        public static float FireDefense(this IEntityStatsVariables stats) => stats.Get(FantasyStatsVariableTypes.FireDefense);
        public static float WindDefense(this IEntityStatsVariables stats) => stats.Get(FantasyStatsVariableTypes.WindDefense);
        public static float EarthDefense(this IEntityStatsVariables stats) => stats.Get(FantasyStatsVariableTypes.EarthDefense);
        public static float LightDefense(this IEntityStatsVariables stats) => stats.Get(FantasyStatsVariableTypes.LightDefense);
        public static float DarkDefense(this IEntityStatsVariables stats) => stats.Get(FantasyStatsVariableTypes.DarkDefense);
        public static float SlashingDefense(this IEntityStatsVariables stats) => stats.Get(FantasyStatsVariableTypes.SlashingDefense);
        public static float BluntDefense(this IEntityStatsVariables stats) => stats.Get(FantasyStatsVariableTypes.BluntDefense);
        public static float PiercingDefense(this IEntityStatsVariables stats) => stats.Get(FantasyStatsVariableTypes.PiercingDefense);
        public static float UnarmedDefense(this IEntityStatsVariables stats) => stats.Get(FantasyStatsVariableTypes.UnarmedDefense);
        public static void IceDefense(this IEntityStatsVariables stats, float value) => stats[FantasyStatsVariableTypes.IceDefense] = value;
        public static void FireDefense(this IEntityStatsVariables stats, float value) => stats[FantasyStatsVariableTypes.FireDefense] = value;
        public static void WindDefense(this IEntityStatsVariables stats, float value) => stats[FantasyStatsVariableTypes.WindDefense] = value;
        public static void EarthDefense(this IEntityStatsVariables stats, float value) => stats[FantasyStatsVariableTypes.EarthDefense] = value;
        public static void LightDefense(this IEntityStatsVariables stats, float value) => stats[FantasyStatsVariableTypes.LightDefense] = value;
        public static void DarkDefense(this IEntityStatsVariables stats, float value) => stats[FantasyStatsVariableTypes.DarkDefense] = value;
        public static void SlashingDefense(this IEntityStatsVariables stats, float value) => stats[FantasyStatsVariableTypes.SlashingDefense] = value;
        public static void BluntDefense(this IEntityStatsVariables stats, float value) => stats[FantasyStatsVariableTypes.BluntDefense] = value;
        public static void PiercingDefense(this IEntityStatsVariables stats, float value) => stats[FantasyStatsVariableTypes.PiercingDefense] = value;
        public static void UnarmedDefense(this IEntityStatsVariables stats, float value) => stats[FantasyStatsVariableTypes.UnarmedDefense] = value;
    }
}