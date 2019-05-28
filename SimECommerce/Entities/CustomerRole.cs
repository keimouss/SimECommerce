using System;
using System.Collections.Generic;

namespace SimECommerce.BOL.Entities
{
    public partial class CustomerRole:BaseEntity
    {
        public CustomerRole()
        {
            CustomerCustomerRoleMapping = new HashSet<CustomerCustomerRoleMapping>();
        }

        //public int Id { get; set; }
        public string Name { get; set; }
        public bool FreeShipping { get; set; }
        public bool TaxExempt { get; set; }
        public bool Active { get; set; }
        public bool IsSystemRole { get; set; }
        public string SystemName { get; set; }
        public int PurchasedWithProductId { get; set; }

        public virtual ICollection<CustomerCustomerRoleMapping> CustomerCustomerRoleMapping { get; set; }
    }
}
