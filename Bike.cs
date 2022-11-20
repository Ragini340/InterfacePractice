using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacePractice
{
    public class Bike : Vehicle
    {
        int speed;
        int gear;

        // To change gear
        public void changeGear(int newGear)
        {
            gear = newGear;
        }

        // To increase speed
        public void speedUp(int increment)
        {
            speed = speed + increment;
        }

        // To decrease speed
        public void applyBrake(int decrement)
        {
            speed = speed - decrement;
        }

        public void printStates()
        {
            Console.WriteLine("speed : " + speed + " gear : " + gear);
        }
    }
}

