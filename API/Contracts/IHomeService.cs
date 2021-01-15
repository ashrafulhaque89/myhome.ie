using System.Threading.Tasks;
using Application.Homes;
using Domain;

namespace API.Contracts
{
    public interface IHomeService
    {
        Task<SearchResult> ListAsync();
        Task<Home> CreateAsync(Home newItem);
        Task<HomeDTO> DetailsAsync(int id);
        Task<dynamic> DeleteAsync(int id);
        Task<Home> EditAsync(int id, Home home);
    }
}