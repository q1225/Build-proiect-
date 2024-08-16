using BUILDPROJECTSHERRY.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BUILDPROJECTSHERRY.Pages.patient
{
    public class IndexModel : PageModel
    {
        private readonly BulidProjectContext _context;
        public List<Models.Patient> patients;
        public IndexModel(BulidProjectContext context)
        {
            _context = context;
        } 
        public void OnGet()
        {
            patients = _context.Patients.ToList();















        }
    }
}
