using System.Threading.Tasks;
using Refit;
using RefitExample.Models;

namespace RefitExample.Service
{
    public interface IRefitService
    {
        [Get("/numero/")]
        Task<int> GetNumber();
    }
}
