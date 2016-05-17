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
        public void InsertFuncionario(Funcionario funcionario)
        {
            try
            {
                OpenConnection();
                Cmd = new SqlCommand("INSERT INTO Funcionario SET Nome = @v1, LofinFuncionario = @v2, SenhaFuncionario = @v3, NivelAcesso = @v4", Con);

                Cmd.Parameters.AddWithValue("@v1", funcionario.Nome);
                Cmd.Parameters.AddWithValue("@v2", funcionario.LoginFuncionario);
                Cmd.Parameters.AddWithValue("@v3", funcionario.SenhaFuncionario);
                Cmd.Parameters.AddWithValue("@v4", funcionario.NivelAcesso);

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


        public bool HasFuncionario(string funcionario)
        {
            try
            {
                OpenConnection();
                Cmd = new SqlCommand("SELECT COUNT(*) FROM funcionario WHERE idfuncionario = @v1", Con);

                Cmd.Parameters.AddWithValue("@v1", funcionario);

                int qtd = Convert.ToInt32(Cmd.ExecuteScalar());

                if (qtd > 0)
                    return true;
                else
                    return false;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao obter Funcionario: " + ex.Message);
            }
            finally
            {
                CloseConnection();
            }
        }

        public void Excluir(int IdFuncionario)
        {
            try
            {
                OpenConnection();
                Cmd = new SqlCommand("DELETE FROM Funcionario WHERE IdFuncionario = @v1", Con);

                Cmd.Parameters.AddWithValue("@v1", IdFuncionario);
                Cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao deletar :" + ex.Message);
            }
            finally
            {
                CloseConnection();
            }
        }

        public Funcionario FindFuncionarioById(int IdFuncionario)
        {
            try
            {

            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao obter Funcionario por ID :" + ex.Message);
            }
        }

    }
}
