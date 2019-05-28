using System;
using System.Collections.Generic;
using System.Text;

namespace SimECommerce.BOL.Entities
{
    public abstract class BaseStringEntity
    {
        protected string id;
        public string Id => this.id;
    }
}
