using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vanns_mobileService.DataObjects
{
    public class Client : BaseUser
    {
        public string PhoneNumber { get; set; }

        //Relationships

        public virtual ICollection<Student> Students { get; set; }
        public virtual ICollection<Rating> Ratings { get; set; }
        public int? VehicleID { get; set; }
        public virtual Vehicle Vehicle { get; set; }
    }
}
