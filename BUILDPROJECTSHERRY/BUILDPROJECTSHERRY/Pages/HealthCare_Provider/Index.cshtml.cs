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
        public void OnGet(int? hospitalId)
        { Providers = _context.HealthCareProviders.Where(x=> !hospitalId.HasValue || x.HospitalId == hospitalId).Select(x => new Models.HealthCareProvider
        {   Id = x.Id,
            Adress = x.Adress,
            City = x.City,
            FirstName= x.FirstName,
            Phone = x.Phone,
            LastName=x.LastName,
            Gender=x.Gender,
            hospitalcount=x.hospitalcount,
            HospitalId=x.HospitalId,
            Hospital=new Models.Hospital
            {
             Id=x.HospitalId.Value,
            HospitalName=x.Hospital.HospitalName,
            },
            Dob =x.Dob,
            Npi=x.Npi,
            State = x.State,
            Zip = x.Zip
        }).ToList();
        }

    }
    }

