using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class ColdWeapon
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public string BladeMaterialUA { get; set; }
        public string BladeMaterialENG { get; set; }
        public string HandleMaterialUA { get; set; }
        public string HandleMaterialENG { get; set; }
        public int Hardness { get; set; }
        public string LockUA { get; set; }
        public string LockENG { get; set; }

        public Product Product { get; set; }
    }
}
