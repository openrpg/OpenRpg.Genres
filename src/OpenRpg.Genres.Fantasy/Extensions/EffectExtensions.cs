using System.Collections.Generic;
using System.Linq;
using OpenRpg.Combat.Effects;
using OpenRpg.Core.Effects;
using OpenRpg.Core.Extensions;
using OpenRpg.Genres.Fantasy.Effects;
using OpenRpg.Genres.Fantasy.Types;

namespace OpenRpg.Genres.Fantasy.Extensions
{
    public static class EffectExtensions
    {
        public static int GetDamageTypeFrom(int effectType)
        {
            if (effectType == FantasyGenreEffectTypes.PiercingBonusAmount) { return FantasyGenreDamageTypes.PiercingDamage; }
            if (effectType == FantasyGenreEffectTypes.SlashingBonusAmount) { return FantasyGenreDamageTypes.SlashingDamage; }
            if (effectType == FantasyGenreEffectTypes.BluntBonusAmount) { return FantasyGenreDamageTypes.BluntDamage; }
            if (effectType == FantasyGenreEffectTypes.UnarmedBonusAmount) { return FantasyGenreDamageTypes.UnarmedDamage; }
            if (effectType == FantasyGenreEffectTypes.FireBonusAmount) { return FantasyGenreDamageTypes.FireDamage; }
            if (effectType == FantasyGenreEffectTypes.IceBonusAmount) { return FantasyGenreDamageTypes.IceDamage; }
            if (effectType == FantasyGenreEffectTypes.WindBonusAmount) { return FantasyGenreDamageTypes.WindDamage; }
            if (effectType == FantasyGenreEffectTypes.EarthBonusAmount) { return FantasyGenreDamageTypes.EarthDamage; }
            if (effectType == FantasyGenreEffectTypes.LightBonusAmount) { return FantasyGenreDamageTypes.LightDamage; }
            if (effectType == FantasyGenreEffectTypes.DarkBonusAmount) { return FantasyGenreDamageTypes.DarkDamage; }
            if (effectType == FantasyGenreEffectTypes.DamageBonusAmount) { return FantasyGenreDamageTypes.Damage; }
            return FantasyGenreDamageTypes.UnknownDamage;
        }
        
        public static int GetApplicableDamageType(this Effect effect)
        { return GetDamageTypeFrom(effect.EffectType); }
        
        public static int GetBonusDamageEffectTypeFrom(int damageType)
        {
            if (damageType == FantasyGenreDamageTypes.PiercingDamage) { return FantasyGenreEffectTypes.PiercingDamageAmount; }
            if (damageType == FantasyGenreDamageTypes.SlashingDamage) { return FantasyGenreEffectTypes.SlashingDamageAmount; }
            if (damageType == FantasyGenreDamageTypes.BluntDamage) { return FantasyGenreEffectTypes.BluntDamageAmount; }
            if (damageType == FantasyGenreDamageTypes.UnarmedDamage) { return FantasyGenreEffectTypes.UnarmedDamageAmount; }
            if (damageType == FantasyGenreDamageTypes.FireDamage) { return FantasyGenreEffectTypes.FireDamageAmount; }
            if (damageType == FantasyGenreDamageTypes.IceDamage) { return FantasyGenreEffectTypes.IceDamageAmount; }
            if (damageType == FantasyGenreDamageTypes.WindDamage) { return FantasyGenreEffectTypes.WindDamageAmount; }
            if (damageType == FantasyGenreDamageTypes.EarthDamage) { return FantasyGenreEffectTypes.EarthDamageAmount; }
            if (damageType == FantasyGenreDamageTypes.LightDamage) { return FantasyGenreEffectTypes.LightDamageAmount; }
            if (damageType == FantasyGenreDamageTypes.DarkDamage) { return FantasyGenreEffectTypes.DarkDamageAmount; }
            if (damageType == FantasyGenreDamageTypes.Damage) { return FantasyGenreEffectTypes.DamageBonusAmount; }
            return FantasyGenreDamageTypes.UnknownDamage;
        }
        
        public static int GetBonusDefenseEffectTypeFrom(int damageType)
        {
            if (damageType == FantasyGenreDamageTypes.PiercingDamage) { return FantasyGenreEffectTypes.PiercingDefenseAmount; }
            if (damageType == FantasyGenreDamageTypes.SlashingDamage) { return FantasyGenreEffectTypes.SlashingDefenseAmount; }
            if (damageType == FantasyGenreDamageTypes.BluntDamage) { return FantasyGenreEffectTypes.BluntDefenseAmount; }
            if (damageType == FantasyGenreDamageTypes.UnarmedDamage) { return FantasyGenreEffectTypes.UnarmedDefenseAmount; }
            if (damageType == FantasyGenreDamageTypes.FireDamage) { return FantasyGenreEffectTypes.FireDefenseAmount; }
            if (damageType == FantasyGenreDamageTypes.IceDamage) { return FantasyGenreEffectTypes.IceDefenseAmount; }
            if (damageType == FantasyGenreDamageTypes.WindDamage) { return FantasyGenreEffectTypes.WindDefenseAmount; }
            if (damageType == FantasyGenreDamageTypes.EarthDamage) { return FantasyGenreEffectTypes.EarthDefenseAmount; }
            if (damageType == FantasyGenreDamageTypes.LightDamage) { return FantasyGenreEffectTypes.LightDefenseAmount; }
            if (damageType == FantasyGenreDamageTypes.DarkDamage) { return FantasyGenreEffectTypes.DarkDefenseAmount; }
            if (damageType == FantasyGenreDamageTypes.Damage) { return FantasyGenreEffectTypes.DefenseBonusAmount; }
            return FantasyGenreDamageTypes.UnknownDamage;
        }

        public static bool IsDamagingEffect(this Effect effect)
        {  return EffectTypeGroups.DamageEffectTypes.Contains(effect.EffectType); }
        
        public static bool IsDefensiveEffect(this Effect effect)
        {  return EffectTypeGroups.DefenseEffectTypes.Contains(effect.EffectType); }

        public static bool IsBeneficialEffect(this ActiveEffect effect)
        {
            if(effect.Effect.EffectType != FantasyGenreEffectTypes.LightBonusAmount)
            {
                if (effect.Effect.IsDamagingEffect())
                { return false; }
            }

            return effect.Effect.Potency >= 0;
        }
    }
}