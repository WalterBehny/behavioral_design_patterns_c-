using System;
using System.Collections.Generic;
using System.Text;

namespace Commad
{
    public class ToggleCommand:Command
    {
        private Light light;

        public ToggleCommand(Light light)
        {
            this.light = light;
        }
        public void execute()
        {
            light.toggle();
        }
    }
}
