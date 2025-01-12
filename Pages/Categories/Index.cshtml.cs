using FunnyWebRazor.Data;
using FunnyWebRazor.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FunnyWebRazor.Pages.Categories
{
    [BindProperties]
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContext _db;
        public List<Category> CategoryList { get; set; }
        public String SortType { get; set; }
        public IndexModel(ApplicationDbContext db)
        {
            _db = db;
        }

        public void OnGet(String sort)
        {
            Console.WriteLine("this is sort: "+ sort);
            SortType = "ratingasc";
            if (sort == "nameasc"){
                SortType = "nameasc";
            }
            if (sort == "ratingasc") {
                SortType = "ratingasc";
            }
            if (sort == "namedesc") {
                SortType = "namedesc";
            }
            if (sort == "ratingdesc") {
                SortType = "ratingdesc";
            }
            CategoryList = _db.Categories.ToList();
        }
    }
}
