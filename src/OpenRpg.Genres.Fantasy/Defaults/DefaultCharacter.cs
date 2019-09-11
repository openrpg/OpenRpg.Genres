using OpenRpg.Core.Classes;
using OpenRpg.Core.Races;
using OpenRpg.Core.Stats;
using OpenRpg.Genres.Fantasy.Characters;
using OpenRpg.Genres.Fantasy.Equipment;

namespace OpenRpg.Genres.Fantasy.Defaults
{
    public class DefaultCharacter : ICharacter
    {
        public int Id { get; }
        public string AssetCode { get; }
        public string NameLocaleId { get; }
        public string DescriptionLocaleId { get; }
        
        public byte GenderType { get; }
        public IClass Class { get; }
        public IRaceTemplate Race { get; }
        public IEquipment Equipment { get; }
        public IEntityStats Stats { get; }
    }
}