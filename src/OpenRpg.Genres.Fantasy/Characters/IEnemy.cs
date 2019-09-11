using OpenRpg.Items.Loot;

namespace OpenRpg.Genres.Fantasy.Characters
{
    public interface IEnemy : ICharacter
    {
        ILootTable LootTable { get; }
    }
}