using System;
using System.Linq;
using OpenRpg.Combat.Processors;
using OpenRpg.Genres.Characters;

namespace OpenRpg.Genres.Extensions
{
    public static class ICharacterExtensions
    {
        public static bool IsDead(this ICharacter character)
        { return character.Stats.Health() <= 0; }
        
        public static void ApplyDamageToTarget(this ICharacter character, ProcessedAttack attack)
        {
            var summedAttack = attack.DamageDone.Sum(x => x.Value);
            var totalDamage = (int)Math.Round(summedAttack);
            if (totalDamage < 0) { totalDamage = 0; }
            character.Stats.DeductHealth(totalDamage);
        }
    }
}