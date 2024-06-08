using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.ViewModels
{
    public class OpticViewModel : BaseProductViewModel
    {
        public string RingDiameterUA { get; set; }
        public string RingDiameterENG { get; set; }
        public string Multiplicity { get; set; }
        public int ObjectiveLensDiameter { get; set; }
        public string TypeOfReticle { get; set; }
        public bool ReticleIllumination { get; set; }
        public string AdjustmentOfParallax_FocusingUA { get; set; }
        public string AdjustmentOfParallax_FocusingENG { get; set; }
    }
}
