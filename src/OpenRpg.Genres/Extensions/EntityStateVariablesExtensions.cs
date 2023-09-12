using System;
using System.Linq;
using OpenRpg.Combat.Processors.Attacks;
using OpenRpg.Core.State.Entity;
using OpenRpg.Genres.Types;

namespace OpenRpg.Genres.Extensions
{
    public static class EntityStateVariablesExtensions
    {
        public static int Health(this IEntityStateVariables state) => (int)state.Get(GenreEntityStateVariableTypes.Health);
        public static void Health(this IEntityStateVariables state, int value) => state[GenreEntityStateVariableTypes.Health] = value;
        
        public static void AddHealth(this IEntityStateVariables state, int change, int? maxHealth = null)
        {
            var newValue = state.Health() + change;
            if(newValue <= 0) { newValue = 0; }
            
            if(maxHealth == null) 
            { state.Health(newValue); }
            else 
            {state.EnsureHealthInBounds(newValue, maxHealth.Value); }
        }

        public static void DeductHealth(this IEntityStateVariables state, int change, int? maxHealth = null)
        {
            var newValue = state.Health() - change;
            if(newValue <= 0) { newValue = 0; }
            
            if(maxHealth == null) 
            { state.Health(newValue); }
            else 
            {state.EnsureHealthInBounds(newValue, maxHealth.Value); }
        }

        public static void EnsureHealthInBounds(this IEntityStateVariables state, int value, int maxHealth)
        {
            if(value > maxHealth)
            { state[GenreEntityStateVariableTypes.Health] = maxHealth; }
            else if(value <= 0)
            { state[GenreEntityStateVariableTypes.Health] = 0; }
            else
            { state[GenreEntityStateVariableTypes.Health] = value; }
        }
        
        public static void ApplyDamageToTarget(this IEntityStateVariables state, ProcessedAttack attack)
        {
            var summedAttack = attack.DamageDone.Sum(x => x.Value);
            var totalDamage = (int)Math.Round(summedAttack);
            if (totalDamage < 0) { totalDamage = 0; }
            state.DeductHealth(totalDamage);
        }
        
        public static bool IsDead(this IEntityStateVariables state)
        { return state.Health() <= 0; }
    }
}