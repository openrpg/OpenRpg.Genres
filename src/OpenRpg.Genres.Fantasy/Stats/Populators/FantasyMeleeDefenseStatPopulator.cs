using System.Collections.Generic;
using OpenRpg.Core.Effects;
using OpenRpg.Core.Stats.Entity;
using OpenRpg.Core.Stats.Populators;
using OpenRpg.Core.Variables;
using OpenRpg.Genres.Fantasy.Effects;
using OpenRpg.Genres.Fantasy.Extensions;
using OpenRpg.Genres.Fantasy.Stats.Populators.Conventions;
using OpenRpg.Genres.Fantasy.Types;
using OpenRpg.Genres.Populators.Entity.Stats;

namespace OpenRpg.Genres.Fantasy.Stats.Populators
{
    public class FantasyMeleeDefenseStatPopulator : CompositeStatPopulator<IEntityStatsVariables>, IEntityPartialStatPopulator
    {
        public int Priority => 10;
        
        public FantasyMeleeDefenseStatPopulator()
        {
            PartialPopulators = new[]
            {
                new DamageOrDefenseStatPartialPopulator(FantasyGenreEffectTypes.AllMeleeDefenseBonusAmount, FantasyGenreEffectTypes.AllMeleeDefenseBonusPercentage, 
                    FantasyStatsVariableTypes.BluntDefense, EffectRelationships.BluntDefenseRelationship, GetBluntModBonus, Priority),
                
                new DamageOrDefenseStatPartialPopulator(FantasyGenreEffectTypes.AllMeleeDefenseBonusAmount, FantasyGenreEffectTypes.AllMeleeDefenseBonusPercentage, 
                    FantasyStatsVariableTypes.PiercingDefense, EffectRelationships.PiercingDefenseRelationship, GetPiercingModBonus, Priority),
                
                new DamageOrDefenseStatPartialPopulator(FantasyGenreEffectTypes.AllMeleeDefenseBonusAmount, FantasyGenreEffectTypes.AllMeleeDefenseBonusPercentage, 
                    FantasyStatsVariableTypes.SlashingDefense, EffectRelationships.SlashingDefenseRelationship, GetSlashingOrUnarmedModBonus, Priority),
                
                new DamageOrDefenseStatPartialPopulator(FantasyGenreEffectTypes.AllMeleeDefenseBonusAmount, FantasyGenreEffectTypes.AllMeleeDefenseBonusPercentage, 
                    FantasyStatsVariableTypes.UnarmedDefense, EffectRelationships.UnarmedDefenseRelationship, GetSlashingOrUnarmedModBonus, Priority),
            };
        }

        public static float GetBluntModBonus(IEntityStatsVariables stats, IReadOnlyCollection<Effect> activeEffects,
            IReadOnlyCollection<IVariables> relatedVars)
        { return stats.Strength() / 100.0f; }

        public static float GetPiercingModBonus(IEntityStatsVariables stats, IReadOnlyCollection<Effect> activeEffects,
            IReadOnlyCollection<IVariables> relatedVars)
        { return stats.Dexterity() / 100.0f; }

        public static float GetSlashingOrUnarmedModBonus(IEntityStatsVariables stats,
            IReadOnlyCollection<Effect> activeEffects, IReadOnlyCollection<IVariables> relatedVars)
        {
            var strengthBonus = stats.Strength() / 200.0f;
            var dexterityBonus = stats.Dexterity() / 200.0f;
            return strengthBonus + dexterityBonus;
        }
    }
}