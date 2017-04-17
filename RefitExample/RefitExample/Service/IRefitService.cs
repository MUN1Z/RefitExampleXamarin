using System.Threading.Tasks;
using Refit;
using RefitExample.Models;

namespace RefitExample.Service
{
    public interface IRefitService
    {
        [Get("/?ext")]
        Task<Person> GetPerson();
    }
}
