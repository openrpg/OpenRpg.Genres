using System.Collections.Generic;
using OpenRpg.Core.Stats;
using OpenRpg.Core.Stats.Entity;
using OpenRpg.Genres.Extensions;
using OpenRpg.Genres.Fantasy.Types;

namespace OpenRpg.Genres.Fantasy.Extensions
{
    public static class StatExtensions
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
        
        public static ICollection<StatReference> GetDamageReferences(this IEntityStatsVariables stats)
        {
            return new[]
            {
                new StatReference(FantasyGenreDamageTypes.IceDamage, stats.IceDamage()),
                new StatReference(FantasyGenreDamageTypes.FireDamage, stats.FireDamage()),
                new StatReference(FantasyGenreDamageTypes.WindDamage, stats.WindDamage()),
                new StatReference(FantasyGenreDamageTypes.EarthDamage, stats.EarthDamage()),
                new StatReference(FantasyGenreDamageTypes.LightDamage, stats.LightDamage()),
                new StatReference(FantasyGenreDamageTypes.DarkDamage, stats.DarkDamage()),
                new StatReference(FantasyGenreDamageTypes.SlashingDamage, stats.SlashingDamage()),
                new StatReference(FantasyGenreDamageTypes.BluntDamage, stats.BluntDamage()),
                new StatReference(FantasyGenreDamageTypes.PiercingDamage, stats.PiercingDamage()),
                new StatReference(FantasyGenreDamageTypes.UnarmedDamage, stats.UnarmedDamage()),
                new StatReference(FantasyGenreDamageTypes.Damage, stats.Damage())
            };
        }
        
        public static ICollection<StatReference> GetDefenseReferences(this IEntityStatsVariables stats)
        {
            return new[]
            {
                new StatReference(FantasyGenreDamageTypes.IceDamage, stats.IceDefense()),
                new StatReference(FantasyGenreDamageTypes.FireDamage, stats.FireDefense()),
                new StatReference(FantasyGenreDamageTypes.WindDamage, stats.WindDefense()),
                new StatReference(FantasyGenreDamageTypes.EarthDamage, stats.EarthDefense()),
                new StatReference(FantasyGenreDamageTypes.LightDamage, stats.LightDefense()),
                new StatReference(FantasyGenreDamageTypes.DarkDamage, stats.DarkDefense()),
                new StatReference(FantasyGenreDamageTypes.SlashingDamage, stats.SlashingDefense()),
                new StatReference(FantasyGenreDamageTypes.BluntDamage, stats.BluntDefense()),
                new StatReference(FantasyGenreDamageTypes.PiercingDamage, stats.PiercingDefense()),
                new StatReference(FantasyGenreDamageTypes.UnarmedDamage, stats.UnarmedDefense()),
                new StatReference(FantasyGenreDamageTypes.Damage, stats.Defense())
            };
        }
        
        public static float GetDefenseFor(this IEntityStatsVariables stats, int effectType)
        {
            if (effectType == FantasyGenreEffectTypes.PiercingBonusAmount) { return stats.PiercingDefense(); }
            if (effectType == FantasyGenreEffectTypes.SlashingBonusAmount) { return stats.SlashingDefense(); }
            if (effectType == FantasyGenreEffectTypes.BluntBonusAmount) { return stats.BluntDefense(); }
            if (effectType == FantasyGenreEffectTypes.UnarmedBonusAmount) { return stats.UnarmedDefense(); }
            if (effectType == FantasyGenreEffectTypes.FireBonusAmount) { return stats.FireDefense(); }
            if (effectType == FantasyGenreEffectTypes.IceBonusAmount) { return stats.IceDefense(); }
            if (effectType == FantasyGenreEffectTypes.WindBonusAmount) { return stats.WindDefense(); }
            if (effectType == FantasyGenreEffectTypes.EarthBonusAmount) { return stats.EarthDefense(); }
            if (effectType == FantasyGenreEffectTypes.LightBonusAmount) { return stats.LightDefense(); }
            if (effectType == FantasyGenreEffectTypes.DarkBonusAmount) { return stats.DarkDefense(); }

            if (effectType == FantasyGenreEffectTypes.AllElementDamageBonusAmount)
            {
                return stats.FireDefense() + stats.IceDefense() + stats.WindDefense() +
                       stats.EarthDefense() + stats.LightDefense() + stats.DarkDefense();
            }

            if (effectType == FantasyGenreEffectTypes.AllMeleeDefenseBonusAmount)
            {
                return stats.PiercingDefense() + stats.SlashingDefense() +
                       stats.BluntDefense() + stats.UnarmedDefense();
            }

            if (effectType == FantasyGenreEffectTypes.DamageBonusAmount)
            { return stats.Defense(); }

            return 0;
        }
        
