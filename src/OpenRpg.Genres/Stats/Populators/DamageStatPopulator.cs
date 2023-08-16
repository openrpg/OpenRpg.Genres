using System.Collections.Generic;
using OpenRpg.Core.Effects;
using OpenRpg.Core.Extensions;
using OpenRpg.Core.Stats.Populators;
using OpenRpg.Core.Stats.Variables;
using OpenRpg.Core.Variables;
using OpenRpg.Genres.Extensions;
using OpenRpg.Genres.Types;

namespace OpenRpg.Genres.Stats.Populators
{
    public class DamageStatPopulator : IPartialStatPopulator
    {
        public int Priority => 10;

        public float ComputeTotal(IReadOnlyCollection<Effect> effects)
        {
            var amount = effects.GetPotencyFor(EffectTypes.DamageBonusAmount);
            var percentage = effects.GetPotencyFor(EffectTypes.DamageBonusPercentage);

            if (percentage == 0)
            { return amount; }

            var addition = amount * (percentage/100);
            return amount + addition;
        }
        
        public void Populate(IStatsVariables stats, IReadOnlyCollection<Effect> activeEffects, IReadOnlyCollection<IVariables> relatedVars)
        {
            var totalValue = ComputeTotal(activeEffects);
            stats.Damage(totalValue);
        }
    }
}