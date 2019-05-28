using System;
using System.Collections.Generic;

namespace SimECommerce.BOL.Entities
{
    public partial class LocaleStringResource:BaseEntity
    {
        //public int Id { get; set; }
        public int LanguageId { get; set; }
        public string ResourceName { get; set; }
        public string ResourceValue { get; set; }

        public virtual Language Language { get; set; }
    }
}
