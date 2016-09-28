using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisDogHotelBackEnd.Entity
{
    public class Cliente
    {
        public int IdCliente { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Telefone { get; set; }
        public string Celular { get; set; }
        public string Cep { get; set; }
        public string Rua { get; set; }
        public string NumeroCasa { get; set; }
        public string Complemento { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string Pais { get; set; }
        public string Cpf { get; set; }
        public string Rg { get; set; }
        public string UsuarioCliente { get; set; }
        public string SenhaCliente { get; set; }

    }
}
