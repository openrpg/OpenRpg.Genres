using System.Collections.Generic;
using OpenRpg.Core.Classes;

namespace OpenRpg.Genres.Persistence.Classes
{
    public class PersistedClass
    {
        public int ClassTemplateId { get; }
        public int ClassLevel { get; }
        public IReadOnlyDictionary<int, object> Variables { get; }
        
        public PersistedClass(int classTemplateId, int classLevel, IReadOnlyDictionary<int, object> variables = null)
        {
            ClassTemplateId = classTemplateId;
            ClassLevel = classLevel;
            Variables = variables ?? new Dictionary<int, object>();
        }

        public PersistedClass(IClass @class)
        {
            ClassTemplateId = @class.ClassTemplate.Id;
            ClassLevel = @class.Level;
            Variables = @class.Variables;
        }
    }
}