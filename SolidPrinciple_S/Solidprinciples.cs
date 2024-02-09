using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciple_S
{
    public class Solidprinciples
    {
        static void Main(string[] args)
        {
            //------Solid Responsibility Principle

            Solidspp s = new Solidspp("lokesh", "Lokesh@gmail.com");
            s.Register();

            //-------open closed Principle
            //Rectangle rectangle = new Rectangle { Width = 5, Height = 10 };
            //Circle circle = new Circle { Radius = 7 };

            //AreaCalculator areaCalculator = new AreaCalculator();

            //double rectangleArea = areaCalculator.CalculateArea(rectangle);
            //double circleArea = areaCalculator.CalculateArea(circle);

            //Console.WriteLine($"Rectangle Area: {rectangleArea}");
            //Console.WriteLine($"Circle Area: {circleArea}");

            //------liskov substition Principle

            // Solidlsp sparrow = new Sparrow();
            // Solidlsp penguin = new Penguin();

            // // Both objects can be used interchangeably
            // sparrow.Fly();
            // penguin.Fly();

            // // Uncommenting the line below would result in a compilation error,
            // // illustrating that LSP is not violated.
            ////penguin.Swim();

            //-----interface segregation

            //// Usage adhering to ISP
            //IFly sparrow = new Sparroww();
            //ISwim penguin = new Penguinn();

            //// Each object only uses the methods relevant to its interface
            //sparrow.Fly();
            //// Uncommenting the line below would result in a compilation error,
            //// preventing the use of an inappropriate method.
            //// sparrow.Swim();

            //penguin.Swim();
            //// Uncommenting the line below would result in a compilation error,
            //// preventing the use of an inappropriate method.
            //// penguin.Fly();

            //-------Dependency Inversion

            //// Usage adhering to DIP
            //Soliddip lightBulb = new LightBulb();
            //Soliddip fan = new Fan();

            //Switch lightSwitch = new Switch(lightBulb);
            //Switch fanSwitch = new Switch(fan);

            //// Turning on and off devices without directly depending on their implementations
            //lightSwitch.TurnOn();
            //lightSwitch.TurnOff();

            //fanSwitch.TurnOn();
            //fanSwitch.TurnOff();
        }
    }
}
