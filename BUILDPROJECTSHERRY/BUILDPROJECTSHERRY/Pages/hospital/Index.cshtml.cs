using BUILDPROJECTSHERRY.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BUILDPROJECTSHERRY.Pages.hospital
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
            Hospital = _context.Hospitals.Select(x => new Models.Hospital
            {
                Id = x.Id,
                Adress = x.Adress,
                City = x.City,
                HospitalName = x.HospitalName,
                Phone = x.Phone,
                HealthCareProviders = x.HealthCareProviders,
                healthcareProvider_count = x.healthcareProvider_count,
                patient_count = x.patient_count,
                State = x.State,
                Zip = x.Zip
            }).ToList();
        }
    }
}
