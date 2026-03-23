using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lb8
{
    public class ManagerHandler : Handler
    {
        public override void Handle(Document doc, ListBox listBox)
        {
            listBox.Items.Add("Manager: reviewing document...");

            if (doc.Amount < 1000)
            {
                listBox.Items.Add("Manager approved the document.");
            }
            else
            {
                listBox.Items.Add("Manager forwarded document to Accounting.");
                nextHandler?.Handle(doc, listBox);
            }
        }
    }
}
