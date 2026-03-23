using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lb8
{
    public class Document
    {
        public string Title { get; set; }
        public double Amount { get; set; }

        public Document(string title, double amount)
        {
            Title = title;
            Amount = amount;
        }
    }
}
