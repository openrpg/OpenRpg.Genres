using System.Collections.Generic;
using OpenRpg.Core.Variables;

namespace OpenRpg.Genres.Variables
{
    public class DefaultCharacterVariables : DefaultVariables<object>, ICharacterVariables
    {
        public DefaultCharacterVariables(IDictionary<int, object> internalVariables = null) : base(GenreVariableTypes.CharacterVariables, internalVariables)
        {
        }
    }
}