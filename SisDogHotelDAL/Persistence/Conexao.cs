using System;
using System.Collections.Generic;
using System.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity; 
using SisDogHotelDAL.Entity; 
using System.Configuration;

namespace SisDogHotelDAL.Persistence
{
    public class Conexao : DbContext
    {

        public Conexao()
            : base(ConfigurationManager.ConnectionStrings["tcc"].ConnectionString)
        {
            
        }




        //protected SqlConnection Con;
        //protected SqlCommand Cmd;
        //protected SqlDataReader Dr;

        //protected void OpenConnection()
        //{
        //    Con = new SqlConnection(ConfigurationManager.ConnectionStrings["tcc"].ConnectionString);

        //    Con.Open();
        //}
        //protected void CloseConnection()
        //{
        //    Con.Close();
        //}
    }
}
