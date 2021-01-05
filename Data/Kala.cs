using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Asp.netCore3._1_Store.Data
{
    public class Kala
    {
        [Key]
        public int KalaId { get; set; }
        [Required]
        public string KalaName { get; set; }
        public int KalaPrice { get; set; }
    }
}
