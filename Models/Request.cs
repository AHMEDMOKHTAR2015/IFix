using System;
using System.Collections.Generic;

namespace IFix.Models
{
    public partial class Request
    {
        public Request()
        {
            Reviews = new HashSet<Review>();
        }

        public int Id { get; set; }
        public int CarId { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; } = null!;
        public double? Cost { get; set; }

        public virtual Car Car { get; set; } = null!;
        public virtual ICollection<Review> Reviews { get; set; }
    }
}
