using System;
using System.Collections.Generic;

namespace SimECommerce.BOL.Entities
{
    public partial class ProductPictureMapping:BaseEntity
    {
        //public int Id { get; set; }
        public int ProductId { get; set; }
        public int PictureId { get; set; }
        public int DisplayOrder { get; set; }

        public virtual Picture Picture { get; set; }
        public virtual Product Product { get; set; }
    }
}
