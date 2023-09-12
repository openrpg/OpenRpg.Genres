using OpenRpg.Core.Stats.Populators;
using OpenRpg.Genres.Fantasy.Types;
using OpenRpg.Genres.Stats.Populators.Conventions;

namespace OpenRpg.Genres.Fantasy.Stats.Populators
{
    public class FantasyAttributeStatPopulator : CompositeStatPopulator, IPartialStatPopulator
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