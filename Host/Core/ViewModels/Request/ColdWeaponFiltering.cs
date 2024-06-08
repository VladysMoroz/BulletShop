namespace Core.ViewModels.Request
{
    public class ColdWeaponFiltering 
    { 
        public List<string> HandleMaterials { get; set; }
        public List<string> BladeMaterials { get; set; }
        public List<int> HardnessMaterials { get; set; }
        public List<string> Locks { get; set; }
    }
}
