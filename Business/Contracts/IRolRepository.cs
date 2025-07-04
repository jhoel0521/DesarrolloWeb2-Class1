using ApiV1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiV1.Business.Contracts
{
    public interface IRolRepository
    {
        Task<List<Rol>> GetList();
        Task<Rol> AgregaActualiza(Rol l, string t);
    }
}