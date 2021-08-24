using OpenRpg.Core.Requirements;
using OpenRpg.Genres.Characters;
using OpenRpg.Genres.Fantasy.Extensions;
using OpenRpg.Genres.Requirements;
using RequirementTypes = OpenRpg.Genres.Fantasy.Types.RequirementTypes;

namespace OpenRpg.Genres.Fantasy.Requirements
{
    public class DefaultFantasyCharacterRequirementChecker : DefaultCharacterRequirementChecker
    {
        public override bool IsRequirementMet(ICharacter character, Requirement requirement)
        {
            if(requirement.RequirementType == RequirementTypes.StrengthRequirement)
            { return character.Stats.Strength() >= requirement.AssociatedValue; }
            
            if(requirement.RequirementType == RequirementTypes.DexterityRequirement)
            { return character.Stats.Dexterity() >= requirement.AssociatedValue; }
            
            if(requirement.RequirementType == RequirementTypes.IntelligenceRequirement)
            { return character.Stats.Intelligence() >= requirement.AssociatedValue; }
            
            if(requirement.RequirementType == RequirementTypes.ConstitutionRequirement)
            { return character.Stats.Constitution() >= requirement.AssociatedValue; }
            
            if(requirement.RequirementType == RequirementTypes.WisdomRequirement)
            { return character.Stats.Wisdom() >= requirement.AssociatedValue; }
            
            if(requirement.RequirementType == RequirementTypes.CharismaRequirement)
            { return character.Stats.Charisma() >= requirement.AssociatedValue; }
            
            if(requirement.RequirementType == RequirementTypes.MaxMagicRequirement)
            { return character.Stats.MaxMagic() >= requirement.AssociatedValue; }

            return base.IsRequirementMet(character, requirement);
        }
    }
}