using OpenRpg.Core.Classes;
using OpenRpg.Core.Entity;
using OpenRpg.Core.Races;

namespace OpenRpg.Genres.Characters
{
    /// <summary>
    /// A slightly more specific character notion built on top of the generic IEntity notion
    /// </summary>
    public interface ICharacter : IEntity, IHasClass
    {
        byte GenderType { get; }
        IRaceTemplate Race { get; }
    }
}