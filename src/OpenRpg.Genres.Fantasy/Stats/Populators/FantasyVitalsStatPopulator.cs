using System.Collections.Generic;
using OpenRpg.Core.Effects;
using OpenRpg.Core.Stats.Populators;
using OpenRpg.Core.Stats.Variables;
using OpenRpg.Core.Variables;
using OpenRpg.Genres.Fantasy.Extensions;
using OpenRpg.Genres.Fantasy.Types;
using OpenRpg.Genres.Stats.Populators.Conventions;

namespace OpenRpg.Genres.Fantasy.Stats.Populators
{
    public class FantasyVitalsStatPopulator : CompositeStatPopulator, IPartialStatPopulator
    {
        public int Priority => 10;
        
        public FantasyVitalsStatPopulator()
        {
            PartialPopulators = new[]
            {
                new BasicStatPartialPopulator(EffectTypes.HealthBonusAmount, EffectTypes.HealthBonusPercentage, IGenreStatsVariableTypes.MaxHealth, GetMiscHealthBonus, Priority),
                new BasicStatPartialPopulator(EffectTypes.MagicBonusAmount, EffectTypes.MagicBonusPercentage, IGenreStatsVariableTypes.MaxMagic, GetMiscMagicBonus, Priority),
            };
        }
        
        public static int GetMiscHealthBonus(IStatsVariables stats, IReadOnlyCollection<Effect> activeEffects, IReadOnlyCollection<IVariables> relatedVars)
        {
            return stats.Constitution() * 5;
        }
        
        public static int GetMiscMagicBonus(IStatsVariables stats, IReadOnlyCollection<Effect> activeEffects, IReadOnlyCollection<IVariables> relatedVars)
        {
            return stats.Intelligence() * 5;
        }
    }
}