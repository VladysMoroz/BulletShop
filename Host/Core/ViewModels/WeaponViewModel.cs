using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Core.ViewModels
{
    public class WeaponViewModel : BaseProductViewModel
    {
        public string Caliber { get; set; }
        public int MagazineCapacity { get; set; }
        public int GeneralLength { get; set; }
        public int BarrelLength { get; set; }
        public string SightingDevicesUA { get; set; }
        public string SightingDevicesENG { get; set; }
        public string GunStockAndButtUA { get; set; }
        public string GunStockAndButtENG { get; set; }
        public int InitialVelocity { get; set; }
        public string BarrelTwist { get; set; }
        public string TypeUA { get; set; }
        public string TypeENG { get; set; }
    }
}
