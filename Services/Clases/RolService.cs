using ApiV1.Business.Contracts;
using ApiV1.Models;
using ApiV1.Services.Contracts;

namespace ApiV1.Services.Clases
{
    public class RolService : IRolService
    {
        private readonly IRolRepository _IRolRepository;
        public RolService(IRolRepository tempI)
        {
            _IRolRepository = tempI;
        }
        public Task<List<Rol>> GetList()
        {
            return _IRolRepository.GetList();
        }
        public Task<Rol> AgregaActualiza(Rol l, string t)
        {
            return _IRolRepository.AgregaActualiza(l, t);
        }
    }

}
