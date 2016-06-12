using Microsoft.Azure.Mobile.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vanns_mobileService.DataObjects
{
    public class Address : EntityData
    {
        public int AddressID { get; set; }
        public int PublicPlace { get; set; }
        public double Lat { get; set; }
        public double Long { get; set; }
        public string Number { get; set; }
        public string Complement { get; set; }
        public string Neighborhood { get; set; }
        public StatesEnum State { get; set; }
        public string PostalCode { get; set; }

        public ICollection<SchoolDriver> SchoolDrivers { get; set; }
        public ICollection<Student> Students { get; set; }
        public ICollection<School> Schools { get; set; }

    }
    public enum StatesEnum
    {
        PE,
        SP
    }

}
