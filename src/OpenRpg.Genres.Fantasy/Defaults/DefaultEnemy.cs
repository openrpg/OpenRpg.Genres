using OpenRpg.Genres.Fantasy.Characters;
using OpenRpg.Items.Loot;

namespace OpenRpg.Genres.Fantasy.Defaults
{
    public class DefaultEnemy : DefaultCharacter, IEnemy
    {
        public ILootTable LootTable { get; }
    }
}