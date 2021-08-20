using OpenRpg.Genres.Fantasy.Equipment.Slots;
using OpenRpg.Genres.Fantasy.Types;
using OpenRpg.Items.Equipment;

namespace OpenRpg.Genres.Fantasy.Extensions
{
    public static class EquipmentExtensions
    {
        public static BackSlot BackSlot(this IEquipment equipment) => equipment.Slots.Get(EquipmentSlotTypes.BackSlot) as BackSlot;
        public static FootSlot FootSlot(this IEquipment equipment) => equipment.Slots.Get(EquipmentSlotTypes.FootSlot) as FootSlot;
        public static HeadSlot HeadSlot(this IEquipment equipment) => equipment.Slots.Get(EquipmentSlotTypes.HeadSlot) as HeadSlot;
        public static NeckSlot NeckSlot(this IEquipment equipment) => equipment.Slots.Get(EquipmentSlotTypes.NeckSlot) as NeckSlot;
        public static RingSlot Ring1Slot(this IEquipment equipment) => equipment.Slots.Get(EquipmentSlotTypes.Ring1Slot) as RingSlot;
        public static RingSlot Ring2Slot(this IEquipment equipment) => equipment.Slots.Get(EquipmentSlotTypes.Ring2Slot) as RingSlot;
        public static WristSlot WristSlot(this IEquipment equipment) => equipment.Slots.Get(EquipmentSlotTypes.WristSlot) as WristSlot;
        public static OffHandSlot OffHandSlot(this IEquipment equipment) => equipment.Slots.Get(EquipmentSlotTypes.OffHandSlot) as OffHandSlot;
        public static MainHandSlot MainHandSlot(this IEquipment equipment) => equipment.Slots.Get(EquipmentSlotTypes.MainHandSlot) as MainHandSlot;
        public static LowerBodySlot LowerBodySlot(this IEquipment equipment) => equipment.Slots.Get(EquipmentSlotTypes.LowerBodySlot) as LowerBodySlot;
        public static UpperBodySlot UpperBodySlot(this IEquipment equipment) => equipment.Slots.Get(EquipmentSlotTypes.UpperBodySlot) as UpperBodySlot;
    }
}