using System;
using System.Collections.Generic;

namespace IFix.Models
{
    public partial class Car
    {
        public Car()
        {
            Requests = new HashSet<Request>();
        }

        public int Id { get; set; }
        public int PersonId { get; set; }
        public string Manufacturer { get; set; } = null!;
        public string Model { get; set; } = null!;
        public int Year { get; set; }
        public string? Color { get; set; }

        public virtual Person Person { get; set; } = null!;
        public virtual ICollection<Request> Requests { get; set; }
    }
}
