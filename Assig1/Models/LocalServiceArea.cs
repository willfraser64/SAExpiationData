using System;
using System.Collections.Generic;

namespace Assig1.Models;

public partial class LocalServiceArea
{
    public string LsaCode { get; set; } = null!;

    public string LsaDescription { get; set; } = null!;

    public virtual ICollection<Expiation> Expiations { get; set; } = new List<Expiation>();
}
