using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SisDogHotelDAL.Entity
{
    public class Funcionario
    {
        public int IdFuncionario { get; set; }
        public string Nome { get; set; }
        public string LoginFuncionario { get; set; }
        public string SenhaFuncionario { get; set; }

        public virtual Cargo Cargo { get; set; }
    }
}
