using System;
using System.Collections.Generic;
using OpenRpg.Genres.Characters;
using OpenRpg.Genres.Persistence.Classes;
using OpenRpg.Genres.Persistence.Items.Equipment;

namespace OpenRpg.Genres.Persistence.Characters
{
    public class PersistedCharacter
    {
        public Guid Id { get; }
        public string NameLocaleId { get; }
        public string DescriptionLocaleId { get; }
        public byte GenderType { get; }
        public int RaceTemplateId { get; }
        public PersistedClass Class { get; }
        public IReadOnlyDictionary<int, float> StateVariables { get; }
        public PersistedEquipment Equipment { get; }
        public IReadOnlyDictionary<int, object> Variables { get; }

        public PersistedCharacter(Guid id, string nameLocaleId, string descriptionLocaleId, byte genderType, int raceTemplateId, PersistedClass @class, IReadOnlyDictionary<int, float> stateVariables, PersistedEquipment equipment, IReadOnlyDictionary<int, object> variables = null)
        {
            Id = id;
            NameLocaleId = nameLocaleId;
            DescriptionLocaleId = descriptionLocaleId;
            GenderType = genderType;
            RaceTemplateId = raceTemplateId;
            Class = @class;
            StateVariables = stateVariables;
            Equipment = equipment;
            Variables = variables ?? new Dictionary<int, object>();
        }

        public PersistedCharacter(ICharacter character)
        {
            Id = character.UniqueId;
            NameLocaleId = character.NameLocaleId;
            DescriptionLocaleId = character.DescriptionLocaleId;
            StateVariables = character.State;
            Class = new PersistedClass(character.Class);
            GenderType = character.GenderType;
            RaceTemplateId = character.Race.Id;
            Equipment = new PersistedEquipment(character.Equipment);
            Variables = character.Variables;
        }
    }
}