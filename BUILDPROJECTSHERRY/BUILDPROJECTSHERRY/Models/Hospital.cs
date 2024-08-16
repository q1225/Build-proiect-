using System;
using System.Collections.Generic;

namespace BUILDPROJECTSHERRY.Models;

public partial class Hospital
{
    public int Id { get; set; }

    public string HospitalName { get; set; } = null!;

    public string? Adress { get; set; }

    public string? City { get; set; }

    public string? State { get; set; }

    public string? Zip { get; set; }

    public string? Phone { get; set; }
    public int patient_count { get; set; }
    public int healthcareProvider_count { get; set; }
    public virtual ICollection<HealthCareProvider> HealthCareProviders { get; set; } = new List<HealthCareProvider>();
}
