using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using chainofresponsibilityone;

namespace chainofresponsibilityone
{
    public abstract class Handler
    {
        protected Handler successor;

        public void setSuccessor(Handler successor)
        {
            this.successor = successor;
        }

        public abstract void handleRequest(Request request);
    }
}
