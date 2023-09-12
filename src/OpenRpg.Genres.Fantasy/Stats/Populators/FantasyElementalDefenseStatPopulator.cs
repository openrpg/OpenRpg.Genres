using System.Collections.Generic;
using OpenRpg.Core.Effects;
using OpenRpg.Core.Stats.Populators;
using OpenRpg.Core.Stats.Variables;
using OpenRpg.Core.Variables;
using OpenRpg.Genres.Fantasy.Effects;
using OpenRpg.Genres.Fantasy.Extensions;
using OpenRpg.Genres.Fantasy.Stats.Populators.Conventions;
using OpenRpg.Genres.Fantasy.Types;

namespace OpenRpg.Genres.Fantasy.Stats.Populators
{
    public class FantasyElementalDefenseStatPopulator : CompositeStatPopulator, IPartialStatPopulator
    {
        public int Priority => 10;
        
        public FantasyElementalDefenseStatPopulator()
        {
            PartialPopulators = new[]
            {
                new DamageOrDefenseStatPartialPopulator(FantasyEffectTypes.AllElementDefenseBonusAmount, FantasyEffectTypes.AllElementDefenseBonusPercentage, 
                    FantasyStatsVariableTypes.IceDefense, EffectRelationships.IceDefenseRelationship, GetElementalModBonus, Priority),
                
                new DamageOrDefenseStatPartialPopulator(FantasyEffectTypes.AllElementDefenseBonusAmount, FantasyEffectTypes.AllElementDefenseBonusPercentage, 
                    FantasyStatsVariableTypes.FireDefense, EffectRelationships.FireDefenseRelationship, GetElementalModBonus, Priority),
                
                new DamageOrDefenseStatPartialPopulator(FantasyEffectTypes.AllElementDefenseBonusAmount, FantasyEffectTypes.AllElementDefenseBonusPercentage, 
                    FantasyStatsVariableTypes.WindDefense, EffectRelationships.WindDefenseRelationship, GetElementalModBonus, Priority),
                
                new DamageOrDefenseStatPartialPopulator(FantasyEffectTypes.AllElementDefenseBonusAmount, FantasyEffectTypes.AllElementDefenseBonusPercentage, 
                    FantasyStatsVariableTypes.EarthDefense, EffectRelationships.EarthDefenseRelationship, GetElementalModBonus, Priority),
                
                new DamageOrDefenseStatPartialPopulator(FantasyEffectTypes.AllElementDefenseBonusAmount, FantasyEffectTypes.AllElementDefenseBonusPercentage, 
                    FantasyStatsVariableTypes.LightDefense, EffectRelationships.LightDefenseRelationship, GetElementalModBonus, Priority),
                
                new DamageOrDefenseStatPartialPopulator(FantasyEffectTypes.AllElementDefenseBonusAmount, FantasyEffectTypes.AllElementDefenseBonusPercentage, 
                    FantasyStatsVariableTypes.DarkDefense, EffectRelationships.DarkDefenseRelationship, GetElementalModBonus, Priority),
            };
        }

        public static float GetElementalModBonus(IStatsVariables stats, IReadOnlyCollection<Effect> activeEffects,
            IReadOnlyCollection<IVariables> relatedVars)
        { return stats.Intelligence() / 100.0f;}
    }
}