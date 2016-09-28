using System;
using System.Collections.Generic;
using System.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using SisDogHotelBackEnd.Entity;
using System.Configuration;
using System.Data.SqlClient;

namespace SisDogHotelBackEnd.Persistence
{
    public class Conexao    {

        //public Conexao()
        //    : base(ConfigurationManager.ConnectionStrings["tcc"].ConnectionString)
        //{

        //}
        //public DbSet<Funcionario> Funcionarios { get; set; }
        //public DbSet<Cargo> Cargos { get; set; }



        protected SqlConnection Con;
        protected SqlCommand Cmd;
        protected SqlDataReader Dr;

        protected void OpenConnection()
        {
            Con = new SqlConnection(ConfigurationManager.ConnectionStrings["tcc"].ConnectionString);

            Con.Open();
        }
        protected void CloseConnection()
        {
            Con.Close();
        }
    }
}
