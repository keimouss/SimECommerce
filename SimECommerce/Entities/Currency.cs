﻿using System;
using System.Collections.Generic;

namespace SimECommerce.BOL.Entities
{
    public partial class Currency:BaseEntity
    {
        //public int Id { get; set; }
        public string Name { get; set; }
        public string CurrencyCode { get; set; }
        public decimal Rate { get; set; }
        public string DisplayLocale { get; set; }
        public string CustomFormatting { get; set; }
        public bool LimitedToStores { get; set; }
        public bool Published { get; set; }
        public int DisplayOrder { get; set; }
        public DateTime CreatedOnUtc { get; set; }
        public DateTime UpdatedOnUtc { get; set; }
    }
}
