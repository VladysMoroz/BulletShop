namespace Core.ViewModels.Request
{
    public class Sorting
    {
        public SortingCondition SortingCondition { get; set; }
    }
    public enum SortingCondition
    {
        Newest = 1,
        FromCheepToExpensive = 2,
        FromExpensiveToCheep = 3
    }
}
