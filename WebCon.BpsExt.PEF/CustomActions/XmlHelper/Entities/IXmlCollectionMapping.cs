using System.Collections.Generic;
using WebCon.WorkFlow.SDK.Documents.Model.ItemLists;

namespace WebCon.BpsExt.PEF.CustomActions.XmlHelper.Entities.Mapping
{
    public interface IXmlCollectionMapping: IXmlMapping
    {
        ItemsList itemsList { get; }

        List<IXmlColumnMapping> ColumnsMapping { get; }

        int Quantity { get; }

        void SetNewRowContext();

        bool HasNextNode { get; }
    }
}