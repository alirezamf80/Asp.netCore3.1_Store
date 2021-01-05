using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace Asp.netCore3._1_Store.Data
{
    public class Customer:IdentityUser
    {
        public string CustomerName { get; set; }
        public string CustomerFamily { get; set; }

    }
}
