using System;
using System.Collections.Generic;
using OpenRpg.Genres.Characters;
using OpenRpg.Genres.Extensions;
using OpenRpg.Genres.Persistence.Classes;
using OpenRpg.Genres.Persistence.Items.Equipment;

namespace OpenRpg.Genres.Persistence.Characters
{
    public class CharacterData
    {
        public Guid Id { get; }
        public string NameLocaleId { get; }
        public string DescriptionLocaleId { get; }
        public byte GenderType { get; }
        public int RaceTemplateId { get; }
        public ClassData ClassData { get; }
        public IReadOnlyDictionary<int, float> StateVariables { get; }
        public EquipmentData EquipmentData { get; }
        public IReadOnlyDictionary<int, object> Variables { get; }

        public CharacterData(Guid id, string nameLocaleId, string descriptionLocaleId, byte genderType, int raceTemplateId, ClassData classData, IReadOnlyDictionary<int, float> stateVariables, EquipmentData equipmentData, IReadOnlyDictionary<int, object> variables = null)
        {
            Id = id;
            NameLocaleId = nameLocaleId;
            DescriptionLocaleId = descriptionLocaleId;
            GenderType = genderType;
            RaceTemplateId = raceTemplateId;
            ClassData = classData;
            StateVariables = stateVariables;
            EquipmentData = equipmentData;
            Variables = variables ?? new Dictionary<int, object>();
        }
    }
}