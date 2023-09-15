using OpenRpg.Core.Stats.Entity;
using OpenRpg.Core.Stats.Populators;
using OpenRpg.Genres.Fantasy.Types;
using OpenRpg.Genres.Populators.Entity;
using OpenRpg.Genres.Populators.Entity.Stats;
using OpenRpg.Genres.Populators.Entity.Stats.Conventions;

namespace OpenRpg.Genres.Fantasy.Stats.Populators
{
    public class FantasyAttributeStatPopulator : CompositeStatPopulator<IEntityStatsVariables>, IEntityPartialStatPopulator
    {
        public int Priority => 100;

        public FantasyAttributeStatPopulator()
        {
            PartialPopulators = new[]
            {
                new BasicAttributePartialPopulator(FantasyEffectTypes.StrengthBonusAmount, FantasyEffectTypes.StrengthBonusPercentage, FantasyStatsVariableTypes.Strength, Priority),
                new BasicAttributePartialPopulator(FantasyEffectTypes.DexterityBonusAmount, FantasyEffectTypes.DexterityBonusPercentage, FantasyStatsVariableTypes.Dexterity, Priority),
                new BasicAttributePartialPopulator(FantasyEffectTypes.ConstitutionBonusAmount, FantasyEffectTypes.ConstitutionBonusPercentage, FantasyStatsVariableTypes.Constitution, Priority),
                new BasicAttributePartialPopulator(FantasyEffectTypes.IntelligenceBonusAmount, FantasyEffectTypes.IntelligenceBonusPercentage, FantasyStatsVariableTypes.Intelligence, Priority),
                new BasicAttributePartialPopulator(FantasyEffectTypes.WisdomBonusAmount, FantasyEffectTypes.WisdomBonusPercentage, FantasyStatsVariableTypes.Wisdom, Priority),
                new BasicAttributePartialPopulator(FantasyEffectTypes.CharismaBonusAmount, FantasyEffectTypes.CharismaBonusPercentage, FantasyStatsVariableTypes.Charisma, Priority),
            };
        }
    }
}