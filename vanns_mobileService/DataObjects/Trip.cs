using Microsoft.Azure.Mobile.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vanns_mobileService.DataObjects
{
    public class Trip: EntityData
    {
        public int TripID { get; set; }
        public double StartLat { get; set; }
        public double StartLong { get; set; }
        public double CurrentLat { get; set; }
        public double CurrentLong { get; set; }
        public double[] HistoryLat { get; set; }
        public double[] HistoryLong { get; set; }
        public DateTime StartDateTime { get; set; }
        public DateTime? EndDateTime { get; set; }

        //Relationships
        public int VehicleID { get; set; }
        public virtual Vehicle Vehicle { get; set; }
        public int SchoolDriverID { get; set; }
        public virtual SchoolDriver SchoolDriver { get; set; }
        public ICollection<Student> Students { get; set; }
        public ICollection<ActivityVan> Actities { get; set; }

    }
}
