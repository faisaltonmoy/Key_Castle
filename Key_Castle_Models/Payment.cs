using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Key_Castle_Models
{
    public class Payment
    {
        [Key]

        public int Pay_id { get; set; }


        public int Amount { get; set; }
        public string Method { get; set; }

        public int? Cart_id { get; set; }
        [ForeignKey("Cart_id")]
        public virtual Cart Cart { get; set; }

        public int Seller_id { get; set; }
        [ForeignKey("Seller_id")]

        public virtual Seller Seller { get; set; }

        public int Buyer_id { get; set; }
        [ForeignKey("Buyer_id")]

        public virtual Buyer Buyer { get; set; }
    }
}
