using System.Collections.Generic;
using OpenRpg.Core.Classes;

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

        public ClassData(IClass @class)
        {
            ClassTemplateId = @class.ClassTemplate.Id;
            ClassLevel = @class.Level;
            Variables = @class.Variables;
        }
    }
}