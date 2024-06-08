using Core.Entities;
using Core.Interfaces.DataManipulation;
using Core.Interfaces.Repositories;
using Core.ViewModels;
using Core.ViewModels.Request;
using Microsoft.EntityFrameworkCore;

namespace DatabaseCatalog.Repositories
{
    public class ColdWeaponRepository : GenericRepository<ColdWeapon>, IColdWeaponRepository
    {
        private readonly CatalogDbContext _dbContext;

        public ColdWeaponRepository(CatalogDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<ColdWeapon>> TakeColdWeaponsByFilter(int skip, int take)
        {
            var coldWeapons  = new List<ColdWeapon>();

            coldWeapons = await _dbContext.ColdWeapons.Skip(skip).Take(take).Include(w => w.Product).OrderBy(w => w.Product.Price).ToListAsync();

            return coldWeapons;
        }
        public async Task<ColdWeapon> CreateAsync(ColdWeapon coldWeapon)
        {
            var dbColdWeapon = await _dbContext.ColdWeapons.AddAsync(coldWeapon);
            await _dbContext.SaveChangesAsync();

            return dbColdWeapon.Entity;
        }

        public async Task DeleteAsync(int id)
        {
            var coldWeapon = await GetByIdAsync(id);

            if (coldWeapon != null)
            {
                _dbContext.ColdWeapons.Remove(coldWeapon);
                await _dbContext.SaveChangesAsync();
            }
        }

        public async Task<List<ColdWeapon>> GetAllAsync()
        {
            var coldWeapons = await _dbContext.ColdWeapons.Include(w => w.Product).ToListAsync();

            return coldWeapons;
        }

        public async Task<ColdWeapon> GetByIdAsync(int id)
        {
            var coldWeapon = await _dbContext.ColdWeapons.Include(w => w.Product).FirstOrDefaultAsync(p => p.ProductId == id);

            return coldWeapon;
        }

        public async Task<ColdWeapon> UpdateAsync(int id, ColdWeapon model)
        {
            var existingColdWeapon = await GetByIdAsync(id);

            if (existingColdWeapon != null)
            {
                existingColdWeapon.HandleMaterialENG = model.HandleMaterialENG;
                existingColdWeapon.HandleMaterialUA = model.HandleMaterialUA;
                existingColdWeapon.BladeMaterialUA = model.BladeMaterialUA;
                existingColdWeapon.BladeMaterialENG = model.BladeMaterialENG;
                existingColdWeapon.Hardness = model.Hardness;
                existingColdWeapon.LockUA = model.LockUA;
                existingColdWeapon.LockENG = model.LockENG;

                existingColdWeapon.Product.NameUA = model.Product.NameUA;
                existingColdWeapon.Product.NameENG = model.Product.NameENG;
                existingColdWeapon.Product.ManufacturerUA = model.Product.ManufacturerUA;
                existingColdWeapon.Product.ManufacturerENG = model.Product.ManufacturerENG;
                existingColdWeapon.Product.DescriptionUA = model.Product.DescriptionUA;
                existingColdWeapon.Product.DescriptionENG = model.Product.DescriptionENG;
                existingColdWeapon.Product.Weight = model.Product.Weight;
                existingColdWeapon.Product.Photo = model.Product.Photo;
                existingColdWeapon.Product.Quantity = model.Product.Quantity;
                existingColdWeapon.Product.Price = model.Product.Price;
                existingColdWeapon.Product.OrderId = model.Product.OrderId;
            }
            await _dbContext.SaveChangesAsync();

            return existingColdWeapon;
        }

        public async Task<List<ColdWeapon>> GetItemsByFilter(
        IFiltering filtering,
        ISorting sorting,
        IPagination pagination)
        {
            return await base.GetItemsByFilter(filtering, sorting, pagination);
        }

        //public async Task<List<ColdWeapon>> GetColdWeaponsByFilter(ColdWeaponRequest request)
        //{
        //    var query = _dbContext.ColdWeapons.AsQueryable();


        //    if (request.Filtering.HardnessMaterials != null && request.Filtering.HardnessMaterials.Any())
        //    {
        //        query = query.Where(w => request.Filtering.HardnessMaterials.Contains(w.Hardness));
        //    }

        //    if (request.Filtering.Locks != null && request.Filtering.Locks.Any())
        //    {
        //        query = query.Where(w => request.Filtering.Locks.Contains(w.LockUA) || request.Filtering.Locks.Contains(w.LockENG));
        //    }

        //    if (request.Filtering.BladeMaterials != null && request.Filtering.BladeMaterials.Any())
        //    {
        //        query = query.Where(w => request.Filtering.BladeMaterials.Contains(w.BladeMaterialUA) || request.Filtering.BladeMaterials.Contains(w.BladeMaterialENG));
        //    }

        //    if (request.Filtering.HandleMaterials != null && request.Filtering.HandleMaterials.Any())
        //    {
        //        query = query.Where(w => request.Filtering.HandleMaterials.Contains(w.HandleMaterialUA) || request.Filtering.HandleMaterials.Contains(w.HandleMaterialENG));
        //    }

        //    switch (request.Sorting.SortingCondition)
        //    {
        //        case SortingCondition.Newest:
        //            query = query.OrderByDescending(w => w.Product.CreationTime); 
        //            break;
        //        case SortingCondition.FromCheepToExpensive:
        //            query = query.OrderBy(w => w.Product.Price);
        //            break;
        //        case SortingCondition.FromExpensiveToCheep:
        //            query = query.OrderByDescending(w => w.Product.Price);
        //            break;
        //        default:
        //            query = query.OrderBy(w => w.Product.Price); 
        //            break;
        //    }

        //    var filteredColdWeapons = await query
        //        .Skip(request.Pagination.Skip)
        //        .Take(request.Pagination.Take)
        //        .Include(w => w.Product)
        //        .ToListAsync();

        //    return filteredColdWeapons;
        //}

        //public async Task<List<ColdWeapon>> GetColdWeaponsByFilter(ColdWeaponRequest request)
        //{
        //    if (request == null) throw new ArgumentNullException(nameof(request));

        //    // Initialize request parameters if they are null

        //    var query = _dbContext.ColdWeapons.AsQueryable();

        //    // Apply filters
        //    if (request.Filtering.HardnessMaterials?.Any() == true)
        //    {
        //        query = query.Where(w => request.Filtering.HardnessMaterials.Contains(w.Hardness));
        //    }

        //    if (request.Filtering.Locks?.Any() == true)
        //    {
        //        query = query.Where(w => request.Filtering.Locks.Contains(w.LockUA) || request.Filtering.Locks.Contains(w.LockENG));
        //    }

        //    if (request.Filtering.BladeMaterials?.Any() == true)
        //    {
        //        query = query.Where(w => request.Filtering.BladeMaterials.Contains(w.BladeMaterialUA) || request.Filtering.BladeMaterials.Contains(w.BladeMaterialENG));
        //    }

        //    if (request.Filtering.HandleMaterials?.Any() == true)
        //    {
        //        query = query.Where(w => request.Filtering.HandleMaterials.Contains(w.HandleMaterialUA) || request.Filtering.HandleMaterials.Contains(w.HandleMaterialENG));
        //    }

        //    // Apply sorting
        //    query = request.Sorting.SortingCondition switch
        //    {
        //        SortingCondition.Newest => query.OrderByDescending(w => w.Product.CreationTime), // Ensure CreationTime property exists
        //        SortingCondition.FromCheepToExpensive => query.OrderBy(w => w.Product.Price),
        //        SortingCondition.FromExpensiveToCheep => query.OrderByDescending(w => w.Product.Price),
        //        _ => query.OrderBy(w => w.Product.Price) // Default sorting
        //    };

        //    // Apply pagination
        //    query = query.Skip(request.Pagination.Skip).Take(request.Pagination.Take);

        //    // Include related entities
        //    query = query.Include(w => w.Product);

        //    // Execute query
        //    return await query.ToListAsync();
        //}


    }
}
