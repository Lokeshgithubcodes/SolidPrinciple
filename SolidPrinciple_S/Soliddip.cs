using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciple_S
{
    public interface Soliddip
    {
        void TurnOn();
        void TurnOff();
    }

    // Low-level module (implementation) adhering to DIP
    public class LightBulb : Soliddip
    {
        public void TurnOn()
        {
            Console.WriteLine("Light bulb is on.");
        }

        public void TurnOff()
        {
            Console.WriteLine("Light bulb is off.");
        }
    }

    // Low-level module (implementation) adhering to DIP
    public class Fan : Soliddip
    {
        public void TurnOn()
        {
            Console.WriteLine("Fan is on.");
        }

        public void TurnOff()
        {
            Console.WriteLine("Fan is off.");
        }
    }

    // High-level module adhering to DIP
    public class Switch
    {
        private Soliddip device;

        public Switch(Soliddip device)
        {
            this.device = device;
        }

        public void TurnOn()
        {
            device.TurnOn();
        }

        public void TurnOff()
        {
            device.TurnOff();
        }
    }
}
