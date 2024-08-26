using System;
using System.Collections.Generic;

namespace Assig1.Models;

public partial class NoticeType
{
    public string TypeCode { get; set; } = null!;

    public string TypeDescription { get; set; } = null!;

    public virtual ICollection<Expiation> Expiations { get; set; } = new List<Expiation>();
}
