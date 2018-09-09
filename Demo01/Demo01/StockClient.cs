using System;
using System.Threading;
using System.Threading.Tasks;

namespace Demo
{
    public class StockClient : IStockClient
    {
        private Random random = new Random(DateTime.UtcNow.Millisecond);

        public int GetSharePrice()
        {
            Thread.Sleep(5000);
            return random.Next(0, 800);
        }

        public async Task<int> GetSharePriceAsync()
        {
            await Task.Delay(5000);
            return random.Next(0, 800);
        }
    }
}
