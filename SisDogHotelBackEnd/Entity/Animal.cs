﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisDogHotelBackEnd.Entity
{
    public class Animal
    {
        public int IdAnimal { get; set; }
        public string Nome { get; set; }
        public string Cor { get; set; }
        public string Observacao { get; set; }
        public decimal Peso { get; set; }
        public string Raca { get; set; }
        public int IdFuncionario { get; set; }
        public int IdCliente { get; set; }
    }
}
