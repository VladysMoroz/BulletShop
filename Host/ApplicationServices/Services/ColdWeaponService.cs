using Core.Entities;
using Core.Interfaces.Repositories;
using Core.Interfaces.Services;
using Core.ViewModels;
using Core.ViewModels.Request;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationServices.Services
{
    public class ColdWeaponService : IColdWeaponService
    {
        private readonly IColdWeaponRepository _coldWeaponRepository;

        public ColdWeaponService(IColdWeaponRepository weaponRepository)
        {
            _coldWeaponRepository = weaponRepository;
        }

        public async Task<ColdWeapon> CreateAsync(ColdWeapon coldWeapon)
        {
            return await _coldWeaponRepository.CreateAsync(coldWeapon);
        }

        public async Task<List<ColdWeapon>> GetAllAsync()
        {
            var weapons = await _coldWeaponRepository.GetAllAsync();

            return weapons;
        }

        public async Task<ColdWeapon> GetByIdAsync(int id)
        {
            return await _coldWeaponRepository.GetByIdAsync(id);
        }

        public async Task<ColdWeapon> UpdateAsync(int id, ColdWeapon coldWeapon)
        {
            return await _coldWeaponRepository.UpdateAsync(id, coldWeapon);
        }

        public async Task DeleteAsync(int id)
        {
            await _coldWeaponRepository.DeleteAsync(id);
        }

        //public async Task<List<ColdWeapon>> GetPaginationColdWeaponsAsync(PaginatorColdWeapon paginator)
        //{
        //    var skip = (paginator.PageNumber-1) * paginator.ItemAmount;

        //    var take = paginator.ItemAmount;

        //    var coldWeapons = await _coldWeaponRepository.TakeColdWeaponsByFilter(skip, take);

        //    return coldWeapons;
        //}

        public async Task<List<ColdWeapon>> GetColdWeaponsByFilter(ColdWeaponRequest request)
        {
            var coldWeapons = await _coldWeaponRepository.GetItemsByFilter(request.Filtering, request.Sorting, request.Pagination);

            return coldWeapons;
        }
    }

}
