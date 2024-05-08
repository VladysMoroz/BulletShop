using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Core.Entities
{
    public class Weapon
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
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

        // ---- NAVIGATION PROPERTIES
        public Product Product { get; set; }

    }
}
