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
                new BasicAttributePartialPopulator(EffectTypes.StrengthBonusAmount, EffectTypes.StrengthBonusPercentage, StatsVariableTypes.Strength, Priority),
                new BasicAttributePartialPopulator(EffectTypes.DexterityBonusAmount, EffectTypes.DexterityBonusPercentage, StatsVariableTypes.Dexterity, Priority),
                new BasicAttributePartialPopulator(EffectTypes.ConstitutionBonusAmount, EffectTypes.ConstitutionBonusPercentage, StatsVariableTypes.Constitution, Priority),
                new BasicAttributePartialPopulator(EffectTypes.IntelligenceBonusAmount, EffectTypes.IntelligenceBonusPercentage, StatsVariableTypes.Intelligence, Priority),
                new BasicAttributePartialPopulator(EffectTypes.WisdomBonusAmount, EffectTypes.WisdomBonusPercentage, StatsVariableTypes.Wisdom, Priority),
                new BasicAttributePartialPopulator(EffectTypes.CharismaBonusAmount, EffectTypes.CharismaBonusPercentage, StatsVariableTypes.Charisma, Priority),
            };
        }
    }
}