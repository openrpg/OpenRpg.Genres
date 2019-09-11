using System.Collections.Generic;
using OpenRpg.Core.Defaults;
using OpenRpg.Core.Effects;
using OpenRpg.Core.Stats;
using OpenRpg.Genres.Fantasy.Stats;

namespace OpenRpg.Genres.Fantasy.Defaults
{
    public class DefaultStatsComputer : IStatsComputer
    {
        public IAttributeStatPopulator AttributeStatPopulator { get; }
        public IVitalStatsPopulator VitalStatsPopulator { get; }
        public IDamageStatPopulator DamageStatPopulator { get; }
        public IDefenseStatPopulator DefenseStatPopulator { get; }

        public DefaultStatsComputer(IAttributeStatPopulator attributeStatPopulator, IVitalStatsPopulator vitalStatsPopulator, IDamageStatPopulator damageStatPopulator, IDefenseStatPopulator defenseStatPopulator)
        {
            AttributeStatPopulator = attributeStatPopulator;
            VitalStatsPopulator = vitalStatsPopulator;
            DamageStatPopulator = damageStatPopulator;
            DefenseStatPopulator = defenseStatPopulator;
        }

        public IEntityStats ComputeStats(IReadOnlyCollection<Effect> effects)
        {
            var stats = new DefaultEntityStats();
            AttributeStatPopulator.PopulateStats(stats, effects);
            DefenseStatPopulator.PopulateStats(stats, effects);
            DamageStatPopulator.PopulateStats(stats, effects);
            VitalStatsPopulator.PopulateStats(stats, effects);
            return stats;
        }
    }
}