using System;
namespace MethodOverride
{
    public class Car:Vehicle
    {
        public override void Engine()
        {
            Console.WriteLine("I have 4 cylynders");
        }
    }
}
