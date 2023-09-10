using OpenRpg.Core.State.Entity;
using OpenRpg.Genres.Fantasy.Types;

namespace OpenRpg.Genres.Fantasy.Extensions
{
    public static class CharacterStateVariableExtensions
    {
        public static int Magic(this IEntityStateVariables state) => (int)state.Get(FantasyEntityStateVariableTypes.Magic);
        public static void Magic(this IEntityStateVariables state, int value) => state[FantasyEntityStateVariableTypes.Magic] = value;
        
        public static void AddMagic(this IEntityStateVariables state, int change, int? maxMagic = null)
        {
            var newValue = state.Magic() + change;
            if (maxMagic.HasValue)
            { state.EnsureMagicInBounds(newValue, maxMagic.Value); }
            else
            { state.Magic(newValue); }
        }

        public static void DeductMagic(this IEntityStateVariables state, int change, int? maxMagic = null)
        {
            var newValue = state.Magic() - change;
            if (maxMagic.HasValue)
            { state.EnsureMagicInBounds(newValue, maxMagic.Value); }
            else
            { state.Magic(newValue); }
        }

        public static void EnsureMagicInBounds(this IEntityStateVariables state, int value, int maxMagic)
        {
            if(value > maxMagic)
            { state[FantasyEntityStateVariableTypes.Magic] = maxMagic; }
            else if(value <= 0)
            { state[FantasyEntityStateVariableTypes.Magic] = 0; }
            else
            { state[FantasyEntityStateVariableTypes.Magic] = value; }
        }
    }
}