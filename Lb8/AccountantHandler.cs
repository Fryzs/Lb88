using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lb8
{
    public class AccountantHandler : Handler
    {
        public override void Handle(Document doc, ListBox listBox)
        {
            listBox.Items.Add("Accounting: checking financial details...");

            if (doc.Amount < 10000)
            {
                listBox.Items.Add("Accounting approved the document.");
            }
            else
            {
                listBox.Items.Add("Accounting forwarded document to Director.");
                nextHandler?.Handle(doc, listBox);
            }
        }
    }
}
