using System;
using System.Collections.Generic;

namespace IFix.Models
{
    public partial class ServiceAlert
    {
        public int Id { get; set; }
        public int RequestId { get; set; }
        public int ProviderId { get; set; }

        public virtual ServiceProviders Provider { get; set; } = null!;
        public virtual Request Request { get; set; } = null!;
    }
}
