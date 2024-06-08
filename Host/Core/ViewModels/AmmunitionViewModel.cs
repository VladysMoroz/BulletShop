using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.ViewModels
{
    public class AmmunitionViewModel : BaseProductViewModel
    {
        public string ColorUA { get; set; }
        public string ColorENG { get; set; }
        public string ProtectionLevelUA { get; set; }
        public string ProtectionLevelENG { get; set; }
        public string SeasonUA { get; set; }
        public string SeasonENG { get; set; }
        public string SizeUA { get; set; }
        public string SizeENG { get; set; }
        public string GenderUA { get; set; }
        public string GenderENG { get; set; }
    }
}
