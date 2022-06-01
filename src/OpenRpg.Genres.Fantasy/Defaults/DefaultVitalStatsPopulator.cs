using System.Collections.Generic;
using OpenRpg.Core.Effects;
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
            var maxHealthStat = (int)activeEffects.GetPotencyFor(EffectTypes.HealthBonusAmount, 
                EffectTypes.HealthBonusPercentage, constitutionBonus);

            stats.MaxHealth(maxHealthStat);
            stats.Health(maxHealthStat);
        }
        
        public void PopulateMP(IStatsVariables stats, IReadOnlyCollection<Effect> activeEffects)
        {
            var intelligenceBonus = stats.Intelligence() * 5;
            var maxMagicStat = (int)activeEffects.GetPotencyFor(EffectTypes.MagicBonusAmount, 
                EffectTypes.MagicBonusPercentage, intelligenceBonus);
            
            stats.MaxMagic(maxMagicStat);
            stats.Magic(maxMagicStat);
        }
    }
}