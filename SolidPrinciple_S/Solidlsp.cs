using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciple_S
{
    public class Solidlsp
    {
        public virtual void Fly()
        {
            Console.WriteLine("A bird can fly.");
        }
    }

    public class Sparrow : Solidlsp
    {
        public override void Fly()
        {
            Console.WriteLine("A sparrow is flying.");
        }
    }

    public class Penguin : Solidlsp
    {
        // Penguins cannot fly, so we override the Fly method to reflect that
        public override void Fly()
        {
            Console.WriteLine("A penguin cannot fly.");
        }

        // Penguins have a unique method for swimming
        public void Swim()
        {
            Console.WriteLine("A penguin is swimming.");
        }
    }


}
