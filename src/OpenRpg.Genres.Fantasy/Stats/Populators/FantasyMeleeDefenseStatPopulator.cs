using System.Collections.Generic;
using OpenRpg.Core.Effects;
using OpenRpg.Core.Stats.Populators;
using OpenRpg.Core.Stats.Variables;
using OpenRpg.Core.Variables;
using OpenRpg.Genres.Fantasy.Effects;
using OpenRpg.Genres.Fantasy.Extensions;
using OpenRpg.Genres.Fantasy.Stats.Populators.Conventions;
using OpenRpg.Genres.Fantasy.Types;

namespace OpenRpg.Genres.Fantasy.Stats.Populators
{
    public class FantasyMeleeDefenseStatPopulator : CompositeStatPopulator, IPartialStatPopulator
    {
        public int Priority => 10;
        
        public FantasyMeleeDefenseStatPopulator()
        {
            PartialPopulators = new[]
            {
                new DamageOrDefenseStatPartialPopulator(EffectTypes.AllMeleeDefenseBonusAmount, EffectTypes.AllMeleeDefenseBonusPercentage, 
                    IGenreStatsVariableTypes.BluntDefense, EffectRelationships.BluntDefenseRelationship, GetBluntModBonus, Priority),
                
                new DamageOrDefenseStatPartialPopulator(EffectTypes.AllMeleeDefenseBonusAmount, EffectTypes.AllMeleeDefenseBonusPercentage, 
                    IGenreStatsVariableTypes.PiercingDefense, EffectRelationships.PiercingDefenseRelationship, GetPiercingModBonus, Priority),
                
                new DamageOrDefenseStatPartialPopulator(EffectTypes.AllMeleeDefenseBonusAmount, EffectTypes.AllMeleeDefenseBonusPercentage, 
                    IGenreStatsVariableTypes.SlashingDefense, EffectRelationships.SlashingDefenseRelationship, GetSlashingOrUnarmedModBonus, Priority),
                
                new DamageOrDefenseStatPartialPopulator(EffectTypes.AllMeleeDefenseBonusAmount, EffectTypes.AllMeleeDefenseBonusPercentage, 
                    IGenreStatsVariableTypes.UnarmedDefense, EffectRelationships.UnarmedDefenseRelationship, GetSlashingOrUnarmedModBonus, Priority),
            };
        }

        public static float GetBluntModBonus(IStatsVariables stats, IReadOnlyCollection<Effect> activeEffects,
            IReadOnlyCollection<IVariables> relatedVars)
        { return stats.Strength() / 100.0f; }

        public static float GetPiercingModBonus(IStatsVariables stats, IReadOnlyCollection<Effect> activeEffects,
            IReadOnlyCollection<IVariables> relatedVars)
        { return stats.Dexterity() / 100.0f; }

        public static float GetSlashingOrUnarmedModBonus(IStatsVariables stats,
            IReadOnlyCollection<Effect> activeEffects, IReadOnlyCollection<IVariables> relatedVars)
        {
            var strengthBonus = stats.Strength() / 200.0f;
            var dexterityBonus = stats.Dexterity() / 200.0f;
            return strengthBonus + dexterityBonus;
        }
    }
}