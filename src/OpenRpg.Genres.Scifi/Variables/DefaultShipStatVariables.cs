using System.Collections.Generic;
using OpenRpg.Core.Variables;
using OpenRpg.Genres.Scifi.Types;

namespace OpenRpg.Genres.Scifi.Variables
{
    public class DefaultShipStatVariables : DefaultVariables<float>, IShipStatVariables
    {
        public DefaultShipStatVariables(IDictionary<int, float> internalVariables = null) : base(ScifiVariableTypes.ShipStatVariables, internalVariables)
        {
        }
    }
}