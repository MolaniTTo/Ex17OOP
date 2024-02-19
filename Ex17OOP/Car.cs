using System;


namespace Ex17OOP
{
    public class Car : IVehicule
    {
        private int fuel;

        public Car(int InitFuel)
        {
            this.fuel = InitFuel;
        }

        public void Drive()
        {
            if (fuel > 0)
            {
                Console.WriteLine("Car is driving");
            }
        }

        public bool Refuel(int quantitat)
        {
            fuel += quantitat;
            return true;
        }




    }
}
