using BUILDPROJECTSHERRY.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BUILDPROJECTSHERRY.Pages.Hospital
{
    public class IndexModel : PageModel
    {
        private readonly BulidProjectContext _context;
        public List<Models.Hospital> Hospital;
        public IndexModel(BulidProjectContext context)
        {
        _context = context;
         }

        public void OnGet()
        {
            Hospital = _context.Hospitals.ToList();
        }
    }
}
