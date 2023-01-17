using System;
using OpenRpg.Genres.Fantasy.Equipment.Slots;
using OpenRpg.Genres.Fantasy.Types;
using OpenRpg.Genres.Persistence.Items;
using OpenRpg.Genres.Persistence.Items.Equipment;
using OpenRpg.Items.Equipment;

namespace OpenRpg.Genres.Fantasy.Persistence.Items.Equipment
{
    public class FantasyEquipmentMapper : EquipmentMapper
    {
        public IItemMapper ItemMapper { get; }

        public FantasyEquipmentMapper(IItemMapper itemMapper)
        { ItemMapper = itemMapper; }
        
        public override IEquipmentSlot GetSlotFor(int slotType, ItemData slottedItemData)
        {
            var item = slottedItemData != null ? ItemMapper.Map(slottedItemData) : null;
            if(slotType == EquipmentSlotTypes.BackSlot) { return new BackSlot(item); }
            if(slotType == EquipmentSlotTypes.FootSlot) { return new FootSlot(item); }
            if(slotType == EquipmentSlotTypes.HeadSlot) { return new HeadSlot(item); }
            if(slotType == EquipmentSlotTypes.NeckSlot) { return new NeckSlot(item); }
            if(slotType == EquipmentSlotTypes.Ring1Slot) { return new RingSlot(item); }
            if(slotType == EquipmentSlotTypes.Ring2Slot) { return new RingSlot(item); }
            if(slotType == EquipmentSlotTypes.WristSlot) { return new WristSlot(item); }
            if(slotType == EquipmentSlotTypes.LowerBodySlot) { return new LowerBodySlot(item); }
            if(slotType == EquipmentSlotTypes.MainHandSlot) { return new MainHandSlot(item); }
            if(slotType == EquipmentSlotTypes.OffHandSlot) { return new OffHandSlot(item); }
            if(slotType == EquipmentSlotTypes.UpperBodySlot) { return new UpperBodySlot(item); }

            throw new Exception($"Cannot map slot type [{slotType}] as there is no known handler for it");
        }
    }
}