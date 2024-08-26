using System;
using System.Collections.Generic;

namespace Assig1.Models;

public partial class PhotoRejection
{
    public int RejectionCode { get; set; }

    public string RejectionDescription { get; set; } = null!;

    public virtual ICollection<Expiation> Expiations { get; set; } = new List<Expiation>();
}
