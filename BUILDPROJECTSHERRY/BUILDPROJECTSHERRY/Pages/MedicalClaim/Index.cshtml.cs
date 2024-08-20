using BUILDPROJECTSHERRY.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BUILDPROJECTSHERRY.Pages.MedicalClaim
{
  public class IndexModel : PageModel
    {
        private readonly BulidProjectContext _context;
        public List<Models.MedicalClaim> medcialClaims;
        public IndexModel(BulidProjectContext context)
        {
            _context = context;
        }
        public void OnGet()
        {
            medcialClaims= _context.MedcialClaims.Select(x => new Models.MedicalClaim
            {
                Id = x.Id,
              DaysSupply= x.DaysSupply,     
              Quantity=x.Quantity,
              HealthCareProvider=x.HealthCareProvider,
              Ndc=x.Ndc,
              Patient=x.Patient,
              PrescritonNumber=x.PrescritonNumber,
                TotalAmount=x.TotalAmount,
              
            }).ToList(); 
        }
    }
}
