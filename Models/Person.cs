using System;
using System.Collections.Generic;

namespace IFix.Models
{
    public partial class Person
    {
        public Person()
        {
            Cars = new HashSet<Car>();
            Reviews = new HashSet<Review>();
            Transactions = new HashSet<Transaction>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string PhoneNumber { get; set; } = null!;
        public string? Email { get; set; }
        public string Address { get; set; } = null!;
        public string Password { get; set; } = null!;

        public virtual ICollection<Car> Cars { get; set; }
        public virtual ICollection<Review> Reviews { get; set; }
        public virtual ICollection<Transaction> Transactions { get; set; }
    }
}
