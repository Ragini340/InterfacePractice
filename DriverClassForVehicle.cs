using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacePractice
{
    public class DriverClassForVehicle
    {
        public static void Main()
        {
            Bicycle bicycle = new Bicycle();
            bicycle.changeGear(2);
            bicycle.speedUp(3);
            bicycle.applyBrake(1);
            Console.WriteLine("Bicycle present state is :");
            bicycle.printStates();

            Bike bike = new Bike();
            bike.changeGear(1);
            bike.speedUp(4);
            bike.applyBrake(3);
            Console.WriteLine("Bike present state is :");
            bike.printStates();
        }
    }
}