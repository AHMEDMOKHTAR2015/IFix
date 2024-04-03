using System;
using System.Collections.Generic;

namespace IFix.Models
{
    public partial class Complaint
    {
        public int Id { get; set; }
        public int PersonId { get; set; }
        public int RequestId { get; set; }
        public string? Other { get; set; }
        public bool Absence { get; set; }
        public string Quality { get; set; } = null!;
        public bool Attitude { get; set; }
        public bool Speed { get; set; }

        public virtual Person Person { get; set; } = null!;
        public virtual Request Request { get; set; } = null!;
    }
}
