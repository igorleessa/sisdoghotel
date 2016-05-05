using SisDogHotelDAL.Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisDogHotelDAL.Persistence
{
    public class FuncionarioDAL : Conexao
    {
        public void InsertFuncionario(Funcionario f)
        {
            try
            {
                OpenConnection();
                Cmd = new SqlCommand("INSERT INTO Funcionario SET Nome = @v1, LofinFuncionario = @v2, SenhaFuncionario = @v3, NivelAcesso = @v4", Con);

                Cmd.Parameters.AddWithValue("@v1", f.Nome);
                Cmd.Parameters.AddWithValue("@v2", f.LoginFuncionario);
                Cmd.Parameters.AddWithValue("@v3", f.SenhaFuncionario);
                Cmd.Parameters.AddWithValue("@v4", f.NivelAcesso);

                Cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao inserir Funcionario: " + ex.Message);
            }
            finally
            {
                CloseConnection();
            }
        }


        public FuncionarioDAL()
        {

        }


    }
}
