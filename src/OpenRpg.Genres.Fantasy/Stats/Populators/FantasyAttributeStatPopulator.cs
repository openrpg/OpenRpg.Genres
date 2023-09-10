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
                new BasicAttributePartialPopulator(EffectTypes.StrengthBonusAmount, EffectTypes.StrengthBonusPercentage, IGenreStatsVariableTypes.Strength, Priority),
                new BasicAttributePartialPopulator(EffectTypes.DexterityBonusAmount, EffectTypes.DexterityBonusPercentage, IGenreStatsVariableTypes.Dexterity, Priority),
                new BasicAttributePartialPopulator(EffectTypes.ConstitutionBonusAmount, EffectTypes.ConstitutionBonusPercentage, IGenreStatsVariableTypes.Constitution, Priority),
                new BasicAttributePartialPopulator(EffectTypes.IntelligenceBonusAmount, EffectTypes.IntelligenceBonusPercentage, IGenreStatsVariableTypes.Intelligence, Priority),
                new BasicAttributePartialPopulator(EffectTypes.WisdomBonusAmount, EffectTypes.WisdomBonusPercentage, IGenreStatsVariableTypes.Wisdom, Priority),
                new BasicAttributePartialPopulator(EffectTypes.CharismaBonusAmount, EffectTypes.CharismaBonusPercentage, IGenreStatsVariableTypes.Charisma, Priority),
            };
        }
    }
}