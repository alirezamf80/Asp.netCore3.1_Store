using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Asp.netCore3._1_Store.Data
{
    public class OrderApp
    {
        public int OrderAppId { get; set; }
        [ForeignKey("CustomerId")]
        public Customer Customer { get; set; }
        public string CustomerId { get; set; }
        [ForeignKey("KalaId")]
        public Kala Kala { get; set; }
        public int KalaId { get; set; }
        public int Tedad { get; set; }
        public int KalaPrice { get; set; }
        public int PriceAll { get; set; }
        public string DateSabt { get; set; }
        public string TimeSabt { get; set; }
    }
}
