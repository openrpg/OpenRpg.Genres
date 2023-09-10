using System.Collections.Generic;
using OpenRpg.Combat.Extensions;
using OpenRpg.Core.Effects;
using OpenRpg.Core.Entity;
using OpenRpg.Genres.Characters;
using OpenRpg.Items.Extensions;

namespace OpenRpg.Genres.Extensions
{
    public static class ICharacterExtensions
    {
        public static IEnumerable<Effect> GetEffects(this IEntity entity)
        {
            var effects = new List<Effect>();
            
            if(entity.Variables.HasEquipment())
            { effects.AddRange(entity.Variables.Equipment().GetEffects()); }
            
            if(entity.Variables.HasActiveEffects())
            { effects.AddRange(entity.Variables.ActiveEffects().Effects);}
            
            return effects;
        }
        
        public static IEnumerable<Effect> GetEffects(this ICharacter character)
        {
            var effects = new List<Effect>();
            effects.AddRange(character.Race.Effects);
            effects.AddRange(character.Class.ClassTemplate.Effects);
            
            if(character.Variables.HasEquipment())
            { effects.AddRange(character.Variables.Equipment().GetEffects()); }
            
            if(character.Variables.HasActiveEffects())
            { effects.AddRange(character.Variables.ActiveEffects().Effects);}
            
            return effects;
        }
    }
}