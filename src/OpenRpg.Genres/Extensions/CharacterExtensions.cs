using System.Collections.Generic;
using OpenRpg.Core.Effects;
using OpenRpg.Genres.Characters;
using OpenRpg.Items.Extensions;

namespace OpenRpg.Genres.Extensions
{
    public static class CharacterExtensions
    {
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