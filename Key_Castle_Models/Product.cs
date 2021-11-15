using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Key_Castle_Models
{
    public class Product
    {
        [System.ComponentModel.DataAnnotations.Key]

        public int Product_id { get; set; }

        [Range(0, int.MaxValue)]
        public int Qty { get; set; }

        [Range(0, int.MaxValue)]
        public int Price { get; set; }
        public string Product_name { get; set; }
        public string Product_photo { get; set; }

        public string Short_Desc { get; set; }
        public string Desc { get; set; }

        public int Category_id { get; set; }
        [ForeignKey("Category_id")]
        public virtual Category Category { get; set; }

       // [NotMapped]
       // [Range(1, 10000, ErrorMessage = "Quantity must be greater than 0.")]
        //public int TempQty { get; set; }
    }
}
