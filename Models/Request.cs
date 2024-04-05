using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IFix.Models
{

    public enum Status { Waiting, Rejected, Accepted }


    public class Request
    {
        [Key]
        public int Id { get; set; }
        
        public DateTime Date { get; set; }
        public string Problem { get; set; }
        public string Address { get; set; }
        public int Job_type { get; set; }
        
        [Required]
        public decimal Cost { get; set; }

        [Required]
        public int Payment_method { get; set; }


        public int ComplaintId { get; set; }
        public virtual Complaint Complaint { get; set; }


        public int CarId { get; set; }
        public virtual Car Car { get; set; }

        [DefaultValue("Waiting")]
        public Status request_status { get; set; }


        public virtual ICollection<ServiceAlert> ServiceAlerts { get; set; }

    }
}
