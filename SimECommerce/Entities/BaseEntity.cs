using System;
using System.Collections.Generic;
using System.Text;

namespace SimECommerce.BOL.Entities
{
    public abstract class BaseEntity:BaseStringEntity
    {
        protected new int id;
        
        public new int Id => this.id;
    }
}
