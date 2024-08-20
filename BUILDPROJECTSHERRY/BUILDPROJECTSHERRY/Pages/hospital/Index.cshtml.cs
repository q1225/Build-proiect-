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
        public void OnGet(int? patientid)
        {
            Hospital = _context.Hospitals.Select(x => new Models.Hospital
            {
              Id=x.Id,
                Adress= x.Adress,
               City=x.City, 
              State=x.State,
              HealthCareProviders=x.HealthCareProviders,        
            HospitalName=x.HospitalName,
            Phone=x.Phone,
             Zip=x.Zip
            }).ToList();
        }
    }
}
