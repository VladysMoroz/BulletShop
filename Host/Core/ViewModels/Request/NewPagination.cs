using Core.Interfaces.DataManipulation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.ViewModels.Request
{
    public class NewPagination : IPagination
    {
        public int Skip { get; set; }
        public int Take { get; set; }

        public IQueryable<T> ApplyPagination<T>(IQueryable<T> query)
        {
            return query.Skip(Skip).Take(Take);
        }
    }
}
