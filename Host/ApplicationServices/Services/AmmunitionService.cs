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
    public class AmmunitionService : IAmmunitionService
    {
        private readonly IAmmunitionRepository _ammunitionRepository;

        public AmmunitionService(IAmmunitionRepository ammunitionRepository)
        {
            _ammunitionRepository = ammunitionRepository;
        }

        public async Task<Ammunition> CreateAsync(Ammunition ammunition)
        {
            return await _ammunitionRepository.CreateAsync(ammunition);
        }

        public async Task<List<Ammunition>> GetAllAsync()
        {
            var ammunitions = await _ammunitionRepository.GetAllAsync();

            return ammunitions;
        }

        public async Task<Ammunition> GetByIdAsync(int id)
        {
            return await _ammunitionRepository.GetByIdAsync(id);
        }

        public async Task<Ammunition> UpdateAsync(int id, Ammunition ammunition)
        {
            return await _ammunitionRepository.UpdateAsync(id, ammunition);
        }

        public async Task DeleteAsync(int id)
        {
            await _ammunitionRepository.DeleteAsync(id);
        }
    }
}
