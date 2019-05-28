﻿using System;
using System.Collections.Generic;

namespace SimECommerce.BOL.Entities
{
    public partial class AspNetRoles:BaseEntity
    {
        public AspNetRoles()
        {
            AspNetUserRoles = new HashSet<AspNetUserRoles>();
        }

        //public string Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<AspNetUserRoles> AspNetUserRoles { get; set; }
    }
}
