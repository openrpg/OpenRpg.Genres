using OpenRpg.Genres.Fantasy.Equipment.Slots;

namespace OpenRpg.Genres.Fantasy.Equipment
{
    /// <summary>
    /// This is an example equipment layout for most fantasy style games
    /// </summary>
    /// <remarks>
    /// Not all properties need to be used, and can be added to or ignored based on scenario
    /// </remarks>
    public interface IEquipment
    {
        HeadSlot HeadSlot { get; }
        BackSlot BackSlot { get; }
        UpperBodySlot UpperBodySlot { get; }
        WristSlot WristSlot { get; }
        MainHandSlot MainHandSlot { get; }
        OffHandSlot OffHandSlot { get; }
        LowerBodySlot LowerBodySlot { get; }
        FootSlot FootSlot { get; }
        
        NeckSlot NeckSlot { get; }
        RingSlot Ring1Slot { get; }
        RingSlot Ring2Slot { get; }
    }
}