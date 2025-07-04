using ApiV1.Models;
using System.Threading.Tasks;

namespace ApiV1.Services.Contracts
{
    public interface IRolService
    {
        Task<List<Rol>> GetList();
        Task<Rol> AgregaActualiza(Rol l, string t);

    }
}
