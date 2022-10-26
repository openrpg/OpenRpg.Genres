using OpenRpg.Core.Modifications;
using OpenRpg.Genres.Persistence.Items;
using OpenRpg.Items.Templates;

namespace OpenRpg.Genres.UnitTests.Persistence.TestImplementations
{
    public class TestItemMapper : ItemMapper
    {
        private readonly DefaultModification DefaultModification = new DefaultModification();
        private readonly DefaultItemTemplate DefaultItemTemplate = new DefaultItemTemplate();
        
        public override IItemTemplate GetItemTemplateFor(int itemTemplateId)
        {
            return DefaultItemTemplate;
        }

        public override IModification GetModificationsFor(int modificationId)
        {
            return DefaultModification;
        }
    }
}