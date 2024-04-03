using System;
using System.Collections.Generic;

namespace IFix.Models
{
    public partial class ServiceProviders
    {
        public ServiceProviders()
        {
            Transactions = new HashSet<Transaction>();
        }

        public int Id { get; set; }
        public int? CenterId { get; set; }
        public int ServiceRequestId { get; set; }
        public string Name { get; set; } = null!;
        public string PhoneNumber { get; set; } = null!;
        public string? Email { get; set; }
        public string Address { get; set; } = null!;
        public int Type { get; set; }

        public virtual ICollection<Transaction> Transactions { get; set; }
    }
}
