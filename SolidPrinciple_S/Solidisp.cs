using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciple_S
{
    public interface Solidisp
    {
        void Fly();
        void Swim(); // Violation: Not all flying animals can swim
    }

    // Segregated interfaces adhering to ISP
    public interface IFly
    {
        void Fly();
    }

    public interface ISwim
    {
        void Swim();
    }

    // Classes implementing segregated interfaces
    public class Sparroww : IFly
    {
        public void Fly()
        {
            Console.WriteLine("A sparrow is flying.");
        }
    }

    public class Penguinn : ISwim
    {
        public void Swim()
        {
            Console.WriteLine("A penguin is swimming.");
        }
    }
}
