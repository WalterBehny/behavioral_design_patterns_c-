using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using chainofresponsibilityone;

namespace chainofresponsibilityone
{
    public class Client
    {
        public static void Main(string[] args)
        {
            Handler director = new Director();
            Handler vp = new VP();
            Handler ceo = new CEO();

            director.setSuccessor(vp);
            vp.setSuccessor(ceo);

            Request request = new Request(RequestType.CONFERENCE, 500);
            director.handleRequest(request);

            request = new Request(RequestType.PURCHASE, 1000);
            vp.handleRequest(request);

            request = new Request(RequestType.PURCHASE, 2000);
            director.handleRequest(request);
        }
    }
}
