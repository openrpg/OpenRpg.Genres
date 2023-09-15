using OpenRpg.Core.Stats.Entity;
using OpenRpg.Core.Stats.Populators;
using OpenRpg.Genres.Fantasy.Types;
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
                new BasicAttributePartialPopulator(FantasyGenreEffectTypes.StrengthBonusAmount, FantasyGenreEffectTypes.StrengthBonusPercentage, FantasyStatsVariableTypes.Strength, Priority),
                new BasicAttributePartialPopulator(FantasyGenreEffectTypes.DexterityBonusAmount, FantasyGenreEffectTypes.DexterityBonusPercentage, FantasyStatsVariableTypes.Dexterity, Priority),
                new BasicAttributePartialPopulator(FantasyGenreEffectTypes.ConstitutionBonusAmount, FantasyGenreEffectTypes.ConstitutionBonusPercentage, FantasyStatsVariableTypes.Constitution, Priority),
                new BasicAttributePartialPopulator(FantasyGenreEffectTypes.IntelligenceBonusAmount, FantasyGenreEffectTypes.IntelligenceBonusPercentage, FantasyStatsVariableTypes.Intelligence, Priority),
                new BasicAttributePartialPopulator(FantasyGenreEffectTypes.WisdomBonusAmount, FantasyGenreEffectTypes.WisdomBonusPercentage, FantasyStatsVariableTypes.Wisdom, Priority),
                new BasicAttributePartialPopulator(FantasyGenreEffectTypes.CharismaBonusAmount, FantasyGenreEffectTypes.CharismaBonusPercentage, FantasyStatsVariableTypes.Charisma, Priority),
            };
        }
    }
}