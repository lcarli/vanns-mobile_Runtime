using Microsoft.Azure.Mobile.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vanns_mobileService.DataObjects
{
    public class Student : EntityData
    {
        public int StudentID { get; set; }
        public string Name { get; set; }
        public DateTime DateBirth { get; set; }

        //Relationships
        public ICollection<Client> Clients { get; set; }
        public int SchoolID { get; set; }
        public virtual School School { get; set; }
        public int? VehicleID { get; set; }
        public virtual Vehicle Vehicle { get; set; }

        public int LevelID { get; set; }
        public virtual Level Level { get; set; }
        public int AddressID { get; set; }
        public virtual Address Address { get; set; }
        public ICollection<Trip> Trips { get; set; }
        public ICollection<ActivityVan> Activities { get; set; }

    }
}
