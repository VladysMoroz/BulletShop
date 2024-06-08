using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class Product
    {
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
        public int OrderId { get; set; }
        public int SubCategoryId { get; set; }
        public DateTime CreationTime { get; set; } = DateTime.UtcNow;

        // ---- NAVIGATION PROPERTIES
        [JsonIgnore]
        public Weapon Weapon { get; set; }
        [JsonIgnore]
        public SubCategory SubCategory { get; set; }
        [JsonIgnore]
        public ColdWeapon ColdWeapon { get; set; }
        [JsonIgnore]
        public Optic Optic { get; set; }
        [JsonIgnore]
        public Bullet Bullet { get; set; }
        [JsonIgnore]
        public Ammunition Ammunition { get; set; }

    }
}
