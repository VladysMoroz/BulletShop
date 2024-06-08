using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.ViewModels
{
    public class BulletViewModel : BaseProductViewModel
    {
        public string Caliber { get; set; }
        public decimal BulletWeight { get; set; }
        public int QuantityInPackage { get; set; }
    }
}
