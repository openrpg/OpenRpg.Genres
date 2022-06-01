using System.Linq;
using OpenRpg.Core.Requirements;
using OpenRpg.Genres.Characters;
using OpenRpg.Genres.Requirements;
using OpenRpg.Quests.States;

namespace OpenRpg.Genres.Extensions
{
    public static class RequirementExtensions
    {
        public static bool AreRequirementsMet(this ICharacterRequirementChecker characterRequirementChecker, ICharacter character, IHasRequirements hasRequirements)
        { return hasRequirements.Requirements.All(x => characterRequirementChecker.IsRequirementMet(character, x)); }
        
        public static bool AreRequirementsMet(this ICharacterRequirementChecker characterRequirementChecker, IQuestStates state, IHasRequirements hasRequirements)
        { return hasRequirements.Requirements.All(x => characterRequirementChecker.IsRequirementMet(state, x)); }

        public static bool AreRequirementsMet(this ICharacterRequirementChecker characterRequirementChecker, IQuestStates state,
            ICharacter character, IHasRequirements hasRequirements)
        {
            var characterRequirementsMet = AreRequirementsMet(characterRequirementChecker, character, hasRequirements);
            return characterRequirementsMet && AreRequirementsMet(characterRequirementChecker, state, hasRequirements);
        }
    }
}