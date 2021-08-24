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
    public class DefaultVitalStatsPopulator : IVitalStatsPopulator
    {
        public void PopulateStats(IStatsVariables stats, IReadOnlyCollection<Effect> activeEffects)
        {
            PopulateHP(stats, activeEffects);
            PopulateMP(stats, activeEffects);
        }
        
        public void PopulateHP(IStatsVariables stats, IReadOnlyCollection<Effect> activeEffects)
        {
            var constitutionBonus = stats.Constitution() * 5;
            var effectBonus = activeEffects.GetPotencyFor(EffectTypes.HealthBonusAmount);
            var effectBonusPercentage = activeEffects.GetPotencyFor(EffectTypes.HealthBonusPercentage);
            var maxHealthStat = constitutionBonus + effectBonus;
            var additionalHealth = maxHealthStat * effectBonusPercentage;
            maxHealthStat += additionalHealth;

            stats.MaxHealth(maxHealthStat);
            stats.Health(maxHealthStat);
        }
        
        public void PopulateMP(IStatsVariables stats, IReadOnlyCollection<Effect> activeEffects)
        {
            var intelligenceBonus = stats.Intelligence() * 5;
            var effectBonus = activeEffects.GetPotencyFor(EffectTypes.MagicBonusAmount);
            var effectBonusPercentage = activeEffects.GetPotencyFor(EffectTypes.MagicBonusPercentage);
            var maxMagicStat = intelligenceBonus + effectBonus;
            var additionalMagic = maxMagicStat * effectBonusPercentage;
            maxMagicStat += additionalMagic;

            stats.MaxMagic(maxMagicStat);
            stats.Magic(maxMagicStat);
        }
    }
}