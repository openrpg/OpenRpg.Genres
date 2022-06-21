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
            if(maxHealth == null) 
            { state.Health(newValue); }
            else 
            {state.EnsureHealthInBounds(newValue, maxHealth.Value); }
        }

        public static void DeductHealth(this ICharacterStateVariables state, int change, int? maxHealth = null)
        {
            var newValue = state.Health() - change;
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
    }
}