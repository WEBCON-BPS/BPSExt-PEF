namespace WebCon.BpsExt.PEF.CustomActions.XmlHelper.Entities.Mapping
{
    public interface IXmlMapping
    {
        object Value { get; set; }

        string GetXMLNode(bool reset = false);
        void ResetNodePath();
    }
}