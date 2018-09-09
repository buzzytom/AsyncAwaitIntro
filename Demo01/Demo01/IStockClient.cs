using System.Threading.Tasks;

namespace Demo
{
    public interface IStockClient
    {
        int GetSharePrice();
        Task<int> GetSharePriceAsync();
    }
}