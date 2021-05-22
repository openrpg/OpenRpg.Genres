using OpenRpg.Genres.Fantasy.Equipment;
using OpenRpg.Genres.Fantasy.Equipment.Slots;

namespace OpenRpg.Genres.Fantasy.Defaults
{
    public class DefaultEquipment : IEquipment
    {
        public HeadSlot HeadSlot { get; set; } = new HeadSlot();
        public BackSlot BackSlot { get; set; } = new BackSlot();
        public UpperBodySlot UpperBodySlot { get; set; } = new UpperBodySlot();
        public WristSlot WristSlot { get; set; } = new WristSlot();
        public MainHandSlot MainHandSlot { get; set; } = new MainHandSlot();
        public OffHandSlot OffHandSlot { get; set; } = new OffHandSlot();
        public LowerBodySlot LowerBodySlot { get; set; } = new LowerBodySlot();
        public FootSlot FootSlot { get; set; } = new FootSlot();
        public NeckSlot NeckSlot { get; set; } = new NeckSlot();
        public RingSlot Ring1Slot { get; set; } = new RingSlot();
        public RingSlot Ring2Slot { get; set; } = new RingSlot();
    }
}