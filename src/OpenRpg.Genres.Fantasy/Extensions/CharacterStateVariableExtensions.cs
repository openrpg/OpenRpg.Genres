using OpenRpg.Genres.Fantasy.Types;
using OpenRpg.Genres.Variables;

namespace OpenRpg.Genres.Fantasy.Extensions
{
    public static class CharacterStateVariableExtensions
    {
        public static int Magic(this ICharacterStateVariables state) => (int)state.Get(CharacterStateVariableTypes.Magic);
        public static void Magic(this ICharacterStateVariables state, int value) => state[CharacterStateVariableTypes.Magic] = value;
        
        public static void AddMagic(this ICharacterStateVariables state, int change, int? maxMagic = null)
        {
            var newValue = state.Magic() + change;
            if (maxMagic.HasValue)
            { state.EnsureMagicInBounds(newValue, maxMagic.Value); }
            else
            { state.Magic(newValue); }
        }

        public static void DeductMagic(this ICharacterStateVariables state, int change, int? maxMagic = null)
        {
            var newValue = state.Magic() - change;
            if (maxMagic.HasValue)
            { state.EnsureMagicInBounds(newValue, maxMagic.Value); }
            else
            { state.Magic(newValue); }
        }

        public static void EnsureMagicInBounds(this ICharacterStateVariables state, int value, int maxMagic)
        {
            if(value > maxMagic)
            { state[CharacterStateVariableTypes.Magic] = maxMagic; }
            else if(value <= 0)
            { state[CharacterStateVariableTypes.Magic] = 0; }
            else
            { state[CharacterStateVariableTypes.Magic] = value; }
        }
    }
}