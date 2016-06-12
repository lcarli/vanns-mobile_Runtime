using Microsoft.Azure.Mobile.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vanns_mobileService.DataObjects
{
    public class Rating : EntityData
    {
        public int RattingID { get; set; }
        public string Comment { get; set; }
        public int Rate { get; set; }

        //Relationship
        public int VehicleID { get; set; }
        public virtual Vehicle Vehicle { get; set; }
        public int ClientID { get; set; }
        public virtual Client Client { get; set; }
    }
}
