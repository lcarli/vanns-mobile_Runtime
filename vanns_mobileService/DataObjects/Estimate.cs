using Microsoft.Azure.Mobile.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vanns_mobileService.DataObjects
{
    public class Estimate : EntityData
    {
        public int EstimateID { get; set; }
        public bool IsPublic { get; set; }
        public decimal Price { get; set; }

        //Relationships
        public int ZoneID { get; set; }
        public virtual Zone Zone { get; set; }
        public int SchoolDriverID { get; set; }
        public virtual SchoolDriver SchoolDriver { get; set; }
    }
}
