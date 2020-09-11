using System.Collections.Generic;
using OpenRpg.Combat.Attacks;
using OpenRpg.Combat.Extensions;
using OpenRpg.Core.Effects;
using OpenRpg.Core.Extensions;
using OpenRpg.Core.Stats;
using OpenRpg.Genres.Fantasy.Effects;
using OpenRpg.Genres.Fantasy.Extensions;
using OpenRpg.Genres.Fantasy.Stats;
using OpenRpg.Genres.Fantasy.Types;

namespace OpenRpg.Genres.Fantasy.Defaults
{
    public class DefaultDamageStatPopulator : IDamageStatPopulator
    {
        public float ComputeMeleeDamage(float statModifier, EffectRelationship damageRelationship, IReadOnlyCollection<Effect> effects)
        {
            var totalDamage = effects.CalculateTotal(damageRelationship);
            totalDamage += effects.GetPotencyFor(EffectTypes.AllMeleeAttackBonusAmount);
            if(totalDamage == 0) { return 0; }

            var modifierBonus = totalDamage * statModifier;
            return totalDamage + modifierBonus;
        }
        
        public float ComputeElementalDamage(float statModifier, EffectRelationship damageRelationship, IReadOnlyCollection<Effect> effects)
        {
            var totalDamage = effects.CalculateTotal(damageRelationship);
            totalDamage += effects.GetPotencyFor(EffectTypes.AllElementDamageBonusAmount);
            if(totalDamage == 0) { return 0; }

            var modifierBonus = totalDamage * statModifier;
            return totalDamage + modifierBonus;
        }
        
        public float ComputeIceDamage(IStatsVariables stats, IReadOnlyCollection<Effect> effects)
        { return ComputeElementalDamage(stats.Intelligence() / 100, EffectRelationships.IceDamageRelationship, effects); }
        
        public float ComputeFireDamage(IStatsVariables stats, IReadOnlyCollection<Effect> effects)
        { return ComputeElementalDamage(stats.Intelligence() / 100, EffectRelationships.FireDamageRelationship, effects); }
        
        public float ComputeWindDamage(IStatsVariables stats, IReadOnlyCollection<Effect> effects)
        { return ComputeElementalDamage(stats.Intelligence() / 100, EffectRelationships.WindDamageRelationship, effects); }
        
        public float ComputeEarthDamage(IStatsVariables stats, IReadOnlyCollection<Effect> effects)
        { return ComputeElementalDamage(stats.Intelligence() / 100, EffectRelationships.EarthDamageRelationship, effects); }
        
        public float ComputeLightDamage(IStatsVariables stats, IReadOnlyCollection<Effect> effects)
        { return ComputeElementalDamage(stats.Intelligence() / 100, EffectRelationships.LightDamageRelationship, effects); }
        
        public float ComputeDarkDamage(IStatsVariables stats, IReadOnlyCollection<Effect> effects)
        { return ComputeElementalDamage(stats.Intelligence() / 100, EffectRelationships.DarkDamageRelationship, effects); }

        public float ComputeSlashingDamage(IStatsVariables stats, IReadOnlyCollection<Effect> effects)
        {
            var strengthBonus = stats.Strength() / 200;
            var dexterityBonus = stats.Dexterity() / 200;
            return ComputeMeleeDamage(strengthBonus + dexterityBonus, EffectRelationships.SlashingDamageRelationship, effects);
        }
        
        public float ComputeBluntDamage(IStatsVariables stats, IReadOnlyCollection<Effect> effects)
        { return ComputeMeleeDamage(stats.Strength() / 100, EffectRelationships.BluntDamageRelationship, effects); }
        
        public float ComputePiercingDamage(IStatsVariables stats, IReadOnlyCollection<Effect> effects)
        { return ComputeMeleeDamage(stats.Dexterity() / 100, EffectRelationships.PiercingDamageRelationship, effects); }
        
        public float ComputeUnarmedDamage(IStatsVariables stats, IReadOnlyCollection<Effect> effects)
        {
            var strengthBonus = stats.Strength() / 200;
            var dexterityBonus = stats.Dexterity() / 200;
            return ComputeMeleeDamage(strengthBonus + dexterityBonus, EffectRelationships.UnarmedDamageRelationship, effects);
        }
        
        public float ComputePureDamage(IStatsVariables stats, IReadOnlyCollection<Effect> effects)
        {
            var amount = effects.GetPotencyFor(EffectTypes.PureDamageAmount);
            var percentage = effects.GetPotencyFor(EffectTypes.PureDamagePercentage);

            if (percentage == 0)
            { return amount; }

            var addition = amount * (percentage/100);
            return amount + addition;
        }
        
        public void PopulateStats(IStatsVariables stats, IReadOnlyCollection<Effect> activeEffects)
        {
            var iceDamage = ComputeIceDamage(stats, activeEffects);
            var fireDamage = ComputeFireDamage(stats, activeEffects);
            var windDamage = ComputeWindDamage(stats, activeEffects);
            var earthDamage = ComputeEarthDamage(stats, activeEffects);
            var lightDamage = ComputeLightDamage(stats, activeEffects);
            var darkDamage = ComputeDarkDamage(stats, activeEffects);
            var slashingDamage = ComputeSlashingDamage(stats, activeEffects);
            var bluntDamage = ComputeBluntDamage(stats, activeEffects);
            var piercingDamage = ComputePiercingDamage(stats, activeEffects);
            var unarmedDamage = ComputeUnarmedDamage(stats, activeEffects);
            var pureDamage = ComputePureDamage(stats, activeEffects);

            stats.IceDamage(iceDamage);
            stats.FireDamage(fireDamage);
            stats.WindDamage(windDamage);
            stats.EarthDamage(earthDamage);
            stats.LightDamage(lightDamage);
            stats.DarkDamage(darkDamage);
            stats.SlashingDamage(slashingDamage);
            stats.BluntDamage(bluntDamage);
            stats.PiercingDamage(piercingDamage);
            stats.UnarmedDamage(unarmedDamage);
            stats.PureDamage(pureDamage);
        }
    }
}