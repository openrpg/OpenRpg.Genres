using OpenRpg.Core.Classes;
using OpenRpg.Core.Common;
using OpenRpg.Core.Races;
using OpenRpg.Core.Stats;
using OpenRpg.Genres.Variables;
using OpenRpg.Items.Equipment;

namespace OpenRpg.Genres.Characters
{
    /// <summary>
    /// Barebones character for extending elsewhere
    /// </summary>
    public interface ICharacter : IIsUnique, IHasLocaleDescription, IHasStats, IHasClass
    {
        byte GenderType { get; }
        IRaceTemplate Race { get; }
        IEquipment Equipment { get; }
        ICharacterStateVariables State { get; }
        ICharacterVariables Variables { get; }
    }
}