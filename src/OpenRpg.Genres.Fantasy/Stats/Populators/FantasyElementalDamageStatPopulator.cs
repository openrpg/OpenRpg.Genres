using System.Collections.Generic;
using OpenRpg.Core.Effects;
using OpenRpg.Core.Stats.Entity;
using OpenRpg.Core.Stats.Populators;
using OpenRpg.Core.Variables;
using OpenRpg.Genres.Fantasy.Effects;
using OpenRpg.Genres.Fantasy.Extensions;
using OpenRpg.Genres.Fantasy.Stats.Populators.Conventions;
using OpenRpg.Genres.Fantasy.Types;
using OpenRpg.Genres.Populators.Entity.Stats;

namespace OpenRpg.Genres.Fantasy.Stats.Populators
{
    public class FantasyElementalDamageStatPopulator : CompositeStatPopulator<IEntityStatsVariables>, IEntityPartialStatPopulator
    {
        public int Priority => 10;
        
        public FantasyElementalDamageStatPopulator()
        {
            PartialPopulators = new[]
            {
                new DamageOrDefenseStatPartialPopulator(FantasyEffectTypes.AllElementDamageBonusAmount, FantasyEffectTypes.AllElementDamageBonusPercentage, 
                    FantasyStatsVariableTypes.IceDamage, EffectRelationships.IceDamageRelationship, GetElementalModBonus, Priority),
                
                new DamageOrDefenseStatPartialPopulator(FantasyEffectTypes.AllElementDamageBonusAmount, FantasyEffectTypes.AllElementDamageBonusPercentage, 
                    FantasyStatsVariableTypes.FireDamage, EffectRelationships.FireDamageRelationship, GetElementalModBonus, Priority),
                
                new DamageOrDefenseStatPartialPopulator(FantasyEffectTypes.AllElementDamageBonusAmount, FantasyEffectTypes.AllElementDamageBonusPercentage, 
                    FantasyStatsVariableTypes.WindDamage, EffectRelationships.WindDamageRelationship, GetElementalModBonus, Priority),
                
                new DamageOrDefenseStatPartialPopulator(FantasyEffectTypes.AllElementDamageBonusAmount, FantasyEffectTypes.AllElementDamageBonusPercentage, 
                    FantasyStatsVariableTypes.EarthDamage, EffectRelationships.EarthDamageRelationship, GetElementalModBonus, Priority),
                
                new DamageOrDefenseStatPartialPopulator(FantasyEffectTypes.AllElementDamageBonusAmount, FantasyEffectTypes.AllElementDamageBonusPercentage, 
                    FantasyStatsVariableTypes.LightDamage, EffectRelationships.LightDamageRelationship, GetElementalModBonus, Priority),
                
                new DamageOrDefenseStatPartialPopulator(FantasyEffectTypes.AllElementDamageBonusAmount, FantasyEffectTypes.AllElementDamageBonusPercentage, 
                    FantasyStatsVariableTypes.DarkDamage, EffectRelationships.DarkDamageRelationship, GetElementalModBonus, Priority),
            };
        }

        public static float GetElementalModBonus(IEntityStatsVariables stats, IReadOnlyCollection<Effect> activeEffects,
            IReadOnlyCollection<IVariables> relatedVars)
        { return stats.Intelligence() / 100.0f;}
    }
}
