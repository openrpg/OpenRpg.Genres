using System.Collections.Generic;
using OpenRpg.Core.Stats;
using OpenRpg.Core.Stats.Variables;
using OpenRpg.Genres.Extensions;
using OpenRpg.Genres.Fantasy.Types;

namespace OpenRpg.Genres.Fantasy.Extensions
{
    public static class StatExtensions
    {
        public static int Strength(this IStatsVariables stats) => (int)stats.Get(StatsVariableTypes.Strength);
        public static int Dexterity(this IStatsVariables stats) => (int)stats.Get(StatsVariableTypes.Dexterity);
        public static int Constitution(this IStatsVariables stats) => (int)stats.Get(StatsVariableTypes.Constitution);
        public static int Intelligence(this IStatsVariables stats) => (int)stats.Get(StatsVariableTypes.Intelligence);
        public static int Wisdom(this IStatsVariables stats) => (int)stats.Get(StatsVariableTypes.Wisdom);
        public static int Charisma(this IStatsVariables stats) => (int)stats.Get(StatsVariableTypes.Charisma);
        public static void Strength(this IStatsVariables stats, int value) => stats[StatsVariableTypes.Strength] = value;
        public static void Dexterity(this IStatsVariables stats, int value) => stats[StatsVariableTypes.Dexterity] = value;
        public static void Constitution(this IStatsVariables stats, int value) => stats[StatsVariableTypes.Constitution] = value;
        public static void Intelligence(this IStatsVariables stats, int value) => stats[StatsVariableTypes.Intelligence] = value;
        public static void Wisdom(this IStatsVariables stats, int value) => stats[StatsVariableTypes.Wisdom] = value;
        public static void Charisma(this IStatsVariables stats, int value) => stats[StatsVariableTypes.Charisma] = value;

        public static void MaxMagic(this IStatsVariables stats, int value) => stats[StatsVariableTypes.MaxMagic] = value;
        public static int MaxMagic(this IStatsVariables stats) => (int)stats.Get(StatsVariableTypes.MaxMagic);
        
        public static float IceDamage(this IStatsVariables stats) => stats.Get(StatsVariableTypes.IceDamage);
        public static float FireDamage(this IStatsVariables stats) => stats.Get(StatsVariableTypes.FireDamage);
        public static float WindDamage(this IStatsVariables stats) => stats.Get(StatsVariableTypes.WindDamage);
        public static float EarthDamage(this IStatsVariables stats) => stats.Get(StatsVariableTypes.EarthDamage);
        public static float LightDamage(this IStatsVariables stats) => stats.Get(StatsVariableTypes.LightDamage);
        public static float DarkDamage(this IStatsVariables stats) => stats.Get(StatsVariableTypes.DarkDamage);
        public static float SlashingDamage(this IStatsVariables stats) => stats.Get(StatsVariableTypes.SlashingDamage);
        public static float BluntDamage(this IStatsVariables stats) => stats.Get(StatsVariableTypes.BluntDamage);
        public static float PiercingDamage(this IStatsVariables stats) => stats.Get(StatsVariableTypes.PiercingDamage);
        public static float UnarmedDamage(this IStatsVariables stats) => stats.Get(StatsVariableTypes.UnarmedDamage);
        public static void IceDamage(this IStatsVariables stats, float value) => stats[StatsVariableTypes.IceDamage] = value;
        public static void FireDamage(this IStatsVariables stats, float value) => stats[StatsVariableTypes.FireDamage] = value;
        public static void WindDamage(this IStatsVariables stats, float value) => stats[StatsVariableTypes.WindDamage] = value;
        public static void EarthDamage(this IStatsVariables stats, float value) => stats[StatsVariableTypes.EarthDamage] = value;
        public static void LightDamage(this IStatsVariables stats, float value) => stats[StatsVariableTypes.LightDamage] = value;
        public static void DarkDamage(this IStatsVariables stats, float value) => stats[StatsVariableTypes.DarkDamage] = value;
        public static void SlashingDamage(this IStatsVariables stats, float value) => stats[StatsVariableTypes.SlashingDamage] = value;
        public static void BluntDamage(this IStatsVariables stats, float value) => stats[StatsVariableTypes.BluntDamage] = value;
        public static void PiercingDamage(this IStatsVariables stats, float value) => stats[StatsVariableTypes.PiercingDamage] = value;
        public static void UnarmedDamage(this IStatsVariables stats, float value) => stats[StatsVariableTypes.UnarmedDamage] = value;
        
