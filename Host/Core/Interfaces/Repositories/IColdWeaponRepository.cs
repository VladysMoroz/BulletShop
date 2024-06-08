using Core.Entities;
using Core.Interfaces.DataManipulation;
using Core.ViewModels;
using Core.ViewModels.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Interfaces.Repositories
{
    public interface IColdWeaponRepository : IRepository<ColdWeapon>
    {
        //public Task<List<ColdWeapon>> TakeColdWeaponsByFilter(int skip, int take );
        //public Task<List<ColdWeapon>> GetColdWeaponsByFilter(ColdWeaponRequest request);
        Task<List<ColdWeapon>> GetItemsByFilter(IFiltering filtering, ISorting sorting, IPagination pagination);
    }
}
