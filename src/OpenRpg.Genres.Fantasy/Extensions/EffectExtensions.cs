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
        public static int CalculateBonusFor(this IReadOnlyCollection<Effect> activeEffects, int amountBonusType, int percentageBonusType, int miscBonus = 0)
        {
            var totalAmount = activeEffects.GetPotencyFor(amountBonusType) + miscBonus;
            var totalGenericAmount = activeEffects.GetPotencyFor(EffectTypes.AllAttributeBonusAmount);
            var percentageBonus = activeEffects.GetPotencyFor(percentageBonusType);
            var totalBonus = (totalAmount + totalGenericAmount) * percentageBonus;
            return totalAmount + totalBonus;
        }

        public static int GetDamageTypeFrom(int effectType)
        {
            if (effectType == EffectTypes.PiercingBonusAmount) { return DamageTypes.PiercingDamage; }
            if (effectType == EffectTypes.SlashingBonusAmount) { return DamageTypes.SlashingDamage; }
            if (effectType == EffectTypes.BluntBonusAmount) { return DamageTypes.BluntDamage; }
            if (effectType == EffectTypes.UnarmedBonusAmount) { return DamageTypes.UnarmedDamage; }
            if (effectType == EffectTypes.FireBonusAmount) { return DamageTypes.FireDamage; }
            if (effectType == EffectTypes.IceBonusAmount) { return DamageTypes.IceDamage; }
            if (effectType == EffectTypes.WindBonusAmount) { return DamageTypes.WindDamage; }
            if (effectType == EffectTypes.EarthBonusAmount) { return DamageTypes.EarthDamage; }
            if (effectType == EffectTypes.LightBonusAmount) { return DamageTypes.LightDamage; }
            if (effectType == EffectTypes.DarkBonusAmount) { return DamageTypes.DarkDamage; }
            if (effectType == EffectTypes.PureDamageAmount) { return DamageTypes.PureDamage; }
            return DamageTypes.UnknownDamage;
        }
        
        public static int GetApplicableDamageType(this Effect effect)
        { return GetDamageTypeFrom(effect.EffectType); }
        
        public static int GetBonusDamageEffectTypeFrom(int damageType)
        {
            if (damageType == DamageTypes.PiercingDamage) { return EffectTypes.PiercingDamageAmount; }
            if (damageType == DamageTypes.SlashingDamage) { return EffectTypes.SlashingDamageAmount; }
            if (damageType == DamageTypes.BluntDamage) { return EffectTypes.BluntDamageAmount; }
            if (damageType == DamageTypes.UnarmedDamage) { return EffectTypes.UnarmedDamageAmount; }
            if (damageType == DamageTypes.FireDamage) { return EffectTypes.FireDamageAmount; }
            if (damageType == DamageTypes.IceDamage) { return EffectTypes.IceDamageAmount; }
            if (damageType == DamageTypes.WindDamage) { return EffectTypes.WindDamageAmount; }
            if (damageType == DamageTypes.EarthDamage) { return EffectTypes.EarthDamageAmount; }
            if (damageType == DamageTypes.LightDamage) { return EffectTypes.LightDamageAmount; }
            if (damageType == DamageTypes.DarkDamage) { return EffectTypes.DarkDamageAmount; }
            if (damageType == DamageTypes.PureDamage) { return EffectTypes.PureDamageAmount; }
            return DamageTypes.UnknownDamage;
        }
        
        public static int GetBonusDefenseEffectTypeFrom(int damageType)
        {
            if (damageType == DamageTypes.PiercingDamage) { return EffectTypes.PiercingDefenseAmount; }
            if (damageType == DamageTypes.SlashingDamage) { return EffectTypes.SlashingDefenseAmount; }
            if (damageType == DamageTypes.BluntDamage) { return EffectTypes.BluntDefenseAmount; }
            if (damageType == DamageTypes.UnarmedDamage) { return EffectTypes.UnarmedDefenseAmount; }
            if (damageType == DamageTypes.FireDamage) { return EffectTypes.FireDefenseAmount; }
            if (damageType == DamageTypes.IceDamage) { return EffectTypes.IceDefenseAmount; }
            if (damageType == DamageTypes.WindDamage) { return EffectTypes.WindDefenseAmount; }
            if (damageType == DamageTypes.EarthDamage) { return EffectTypes.EarthDefenseAmount; }
            if (damageType == DamageTypes.LightDamage) { return EffectTypes.LightDefenseAmount; }
            if (damageType == DamageTypes.DarkDamage) { return EffectTypes.DarkDefenseAmount; }
            if (damageType == DamageTypes.PureDamage) { return EffectTypes.PureDefenseAmount; }
            return DamageTypes.UnknownDamage;
        }

        public static bool IsDamagingEffect(this Effect effect)
        {  return EffectTypeGroups.DamageEffectTypes.Contains(effect.EffectType); }

        public static bool IsBeneficialEffect(this ActiveEffect effect)
        {
            if (effect.Effect.IsDamagingEffect())
            { return false; }

            return effect.Effect.Potency >= 0;
        }
    }
}