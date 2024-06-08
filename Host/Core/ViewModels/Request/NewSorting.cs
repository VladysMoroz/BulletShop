using Core.Entities;
using Core.Interfaces.DataManipulation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.ViewModels.Request
{
    public class NewSorting : ISorting
    {
        public SortingCondition SortingCondition { get; set; }

        public IQueryable<T> ApplySorting<T>(IQueryable<T> query)
        {
            if (typeof(T) == typeof(ColdWeapon))
            {
                var coldWeaponQuery = query as IQueryable<ColdWeapon>;
                coldWeaponQuery = SortingCondition switch
                {
                    SortingCondition.Newest => coldWeaponQuery.OrderByDescending(w => w.Product.CreationTime),
                    SortingCondition.FromCheepToExpensive => coldWeaponQuery.OrderBy(w => w.Product.Price),
                    SortingCondition.FromExpensiveToCheep => coldWeaponQuery.OrderByDescending(w => w.Product.Price),
                    _ => coldWeaponQuery.OrderBy(w => w.Product.Price),
                };
                return coldWeaponQuery as IQueryable<T>;
            }

            if (typeof(T) == typeof(Optic))
            {
                var opticQuery = query as IQueryable<Optic>;
                opticQuery = SortingCondition switch
                {
                    SortingCondition.Newest => opticQuery.OrderByDescending(o => o.Product.CreationTime),
                    SortingCondition.FromCheepToExpensive => opticQuery.OrderBy(o => o.Product.Price),
                    SortingCondition.FromExpensiveToCheep => opticQuery.OrderByDescending(o => o.Product.Price),
                    _ => opticQuery.OrderBy(o => o.Product.Price),
                };
                return opticQuery as IQueryable<T>;
            }

            return query;
        }
    }
}
