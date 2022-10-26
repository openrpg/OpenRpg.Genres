using System.Linq;
using OpenRpg.Core.Classes;
using OpenRpg.Core.Classes.Variables;

namespace OpenRpg.Genres.Persistence.Classes
{
    public abstract class ClassMapper : IClassMapper
    {
        public IClass Map(ClassData data)
        {
            var characterVariables = new DefaultClassVariables(data.Variables
                .ToDictionary(x => x.Key, x => x.Value));

            return new DefaultClass
            {
                Variables = characterVariables,
                ClassTemplate = GetClassTemplateFor(data.ClassTemplateId),
                Level = data.ClassLevel
            };
        }

        public abstract IClassTemplate GetClassTemplateFor(int classTemplateId);
    }
}