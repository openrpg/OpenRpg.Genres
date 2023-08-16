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
                new BasicStatPartialPopulator(EffectTypes.StrengthBonusAmount, EffectTypes.StrengthBonusPercentage, StatsVariableTypes.Strength, Priority),
                new BasicStatPartialPopulator(EffectTypes.DexterityBonusAmount, EffectTypes.DexterityBonusPercentage, StatsVariableTypes.Dexterity, Priority),
                new BasicStatPartialPopulator(EffectTypes.ConstitutionBonusAmount, EffectTypes.ConstitutionBonusPercentage, StatsVariableTypes.Constitution, Priority),
                new BasicStatPartialPopulator(EffectTypes.IntelligenceBonusAmount, EffectTypes.IntelligenceBonusPercentage, StatsVariableTypes.Intelligence, Priority),
                new BasicStatPartialPopulator(EffectTypes.WisdomBonusAmount, EffectTypes.WisdomBonusPercentage, StatsVariableTypes.Wisdom, Priority),
                new BasicStatPartialPopulator(EffectTypes.CharismaBonusAmount, EffectTypes.CharismaBonusPercentage, StatsVariableTypes.Charisma, Priority),
            };
        }
    }
}