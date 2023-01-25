using System;
using System.Collections.Generic;
using System.Linq;
using OpenRpg.Combat.Processors;
using OpenRpg.Core.Effects;
using OpenRpg.Core.Stats.Variables;
using OpenRpg.Genres.Characters;
using OpenRpg.Genres.Variables;
using OpenRpg.Items.Extensions;

namespace OpenRpg.Genres.Extensions
{
    public static class ICharacterExtensions
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