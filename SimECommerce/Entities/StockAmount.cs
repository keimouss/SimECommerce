using System;
using System.Collections.Generic;
using System.Text;

namespace SimECommerce.BOL.Entities
{
    public class StockAmount:BaseEntity
    {
        int productId;

       

        private StockAmount() { }
        public StockAmount(int productId,int initialStock)
        {
            if (initialStock < 0)
                throw new ArgumentException($"{nameof(initialStock)} doit être supérieur à zéro");
            this.productId = productId;
            this.Quantity = initialStock;
        }
        public int Quantity { get; set; }
        public int ProductId => this.productId;
    }
}
