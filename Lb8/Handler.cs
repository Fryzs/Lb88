using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lb8
{
    public abstract class Handler
    {
        protected Handler nextHandler;

        public void SetNext(Handler handler)
        {
            nextHandler = handler;
        }

        public abstract void Handle(Document doc, ListBox listBox);
    }
}
