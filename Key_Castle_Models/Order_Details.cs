using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Key_Castle_Models
{
    public class Order_Details
    {
        [System.ComponentModel.DataAnnotations.Key]

        public int Order_details_id { get; set; }

        public int Qty { get; set; }
        public int Price { get; set; }

        public int Product_id { get; set; }
        [ForeignKey("Product_id")]
        public virtual Product Product { get; set; }

    }
}
