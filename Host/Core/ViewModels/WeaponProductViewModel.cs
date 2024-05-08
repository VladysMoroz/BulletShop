using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Core.ViewModels
{
    public class WeaponProductViewModel
    {
        [JsonIgnore]
        public int Id { get; set; }
        public string NameUA { get; set; }
        public string NameENG { get; set; }
        public string ManufacturerUA { get; set; }
        public string ManufacturerENG { get; set; }
        public string DescriptionUA { get; set; }
        public string DescriptionENG { get; set; }
        public decimal Weight { get; set; }
        public string Photo { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public int SubCategoryId { get; set; }

        // ------

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
