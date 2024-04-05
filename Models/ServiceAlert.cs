using Microsoft.DotNet.Scaffolding.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace IFix.Models
{
    

    public class ServiceAlert
    {
    

        [Key]
        public int Id { get; set; }

        [DefaultValue("Waiting")]
        public Status request_status { get; set; }

        public decimal? new_price { get; set; }


        public int RequestId { get; set; }
        public virtual Request Request { get; set; }


        public int ServiceProvidersId { get; set; }
        public virtual ServiceProviders ServiceProviders { get; set; }



    }
}
