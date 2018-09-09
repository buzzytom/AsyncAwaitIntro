using System;
using System.Threading.Tasks;

namespace Demo.Demos
{
    public class Demo2 : IDemo
    {
        public async Task Run()
        {
            Console.WriteLine("Demo 2");
            await MethodOnlySyncronisation();
            await MethodWithResult();
        }

        private async Task MethodOnlySyncronisation()
        {
            await Task.Run(() =>
            {
                Console.WriteLine("Fire And Wait");
            });
        }

        private async Task MethodWithResult()
        {
            int task = await Task.Run(() => 42);
            Console.WriteLine($"Method With Result: {42}");
        }
    }
}
