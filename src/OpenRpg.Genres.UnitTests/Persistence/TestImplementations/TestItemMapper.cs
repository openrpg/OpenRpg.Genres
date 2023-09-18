using OpenRpg.Core.Modifications;
using OpenRpg.Genres.Persistence.Items;
using OpenRpg.Items.Templates;

namespace OpenRpg.Genres.UnitTests.Persistence.TestImplementations
{
    public class TestItemMapper : ItemMapper
    {
        private readonly DefaultModificationTemplate DefaultModification = new DefaultModificationTemplate();
        private readonly DefaultItemTemplate DefaultItemTemplate = new DefaultItemTemplate();
        
        public override IItemTemplate GetItemTemplateFor(int itemTemplateId)
        {
            return DefaultItemTemplate;
        }

        public override IModificationTemplate GetModificationsFor(int modificationId)
        {
            return DefaultModification;
        }
    }
}