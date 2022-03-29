using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebCon.WorkFlow.SDK.Documents.Model.Fields;
using WebCon.WorkFlow.SDK.Tools.Other;

namespace WebCon.BpsExt.PEF.CustomActions.XmlHelper.Entities.Mapping
{
    public class XmlFieldMapping : IXmlMapping
    {
        protected Queue<string> _queue;
        BaseField _field;

        public string XmlPath { get; set; }
        public virtual object Value { get => GetValue(_field); set => _field.SetValue(value); }

        private object GetValue(BaseField field)
        {
            if (field is ChooseField || field is PickerField || field is PeopleField)
                return TextHelper.GetPairId(field.GetValue()?.ToString());
            else if (field is DecimalField decimalField && decimalField.Value.HasValue)
                return Decimal.Round(decimalField.Value.Value, decimalField.Configuration.DecimalPlaces, MidpointRounding.AwayFromZero);
            else
                return field.GetValue();
        }

        public string GetXMLNode(bool reset = false)
        {
            if (_queue == null)
                ResetNodePath();

            if (_queue.Count == 0)
                return null;
            return _queue.Dequeue();
        }

        public void ResetNodePath()
        {
            _queue = new Queue<string>(XmlPath.Split('/'));
        }

        public XmlFieldMapping(string xmlPath)
        {
            XmlPath = xmlPath;
        }

        public XmlFieldMapping(string xmlPath, BaseField field): this(xmlPath)
        {
            _field = field;
        }

    }


}
