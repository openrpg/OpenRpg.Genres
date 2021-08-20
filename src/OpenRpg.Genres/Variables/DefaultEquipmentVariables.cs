using System.Collections.Generic;
using OpenRpg.Core.Variables;

namespace OpenRpg.Genres.Variables
{
    public class DefaultEquipmentVariables : DefaultVariables<object>, IEquipmentVariables
    {
        public DefaultEquipmentVariables(IDictionary<int, object> internalVariables = null) : base(internalVariables)
        {
        }
    }
}