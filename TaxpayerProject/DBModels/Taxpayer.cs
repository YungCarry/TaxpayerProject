using System;
using System.Collections.Generic;

namespace TaxpayerProject.DBModels;

public partial class Taxpayer
{
    public string? Email { get; set; }

    public string? Name { get; set; }

    public int? Amount { get; set; }
}
