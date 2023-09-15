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
    public class FantasyMeleeDamageStatPopulator : CompositeStatPopulator<IEntityStatsVariables>, IEntityPartialStatPopulator
    {
        public int Priority => 10;
        
        public FantasyMeleeDamageStatPopulator()
        {
            PartialPopulators = new[]
            {
                new DamageOrDefenseStatPartialPopulator(FantasyEffectTypes.AllMeleeAttackBonusAmount, FantasyEffectTypes.AllMeleeAttackBonusPercentage, 
                    FantasyStatsVariableTypes.BluntDamage, EffectRelationships.BluntDamageRelationship, GetBluntModBonus, Priority),
                
                new DamageOrDefenseStatPartialPopulator(FantasyEffectTypes.AllMeleeAttackBonusAmount, FantasyEffectTypes.AllMeleeAttackBonusPercentage, 
                    FantasyStatsVariableTypes.PiercingDamage, EffectRelationships.PiercingDamageRelationship, GetPiercingModBonus, Priority),
                
                new DamageOrDefenseStatPartialPopulator(FantasyEffectTypes.AllMeleeAttackBonusAmount, FantasyEffectTypes.AllMeleeAttackBonusPercentage, 
                    FantasyStatsVariableTypes.SlashingDamage, EffectRelationships.SlashingDamageRelationship, GetSlashingOrUnarmedModBonus, Priority),
                
                new DamageOrDefenseStatPartialPopulator(FantasyEffectTypes.AllMeleeAttackBonusAmount, FantasyEffectTypes.AllMeleeAttackBonusPercentage, 
                    FantasyStatsVariableTypes.UnarmedDamage, EffectRelationships.UnarmedDamageRelationship, GetSlashingOrUnarmedModBonus, Priority),
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