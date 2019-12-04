using System;
using System.Collections.Generic;

namespace Commad
{
    class Program
    {
        static void Main(string[] args)
        {
            Light bedroomLight = new Light();
            Light kitchenLight = new Light();
            Switch lightSwitch = new Switch();
            Command toggleCommand = new ToggleCommand(bedroomLight);
            lightSwitch.storeAndExecute(toggleCommand);
            // lightSwitch.storeAndExecute(toggleCommand);
            // lightSwitch.storeAndExecute(toggleCommand);

            toggleCommand = new ToggleCommand(kitchenLight);
            lightSwitch.storeAndExecute(toggleCommand);

            Console.WriteLine("**************************************");

            List<Light> lights = new List<Light>();
            lights.Add(kitchenLight);
            lights.Add(bedroomLight);
            Command allLightsCommand = new AllLightsCommand(lights);

            lightSwitch.storeAndExecute(allLightsCommand);
        }
    }
}
