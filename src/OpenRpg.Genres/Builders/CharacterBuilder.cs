﻿using System;
using System.Collections.Generic;
using System.Linq;
using OpenRpg.Core.Utils;
using OpenRpg.Genres.Characters;
using OpenRpg.Genres.Persistence.Characters;
using OpenRpg.Genres.Persistence.Classes;
using OpenRpg.Genres.Persistence.Items;
using OpenRpg.Genres.Persistence.Items.Equipment;
using OpenRpg.Items;

namespace OpenRpg.Genres.Builders
{
    public class CharacterBuilder
    {
        public CharacterMapper CharacterMapper { get; }
        public IRandomizer Randomizer { get; }

        protected int _raceId, _classId, _classLevels, _genderId;
        protected string _name, _description;
        protected Dictionary<int, IUniqueItem> _equipment;
        protected Dictionary<int, float> _state;
        
        protected CharacterBuilder(CharacterMapper characterMapper, IRandomizer randomizer)
        {
            CharacterMapper = characterMapper;
            Randomizer = randomizer;
        }

        public CharacterBuilder CreateNew()
        {
            _raceId = _classId = _classLevels = _genderId = 0;
            _name = _description = string.Empty;
            _equipment = new Dictionary<int, IUniqueItem>();
            _state = new Dictionary<int, float>();
            return this;
        }

        public CharacterBuilder WithName(string name)
        {
            _name = name;
            return this;
        }
        
        public CharacterBuilder WithNameLocale(string nameLocaleId)
        { return WithName(nameLocaleId); }
        
        public CharacterBuilder WithDescription(string description)
        {
            _description = description;
            return this;
        }
        
        public CharacterBuilder WithDescriptionLocale(string nameLocaleId)
        { return WithDescription(nameLocaleId); }

        public CharacterBuilder WithRaceId(int raceId)
        {
            _raceId = raceId;
            return this;
        }

        public CharacterBuilder WithClassId(int classId)
        {
            _classId = classId;
            return this;
        }

        public CharacterBuilder WithClassLevels(int levels)
        {
            _classLevels = levels;
            return this;
        }

        public CharacterBuilder AsMale()
        {
            _genderId = 1;
            return this;
        }

        public CharacterBuilder AsFemale()
        {
            _genderId = 2;
            return this;
        }

        public CharacterBuilder WithGender(byte genderId)
        {
            _genderId = genderId;
            return this;
        }

        public CharacterBuilder WithEquipment(int slotType, IUniqueItem item)
        {
            _equipment[slotType] = item;
            return this;
        }
        
        public CharacterBuilder WithState(int stateTypeId, float value)
        {
            _state[stateTypeId] = value;
            return this;
        }
        
        public virtual void RandomzieDefaults()
        {
            if (_genderId == 0) { _genderId = Randomizer.Random(1,2); }
            if (_classLevels == 0) { _classLevels = Randomizer.Random(1,5); }
        }
        
        public ICharacter Build()
        {
            RandomzieDefaults();
            
            if (string.IsNullOrEmpty(_name))
            { _name = "Unknown Name"; }

            var persistedClass = new PersistedClass(_classId, _classLevels);
            var persistedEquipmentData = _equipment
                .ToDictionary(x => x.Key, x => new PersistedItem(x.Value));
            
            var persistedEquipment = new PersistedEquipment(persistedEquipmentData);
            
            var character = new PersistedCharacter(Guid.NewGuid(), _name, _description, (byte)_genderId, 
                _raceId, persistedClass, _state, persistedEquipment);

            return CharacterMapper.Map(character);
        }
    }
}