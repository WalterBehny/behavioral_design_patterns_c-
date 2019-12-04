using System;
using System.Collections.Generic;
using System.Text;

namespace Commad
{
    public class AllLightsCommand:Command
    {
        private List<Light> lights;

        public AllLightsCommand(List<Light> lights)
        {
            this.lights = lights;
        }
        public void execute()
        {
            foreach (Light light in lights)
            {
                if (light.IsOn())
                {
                    light.toggle();
                }
            }
        }
    }
}
