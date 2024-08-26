using System;
using System.Collections.Generic;

namespace Assig1.Models;

public partial class CountryState
{
    public string CountryStateCode { get; set; } = null!;

    public string? CountryState1 { get; set; }

    public virtual ICollection<Expiation> ExpiationDriverStateNavigations { get; set; } = new List<Expiation>();

    public virtual ICollection<Expiation> ExpiationRegStateNavigations { get; set; } = new List<Expiation>();
}
