using BUILDPROJECTSHERRY.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BUILDPROJECTSHERRY.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly BulidProjectContext _context;
        public IndexModel(ILogger<IndexModel> logger,BulidProjectContext context)
        {
            _logger = logger;
            _context = context;
        }

        public void OnGet()
        {

        }
    }
}
