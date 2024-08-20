using System;
using System.Collections.Generic;

namespace BUILDPROJECTSHERRY.Models;

public partial class Patient
{
    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public string? Dob { get; set; }

    public string? Gender { get; set; }

    public string? Mrn { get; set; }

    public string? Ssn { get; set; }
   public string? InsuranceId { get; set; }

    public int? HospitalId { get; set; }
    public int? hospitalcount { get; set; }
    public virtual Hospital Hospital { get; set; } = null!;
}
