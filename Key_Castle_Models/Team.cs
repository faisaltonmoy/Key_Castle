using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Key_Castle_Models
{
    public class Team
    {
        [System.ComponentModel.DataAnnotations.Key]
        public int Team_id { get; set; }

        public string Team_Name { get; set; }
        public string Fb_id { get; set; }
        public string Gmail_id { get; set; }
        public string Team_photo { get; set; }
    }
}
