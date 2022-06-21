using System.Collections.Generic;
using OpenRpg.Core.Variables;

namespace OpenRpg.Genres.Variables
{
    public class DefaultCharacterStateVariables : DefaultVariables<float>, ICharacterStateVariables
    {
        public DefaultCharacterStateVariables(IDictionary<int, float> internalVariables = null) : base(GenreVariableTypes.CharacterStateVariables, internalVariables)
        {
        }
    }
}