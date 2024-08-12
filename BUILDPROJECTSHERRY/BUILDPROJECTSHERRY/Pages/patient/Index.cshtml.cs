using BUILDPROJECTSHERRY.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BUILDPROJECTSHERRY.Pages.patient
{
 public class IndexModel : PageModel
    {
        private readonly BulidProjectContext _context;
        public List<Models.Patient> Patients;
        public IndexModel(BulidProjectContext context)
        {
            _context = context;
        }
        public void OnGet()
        {
            Patients = _context.Patients.ToList();
        }
    }
}
