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
            if (requirement.RequirementType == GenreRequirementTypes.RaceRequirement)
            { return character.Race.Id == requirement.AssociatedId; }
            
            if (requirement.RequirementType == GenreRequirementTypes.ClassRequirement)
            { return character.Class.ClassTemplate.Id == requirement.AssociatedId; }
            
            if (requirement.RequirementType == GenreRequirementTypes.LevelRequirement)
            { return character.Class.Level >= requirement.AssociatedValue; }
            
            if(requirement.RequirementType == GenreRequirementTypes.GenderRequirement)
            { return character.GenderType == requirement.AssociatedId; }
            
            if (requirement.RequirementType == GenreRequirementTypes.EquipmentItemRequirement)
            {
                if (!character.Variables.HasEquipment())
                { return false; }

                return character.Variables.Equipment().Slots.Values
                    .Any(x => x.SlottedItem?.ItemTemplate.Id == requirement.AssociatedId);
            }
            
            if (requirement.RequirementType == GenreRequirementTypes.InventoryItemRequirement)
            {
                if (!character.Variables.HasInventory())
                { return false; }

                return character.Variables.Inventory()
                    .HasItem(requirement.AssociatedId, requirement.AssociatedValue);
            }

            if(requirement.RequirementType == GenreRequirementTypes.MaxHealthRequirement)
            { return character.Stats.MaxHealth() >= requirement.AssociatedValue; }
            
            return true;
        }

        public virtual bool IsRequirementMet(IQuestStateVariables state, Requirement requirement)
        {
            if (requirement.RequirementType == GenreRequirementTypes.QuestStateRequirement)
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
            if (requirement.RequirementType == GenreRequirementTypes.TriggerRequirement)
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