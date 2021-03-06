﻿
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Asp.netCore3._1_Store.Models
{
    public class DetailsKalaViewModel
    {
        
        public int KalaId { get; set; }
        
        public string KalaName { get; set; }
        public int KalaPrice { get; set; }
    }
    public class CreateKalaViewModel
    {
        [Required]
        public string KalaName { get; set; }
        public int KalaPrice { get; set; }
    }
}
