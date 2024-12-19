using System.Threading.Tasks;
using FilipIoanaLab11MAUI.Models;

namespace FilipIoanaLab11MAUI.Data
{
    public interface IRestService
    {
        Task<List<ShopList>> RefreshDataAsync();
        Task SaveShopListAsync(ShopList item, bool isNewItem);
        Task DeleteShopListAsync(int id);
    }

}
