using System;
using System.Collections.Generic;
using System.Text;

namespace Commad
{
    public class Light
    {
        private Boolean isOn = false;
       
        public Boolean IsOn()
        {
            return isOn;
        }
        public void toggle()
        {
            if (isOn)
            {
                off();
                isOn = false;
            }
            else
            {
                on();
                isOn = true;
            }
        }

        public void on()
        {
            Console.WriteLine("Light switched on.");
        }

        public void off()
        {
            Console.WriteLine("Light switched off.");
        }
    }
}
