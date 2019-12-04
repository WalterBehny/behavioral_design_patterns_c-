using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using chainofresponsibilityone;

namespace chainofresponsibilityone
{
    public class VP : Handler
    {
        public override void handleRequest(Request request)
        {
            if (request.getRequestType() == RequestType.PURCHASE)
            {
                if (request.getAmount() < 1500)
                {
                    Console.WriteLine("VPs can approve purchases below 1500");
                    Console.Read();
                }
                else
                {
                    successor.handleRequest(request);
                }
            }
        }
    }
}
