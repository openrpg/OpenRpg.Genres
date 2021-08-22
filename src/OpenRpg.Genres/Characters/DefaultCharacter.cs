using OpenRpg.Core.Classes;
using OpenRpg.Core.Races;
using OpenRpg.Core.Stats;
using OpenRpg.Genres.Variables;
using OpenRpg.Items.Equipment;

namespace OpenRpg.Genres.Characters
{
    /// <summary>
    /// A default character implementation, this can be ignored or used as a basis for your own
    /// </summary>
    public class DefaultCharacter : ICharacter
    {
        public int Id { get; set; }
        public string NameLocaleId { get; set; }
        public string DescriptionLocaleId { get; set; }
        public IStatsVariables Stats { get; set; }
        public IClass Class { get; set; }
        public byte GenderType { get; set; }
        public IRaceTemplate Race { get; set; } = new DefaultRaceTemplate();
        public IEquipment Equipment { get; set; } = new DefaultEquipment();
        public ICharacterVariables Variables { get; set; } = new DefaultCharacterVariables();
    }
}