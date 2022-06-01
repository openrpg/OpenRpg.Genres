using System.Collections.Generic;
using OpenRpg.Core.Effects;
using OpenRpg.Core.Extensions;
using OpenRpg.Core.Stats;
using OpenRpg.Genres.Extensions;
using OpenRpg.Genres.Fantasy.Extensions;
using OpenRpg.Genres.Fantasy.Stats;
using OpenRpg.Genres.Fantasy.Types;

namespace OpenRpg.Genres.Fantasy.Defaults
{
    public class DefaultAttributeStatPopulator : IAttributeStatPopulator
    {
        public void PopulateStats(IStatsVariables stats, IReadOnlyCollection<Effect> activeEffects)
        {
            var strengthValue = (int)activeEffects.CalculateBonusFor(EffectTypes.StrengthBonusAmount, EffectTypes.StrengthBonusPercentage);
            var dexterityValue = (int)activeEffects.CalculateBonusFor(EffectTypes.DexterityBonusAmount, EffectTypes.DexterityBonusPercentage);
            var constitutionValue = (int)activeEffects.CalculateBonusFor(EffectTypes.ConstitutionBonusAmount, EffectTypes.ConstitutionBonusPercentage);
            var intelligenceValue = (int)activeEffects.CalculateBonusFor(EffectTypes.IntelligenceBonusAmount, EffectTypes.IntelligenceBonusPercentage);
            var wisdomValue = (int)activeEffects.CalculateBonusFor(EffectTypes.WisdomBonusAmount, EffectTypes.WisdomBonusPercentage);
            var charismaValue = (int)activeEffects.CalculateBonusFor(EffectTypes.CharismaBonusAmount, EffectTypes.CharismaBonusPercentage);
            var allAttributeValue = (int)activeEffects.GetPotencyFor(EffectTypes.AllAttributeBonusAmount);

            stats.Strength(strengthValue + allAttributeValue);
            stats.Dexterity(dexterityValue + allAttributeValue);
            stats.Constitution(constitutionValue + allAttributeValue);
            stats.Intelligence(intelligenceValue + allAttributeValue);
            stats.Wisdom(wisdomValue + allAttributeValue);
            stats.Charisma(charismaValue + allAttributeValue);
        }
    }
}