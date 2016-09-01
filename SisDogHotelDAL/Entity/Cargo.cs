using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SisDogHotelDAL.Entity
{
   public class Cargo
    {
        public int CargoID { get; set; }
        public string Sigla { get; set; }
        public string Descricao { get; set; }

        public List<Funcionario> Funcionario { get; set; }
    }
}
