using System;
using System.Threading.Tasks;

namespace Demo.Demos
{
    public class Demo3 : GUIWindow, IDemo
    {
        private TaskCompletionSource<bool> completed = null;

        public async Task Run()
        {
            if (completed != null)
                await completed.Task;
            completed = new TaskCompletionSource<bool>();

            Console.WriteLine("Demo 3 - UI Thread Updates");
            ButtonClicked += OnButtonClicked;
            InvokeButtonClick();

            await completed.Task;
            completed = null;
        }

        private async void OnButtonClicked(object sender, EventArgs e)
        {
            int result = await GetTheNumber42FromTheWeb();
            Console.WriteLine($"Updating UI Element to {result}.");
            completed.SetResult(true);
        }

        private async Task<int> GetTheNumber42FromTheWeb()
        {
            await Task.Delay(5000);
            return 42;
        }
    }

    public class GUIWindow
    {
        public event EventHandler ButtonClicked;

        public void InvokeButtonClick()
        {
            ButtonClicked?.Invoke(this, new EventArgs());
        }
    }
}
