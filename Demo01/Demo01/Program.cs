using Demo.Demos;
using System;

namespace Demo
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Change the class initialised here to change the demo
            IDemo demo = new Demo4();
            demo.Run().GetAwaiter().GetResult();
            Console.ReadKey();
        }
    }
}
