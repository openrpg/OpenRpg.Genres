using OpenRpg.Genres.Fantasy.Characters;
using OpenRpg.Items.Loot;

namespace OpenRpg.Genres.Fantasy.Defaults
{
    /// <summary>
    /// A default enemy implementation, can be ignored or used as a basis to build off
    /// </summary>
    public class DefaultEnemy : DefaultCharacter, IEnemy
    {
        public ILootTable LootTable { get; set;  }
    }
}