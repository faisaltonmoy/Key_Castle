﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Key_Castle_Models
{
    public class Seller
    {
        [System.ComponentModel.DataAnnotations.Key]
        public int Seller_id { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

    }
}
