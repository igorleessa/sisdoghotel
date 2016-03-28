using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisDogHotelDAL.Entity
{
    public class Alimentacao
    {
        public int IdAlimentacao { get; set; }
        public string NomeAlimentacao { get; set; }
        public string Tipo { get; set; }
        public decimal Valor { get; set; }
        public string Descricao { get; set; }
    }
}
