using System.Collections.Generic;
using OpenRpg.Core.Effects;
using OpenRpg.Core.Stats.Entity;
using OpenRpg.Core.Stats.Populators;
using OpenRpg.Core.Variables;
using OpenRpg.Genres.Fantasy.Extensions;
using OpenRpg.Genres.Fantasy.Types;
using OpenRpg.Genres.Populators.Entity.Stats;
using OpenRpg.Genres.Populators.Entity.Stats.Conventions;

namespace OpenRpg.Genres.Fantasy.Stats.Populators
{
    public class FantasyVitalsStatPopulator : CompositeStatPopulator<IEntityStatsVariables>, IEntityPartialStatPopulator
    {
        public int Priority => 10;
        
        public FantasyVitalsStatPopulator()
        {
            PartialPopulators = new[]
            {
                new BasicStatPartialPopulator(FantasyGenreEffectTypes.HealthBonusAmount, FantasyGenreEffectTypes.HealthBonusPercentage, FantasyStatsVariableTypes.MaxHealth, GetMiscHealthBonus, Priority),
                new BasicStatPartialPopulator(FantasyGenreEffectTypes.MagicBonusAmount, FantasyGenreEffectTypes.MagicBonusPercentage, FantasyStatsVariableTypes.MaxMagic, GetMiscMagicBonus, Priority),
            };
        }
        
        public static int GetMiscHealthBonus(IEntityStatsVariables stats, IReadOnlyCollection<Effect> activeEffects, IReadOnlyCollection<IVariables> relatedVars)
        {
            return stats.Constitution() * 5;
        }
        
        public static int GetMiscMagicBonus(IEntityStatsVariables stats, IReadOnlyCollection<Effect> activeEffects, IReadOnlyCollection<IVariables> relatedVars)
        {
            return stats.Intelligence() * 5;
        }
    }
}