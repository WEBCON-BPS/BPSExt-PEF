using WebCon.WorkFlow.SDK.Documents.Model.ItemLists;

namespace WebCon.BpsExt.PEF.CustomActions.XmlHelper.Entities.Mapping
{
    public interface IXmlColumnMapping: IXmlMapping
    {
        void SetRowContext(ItemRowData row);
    }
}