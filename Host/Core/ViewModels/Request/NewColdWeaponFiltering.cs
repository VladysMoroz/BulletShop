using Core.Entities;
using Core.Interfaces.DataManipulation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.ViewModels.Request
{
    public class NewColdWeaponFiltering : IFiltering
    {
        public List<string> HandleMaterials { get; set; }
        public List<string> BladeMaterials { get; set; }
        public List<int> HardnessMaterials { get; set; }
        public List<string> Locks { get; set; }

        public IQueryable<T> ApplyFilter<T>(IQueryable<T> query)
        {
            if (typeof(T) == typeof(ColdWeapon))
            {
                var coldWeaponQuery = query as IQueryable<ColdWeapon>;

                if (HardnessMaterials != null && HardnessMaterials.Any())
                {
                    coldWeaponQuery = coldWeaponQuery.Where(w => HardnessMaterials.Contains(w.Hardness));
                }

                if (Locks != null && Locks.Any())
                {
                    coldWeaponQuery = coldWeaponQuery.Where(w => Locks.Contains(w.LockUA) || Locks.Contains(w.LockENG));
                }

                if (BladeMaterials != null && BladeMaterials.Any())
                {
                    coldWeaponQuery = coldWeaponQuery.Where(w => BladeMaterials.Contains(w.BladeMaterialUA) || BladeMaterials.Contains(w.BladeMaterialENG));
                }

                if (HandleMaterials != null && HandleMaterials.Any())
                {
                    coldWeaponQuery = coldWeaponQuery.Where(w => HandleMaterials.Contains(w.HandleMaterialUA) || HandleMaterials.Contains(w.HandleMaterialENG));
                }

                return coldWeaponQuery as IQueryable<T>;
            }

            return query;
        }
    }

}
