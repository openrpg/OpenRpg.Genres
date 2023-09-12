using System.Collections.Generic;
using OpenRpg.Core.Stats;
using OpenRpg.Core.Stats.Variables;
using OpenRpg.Genres.Extensions;
using OpenRpg.Genres.Fantasy.Types;

namespace OpenRpg.Genres.Fantasy.Extensions
{
    public static class StatExtensions
    {
        public static int Strength(this IStatsVariables stats) => (int)stats.Get(FantasyStatsVariableTypes.Strength);
        public static int Dexterity(this IStatsVariables stats) => (int)stats.Get(FantasyStatsVariableTypes.Dexterity);
        public static int Constitution(this IStatsVariables stats) => (int)stats.Get(FantasyStatsVariableTypes.Constitution);
        public static int Intelligence(this IStatsVariables stats) => (int)stats.Get(FantasyStatsVariableTypes.Intelligence);
        public static int Wisdom(this IStatsVariables stats) => (int)stats.Get(FantasyStatsVariableTypes.Wisdom);
        public static int Charisma(this IStatsVariables stats) => (int)stats.Get(FantasyStatsVariableTypes.Charisma);
        public static void Strength(this IStatsVariables stats, int value) => stats[FantasyStatsVariableTypes.Strength] = value;
        public static void Dexterity(this IStatsVariables stats, int value) => stats[FantasyStatsVariableTypes.Dexterity] = value;
        public static void Constitution(this IStatsVariables stats, int value) => stats[FantasyStatsVariableTypes.Constitution] = value;
        public static void Intelligence(this IStatsVariables stats, int value) => stats[FantasyStatsVariableTypes.Intelligence] = value;
        public static void Wisdom(this IStatsVariables stats, int value) => stats[FantasyStatsVariableTypes.Wisdom] = value;
        public static void Charisma(this IStatsVariables stats, int value) => stats[FantasyStatsVariableTypes.Charisma] = value;

        public static void MaxMagic(this IStatsVariables stats, int value) => stats[FantasyStatsVariableTypes.MaxMagic] = value;
        public static int MaxMagic(this IStatsVariables stats) => (int)stats.Get(FantasyStatsVariableTypes.MaxMagic);
        
        public static float IceDamage(this IStatsVariables stats) => stats.Get(FantasyStatsVariableTypes.IceDamage);
        public static float FireDamage(this IStatsVariables stats) => stats.Get(FantasyStatsVariableTypes.FireDamage);
        public static float WindDamage(this IStatsVariables stats) => stats.Get(FantasyStatsVariableTypes.WindDamage);
        public static float EarthDamage(this IStatsVariables stats) => stats.Get(FantasyStatsVariableTypes.EarthDamage);
        public static float LightDamage(this IStatsVariables stats) => stats.Get(FantasyStatsVariableTypes.LightDamage);
        public static float DarkDamage(this IStatsVariables stats) => stats.Get(FantasyStatsVariableTypes.DarkDamage);
        public static float SlashingDamage(this IStatsVariables stats) => stats.Get(FantasyStatsVariableTypes.SlashingDamage);
        public static float BluntDamage(this IStatsVariables stats) => stats.Get(FantasyStatsVariableTypes.BluntDamage);
        public static float PiercingDamage(this IStatsVariables stats) => stats.Get(FantasyStatsVariableTypes.PiercingDamage);
        public static float UnarmedDamage(this IStatsVariables stats) => stats.Get(FantasyStatsVariableTypes.UnarmedDamage);
        public static void IceDamage(this IStatsVariables stats, float value) => stats[FantasyStatsVariableTypes.IceDamage] = value;
        public static void FireDamage(this IStatsVariables stats, float value) => stats[FantasyStatsVariableTypes.FireDamage] = value;
        public static void WindDamage(this IStatsVariables stats, float value) => stats[FantasyStatsVariableTypes.WindDamage] = value;
        public static void EarthDamage(this IStatsVariables stats, float value) => stats[FantasyStatsVariableTypes.EarthDamage] = value;
        public static void LightDamage(this IStatsVariables stats, float value) => stats[FantasyStatsVariableTypes.LightDamage] = value;
        public static void DarkDamage(this IStatsVariables stats, float value) => stats[FantasyStatsVariableTypes.DarkDamage] = value;
        public static void SlashingDamage(this IStatsVariables stats, float value) => stats[FantasyStatsVariableTypes.SlashingDamage] = value;
        public static void BluntDamage(this IStatsVariables stats, float value) => stats[FantasyStatsVariableTypes.BluntDamage] = value;
        public static void PiercingDamage(this IStatsVariables stats, float value) => stats[FantasyStatsVariableTypes.PiercingDamage] = value;
        public static void UnarmedDamage(this IStatsVariables stats, float value) => stats[FantasyStatsVariableTypes.UnarmedDamage] = value;
        
