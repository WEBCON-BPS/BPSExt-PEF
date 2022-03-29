using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebCon.WorkFlow.SDK.Documents.Model.ItemLists;
using WebCon.WorkFlow.SDK.Documents.Model.ItemLists.Configuration;
using WebCon.WorkFlow.SDK.Tools.Other;

namespace WebCon.BpsExt.PEF.CustomActions.XmlHelper.Entities.Mapping
{
    public class XmlColumnMapping : XmlFieldMapping, IXmlColumnMapping
    {
        public override object Value { get => GetValue(_cell); set => _cell.SetValue(value); }

        private object GetValue(BaseCell cell)
        {


            if (cell is ChooseCell || cell is PickerCell)
                return TextHelper.GetPairId(cell.GetValue()?.ToString());
            else if (cell is DecimalCell decimalCell && decimalCell.Value.HasValue)
                return Decimal.Round(decimalCell.Value.Value, decimalCell.Column.Configuration.DecimalPlaces, MidpointRounding.AwayFromZero);

            else
                return cell.GetValue();
        }

        ColumnInfo _column { get; }
        BaseCell _cell;
        public XmlColumnMapping(string xmlPath, ColumnInfo column) : base(xmlPath)
        {
            XmlPath = xmlPath;
            _column = column;
        }

        public void SetRowContext(ItemRowData row)
        {
            _cell = row.Cells.GetByID(_column.ID);
        }

    }


}
