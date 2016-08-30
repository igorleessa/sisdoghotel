using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisDogHotelDAL.Entity
{
    public class Formulario
    {
        public int FormularioID { get; set; }
        public string NomeForm { get; set; }
        public string DescricaoForm { get; set; }

        public virtual Permissao Permissao { get; set; }
    }
}
