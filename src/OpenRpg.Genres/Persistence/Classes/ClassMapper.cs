using System.Linq;
using OpenRpg.Core.Classes;
using OpenRpg.Core.Classes.Variables;

namespace OpenRpg.Genres.Persistence.Classes
{
    public abstract class ClassMapper : IClassMapper
    {
        public IClass Map(PersistedClass persistedData)
        {
            var characterVariables = new DefaultClassVariables(persistedData.Variables
                .ToDictionary(x => x.Key, x => x.Value));

            return new DefaultClass
            {
                Variables = characterVariables,
                ClassTemplate = GetClassTemplateFor(persistedData.ClassTemplateId),
                Level = persistedData.ClassLevel
            };
        }

        public abstract IClassTemplate GetClassTemplateFor(int classTemplateId);
    }
}