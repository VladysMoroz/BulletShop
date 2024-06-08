using Core.Entities;
using Core.ViewModels;
using Core.ViewModels.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Interfaces.Services
{
    public interface IColdWeaponService : IService<ColdWeapon>
    {
        //public Task<List<ColdWeapon>> GetPaginationColdWeaponsAsync(PaginatorColdWeapon paginator);
        public Task<List<ColdWeapon>> GetColdWeaponsByFilter(ColdWeaponRequest request);

    }
}
