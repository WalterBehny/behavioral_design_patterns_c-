using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using chainofresponsibilityone;

namespace chainofresponsibilityone
{
    public class Director : Handler
    {
        public override void handleRequest(Request request)
        {
            if (request.getRequestType() == RequestType.CONFERENCE)
            {
                Console.WriteLine("Directors can approve conferences");
                Console.Read();
            }
            else
            {
                successor.handleRequest(request);
            }
        }
    }
}
