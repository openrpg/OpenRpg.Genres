using System.Collections.Generic;

namespace OpenRpg.Genres.Persistence.Classes
{
    public class ClassData
    {
        public int ClassTemplateId { get; }
        public int ClassLevel { get; }
        public IReadOnlyDictionary<int, object> Variables { get; }
        
        public ClassData(int classTemplateId, int classLevel, IReadOnlyDictionary<int, object> variables = null)
        {
            ClassTemplateId = classTemplateId;
            ClassLevel = classLevel;
            Variables = variables ?? new Dictionary<int, object>();
        }
    }
}