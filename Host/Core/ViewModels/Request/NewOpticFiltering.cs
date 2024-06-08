using Core.Entities;
using Core.Interfaces.DataManipulation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.ViewModels.Request
{
    public class NewOpticFiltering : IFiltering
    {
        public List<string> RingDiameters { get; set; }
        public List<string> Multiplicities { get; set; }
        public List<int> ObjectiveLensDiameters { get; set; }
        public List<string> ReticleTypes { get; set; }

        public IQueryable<T> ApplyFilter<T>(IQueryable<T> query)
        {
            if (typeof(T) == typeof(Optic))
            {
                var opticQuery = query as IQueryable<Optic>;

                if (RingDiameters != null && RingDiameters.Any())
                {
                    opticQuery = opticQuery.Where(o => RingDiameters.Contains(o.RingDiameterUA) || RingDiameters.Contains(o.RingDiameterENG));
                }

                if (Multiplicities != null && Multiplicities.Any())
                {
                    opticQuery = opticQuery.Where(o => Multiplicities.Contains(o.Multiplicity));
                }

                if (ObjectiveLensDiameters != null && ObjectiveLensDiameters.Any())
                {
                    opticQuery = opticQuery.Where(o => ObjectiveLensDiameters.Contains(o.ObjectiveLensDiameter));
                }

                if (ReticleTypes != null && ReticleTypes.Any())
                {
                    opticQuery = opticQuery.Where(o => ReticleTypes.Contains(o.TypeOfReticle));
                }

                return opticQuery as IQueryable<T>;
            }

            return query;
        }
    }
}
