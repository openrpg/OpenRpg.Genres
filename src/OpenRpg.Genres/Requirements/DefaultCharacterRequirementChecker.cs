using System.Linq;
using OpenRpg.Core.Requirements;
using OpenRpg.Genres.Characters;
using OpenRpg.Genres.Extensions;
using OpenRpg.Genres.Types;
using OpenRpg.Items.Extensions;
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
                if (!character.Variables.HasEquipment())
                { return false; }

                return character.Variables.Equipment().Slots.Values
                    .Any(x => x.SlottedItem?.ItemTemplate.Id == requirement.AssociatedId);
            }
            
            if (requirement.RequirementType == RequirementTypes.InventoryItemRequirement)
            {
                if (!character.Variables.HasInventory())
                { return false; }

                return character.Variables.Inventory()
                    .HasItem(requirement.AssociatedId, requirement.AssociatedValue);
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