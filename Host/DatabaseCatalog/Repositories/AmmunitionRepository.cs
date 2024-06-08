using Core.Entities;
using Core.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseCatalog.Repositories
{
    public class AmmunitionRepository : IAmmunitionRepository
    {
        private readonly CatalogDbContext _dbContext;

        public AmmunitionRepository(CatalogDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Ammunition> CreateAsync(Ammunition model)
        {
            var dbAmmunition = await _dbContext.Ammunitions.AddAsync(model);
            await _dbContext.SaveChangesAsync();

            return dbAmmunition.Entity;
        }

        public async Task DeleteAsync(int id)
        {
            var ammunition = await GetByIdAsync(id);

            if (ammunition != null)
            {
                _dbContext.Ammunitions.Remove(ammunition);
                await _dbContext.SaveChangesAsync();
            }
        }

        public async Task<List<Ammunition>> GetAllAsync()
        {
            var ammunitions = await _dbContext.Ammunitions.Include(w => w.Product).ToListAsync();

            return ammunitions;
        }

        public async Task<Ammunition> GetByIdAsync(int id)
        {
            var ammunitions = await _dbContext.Ammunitions.Include(w => w.Product).FirstOrDefaultAsync(p => p.ProductId == id);

            return ammunitions;
        }

        public async Task<Ammunition> UpdateAsync(int id, Ammunition model)
        {
            var existingAmmunition = await GetByIdAsync(id);

            if (existingAmmunition != null)
            {
                existingAmmunition.ProtectionLevelENG = model.ProtectionLevelENG;
                existingAmmunition.ProtectionLevelUA = model.ProtectionLevelUA;
                existingAmmunition.ColorUA = model.ColorUA;
                existingAmmunition.ColorENG = model.ColorENG;
                existingAmmunition.GenderENG = model.GenderENG;
                existingAmmunition.GenderUA = model.GenderUA;
                existingAmmunition.SeasonENG = model.SeasonENG;
                existingAmmunition.SeasonUA = model.SeasonUA;
                existingAmmunition.SizeUA = model.SizeUA;
                existingAmmunition.SizeENG = model.SizeENG;

                existingAmmunition.Product.NameUA = model.Product.NameUA;
                existingAmmunition.Product.NameENG = model.Product.NameENG;
                existingAmmunition.Product.ManufacturerUA = model.Product.ManufacturerUA;
                existingAmmunition.Product.ManufacturerENG = model.Product.ManufacturerENG;
                existingAmmunition.Product.DescriptionUA = model.Product.DescriptionUA;
                existingAmmunition.Product.DescriptionENG = model.Product.DescriptionENG;
                existingAmmunition.Product.Weight = model.Product.Weight;
                existingAmmunition.Product.Photo = model.Product.Photo;
                existingAmmunition.Product.Quantity = model.Product.Quantity;
                existingAmmunition.Product.Price = model.Product.Price;
                existingAmmunition.Product.OrderId = model.Product.OrderId;
            }
            await _dbContext.SaveChangesAsync();

            return existingAmmunition;
        }
    }
}
