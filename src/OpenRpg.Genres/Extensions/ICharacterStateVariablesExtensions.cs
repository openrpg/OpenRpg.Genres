using System;
using System.Linq;
using OpenRpg.Combat.Processors;
using OpenRpg.Genres.Types;
using OpenRpg.Genres.Variables;

namespace OpenRpg.Genres.Extensions
{
    public static class ICharacterStateVariablesExtensions
    {
        public static int Health(this ICharacterStateVariables state) => (int)state.Get(CharacterStateVariableTypes.Health);
        public static void Health(this ICharacterStateVariables state, int value) => state[CharacterStateVariableTypes.Health] = value;
        
        public static void AddHealth(this ICharacterStateVariables state, int change, int? maxHealth = null)
        {
            var newValue = state.Health() + change;
            if(newValue <= 0) { newValue = 0; }
            
            if(maxHealth == null) 
            { state.Health(newValue); }
            else 
            {state.EnsureHealthInBounds(newValue, maxHealth.Value); }
        }

        public static void DeductHealth(this ICharacterStateVariables state, int change, int? maxHealth = null)
        {
            var newValue = state.Health() - change;
            if(newValue <= 0) { newValue = 0; }
            
            if(maxHealth == null) 
            { state.Health(newValue); }
            else 
            {state.EnsureHealthInBounds(newValue, maxHealth.Value); }
        }

        public static void EnsureHealthInBounds(this ICharacterStateVariables state, int value, int maxHealth)
        {
            if(value > maxHealth)
            { state[CharacterStateVariableTypes.Health] = maxHealth; }
            else if(value <= 0)
            { state[CharacterStateVariableTypes.Health] = 0; }
            else
            { state[CharacterStateVariableTypes.Health] = value; }
        }
        
        public static void ApplyDamageToTarget(this ICharacterStateVariables state, ProcessedAttack attack)
        {
            var summedAttack = attack.DamageDone.Sum(x => x.Value);
            var totalDamage = (int)Math.Round(summedAttack);
            if (totalDamage < 0) { totalDamage = 0; }
            state.DeductHealth(totalDamage);
        }
        
        public static bool IsDead(this ICharacterStateVariables state)
        { return state.Health() <= 0; }
    }
}