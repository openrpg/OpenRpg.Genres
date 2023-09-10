using OpenRpg.Core.Classes;
using OpenRpg.Core.Entity;
using OpenRpg.Core.Races;

namespace OpenRpg.Genres.Characters
{
    /// <summary>
    /// A character implementation, which builds upon the entity notion for more complex details
    /// </summary>
    public class DefaultCharacter : DefaultEntity, ICharacter
    {
        public byte GenderType { get; set; }
        public IClass Class { get; set; } = new DefaultClass();
        public IRaceTemplate Race { get; set; } = new DefaultRaceTemplate();
    }
}