        public static float IceDefense(this IStatsVariables stats) => stats.Get(FantasyStatsVariableTypes.IceDefense);
        public static float FireDefense(this IStatsVariables stats) => stats.Get(FantasyStatsVariableTypes.FireDefense);
        public static float WindDefense(this IStatsVariables stats) => stats.Get(FantasyStatsVariableTypes.WindDefense);
        public static float EarthDefense(this IStatsVariables stats) => stats.Get(FantasyStatsVariableTypes.EarthDefense);
        public static float LightDefense(this IStatsVariables stats) => stats.Get(FantasyStatsVariableTypes.LightDefense);
        public static float DarkDefense(this IStatsVariables stats) => stats.Get(FantasyStatsVariableTypes.DarkDefense);
        public static float SlashingDefense(this IStatsVariables stats) => stats.Get(FantasyStatsVariableTypes.SlashingDefense);
        public static float BluntDefense(this IStatsVariables stats) => stats.Get(FantasyStatsVariableTypes.BluntDefense);
        public static float PiercingDefense(this IStatsVariables stats) => stats.Get(FantasyStatsVariableTypes.PiercingDefense);
        public static float UnarmedDefense(this IStatsVariables stats) => stats.Get(FantasyStatsVariableTypes.UnarmedDefense);
        public static void IceDefense(this IStatsVariables stats, float value) => stats[FantasyStatsVariableTypes.IceDefense] = value;
        public static void FireDefense(this IStatsVariables stats, float value) => stats[FantasyStatsVariableTypes.FireDefense] = value;
        public static void WindDefense(this IStatsVariables stats, float value) => stats[FantasyStatsVariableTypes.WindDefense] = value;
        public static void EarthDefense(this IStatsVariables stats, float value) => stats[FantasyStatsVariableTypes.EarthDefense] = value;
        public static void LightDefense(this IStatsVariables stats, float value) => stats[FantasyStatsVariableTypes.LightDefense] = value;
        public static void DarkDefense(this IStatsVariables stats, float value) => stats[FantasyStatsVariableTypes.DarkDefense] = value;
        public static void SlashingDefense(this IStatsVariables stats, float value) => stats[FantasyStatsVariableTypes.SlashingDefense] = value;
        public static void BluntDefense(this IStatsVariables stats, float value) => stats[FantasyStatsVariableTypes.BluntDefense] = value;
        public static void PiercingDefense(this IStatsVariables stats, float value) => stats[FantasyStatsVariableTypes.PiercingDefense] = value;
        public static void UnarmedDefense(this IStatsVariables stats, float value) => stats[FantasyStatsVariableTypes.UnarmedDefense] = value;
        
