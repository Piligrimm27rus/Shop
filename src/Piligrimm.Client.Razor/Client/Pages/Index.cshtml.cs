using Microsoft.AspNetCore.Mvc.RazorPages;
using Piligrimm.Client.Razor.Models.Market;
using Piligrimm.Client.Razor.Provider.Market;

namespace Piligrimm.Client.Razor.Pages
{
    internal class IndexModel : PageModel
    {
        private readonly ICategoryProvider _categoryProvider;

        public IEnumerable<Category> Categories;

        public IndexModel(ICategoryProvider categoryProvider)
        {
            _categoryProvider = categoryProvider;
        }

        public async void OnGet()
        {
            Categories = await _categoryProvider.GetAll();
        }
    }
}