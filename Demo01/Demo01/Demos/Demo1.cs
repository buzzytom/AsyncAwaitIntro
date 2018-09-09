using System;
using System.Threading.Tasks;

namespace Demo.Demos
{
    public class Demo1 : IDemo
    {
        public Task Run()
        {
            Console.WriteLine("Demo 1");
            MethodOnlySyncronisation();
            MethodWithResult();
            return Task.CompletedTask;
        }

        private void MethodOnlySyncronisation()
        {
            Task task = Task.Run(() =>
            {
                Console.WriteLine("Fire And Wait");
            });
            task.GetAwaiter().GetResult();
        }

        private void MethodWithResult()
        {
            Task<int> task = Task.Run(() => 42);
            int result = task
                .GetAwaiter()
                .GetResult();
            Console.WriteLine($"Method With Result: {42}");
        }
    }
}
