using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Key_Castle_Models
{
    public class Order
    {
        [System.ComponentModel.DataAnnotations.Key]

        public int Order_id { get; set; }

        public int Status { get; set; }
        public string Date { get; set; }
        public int Amount { get; set; }

        public int Order_details_id { get; set; }
        [ForeignKey("Order_details_id")]
        public virtual Order_Details Order_Details { get; set; }

        public int? Product_id { get; set; }
        [ForeignKey("Product_id")]
        public virtual Product Product { get; set; }

        public int Buyer_id { get; set; }
        [ForeignKey("Buyer_id")]
        public virtual Buyer Buyer { get; set; }

        public int Seller_id { get; set; }
        [ForeignKey("Seller_id")]
        public virtual Seller Seller { get; set; }



    }
}
