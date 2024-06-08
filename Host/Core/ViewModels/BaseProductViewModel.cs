using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Core.ViewModels
{
    public class BaseProductViewModel
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
    }
}
