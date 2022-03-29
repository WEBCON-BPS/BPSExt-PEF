using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace WebCon.BpsExt.PEF.CustomActions.XmlHelper.CreditNote
{
    public partial class IdentifierType : ICommonType
    {

        public object GetValue()
        {
            return this.Value;
        }

        public void SetValue(object fieldValue)
        {
            this.Value = fieldValue?.ToString();
        }

    }


    public partial class TextType : ICommonType
    {
        public object GetValue()
        {
            return this.Value;
        }

        public void SetValue(object fieldValue)
        {
            this.Value = fieldValue?.ToString();
        }

    }

    public partial class DateType : ICommonType
    {
        public object GetValue()
        {
            return this.Value;
        }

        public void SetValue(object fieldValue)
        {
            if (fieldValue != null)
            {
                this.Value = DateTime.Parse(fieldValue.ToString());
            }

        }

    }

    public partial class NumericType : ICommonType
    {
        public object GetValue()
        {
            return this.Value;
        }

        public void SetValue(object fieldValue)
        {
            if (fieldValue != null)
            {
                this.Value = Decimal.Parse(fieldValue.ToString());
            }
        }

    }

    public partial class TimeType : ICommonType
    {
        public object GetValue()
        {
            return this.Value;
        }

        public void SetValue(object fieldValue)
        {
            if (fieldValue != null)
            {
                this.Value = DateTime.Parse(fieldValue.ToString());
            }

        }

    }

    public partial class IndicatorType : ICommonType
    {
        public object GetValue()
        {
            return this.Value;
        }

        public void SetValue(object fieldValue)
        {
            if (fieldValue != null && !string.IsNullOrEmpty(fieldValue.ToString()))
            {
                this.Value = bool.Parse(fieldValue.ToString());
            }

        }

    }

    public partial class MeasureType : ICommonType
    {
        public object GetValue()
        {
            return this.Value;
        }

        public void SetValue(object fieldValue)
        {
            if (fieldValue != null)
            {
                this.Value = decimal.Parse(fieldValue.ToString());
            }

        }

    }

    public partial class AmountType : ICommonType
    {
        public object GetValue()
        {
            return this.Value;
        }

        public void SetValue(object fieldValue)
        {
            if (fieldValue != null)
            {
                this.Value = decimal.Parse(fieldValue.ToString());
            }

        }

    }

    public partial class QuantityType : ICommonType
    {
        public object GetValue()
        {
            return this.Value;
        }

        public void SetValue(object fieldValue)
        {
            if (fieldValue != null)
            {
                this.Value = decimal.Parse(fieldValue.ToString());
            }

        }

    }

    public partial class CodeType : ICommonType
    {
        public object GetValue()
        {
            return this.Value;
        }

        public void SetValue(object fieldValue)
        {
            this.Value = fieldValue?.ToString();
        }

    }

    public partial class BinaryObjectType : ICommonType
    {
        public object GetValue()
        {
            return this.Value;
        }

        public void SetValue(object fieldValue)
        {
            this.Value = (byte[])fieldValue;
        }

    }
}
