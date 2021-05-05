using System.Collections.Generic;
using OpenRpg.Combat.Attacks;
using OpenRpg.Combat.Extensions;
using OpenRpg.Core.Effects;
using OpenRpg.Core.Extensions;
using OpenRpg.Core.Stats;
using OpenRpg.Genres.Fantasy.Characters;
using OpenRpg.Genres.Fantasy.Effects;
using OpenRpg.Genres.Fantasy.Extensions;
using OpenRpg.Genres.Fantasy.Stats;
using OpenRpg.Genres.Fantasy.Types;

namespace OpenRpg.Genres.Fantasy.Defaults
{
    public class DefaultDefenseStatPopulator : IDefenseStatPopulator
    {
        public float ComputeMeleeDefense(float statModifier, EffectRelationship damageRelationship, IReadOnlyCollection<Effect> effects)
        {
            var totalDamage = effects.CalculateTotal(damageRelationship);
            totalDamage += effects.GetPotencyFor(EffectTypes.AllMeleeDefenseBonusAmount);
            if(totalDamage == 0) { return 0; }
            
            var percentageBonus = effects.GetPotencyFor(EffectTypes.AllMeleeDefenseBonusPercentage);
            if (percentageBonus != 0)
            { 
                var addition = totalDamage * (percentageBonus/100);
                totalDamage += addition;
            }

            var modifierBonus = totalDamage * statModifier;
            return totalDamage + modifierBonus;
        }
        
        public float ComputeElementalDefense(float statModifier, EffectRelationship damageRelationship, IReadOnlyCollection<Effect> effects)
        {
            var totalDamage = effects.CalculateTotal(damageRelationship);
            totalDamage += effects.GetPotencyFor(EffectTypes.AllElementDefenseBonusAmount);
            if(totalDamage == 0) { return 0; }
            
            var percentageBonus = effects.GetPotencyFor(EffectTypes.AllElementDefenseBonusPercentage);
            if (percentageBonus != 0)
            { 
                var addition = totalDamage * (percentageBonus/100);
                totalDamage += addition;
            }

            var modifierBonus = totalDamage * statModifier;
            return totalDamage + modifierBonus;
        }
        
        public float ComputePureDefense(IStatsVariables stats, IReadOnlyCollection<Effect> effects)
        {
            var amount = effects.GetPotencyFor(EffectTypes.PureDefenseAmount);
            var percentage = effects.GetPotencyFor(EffectTypes.PureDefensePercentage);

            if (percentage == 0)
            { return amount; }

            var addition = amount * (percentage/100);
            return amount + addition;
        }
        
        public float ComputeIceDefense(IStatsVariables baseAttributeStats, IReadOnlyCollection<Effect> effects)
        { return ComputeElementalDefense(baseAttributeStats.Intelligence() / 100, EffectRelationships.IceDefenseRelationship, effects); }
        
        public float ComputeFireDefense(IStatsVariables baseAttributeStats, IReadOnlyCollection<Effect> effects)
        { return ComputeElementalDefense(baseAttributeStats.Intelligence() / 100, EffectRelationships.FireDefenseRelationship, effects); }
        
        public float ComputeWindDefense(IStatsVariables baseAttributeStats, IReadOnlyCollection<Effect> effects)
        { return ComputeElementalDefense(baseAttributeStats.Intelligence() / 100, EffectRelationships.WindDefenseRelationship, effects); }
        
        public float ComputeEarthDefense(IStatsVariables baseAttributeStats, IReadOnlyCollection<Effect> effects)
        { return ComputeElementalDefense(baseAttributeStats.Intelligence() / 100, EffectRelationships.EarthDefenseRelationship, effects); }
        
        public float ComputeLightDefense(IStatsVariables baseAttributeStats, IReadOnlyCollection<Effect> effects)
        { return ComputeElementalDefense(baseAttributeStats.Intelligence() / 100, EffectRelationships.LightDefenseRelationship, effects); }
        
        public float ComputeDarkDefense(IStatsVariables baseAttributeStats, IReadOnlyCollection<Effect> effects)
        { return ComputeElementalDefense(baseAttributeStats.Intelligence() / 100, EffectRelationships.DarkDefenseRelationship, effects); }

        public float ComputeSlashingDefense(IStatsVariables baseAttributeStats, IReadOnlyCollection<Effect> effects)
        {
            var strengthBonus = baseAttributeStats.Strength() / 200;
            var dexterityBonus = baseAttributeStats.Dexterity() / 200;
            return ComputeMeleeDefense(strengthBonus + dexterityBonus, EffectRelationships.SlashingDefenseRelationship, effects);
        }
        
        public float ComputeBluntDefense(IStatsVariables baseAttributeStats, IReadOnlyCollection<Effect> effects)
        { return ComputeMeleeDefense(baseAttributeStats.Strength() / 100, EffectRelationships.BluntDefenseRelationship, effects); }
        
        public float ComputePiercingDefense(IStatsVariables baseAttributeStats, IReadOnlyCollection<Effect> effects)
        { return ComputeMeleeDefense(baseAttributeStats.Dexterity() / 100, EffectRelationships.PiercingDefenseRelationship, effects); }
        
        public float ComputeUnarmedDefense(IStatsVariables baseAttributeStats, IReadOnlyCollection<Effect> effects)
        {
            var strengthBonus = baseAttributeStats.Strength() / 200;
            var dexterityBonus = baseAttributeStats.Dexterity() / 200;
            return ComputeMeleeDefense(strengthBonus + dexterityBonus, EffectRelationships.UnarmedDefenseRelationship, effects);
        }       

        public void PopulateStats(IStatsVariables stats, IReadOnlyCollection<Effect> activeEffects)
        {
            var iceDefense = ComputeIceDefense(stats, activeEffects);
            var fireDefense = ComputeFireDefense(stats, activeEffects);
            var windDefense = ComputeWindDefense(stats, activeEffects);
            var earthDefense = ComputeEarthDefense(stats, activeEffects);
            var lightDefense = ComputeLightDefense(stats, activeEffects);
            var darkDefense = ComputeDarkDefense(stats, activeEffects);
            var slashingDefense = ComputeSlashingDefense(stats, activeEffects);
            var bluntDefense = ComputeBluntDefense(stats, activeEffects);
            var piercingDefense = ComputePiercingDefense(stats, activeEffects);
            var unarmedDefense = ComputeUnarmedDefense(stats, activeEffects);
            var pureDefense = ComputePureDefense(stats, activeEffects);

            stats.IceDefense(iceDefense);
            stats.FireDefense(fireDefense);
            stats.WindDefense(windDefense);
            stats.EarthDefense(earthDefense);
            stats.LightDefense(lightDefense);
            stats.DarkDefense(darkDefense);
            stats.SlashingDefense(slashingDefense);
            stats.BluntDefense(bluntDefense);
            stats.PiercingDefense(piercingDefense);
            stats.UnarmedDefense(unarmedDefense);
            stats.PureDefense(pureDefense);
        }
    }
}