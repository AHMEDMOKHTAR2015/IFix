using System;
using System.Collections.Generic;

namespace IFix.Models
{
    public partial class Transaction
    {
        public int Id { get; set; }
        public int ServiceRequestId { get; set; }
        public int ProviderId { get; set; }
        public int PersonId { get; set; }
        public decimal CommissionAmount { get; set; }
        public bool CommissionPaid { get; set; }
        public TimeSpan ServiceDuration { get; set; }

        public virtual Person Person { get; set; } = null!;
        public virtual ServiceProviders Provider { get; set; } = null!;
    }
}
