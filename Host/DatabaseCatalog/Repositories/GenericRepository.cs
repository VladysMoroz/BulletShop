using Core.Entities;
using Core.Interfaces.DataManipulation;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseCatalog.Repositories
{
    public class GenericRepository<T> where T : class
    {
        protected readonly CatalogDbContext _dbContext;

        public GenericRepository(CatalogDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<T>> GetItemsByFilter(
            IFiltering filtering,
            ISorting sorting,
            IPagination pagination)
        {
            if (filtering == null) throw new ArgumentNullException(nameof(filtering));
            if (sorting == null) throw new ArgumentNullException(nameof(sorting));
            if (pagination == null) throw new ArgumentNullException(nameof(pagination));

            var query = _dbContext.Set<T>().AsQueryable();

            // Apply filters
            query = filtering.ApplyFilter(query);

            // Apply sorting
            query = sorting.ApplySorting(query);

            // Apply pagination
            query = pagination.ApplyPagination(query);

            
            query = query.Include("Product");


            return await query.ToListAsync();
        }
    }
}