        public static ICollection<StatReference> GetDamageReferences(this IStatsVariables stats)
        {
            return new[]
            {
                new StatReference(FantasyDamageTypes.IceDamage, stats.IceDamage()),
                new StatReference(FantasyDamageTypes.FireDamage, stats.FireDamage()),
                new StatReference(FantasyDamageTypes.WindDamage, stats.WindDamage()),
                new StatReference(FantasyDamageTypes.EarthDamage, stats.EarthDamage()),
                new StatReference(FantasyDamageTypes.LightDamage, stats.LightDamage()),
                new StatReference(FantasyDamageTypes.DarkDamage, stats.DarkDamage()),
                new StatReference(FantasyDamageTypes.SlashingDamage, stats.SlashingDamage()),
                new StatReference(FantasyDamageTypes.BluntDamage, stats.BluntDamage()),
                new StatReference(FantasyDamageTypes.PiercingDamage, stats.PiercingDamage()),
                new StatReference(FantasyDamageTypes.UnarmedDamage, stats.UnarmedDamage()),
                new StatReference(FantasyDamageTypes.Damage, stats.Damage())
            };
        }
        
        public static ICollection<StatReference> GetDefenseReferences(this IStatsVariables stats)
        {
            return new[]
            {
                new StatReference(FantasyDamageTypes.IceDamage, stats.IceDefense()),
                new StatReference(FantasyDamageTypes.FireDamage, stats.FireDefense()),
                new StatReference(FantasyDamageTypes.WindDamage, stats.WindDefense()),
                new StatReference(FantasyDamageTypes.EarthDamage, stats.EarthDefense()),
                new StatReference(FantasyDamageTypes.LightDamage, stats.LightDefense()),
                new StatReference(FantasyDamageTypes.DarkDamage, stats.DarkDefense()),
                new StatReference(FantasyDamageTypes.SlashingDamage, stats.SlashingDefense()),
                new StatReference(FantasyDamageTypes.BluntDamage, stats.BluntDefense()),
                new StatReference(FantasyDamageTypes.PiercingDamage, stats.PiercingDefense()),
                new StatReference(FantasyDamageTypes.UnarmedDamage, stats.UnarmedDefense()),
                new StatReference(FantasyDamageTypes.Damage, stats.Defense())
            };
        }
        
        public static float GetDefenseFor(this IStatsVariables stats, int effectType)
        {
            if (effectType == FantasyEffectTypes.PiercingBonusAmount) { return stats.PiercingDefense(); }
            if (effectType == FantasyEffectTypes.SlashingBonusAmount) { return stats.SlashingDefense(); }
            if (effectType == FantasyEffectTypes.BluntBonusAmount) { return stats.BluntDefense(); }
            if (effectType == FantasyEffectTypes.UnarmedBonusAmount) { return stats.UnarmedDefense(); }
            if (effectType == FantasyEffectTypes.FireBonusAmount) { return stats.FireDefense(); }
            if (effectType == FantasyEffectTypes.IceBonusAmount) { return stats.IceDefense(); }
            if (effectType == FantasyEffectTypes.WindBonusAmount) { return stats.WindDefense(); }
            if (effectType == FantasyEffectTypes.EarthBonusAmount) { return stats.EarthDefense(); }
            if (effectType == FantasyEffectTypes.LightBonusAmount) { return stats.LightDefense(); }
            if (effectType == FantasyEffectTypes.DarkBonusAmount) { return stats.DarkDefense(); }

            if (effectType == FantasyEffectTypes.AllElementDamageBonusAmount)
            {
                return stats.FireDefense() + stats.IceDefense() + stats.WindDefense() +
                       stats.EarthDefense() + stats.LightDefense() + stats.DarkDefense();
            }

            if (effectType == FantasyEffectTypes.AllMeleeDefenseBonusAmount)
            {
                return stats.PiercingDefense() + stats.SlashingDefense() +
                       stats.BluntDefense() + stats.UnarmedDefense();
            }

            if (effectType == FantasyEffectTypes.DamageBonusAmount)
            { return stats.Defense(); }

            return 0;
        }
        
