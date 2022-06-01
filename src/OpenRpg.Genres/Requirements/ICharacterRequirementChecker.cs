using OpenRpg.Core.Requirements;
using OpenRpg.Genres.Characters;
using OpenRpg.Quests.States;

namespace OpenRpg.Genres.Requirements
{
    public interface ICharacterRequirementChecker : IRequirementChecker<ICharacter>
    {
        bool IsRequirementMet(IQuestStates state, Requirement requirement);
    }
}