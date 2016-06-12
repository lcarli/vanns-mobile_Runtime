using Microsoft.Azure.Mobile.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vanns_mobileService.DataObjects
{
    public class ActivityVan : EntityData
    {
        public int ActivityVanID { get; set; }
        public DateTime CreateAt { get; set; }
        public ActivityType ActivityType { get; set; }

        //Relationship
        public int StudentID { get; set; }
        public virtual Student Student { get; set; }
        public int TripID { get; set; }
        public virtual Trip Trip { get; set; }

    }

    public enum ActivityType {
        HomeToVehicle,
        VehicleToSchool,
        SchoolToVehicle,
        VehicleToHome
    }
}
