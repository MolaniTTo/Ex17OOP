using Ex17OOP;
class Program
{
    static void Main()
    {
       
        Car car = new Car(0);

        Console.WriteLine("Cantidad a repostar");
        int gasAmount = Convert.ToInt32(Console.ReadLine());

        car.Refuel(gasAmount);

        car.Drive();
    }
}
