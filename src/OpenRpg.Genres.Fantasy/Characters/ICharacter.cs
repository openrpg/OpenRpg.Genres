using OpenRpg.Core.Classes;
using OpenRpg.Core.Common;
using OpenRpg.Core.Races;
using OpenRpg.Core.Stats;
using OpenRpg.Genres.Fantasy.Equipment;
using OpenRpg.Genres.Fantasy.Variables;

namespace OpenRpg.Genres.Fantasy.Characters
{
    public interface ICharacter : IHasDataId, IHasLocaleDescription, IHasStats, IHasClass
    {
        byte GenderType { get; }
        IRaceTemplate Race { get; }
        IEquipment Equipment { get; }
        ICharacterVariables Variables { get; }
    }
}