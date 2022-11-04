using System.Collections.Generic;
using OpenRpg.Core.Effects;
using OpenRpg.Core.Stats.Variables;
using OpenRpg.Core.Variables;
using OpenRpg.Genres.Fantasy.Stats.SubPopulators;

namespace OpenRpg.Genres.Fantasy.Stats
{
    public class FantasyStatsPopulator : IStatPopulator
    {
        public IAttributeStatPopulator AttributeStatPopulator { get; }
        public IVitalStatsPopulator VitalStatsPopulator { get; }
        public IDamageStatPopulator DamageStatPopulator { get; }
        public IDefenseStatPopulator DefenseStatPopulator { get; }

        public FantasyStatsPopulator(IAttributeStatPopulator attributeStatPopulator, IVitalStatsPopulator vitalStatsPopulator, IDamageStatPopulator damageStatPopulator, IDefenseStatPopulator defenseStatPopulator)
        {
            AttributeStatPopulator = attributeStatPopulator;
            VitalStatsPopulator = vitalStatsPopulator;
            DamageStatPopulator = damageStatPopulator;
            DefenseStatPopulator = defenseStatPopulator;
        }
        
        public void Populate(IStatsVariables existingVars, IReadOnlyCollection<Effect> activeEffects, IReadOnlyCollection<IVariables> relatedVars)
        {
            AttributeStatPopulator.Populate(existingVars, activeEffects, relatedVars);
            DefenseStatPopulator.Populate(existingVars, activeEffects, relatedVars);
            DamageStatPopulator.Populate(existingVars, activeEffects, relatedVars);
            VitalStatsPopulator.Populate(existingVars, activeEffects, relatedVars);
        }
    }
}