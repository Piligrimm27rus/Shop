using Microsoft.AspNetCore.Mvc.RazorPages;
using Piligrimm.Client.Razor.Models.Market;
using Piligrimm.Client.Razor.Service.Market;

namespace Piligrimm.Client.Razor.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ICategoryService _categoryService;

        public IEnumerable<Category> Categories;

        public IndexModel(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        public async void OnGet()
        {
            Categories = await _categoryService.GetAll();
        }
    }
}