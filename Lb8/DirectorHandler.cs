using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lb8
{
    public class DirectorHandler : Handler
    {
        public override void Handle(Document doc, ListBox listBox)
        {
            listBox.Items.Add("Director: final decision...");
            listBox.Items.Add("Director approved the document.");
        }
    }
}
