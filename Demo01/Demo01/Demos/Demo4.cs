using System;
using System.Threading.Tasks;

namespace Demo.Demos
{
    public class Demo4 : IDemo
    {
        public async Task Run()
        {
            Console.WriteLine("Demo 4 - ConfigureAwait");

            // ConfigureAwait(false) can be used to indicate that you don't need to resume on the thread that paused.
            // This is useful with UI applications when you DON'T need to synchronise with the UI thread.
            // If you need to update a UI element after the "await" don't use this mechanism.
            int result = await GetTheNumber42FromTheWeb()
                .ConfigureAwait(continueOnCapturedContext: false);

            Console.WriteLine($"The result is {result}");
        }

        private async Task<int> GetTheNumber42FromTheWeb()
        {
            await Task.Delay(5000);
            return 42;
        }
    }
}
