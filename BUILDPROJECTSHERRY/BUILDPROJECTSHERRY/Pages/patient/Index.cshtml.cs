using BUILDPROJECTSHERRY.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Linq;

namespace BUILDPROJECTSHERRY.Pages.Patient
{
    public class IndexModel : PageModel
    {
        private readonly BulidProjectContext _context;
        public List<Models.Patient> patients;
        public IndexModel(BulidProjectContext context)
        {
            _context = context;
        }
        public void OnGet(int? hosptailid)
        {
            patients = _context.Patients.Where(x => !hosptailid.HasValue || x.HospitalId == hosptailid).Select(x => new Models.Patient
            {
                InsuranceId = x.InsuranceId,
                Dob = x.Dob,
                Mrn = x.Mrn,
                Ssn = x.Ssn,
                Gender = x.Gender,
                hospitalcount = x.hospitalcount,
                HospitalId = x.HospitalId,
                Hospital = new Models.Hospital
                {
                    Id = x.HospitalId.Value,
                    HospitalName = x.Hospital.HospitalName,
                },
                LastName = x.LastName,
              FirstName = x.FirstName,
            }).ToList();

        }
    } 
    }
