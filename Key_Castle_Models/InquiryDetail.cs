﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Key_Castle_Models
{
    public class InquiryDetail
    {
        [System.ComponentModel.DataAnnotations.Key]
        public int Id { get; set; }

        [Required]
        public int InquiryHeaderId { get; set; }
        [ForeignKey("InquiryHeaderId")]
        public InquiryHeader InquiryHeader { get; set; }

        [Required]
        public int ProductId { get; set; }
        [ForeignKey("ProductId")]
        public Product Product { get; set; }

        public int Qnty { get; set; }
        public double PricePerQnty { get; set; }


    }
}
