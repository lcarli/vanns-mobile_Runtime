using Microsoft.Azure.Mobile.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vanns_mobileService.DataObjects
{
    public class Zone : EntityData
    {
        public int ZoneID { get; set; }
        public string Name { get; set; }

        //Relationships
        public virtual ICollection<SchoolDriver> SchoolDrivers { get; set; }
        public virtual ICollection<Estimate> Estimates { get; set; }
        public virtual ICollection<School> Schools { get; set; }

    }
}
