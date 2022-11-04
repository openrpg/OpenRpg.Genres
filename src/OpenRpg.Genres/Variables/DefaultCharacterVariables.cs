using System.Collections.Generic;
using OpenRpg.Core.Variables;
using OpenRpg.Genres.Types;

namespace OpenRpg.Genres.Variables
{
    public class DefaultCharacterVariables : DefaultVariables<object>, ICharacterVariables
    {
        public DefaultCharacterVariables(IDictionary<int, object> internalVariables = null) : base(GenreVariableTypes.CharacterVariables, internalVariables)
        {
        }
    }
}