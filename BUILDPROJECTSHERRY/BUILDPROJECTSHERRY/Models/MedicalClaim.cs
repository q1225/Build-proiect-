using System;
using System.Collections.Generic;

namespace BUILDPROJECTSHERRY.Models;

public partial class MedicalClaim
{
    public int Id { get; set; }

    public string? Patient { get; set; }

    public string? HealthCareProvider { get; set; }

    public string? Ndc { get; set; }

    public int? Quantity { get; set; }

    public int? TotalAmount { get; set; }

    public string? DaysSupply { get; set; }

    public string? PrescritonNumber { get; set; }
}
