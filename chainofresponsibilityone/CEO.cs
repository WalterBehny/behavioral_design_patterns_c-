using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using chainofresponsibilityone;

namespace chainofresponsibilityone
{
    public class CEO : Handler
    {
        public override void handleRequest(Request request)
        {
            Console.WriteLine ("CEOs can approve anything they want");
            Console.Read();
        }
    }
}
