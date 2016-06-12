using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vanns_mobileService.DataObjects
{
    public class School : BaseUser
    {
        public string StateRegistration { get; set; }

        //Relationships
        public int ZoneID { get; set; }
        public virtual Zone Zone { get; set; }
        public int AddressID { get; set; }
        public virtual Address Address { get; set; }
        public virtual ICollection<SchoolDriver> SchoolDrivers { get; set; }
        public virtual ICollection<Level> Levels { get; set; }
        public virtual ICollection<Student> Students { get; set; }

    }
}
