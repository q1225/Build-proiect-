using BUILDPROJECTSHERRY.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BUILDPROJECTSHERRY.Pages.medical_claim
{
  public class IndexModel : PageModel
    {
        private readonly BulidProjectContext _context;
        public List<Models.MedcialClaim> medcialClaims;
        public IndexModel(BulidProjectContext context)
        {
            _context = context;
        }
        public void OnGet()
        {
            medcialClaims= _context.MedcialClaims.ToList();
        }
    }
}
