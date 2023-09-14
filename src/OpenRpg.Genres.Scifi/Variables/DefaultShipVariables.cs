using System.Collections.Generic;
using OpenRpg.Core.Variables;
using OpenRpg.Genres.Scifi.Types;

namespace OpenRpg.Genres.Scifi.Variables
{
    public class DefaultShipVariables : DefaultVariables<object>, IShipVariables
    {
        public DefaultShipVariables(IDictionary<int, object> internalVariables = null) : base(ScifiVariableTypes.ShipVariables, internalVariables)
        {
        }
    }
}