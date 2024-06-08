using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Interfaces.DataManipulation
{
    public interface IPagination
    {
        IQueryable<T> ApplyPagination<T>(IQueryable<T> query);
    }
}
