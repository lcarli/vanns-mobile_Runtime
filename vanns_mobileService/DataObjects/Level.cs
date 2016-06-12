using Microsoft.Azure.Mobile.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vanns_mobileService.DataObjects
{
    public class Level : EntityData
    {
        public int LevelID { get; set; }
        public string LevelName { get; set; }

        //Relationships
        public virtual ICollection<School> Schools { get; set; }
        public virtual ICollection<Student> Students { get; set; }
    }
}
