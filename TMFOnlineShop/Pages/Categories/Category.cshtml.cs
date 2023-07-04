using Data;
using Data.Models.Category;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace TMFOnlineShop.Pages.Categories
{
    public class CategoriesModel : PageModel
    {
        private readonly ApplicationDbContext _db;
        public IEnumerable<Category> categories { get; set; }
        public CategoriesModel(ApplicationDbContext db)
        {
            _db=db;
        }
        public void OnGet()
        {
            categories = _db.Categories;
        }
    }
}
