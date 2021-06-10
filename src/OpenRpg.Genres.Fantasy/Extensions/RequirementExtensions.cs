using System.Linq;
using OpenRpg.Core.Requirements;
using OpenRpg.Genres.Fantasy.Characters;
using OpenRpg.Genres.Fantasy.Requirements;
using OpenRpg.Quests.States;

namespace OpenRpg.Genres.Fantasy.Extensions
{
    public static class RequirementExtensions
    {
        public static bool AreRequirementsMet(this ICharacterRequirementChecker characterRequirementChecker, ICharacter character, IHasRequirements hasRequirements)
        { return hasRequirements.Requirements.All(x => characterRequirementChecker.IsRequirementMet(character, x)); }
        
        public static bool AreRequirementsMet(this ICharacterRequirementChecker characterRequirementChecker, IGameState state, IHasRequirements hasRequirements)
        { return hasRequirements.Requirements.All(x => characterRequirementChecker.IsRequirementMet(state, x)); }

        public static bool AreRequirementsMet(this ICharacterRequirementChecker characterRequirementChecker, IGameState state,
            ICharacter character, IHasRequirements hasRequirements)
        {
            var characterRequirementsMet = AreRequirementsMet(characterRequirementChecker, character, hasRequirements);
            if(characterRequirementsMet == false) { return false; }

            return AreRequirementsMet(characterRequirementChecker, state, hasRequirements);
        }
    }
}