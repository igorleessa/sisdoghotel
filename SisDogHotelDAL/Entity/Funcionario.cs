using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisDogHotelDAL.Entity
{
    public class Funcionario
    {
        public int IdFuncionario { get; set; }
        public string Nome { get; set; }
        public string LoginFuncionario { get; set; }
        public string SenhaFuncionario { get; set; }
        public string NivelAcesso { get; set; }

    }
}
