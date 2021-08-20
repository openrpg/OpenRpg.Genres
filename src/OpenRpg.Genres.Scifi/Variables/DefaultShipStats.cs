using System.Collections.Generic;
using OpenRpg.Core.Variables;

namespace OpenRpg.Genres.Scifi.Variables
{
    public class DefaultShipStats : DefaultVariables<int>, IShipStats
    {
        public DefaultShipStats(IDictionary<int, int> internalVariables = null) : base(internalVariables)
        {
        }
    }
}