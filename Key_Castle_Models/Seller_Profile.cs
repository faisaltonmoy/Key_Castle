using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Key_Castle_Models
{
    public class Seller_Profile
    {
        [System.ComponentModel.DataAnnotations.Key]
        public int Seller_pro_id { get; set; }

        public string ShopName { get; set; }
        public string Seller_photo { get; set; }
        public int Item_sold { get; set; }

        public int Seller_id { get; set; }
        [ForeignKey("Seller_id")]

        public virtual Seller Seller { get; set; }

    }
}
