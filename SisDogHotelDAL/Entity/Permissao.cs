using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SisDogHotelDAL.Entity
{
    public class Permissao
    {
        public int PermissaoID { get; set; }
        public int Permitir { get; set; }
        public int FormularioID { get; set; }

        public List<Funcionario> Funcionario { get; set; }
        public List<Formulario> Formulario { get; set; }
    }
}
