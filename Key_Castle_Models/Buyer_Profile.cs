using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Key_Castle_Models
{
    public class Buyer_Profile
    {
        [Key]
        public int Buyer_pro_id { get; set; }

        public string FullName { get; set; }
        public string Item_purchase { get; set; }
        public string Buyer_photo { get; set; }

        public int Buyer_id { get; set; }
        [ForeignKey("Buyer_id")]

        public virtual Buyer Buyer { get; set; }
    }
}
