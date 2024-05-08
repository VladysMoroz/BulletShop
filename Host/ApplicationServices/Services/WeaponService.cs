using Core.Entities;
using Core.Interfaces.Repositories;
using Core.Interfaces.Services;
using Core.ViewModels;

namespace ApplicationServices.Services
{
    public class WeaponService : IWeaponService
    {
        private readonly IWeaponRepository _weaponRepository;

        public WeaponService(IWeaponRepository weaponRepository)
        {
            _weaponRepository = weaponRepository;
        }

        public async Task<Weapon> CreateAsync(Weapon weapon)
        {
            return await _weaponRepository.CreateAsync(weapon);
        }

        public async Task<List<Weapon>> GetAllAsync()
        {
            var weapons = await _weaponRepository.GetAllAsync();

            return weapons;
        }

        public async Task<Weapon> GetByIdAsync(int id)
        {
            return await _weaponRepository.GetByIdAsync(id);
        }

        public async Task<Weapon> UpdateAsync(int id, Weapon weapon)
        {
            return await _weaponRepository.UpdateAsync(id, weapon);
        }

        public async Task DeleteAsync(int id)
        {
            await _weaponRepository.DeleteAsync(id);
        }  
    }
}
