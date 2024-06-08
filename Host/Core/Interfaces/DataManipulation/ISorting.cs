using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Interfaces.DataManipulation
{
    public interface ISorting
    {
        IQueryable<T> ApplySorting<T>(IQueryable<T> query);
    }
}
