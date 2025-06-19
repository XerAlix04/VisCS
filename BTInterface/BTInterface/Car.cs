using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BTInterface
{
    internal class Car: IVehicle
    {
        private int Fuel { get; set; }
        public Car() { }
        public Car(int Fuel)
        {
            this.Fuel = Fuel;
        }
        public void setFuel(int fuel)
        {
            this.Fuel = fuel;
        }
        public int getFuel()
        {
            return this.Fuel;
        }

        public void Drive()
        {
            while (this.Fuel >= 3)
            {
                System.Console.WriteLine("Xe dang chay " + DateTime.Now.ToString());
                Fuel -= 3;
                Thread.Sleep(1000);
            }
            if (this.Fuel < 3)
            {
                
                System.Console.WriteLine("Xe het xang");
                
            }
        }
        public bool Refuel(int refuel)
        {
            Fuel += refuel;
            return true;
        }

    }
}
