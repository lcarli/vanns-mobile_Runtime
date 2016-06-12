using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vanns_mobileService.DataObjects
{
    public class SchoolDriver : BaseUser
    {
        public DateTime DateBirth { get; set; }
        public string License { get; set; }

        //Relationships
        public int VehicleID { get; set; }
        public virtual Vehicle Vehicle { get; set; }
        public int AddressID { get; set; }
        public virtual Address Address { get; set; }

        public virtual ICollection<School> Schools { get; set; }
        public virtual ICollection<Zone> Zones { get; set; }
        public virtual ICollection<Estimate> Estimates { get; set; }
        public virtual ICollection<Trip> Trips { get; set; }
    }
}
