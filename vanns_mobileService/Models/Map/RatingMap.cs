﻿using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using vanns_mobileService.DataObjects;

namespace vanns_mobileService.Models.Map
{
    public class RatingMap : EntityTypeConfiguration<Rating>
    {
        public RatingMap()
        {
            ToTable("Rating");
        }
    }
}
