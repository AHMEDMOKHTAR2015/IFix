using System;
using System.Collections.Generic;

namespace IFix.Models
{
    public partial class Review
    {
        public int Id { get; set; }
        public int PersonId { get; set; }
        public int RequestId { get; set; }
        public DateTime Duration { get; set; }
        public int Attitude { get; set; }
        public int Quality { get; set; }
        public double Fraud { get; set; }
        public string? Notes { get; set; }

        public virtual Person Person { get; set; } = null!;
        public virtual Request Request { get; set; } = null!;
    }
}
