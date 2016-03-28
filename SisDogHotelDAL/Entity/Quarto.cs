using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisDogHotelDAL.Entity
{
    public class Quarto
    {
        public int IdQuarto { get; set; }
        public int NumeroQuarto { get; set; }
        public string Descricao { get; set; }
        public decimal Valor { get; set; }
        public string Status { get; set; }
    }
}
