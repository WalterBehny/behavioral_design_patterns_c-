using System;
using System.Collections.Generic;
using System.Text;

namespace Commad
{
    public class Switch
    {
        public void storeAndExecute(Command command)
        {
            command.execute();
        }
    }
}
