using Core.Entities;
using Core.Interfaces.Repositories;
using Core.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationServices.Services
{
    public class BulletService : IBulletService
    {
        private readonly IBulletRepository _bulletRepository;

        public BulletService(IBulletRepository bulletRepository)
        {
            _bulletRepository = bulletRepository;
        }

        public async Task<Bullet> CreateAsync(Bullet bullet)
        {
            return await _bulletRepository.CreateAsync(bullet);
        }

        public async Task<List<Bullet>> GetAllAsync()
        {
            var weapons = await _bulletRepository.GetAllAsync();

            return weapons;
        }

        public async Task<Bullet> GetByIdAsync(int id)
        {
            return await _bulletRepository.GetByIdAsync(id);
        }

        public async Task<Bullet> UpdateAsync(int id, Bullet bullet)
        {
            return await _bulletRepository.UpdateAsync(id, bullet);
        }

        public async Task DeleteAsync(int id)
        {
            await _bulletRepository.DeleteAsync(id);
        }
    }
}
