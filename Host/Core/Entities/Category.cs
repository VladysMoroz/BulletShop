using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class Category
    {
        public int Id { get; set; }
        public string NameUA { get; set; }
        public string NameENG { get; set; }

        // --- NAVIGATION PROPERTIES
        public ICollection<SubCategory> SubCategories { get; set; }
    }
}
