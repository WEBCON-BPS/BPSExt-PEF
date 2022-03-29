using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebCon.WorkFlow.SDK.Documents.Model.ItemLists;

namespace WebCon.BpsExt.PEF.CustomActions.XmlHelper.Entities.Mapping
{
    public class XmlCollectionMapping : XmlFieldMapping, IXmlCollectionMapping
    {
        public bool HasNextNode => _queue.Count() > 0;

        public ItemsList itemsList { get; }
        public List<IXmlColumnMapping> ColumnsMapping { get; set; }
        public int Quantity => itemsList.Rows.Count();

        public override object Value { get => throw new InvalidOperationException(); set => throw new InvalidOperationException(); }

        public XmlCollectionMapping(string xmlPath, ItemsList itemsList): base(xmlPath)
        {
            this.itemsList = itemsList;
        }

        public void SetNewRowContext()
        {
            var newRow = itemsList.Rows.AddNewRow();
            foreach (var colMap in ColumnsMapping)
            {
                colMap.SetRowContext(newRow);
            }

        }

    }
}
