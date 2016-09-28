using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisDogHotelBackEnd.Entity
{
    public class Checkout
    {
        public int IdCheckout { get; set; }
        public string StatusCheckout { get; set; }
        public decimal CustoFinal { get; set; }
        public decimal CustoAdicional { get; set; }

    }
}
