using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Asp.netCore3._1_Store.Data;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Asp.netCore3._1_Store.Models
{
    public class OrderAppViewModel
    {
        public int OrderAppId { get; set; }
        
        public CustomerViewModel Customer { get; set; }
        public string CustomerId { get; set; }
        
        public DetailsKalaViewModel Kala { get; set; }
        public int KalaId { get; set; }

        public IEnumerable<SelectListItem> CustomerSelectListItems { get; set; }
        public IEnumerable<SelectListItem> KalaSelectListItems { get; set; }


        public int Tedad { get; set; }
        public int KalaPrice { get; set; }
        public int PriceAll { get; set; }
        public string DateSabt { get; set; }
        public string TimeSabt { get; set; }
    }
}