        public static float IceDefense(this IStatsVariables stats) => stats.Get(StatsVariableTypes.IceDefense);
        public static float FireDefense(this IStatsVariables stats) => stats.Get(StatsVariableTypes.FireDefense);
        public static float WindDefense(this IStatsVariables stats) => stats.Get(StatsVariableTypes.WindDefense);
        public static float EarthDefense(this IStatsVariables stats) => stats.Get(StatsVariableTypes.EarthDefense);
        public static float LightDefense(this IStatsVariables stats) => stats.Get(StatsVariableTypes.LightDefense);
        public static float DarkDefense(this IStatsVariables stats) => stats.Get(StatsVariableTypes.DarkDefense);
        public static float SlashingDefense(this IStatsVariables stats) => stats.Get(StatsVariableTypes.SlashingDefense);
        public static float BluntDefense(this IStatsVariables stats) => stats.Get(StatsVariableTypes.BluntDefense);
        public static float PiercingDefense(this IStatsVariables stats) => stats.Get(StatsVariableTypes.PiercingDefense);
        public static float UnarmedDefense(this IStatsVariables stats) => stats.Get(StatsVariableTypes.UnarmedDefense);
        public static void IceDefense(this IStatsVariables stats, float value) => stats[StatsVariableTypes.IceDefense] = value;
        public static void FireDefense(this IStatsVariables stats, float value) => stats[StatsVariableTypes.FireDefense] = value;
        public static void WindDefense(this IStatsVariables stats, float value) => stats[StatsVariableTypes.WindDefense] = value;
        public static void EarthDefense(this IStatsVariables stats, float value) => stats[StatsVariableTypes.EarthDefense] = value;
        public static void LightDefense(this IStatsVariables stats, float value) => stats[StatsVariableTypes.LightDefense] = value;
        public static void DarkDefense(this IStatsVariables stats, float value) => stats[StatsVariableTypes.DarkDefense] = value;
        public static void SlashingDefense(this IStatsVariables stats, float value) => stats[StatsVariableTypes.SlashingDefense] = value;
        public static void BluntDefense(this IStatsVariables stats, float value) => stats[StatsVariableTypes.BluntDefense] = value;
        public static void PiercingDefense(this IStatsVariables stats, float value) => stats[StatsVariableTypes.PiercingDefense] = value;
        public static void UnarmedDefense(this IStatsVariables stats, float value) => stats[StatsVariableTypes.UnarmedDefense] = value;
        
        public static ICollection<StatReference> GetDamageReferences(this IStatsVariables stats)
        {
            return new[]
            {
                new StatReference(DamageTypes.IceDamage, stats.IceDamage()),
                new StatReference(DamageTypes.FireDamage, stats.FireDamage()),
                new StatReference(DamageTypes.WindDamage, stats.WindDamage()),
                new StatReference(DamageTypes.EarthDamage, stats.EarthDamage()),
                new StatReference(DamageTypes.LightDamage, stats.LightDamage()),
                new StatReference(DamageTypes.DarkDamage, stats.DarkDamage()),
                new StatReference(DamageTypes.SlashingDamage, stats.SlashingDamage()),
                new StatReference(DamageTypes.BluntDamage, stats.BluntDamage()),
                new StatReference(DamageTypes.PiercingDamage, stats.PiercingDamage()),
                new StatReference(DamageTypes.UnarmedDamage, stats.UnarmedDamage()),
                new StatReference(DamageTypes.Damage, stats.PureDamage())
            };
        }
        
        public static ICollection<StatReference> GetDefenseReferences(this IStatsVariables stats)
        {
            return new[]
            {
                new StatReference(DamageTypes.IceDamage, stats.IceDefense()),
                new StatReference(DamageTypes.FireDamage, stats.FireDefense()),
                new StatReference(DamageTypes.WindDamage, stats.WindDefense()),
                new StatReference(DamageTypes.EarthDamage, stats.EarthDefense()),
                new StatReference(DamageTypes.LightDamage, stats.LightDefense()),
                new StatReference(DamageTypes.DarkDamage, stats.DarkDefense()),
                new StatReference(DamageTypes.SlashingDamage, stats.SlashingDefense()),
                new StatReference(DamageTypes.BluntDamage, stats.BluntDefense()),
                new StatReference(DamageTypes.PiercingDamage, stats.PiercingDefense()),
                new StatReference(DamageTypes.UnarmedDamage, stats.UnarmedDefense()),
                new StatReference(DamageTypes.Damage, stats.PureDefense())
            };
        }
        
