using System.Collections.Generic;
using OpenRpg.Core.Stats.Entity;
using OpenRpg.Core.Stats.Populators;
using OpenRpg.Genres.Fantasy.Stats.Populators;

namespace OpenRpg.Genres.Fantasy.Stats
{
    public class FantasyStatsPopulator : CompositeStatPopulator<IEntityStatsVariables>
    {
        public FantasyStatsPopulator(IEnumerable<IPartialStatPopulator<IEntityStatsVariables>> additionalStatPopulators = null)
        {
            var fantasyPopulators = new List<IPartialStatPopulator<IEntityStatsVariables>>()
            {
                new FantasyAttributeStatPopulator(),
                new FantasyVitalsStatPopulator(),
                new FantasyMeleeDamageStatPopulator(),
                new FantasyElementalDamageStatPopulator(),
                new FantasyMeleeDefenseStatPopulator(),
                new FantasyElementalDefenseStatPopulator()
            };

            if (additionalStatPopulators != null)
            { fantasyPopulators.AddRange(additionalStatPopulators); }

            PartialPopulators = fantasyPopulators.ToArray();
        }
    }
}