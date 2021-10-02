using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Key_Castle_Models
{
    public class Category
    {
        [Key]

        public int Category_id { get; set; }
        [Required]
        [DisplayName("Category Name")]
        public string Category_name { get; set; }
        [Required]
        [Range(0,1,ErrorMessage ="Status should be 0/1")]
        public int Status { get; set; }

    }
}
