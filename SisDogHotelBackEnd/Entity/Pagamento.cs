﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisDogHotelBackEnd.Entity
{
    public class Pagamento
    {
        public int IdPagamento { get; set; }
        public decimal ValorTotal { get; set; }
        public string TipoPagamento { get; set; }
        public int IdCheckout { get; set; }
        public int IdReserva { get; set; }


    }
}
