using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisDogHotelDAL.Entity
{
    public class RotinaAlimentacao
    {
        public int IdRotinaAlimentacao { get; set; }
        public decimal Quantidade { get; set; }
        public DateTime HorarioAlimentacao { get; set; }
        public DateTime Data { get; set; }
        public int IdFuncionario { get; set; }
        public int IdAnimal { get; set; }
        public int IdAlimentacao { get; set; }
        public int NumeroRefeicao { get; set; }
    }
}
