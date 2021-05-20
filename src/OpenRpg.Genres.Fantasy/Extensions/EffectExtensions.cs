using System.Collections.Generic;
using System.Linq;
using OpenRpg.Combat.Effects;
using OpenRpg.Core.Effects;
using OpenRpg.Core.Extensions;
using OpenRpg.Genres.Fantasy.Effects;
using OpenRpg.Genres.Fantasy.Types;

namespace OpenRpg.Genres.Fantasy.Extensions
{
    public static class EffectExtensions
    {
        public static int CalculateBonusFor(this IReadOnlyCollection<Effect> activeEffects, int amountBonusType, int percentageBonusType, int miscBonus = 0)
        {
            var totalAmount = activeEffects.GetPotencyFor(amountBonusType) + miscBonus;
            var totalGenericAmount = activeEffects.GetPotencyFor(EffectTypes.AllAttributeBonusAmount);
            var percentageBonus = activeEffects.GetPotencyFor(percentageBonusType);
            var totalBonus = (totalAmount + totalGenericAmount) * percentageBonus;
            return totalAmount + totalBonus;
        }

        public static bool IsDamagingEffect(this Effect effect)
        {  return EffectTypeGroups.DamageEffectTypes.Contains(effect.EffectType); }

        public static bool IsBeneficialEffect(this ActiveEffect effect)
        {
            if (effect.Effect.IsDamagingEffect())
            { return false; }

            return effect.Effect.Potency >= 0;
        }
    }
}