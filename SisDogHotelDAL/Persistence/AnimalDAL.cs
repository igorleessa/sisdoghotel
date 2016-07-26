using SisDogHotelDAL.Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisDogHotelDAL.Persistence
{
    class AnimalDAL : Conexao
    {
        public void InsertAnimal(Animal animal)
        {
            try
            {
                OpenConnection();
                Cmd = new SqlCommand("INSERT INTO animal(nome, cor, idfuncionario,)");
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                CloseConnection();
            }
        }
    }
}
