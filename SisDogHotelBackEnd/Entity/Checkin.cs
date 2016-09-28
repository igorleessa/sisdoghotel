using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisDogHotelBackEnd.Entity
{
    public class Checkin
    {
        public int IdCheckin { get; set; }
        public DateTime DataInicio { get; set; }
        public string StatusCheckin { get; set; }
    }
}
