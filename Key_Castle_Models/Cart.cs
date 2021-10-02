using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Key_Castle_Models
{
    public class Cart
    {
        [Key]

        public int Cart_id { get; set; }

        public int Total_qty { get; set; }
        public int Total_price { get; set; }

        public int Buyer_id { get; set; }
        [ForeignKey("Buyer_id")]

        public virtual Buyer Buyer { get; set; }

        public int? Order_id { get; set; }
        [ForeignKey("Order_id")]

        public virtual Order Order { get; set; }

    }
}
