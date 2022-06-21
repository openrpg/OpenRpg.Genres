using OpenRpg.Combat.Types;
using OpenRpg.Items.Types;
using OpenRpg.Quests.Types;

namespace OpenRpg.Genres.Variables
{
    public interface GenreVariableTypes : CombatVariableTypes, QuestVariableTypes, ItemVariableTypes
    {
        public static int CharacterVariables = 100;
        public static int CharacterStateVariables = 101;
    }
}