using Core.Entities;
using Core.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseCatalog.Repositories
{
    public class OpticRepository : IOpticRepository
    {
        private readonly CatalogDbContext _dbContext;

        public OpticRepository(CatalogDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<Optic> CreateAsync(Optic model)
        {
            var dbOptic = await _dbContext.Optics.AddAsync(model);
            await _dbContext.SaveChangesAsync();

            return dbOptic.Entity;
        }

        public async Task DeleteAsync(int id)
        {
            var optic = await GetByIdAsync(id);

            if (optic != null)
            {
                _dbContext.Optics.Remove(optic);
                await _dbContext.SaveChangesAsync();
            }
        }

        public async Task<List<Optic>> GetAllAsync()
        {
            var optics = await _dbContext.Optics.Include(w => w.Product).ToListAsync();

            return optics;
        }

        public async Task<Optic> GetByIdAsync(int id)
        {
            var optic = await _dbContext.Optics.Include(w => w.Product).FirstOrDefaultAsync(p => p.ProductId == id);

            return optic;
        }

        public async Task<Optic> UpdateAsync(int id, Optic model)
        {
            var existingOptic = await GetByIdAsync(id);

            if (existingOptic != null)
            {
                existingOptic.RingDiameterENG = model.RingDiameterENG;
                existingOptic.RingDiameterUA = model.RingDiameterUA;
                existingOptic.AdjustmentOfParallax_FocusingENG = model.AdjustmentOfParallax_FocusingENG;
                existingOptic.AdjustmentOfParallax_FocusingUA = model.AdjustmentOfParallax_FocusingUA;
                existingOptic.Multiplicity = model.Multiplicity;
                existingOptic.ObjectiveLensDiameter = model.ObjectiveLensDiameter;
                existingOptic.ReticleIllumination = model.ReticleIllumination;
                existingOptic.TypeOfReticle = model.TypeOfReticle;

                existingOptic.Product.NameUA = model.Product.NameUA;
                existingOptic.Product.NameENG = model.Product.NameENG;
                existingOptic.Product.ManufacturerUA = model.Product.ManufacturerUA;
                existingOptic.Product.ManufacturerENG = model.Product.ManufacturerENG;
                existingOptic.Product.DescriptionUA = model.Product.DescriptionUA;
                existingOptic.Product.DescriptionENG = model.Product.DescriptionENG;
                existingOptic.Product.Weight = model.Product.Weight;
                existingOptic.Product.Photo = model.Product.Photo;
                existingOptic.Product.Quantity = model.Product.Quantity;
                existingOptic.Product.Price = model.Product.Price;
                existingOptic.Product.OrderId = model.Product.OrderId;
            }
            await _dbContext.SaveChangesAsync();

            return existingOptic;
        }
    }
}
