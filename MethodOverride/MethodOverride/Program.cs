using System;

namespace MethodOverride
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            Bike bike = new Bike();
            car.Engine();
            bike.Engine();
            Console.WriteLine();
        }
    }
}
