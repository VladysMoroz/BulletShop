using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class Bullet
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public string Caliber { get; set; }
        public decimal BulletWeight { get; set; }
        public int QuantityInPackage { get; set; }
        public Product Product { get; set; }
    }
}
