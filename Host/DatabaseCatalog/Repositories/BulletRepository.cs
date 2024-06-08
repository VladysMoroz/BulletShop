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
    public class BulletRepository : IBulletRepository
    {
        private readonly CatalogDbContext _dbContext;

        public BulletRepository(CatalogDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Bullet> CreateAsync(Bullet model)
        {
            var dbBullet = await _dbContext.Bullets.AddAsync(model);
            await _dbContext.SaveChangesAsync();

            return dbBullet.Entity;
        }

        public async Task DeleteAsync(int id)
        {
            var bullet = await GetByIdAsync(id);

            if (bullet != null)
            {
                _dbContext.Bullets.Remove(bullet);
                await _dbContext.SaveChangesAsync();
            }
        }

        public async Task<List<Bullet>> GetAllAsync()
        {
            var bullets = await _dbContext.Bullets.Include(w => w.Product).ToListAsync();

            return bullets;
        }

        public async Task<Bullet> GetByIdAsync(int id)
        {
            var bullets = await _dbContext.Bullets.Include(w => w.Product).FirstOrDefaultAsync(p => p.ProductId == id);

            return bullets;
        }

        public async Task<Bullet> UpdateAsync(int id, Bullet model)
        {
            var existingBullet = await GetByIdAsync(id);

            if (existingBullet != null)
            {
                existingBullet.BulletWeight = model.BulletWeight;
                existingBullet.QuantityInPackage = model.QuantityInPackage;
                existingBullet.Caliber = model.Caliber;

                existingBullet.Product.NameUA = model.Product.NameUA;
                existingBullet.Product.NameENG = model.Product.NameENG;
                existingBullet.Product.ManufacturerUA = model.Product.ManufacturerUA;
                existingBullet.Product.ManufacturerENG = model.Product.ManufacturerENG;
                existingBullet.Product.DescriptionUA = model.Product.DescriptionUA;
                existingBullet.Product.DescriptionENG = model.Product.DescriptionENG;
                existingBullet.Product.Weight = model.Product.Weight;
                existingBullet.Product.Photo = model.Product.Photo;
                existingBullet.Product.Quantity = model.Product.Quantity;
                existingBullet.Product.Price = model.Product.Price;
                existingBullet.Product.OrderId = model.Product.OrderId;
            }
            await _dbContext.SaveChangesAsync();

            return existingBullet;
        }
    }
}
