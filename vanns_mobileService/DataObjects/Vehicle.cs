using Microsoft.Azure.Mobile.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vanns_mobileService.DataObjects
{
    public class Vehicle : EntityData
    {
        public int VehicleID { get; set; }
        public string PlateCar { get; set; }
        public string Model { get; set; }
        public string Year { get; set; }
        public int Occupants { get; set; }
        public string IdentityCar { get; set; }
        public CarColorEnum CarColor { get; set; }

        //Relationships
        public virtual ICollection<SchoolDriver> SchoolDrivers { get; set; }
        public virtual ICollection<Rating> Ratings { get; set; }
        public virtual ICollection<Client> Clients { get; set; }
        public virtual ICollection<Trip> Trips { get; set; }
    }

    public enum CarColorEnum
    {
        RED,
        Black
    }
}
