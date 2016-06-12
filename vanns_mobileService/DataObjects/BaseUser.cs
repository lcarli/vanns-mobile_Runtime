using Microsoft.Azure.Mobile.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vanns_mobileService.DataObjects
{
    public class BaseUser : EntityData
    {
        public int BaseUserID { get; set; }
        public string PasswordHash { get; set; }
        public string Login { get; set; }
        public string Email { get; set; }
        public string Name { get; set; }

        //Relationship
        //Ranking


    }
}
