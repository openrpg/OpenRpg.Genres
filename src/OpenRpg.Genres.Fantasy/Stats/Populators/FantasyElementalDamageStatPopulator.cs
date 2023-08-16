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
    public class FantasyElementalDamageStatPopulator : CompositeStatPopulator, IPartialStatPopulator
    {
        public int Priority => 10;
        
        public FantasyElementalDamageStatPopulator()
        {
            PartialPopulators = new[]
            {
                new DamageOrDefenseStatPartialPopulator(EffectTypes.AllElementDamageBonusAmount, EffectTypes.AllElementDamageBonusPercentage, 
                    StatsVariableTypes.IceDamage, EffectRelationships.IceDamageRelationship, GetElementalModBonus, Priority),
                
                new DamageOrDefenseStatPartialPopulator(EffectTypes.AllElementDamageBonusAmount, EffectTypes.AllElementDamageBonusPercentage, 
                    StatsVariableTypes.FireDamage, EffectRelationships.FireDamageRelationship, GetElementalModBonus, Priority),
                
                new DamageOrDefenseStatPartialPopulator(EffectTypes.AllElementDamageBonusAmount, EffectTypes.AllElementDamageBonusPercentage, 
                    StatsVariableTypes.WindDamage, EffectRelationships.WindDamageRelationship, GetElementalModBonus, Priority),
                
                new DamageOrDefenseStatPartialPopulator(EffectTypes.AllElementDamageBonusAmount, EffectTypes.AllElementDamageBonusPercentage, 
                    StatsVariableTypes.EarthDamage, EffectRelationships.EarthDamageRelationship, GetElementalModBonus, Priority),
                
                new DamageOrDefenseStatPartialPopulator(EffectTypes.AllElementDamageBonusAmount, EffectTypes.AllElementDamageBonusPercentage, 
                    StatsVariableTypes.LightDamage, EffectRelationships.LightDamageRelationship, GetElementalModBonus, Priority),
                
                new DamageOrDefenseStatPartialPopulator(EffectTypes.AllElementDamageBonusAmount, EffectTypes.AllElementDamageBonusPercentage, 
                    StatsVariableTypes.DarkDamage, EffectRelationships.DarkDamageRelationship, GetElementalModBonus, Priority),
            };
        }

        public static float GetElementalModBonus(IStatsVariables stats, IReadOnlyCollection<Effect> activeEffects,
            IReadOnlyCollection<IVariables> relatedVars)
        { return stats.Intelligence() / 100.0f;}
    }
}
