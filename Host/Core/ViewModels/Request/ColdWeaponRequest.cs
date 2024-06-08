namespace Core.ViewModels.Request
{
    public class ColdWeaponRequest
    {
        public NewPagination Pagination { get; set; }
        public NewSorting Sorting { get; set; }
        public NewColdWeaponFiltering Filtering { get; set; }

    }

}
