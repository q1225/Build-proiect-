using BUILDPROJECTSHERRY.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BUILDPROJECTSHERRY.Pages.HealthCare_Provider
{  
    public class IndexModel : PageModel
    {
        private readonly BulidProjectContext _context;
        public List<Models.HealthCareProvider> Providers;
        public IndexModel(BulidProjectContext context)
        {
            _context = context;
        }
        public void OnGet()
        { Providers = _context.HealthCareProviders.ToList();
        }
    }
}
