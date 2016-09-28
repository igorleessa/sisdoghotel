using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisDogHotelBackEnd.Entity
{
    public class Reserva
    {
        public int IdReserva { get; set; }
        public decimal Valor { get; set; }
        public decimal Sinal { get; set; }
        public DateTime DataReserva { get; set; }
        public DateTime DataFinal { get; set; }
    }
}
