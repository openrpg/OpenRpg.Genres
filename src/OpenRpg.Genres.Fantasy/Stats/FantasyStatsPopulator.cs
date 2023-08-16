using System.Collections.Generic;
using OpenRpg.Core.Effects;
using OpenRpg.Core.Stats.Populators;
using OpenRpg.Core.Stats.Variables;
using OpenRpg.Core.Variables;
using OpenRpg.Genres.Fantasy.Stats.Populators;

namespace OpenRpg.Genres.Fantasy.Stats
{
    public class FantasyStatsPopulator : CompositeStatPopulator
    {
        public FantasyStatsPopulator(IEnumerable<IPartialStatPopulator> additionalStatPopulators = null)
        {
            var fantasyPopulators = new List<IPartialStatPopulator>()
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