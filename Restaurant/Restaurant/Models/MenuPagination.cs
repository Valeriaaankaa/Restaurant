namespace Restaurant.Models
{
    public class MenuPagination
    {
        public int Page { get; set; } = 0;
        public int MaxPage { get; set; }
        public string Category { get; set; } = "Alcohol";
        public int PageSize { get; } = 6;
    }
}