        public static float GetDefenseFor(this IStatsVariables stats, int effectType)
        {
            if (effectType == EffectTypes.PiercingBonusAmount) { return stats.PiercingDefense(); }
            if (effectType == EffectTypes.SlashingBonusAmount) { return stats.SlashingDefense(); }
            if (effectType == EffectTypes.BluntBonusAmount) { return stats.BluntDefense(); }
            if (effectType == EffectTypes.UnarmedBonusAmount) { return stats.UnarmedDefense(); }
            if (effectType == EffectTypes.FireBonusAmount) { return stats.FireDefense(); }
            if (effectType == EffectTypes.IceBonusAmount) { return stats.IceDefense(); }
            if (effectType == EffectTypes.WindBonusAmount) { return stats.WindDefense(); }
            if (effectType == EffectTypes.EarthBonusAmount) { return stats.EarthDefense(); }
            if (effectType == EffectTypes.LightBonusAmount) { return stats.LightDefense(); }
            if (effectType == EffectTypes.DarkBonusAmount) { return stats.DarkDefense(); }

            if (effectType == EffectTypes.AllElementDamageBonusAmount)
            {
                return stats.FireDefense() + stats.IceDefense() + stats.WindDefense() +
                       stats.EarthDefense() + stats.LightDefense() + stats.DarkDefense();
            }

            if (effectType == EffectTypes.AllMeleeDefenseBonusAmount)
            {
                return stats.PiercingDefense() + stats.SlashingDefense() +
                       stats.BluntDefense() + stats.UnarmedDefense();
            }

            if (effectType == EffectTypes.DamageBonusAmount)
            { return stats.PureDefense(); }

            return 0;
        }
        
        public static float GetDefenseFromDamageType(this IStatsVariables stats, int damageType)
        {
            if (damageType == DamageTypes.PiercingDamage) { return stats.PiercingDefense(); }
            if (damageType == DamageTypes.SlashingDamage) { return stats.SlashingDefense(); }
            if (damageType == DamageTypes.BluntDamage) { return stats.BluntDefense(); }
            if (damageType == DamageTypes.UnarmedDamage) { return stats.UnarmedDefense(); }
            if (damageType == DamageTypes.FireDamage) { return stats.FireDefense(); }
            if (damageType == DamageTypes.IceDamage) { return stats.IceDefense(); }
            if (damageType == DamageTypes.WindDamage) { return stats.WindDefense(); }
            if (damageType == DamageTypes.EarthDamage) { return stats.EarthDefense(); }
            if (damageType == DamageTypes.LightDamage) { return stats.LightDefense(); }
            if (damageType == DamageTypes.DarkDamage) { return stats.DarkDefense(); }
            if (damageType == DamageTypes.Damage) { return stats.PureDefense(); }
            return 0;
        }

        public static float GetDamageFor(this IStatsVariables stats, int effectType)
        {
            if (effectType == EffectTypes.PiercingBonusAmount) { return stats.PiercingDamage(); }
            if (effectType == EffectTypes.SlashingBonusAmount) { return stats.SlashingDamage(); }
            if (effectType == EffectTypes.BluntBonusAmount) { return stats.BluntDamage(); }
            if (effectType == EffectTypes.UnarmedBonusAmount) { return stats.UnarmedDamage(); }
            if (effectType == EffectTypes.FireBonusAmount) { return stats.FireDamage(); }
            if (effectType == EffectTypes.IceBonusAmount) { return stats.IceDamage(); }
            if (effectType == EffectTypes.WindBonusAmount) { return stats.WindDamage(); }
            if (effectType == EffectTypes.EarthBonusAmount) { return stats.EarthDamage(); }
            if (effectType == EffectTypes.LightBonusAmount) { return stats.LightDamage(); }
            if (effectType == EffectTypes.DarkBonusAmount) { return stats.DarkDamage(); }

            if (effectType == EffectTypes.AllElementDamageBonusAmount)
            {
                return stats.FireDamage() + stats.IceDamage() + stats.WindDamage() +
                       stats.EarthDamage() + stats.LightDamage() + stats.DarkDamage();
            }

            if (effectType == EffectTypes.AllMeleeDefenseBonusAmount)
            {
                return stats.PiercingDamage() + stats.SlashingDamage() +
                       stats.BluntDamage() + stats.UnarmedDamage();
            }

            if (effectType == EffectTypes.DamageBonusAmount)
            { return stats.PureDamage(); }

            return 0;
        }
        
        public static float GetDamageFromDamageType(this IStatsVariables stats, int damageType)
        {
            if (damageType == DamageTypes.PiercingDamage) { return stats.PiercingDamage(); }
            if (damageType == DamageTypes.SlashingDamage) { return stats.SlashingDamage(); }
            if (damageType == DamageTypes.BluntDamage) { return stats.BluntDamage(); }
            if (damageType == DamageTypes.UnarmedDamage) { return stats.UnarmedDamage(); }
            if (damageType == DamageTypes.FireDamage) { return stats.FireDamage(); }
            if (damageType == DamageTypes.IceDamage) { return stats.IceDamage(); }
            if (damageType == DamageTypes.WindDamage) { return stats.WindDamage(); }
            if (damageType == DamageTypes.EarthDamage) { return stats.EarthDamage(); }
            if (damageType == DamageTypes.LightDamage) { return stats.LightDamage(); }
            if (damageType == DamageTypes.DarkDamage) { return stats.DarkDamage(); }
            if (damageType == DamageTypes.Damage) { return stats.PureDamage(); }
            return 0;
        }
    }
}