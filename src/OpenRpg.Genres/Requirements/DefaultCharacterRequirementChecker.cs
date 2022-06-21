using System.Linq;
using OpenRpg.Core.Requirements;
using OpenRpg.Genres.Characters;
using OpenRpg.Genres.Extensions;
using OpenRpg.Genres.Types;
using OpenRpg.Quests.Types;
using OpenRpg.Quests.Variables;

namespace OpenRpg.Genres.Requirements
{
    public class DefaultCharacterRequirementChecker : ICharacterRequirementChecker
    {
        public virtual bool IsRequirementMet(ICharacter character, Requirement requirement)
        {
            if (requirement.RequirementType == RequirementTypes.RaceRequirement)
            { return character.Race.Id == requirement.AssociatedId; }
            
            if (requirement.RequirementType == RequirementTypes.ClassRequirement)
            { return character.Class.ClassTemplate.Id == requirement.AssociatedId; }
            
            if (requirement.RequirementType == RequirementTypes.LevelRequirement)
            { return character.Class.Level >= requirement.AssociatedValue; }
            
            if(requirement.RequirementType == RequirementTypes.GenderRequirement)
            { return character.GenderType == requirement.AssociatedId; }
            
            if (requirement.RequirementType == RequirementTypes.EquipmentItemRequirement)
            {
                return character.Equipment.Slots.Values.Any(x =>
                    x.SlotType == requirement.AssociatedId &&
                    x.SlottedItem.ItemTemplate.Id == requirement.AssociatedValue);
            }

            if(requirement.RequirementType == RequirementTypes.MaxHealthRequirement)
            { return character.Stats.MaxHealth() >= requirement.AssociatedValue; }
            
            return true;
        }

        public virtual bool IsRequirementMet(IQuestStateVariables state, Requirement requirement)
        {
            if (requirement.RequirementType == RequirementTypes.QuestStateRequirement)
            {
                var hasQuestState = state.ContainsKey(requirement.AssociatedId);
                if(requirement.AssociatedValue == QuestStateTypes.QuestNotStarted && !hasQuestState) 
                { return true; }

                return state[requirement.AssociatedId] == requirement.AssociatedValue;
            }
            
            return true;
        }
    
        public virtual bool IsRequirementMet(ITriggerStateVariables state, Requirement requirement)
        {
            if (requirement.RequirementType == RequirementTypes.TriggerRequirement)
            {
                var hasTrigger = state.ContainsKey(requirement.AssociatedId);
                var triggerState = (requirement.AssociatedValue == 1);
                if(requirement.AssociatedValue == 0 && !hasTrigger) { return true; }
                
                return state[requirement.AssociatedId] == triggerState;
            }
            
            return true;
        }
    }
}