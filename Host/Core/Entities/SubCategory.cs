using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class SubCategory
    {
        public int Id { get; set; }
        public string NameUA { get; set; }
        public string NameENG { get; set; }
        public int CategoryId { get; set; }

        // --- NAVIGATION PROPERTIES
        public ICollection<Product> Products { get; set; }     
        public Category Category { get; set; }
    }
}
