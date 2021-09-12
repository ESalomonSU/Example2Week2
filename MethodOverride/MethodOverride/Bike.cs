using System;
namespace MethodOverride
{
    public class Bike:Vehicle
    {
        public override void Engine()
        {
            Console.WriteLine("I'm small and I have 2 cylynders");
        }
    }
}
