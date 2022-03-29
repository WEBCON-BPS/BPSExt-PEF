using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebCon.BpsExt.PEF.CustomActions.Models
{
    public class Attachments
    {
        public DocumentReferenceType[] Documents { get; set; }
        public string Category { get; set; }


        public Attachments(DocumentReferenceType[] documents, string category)
        {
            Documents = documents;
            Category = category;
        }
    }

    public class CreditNoteAttachments
    {
        public XmlHelper.CreditNote.DocumentReferenceType[] Documents { get; set; }
        public string Category { get; set; }


        public CreditNoteAttachments(XmlHelper.CreditNote.DocumentReferenceType[] documents, string category)
        {
            Documents = documents;
            Category = category;
        }
    }
}