        public static float GetDefenseFromDamageType(this IStatsVariables stats, int damageType)
        {
            if (damageType == FantasyDamageTypes.PiercingDamage) { return stats.PiercingDefense(); }
            if (damageType == FantasyDamageTypes.SlashingDamage) { return stats.SlashingDefense(); }
            if (damageType == FantasyDamageTypes.BluntDamage) { return stats.BluntDefense(); }
            if (damageType == FantasyDamageTypes.UnarmedDamage) { return stats.UnarmedDefense(); }
            if (damageType == FantasyDamageTypes.FireDamage) { return stats.FireDefense(); }
            if (damageType == FantasyDamageTypes.IceDamage) { return stats.IceDefense(); }
            if (damageType == FantasyDamageTypes.WindDamage) { return stats.WindDefense(); }
            if (damageType == FantasyDamageTypes.EarthDamage) { return stats.EarthDefense(); }
            if (damageType == FantasyDamageTypes.LightDamage) { return stats.LightDefense(); }
            if (damageType == FantasyDamageTypes.DarkDamage) { return stats.DarkDefense(); }
            if (damageType == FantasyDamageTypes.Damage) { return stats.Defense(); }
            return 0;
        }

        public static float GetDamageFor(this IStatsVariables stats, int effectType)
        {
            if (effectType == FantasyEffectTypes.PiercingBonusAmount) { return stats.PiercingDamage(); }
            if (effectType == FantasyEffectTypes.SlashingBonusAmount) { return stats.SlashingDamage(); }
            if (effectType == FantasyEffectTypes.BluntBonusAmount) { return stats.BluntDamage(); }
            if (effectType == FantasyEffectTypes.UnarmedBonusAmount) { return stats.UnarmedDamage(); }
            if (effectType == FantasyEffectTypes.FireBonusAmount) { return stats.FireDamage(); }
            if (effectType == FantasyEffectTypes.IceBonusAmount) { return stats.IceDamage(); }
            if (effectType == FantasyEffectTypes.WindBonusAmount) { return stats.WindDamage(); }
            if (effectType == FantasyEffectTypes.EarthBonusAmount) { return stats.EarthDamage(); }
            if (effectType == FantasyEffectTypes.LightBonusAmount) { return stats.LightDamage(); }
            if (effectType == FantasyEffectTypes.DarkBonusAmount) { return stats.DarkDamage(); }

            if (effectType == FantasyEffectTypes.AllElementDamageBonusAmount)
            {
                return stats.FireDamage() + stats.IceDamage() + stats.WindDamage() +
                       stats.EarthDamage() + stats.LightDamage() + stats.DarkDamage();
            }

            if (effectType == FantasyEffectTypes.AllMeleeDefenseBonusAmount)
            {
                return stats.PiercingDamage() + stats.SlashingDamage() +
                       stats.BluntDamage() + stats.UnarmedDamage();
            }

            if (effectType == FantasyEffectTypes.DamageBonusAmount)
            { return stats.Damage(); }

            return 0;
        }
        
        public static float GetDamageFromDamageType(this IStatsVariables stats, int damageType)
        {
            if (damageType == FantasyDamageTypes.PiercingDamage) { return stats.PiercingDamage(); }
            if (damageType == FantasyDamageTypes.SlashingDamage) { return stats.SlashingDamage(); }
            if (damageType == FantasyDamageTypes.BluntDamage) { return stats.BluntDamage(); }
            if (damageType == FantasyDamageTypes.UnarmedDamage) { return stats.UnarmedDamage(); }
            if (damageType == FantasyDamageTypes.FireDamage) { return stats.FireDamage(); }
            if (damageType == FantasyDamageTypes.IceDamage) { return stats.IceDamage(); }
            if (damageType == FantasyDamageTypes.WindDamage) { return stats.WindDamage(); }
            if (damageType == FantasyDamageTypes.EarthDamage) { return stats.EarthDamage(); }
            if (damageType == FantasyDamageTypes.LightDamage) { return stats.LightDamage(); }
            if (damageType == FantasyDamageTypes.DarkDamage) { return stats.DarkDamage(); }
            if (damageType == FantasyDamageTypes.Damage) { return stats.Damage(); }
            return 0;
        }
    }
}