        public static float GetDefenseFromDamageType(this IEntityStatsVariables stats, int damageType)
        {
            if (damageType == FantasyGenreDamageTypes.PiercingDamage) { return stats.PiercingDefense(); }
            if (damageType == FantasyGenreDamageTypes.SlashingDamage) { return stats.SlashingDefense(); }
            if (damageType == FantasyGenreDamageTypes.BluntDamage) { return stats.BluntDefense(); }
            if (damageType == FantasyGenreDamageTypes.UnarmedDamage) { return stats.UnarmedDefense(); }
            if (damageType == FantasyGenreDamageTypes.FireDamage) { return stats.FireDefense(); }
            if (damageType == FantasyGenreDamageTypes.IceDamage) { return stats.IceDefense(); }
            if (damageType == FantasyGenreDamageTypes.WindDamage) { return stats.WindDefense(); }
            if (damageType == FantasyGenreDamageTypes.EarthDamage) { return stats.EarthDefense(); }
            if (damageType == FantasyGenreDamageTypes.LightDamage) { return stats.LightDefense(); }
            if (damageType == FantasyGenreDamageTypes.DarkDamage) { return stats.DarkDefense(); }
            if (damageType == FantasyGenreDamageTypes.Damage) { return stats.Defense(); }
            return 0;
        }

        public static float GetDamageFor(this IEntityStatsVariables stats, int effectType)
        {
            if (effectType == FantasyGenreEffectTypes.PiercingBonusAmount) { return stats.PiercingDamage(); }
            if (effectType == FantasyGenreEffectTypes.SlashingBonusAmount) { return stats.SlashingDamage(); }
            if (effectType == FantasyGenreEffectTypes.BluntBonusAmount) { return stats.BluntDamage(); }
            if (effectType == FantasyGenreEffectTypes.UnarmedBonusAmount) { return stats.UnarmedDamage(); }
            if (effectType == FantasyGenreEffectTypes.FireBonusAmount) { return stats.FireDamage(); }
            if (effectType == FantasyGenreEffectTypes.IceBonusAmount) { return stats.IceDamage(); }
            if (effectType == FantasyGenreEffectTypes.WindBonusAmount) { return stats.WindDamage(); }
            if (effectType == FantasyGenreEffectTypes.EarthBonusAmount) { return stats.EarthDamage(); }
            if (effectType == FantasyGenreEffectTypes.LightBonusAmount) { return stats.LightDamage(); }
            if (effectType == FantasyGenreEffectTypes.DarkBonusAmount) { return stats.DarkDamage(); }

            if (effectType == FantasyGenreEffectTypes.AllElementDamageBonusAmount)
            {
                return stats.FireDamage() + stats.IceDamage() + stats.WindDamage() +
                       stats.EarthDamage() + stats.LightDamage() + stats.DarkDamage();
            }

            if (effectType == FantasyGenreEffectTypes.AllMeleeDefenseBonusAmount)
            {
                return stats.PiercingDamage() + stats.SlashingDamage() +
                       stats.BluntDamage() + stats.UnarmedDamage();
            }

            if (effectType == FantasyGenreEffectTypes.DamageBonusAmount)
            { return stats.Damage(); }

            return 0;
        }
        
        public static float GetDamageFromDamageType(this IEntityStatsVariables stats, int damageType)
        {
            if (damageType == FantasyGenreDamageTypes.PiercingDamage) { return stats.PiercingDamage(); }
            if (damageType == FantasyGenreDamageTypes.SlashingDamage) { return stats.SlashingDamage(); }
            if (damageType == FantasyGenreDamageTypes.BluntDamage) { return stats.BluntDamage(); }
            if (damageType == FantasyGenreDamageTypes.UnarmedDamage) { return stats.UnarmedDamage(); }
            if (damageType == FantasyGenreDamageTypes.FireDamage) { return stats.FireDamage(); }
            if (damageType == FantasyGenreDamageTypes.IceDamage) { return stats.IceDamage(); }
            if (damageType == FantasyGenreDamageTypes.WindDamage) { return stats.WindDamage(); }
            if (damageType == FantasyGenreDamageTypes.EarthDamage) { return stats.EarthDamage(); }
            if (damageType == FantasyGenreDamageTypes.LightDamage) { return stats.LightDamage(); }
            if (damageType == FantasyGenreDamageTypes.DarkDamage) { return stats.DarkDamage(); }
            if (damageType == FantasyGenreDamageTypes.Damage) { return stats.Damage(); }
            return 0;
        }
    }
}