using OpenRpg.Core.Classes;
using OpenRpg.Core.Races;
using OpenRpg.Core.Stats;
using OpenRpg.Genres.Fantasy.Characters;
using OpenRpg.Genres.Fantasy.Equipment;

namespace OpenRpg.Genres.Fantasy.Defaults
{
    /// <summary>
    /// A default character implementation, this can be ignored or used as a basis for your own
    /// </summary>
    public class DefaultCharacter : ICharacter
    {
        public int Id { get; set; }
        public string AssetCode { get; set;  }
        public string NameLocaleId { get; set;  }
        public string DescriptionLocaleId { get; set;  }
        
        public byte GenderType { get; set;  }
        public IClass Class { get; set;  }
        public IRaceTemplate Race { get; set;  }
        public IEquipment Equipment { get; set;  }
        public IStatsVariables Stats { get; set; }
    }
}