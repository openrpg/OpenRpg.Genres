using System;
using System.Collections.Generic;
using System.Linq;
using OpenRpg.Combat.Processors;
using OpenRpg.Core.Effects;
using OpenRpg.Genres.Characters;
using OpenRpg.Items.Extensions;

namespace OpenRpg.Genres.Extensions
{
    public static class ICharacterExtensions
    {
        public static bool IsDead(this ICharacter character)
        { return character.State.Health() <= 0; }
        
        public static void ApplyDamageToTarget(this ICharacter character, ProcessedAttack attack)
        {
            var summedAttack = attack.DamageDone.Sum(x => x.Value);
            var totalDamage = (int)Math.Round(summedAttack);
            if (totalDamage < 0) { totalDamage = 0; }
            character.State.DeductHealth(totalDamage);
        }
        
        public static IEnumerable<Effect> GetEffects(this ICharacter character)
        {
            var effects = new List<Effect>();
            effects.AddRange(character.Race.Effects);
            effects.AddRange(character.Class.ClassTemplate.Effects);
            effects.AddRange(character.Equipment.GetEffects());
            return effects;
        }
    }
}