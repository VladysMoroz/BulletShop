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
    public class OpticService : IOpticService
    {
        private readonly IOpticRepository _opticRepository;

        public OpticService(IOpticRepository opticRepository)
        {
            _opticRepository = opticRepository;
        }
        public async Task<Optic> CreateAsync(Optic model)
        {
            return await _opticRepository.CreateAsync(model);
        }

        public async Task<List<Optic>> GetAllAsync()
        {
            var weapons = await _opticRepository.GetAllAsync();

            return weapons;
        }

        public async Task<Optic> GetByIdAsync(int id)
        {
            return await _opticRepository.GetByIdAsync(id);
        }

        public async Task<Optic> UpdateAsync(int id, Optic model)
        {
            return await _opticRepository.UpdateAsync(id, model);
        }

        public async Task DeleteAsync(int id)
        {
            await _opticRepository.DeleteAsync(id);
        }
    }
}
