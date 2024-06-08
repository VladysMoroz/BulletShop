using System.Text.Json.Serialization;

namespace Core.ViewModels
{
    public class ColdWeaponViewModel : BaseProductViewModel
    {
        public string BladeMaterialUA { get; set; }
        public string BladeMaterialENG { get; set; }
        public string HandleMaterialUA { get; set; }
        public string HandleMaterialENG { get; set; }
        public int Hardness { get; set; }
        public string LockUA { get; set; }
        public string LockENG { get; set; }
    }
}
