using Data;
using Data.Models.Category;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace TMFOnlineShop.Pages.Categories
{
    [BindProperties]
    public class CreateModel : PageModel
    {
        #region field

        private readonly ApplicationDbContext _db;

        public Category category { get; set; }

        #endregion

        #region Ctor
        
        public CreateModel(ApplicationDbContext db)
        {
            _db = db;
        }

        #endregion

        #region Method

        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPost()
        {
            await _db.AddAsync(category);     
            await _db.SaveChangesAsync();
            return RedirectToPage("Category");
        }

        #endregion
    }
}
