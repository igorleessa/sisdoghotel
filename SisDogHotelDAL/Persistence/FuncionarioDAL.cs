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
                Cmd = new SqlCommand("INSERT INTO Funcionario SET Nome = @v1, LoginFuncionario = @v2, SenhaFuncionario = @v3, NivelAcesso = @v4", Con);

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
                OpenConnection();
                Cmd = new SqlCommand("SELECT * FROM funcionario WHERE idfuncionario = @v1", Con);

                Cmd.Parameters.AddWithValue("@v1", IdFuncionario);

                Dr = Cmd.ExecuteReader();

                if (Dr.Read())
                {
                    Funcionario func = new Funcionario();

                    func.IdFuncionario = Convert.ToInt32(Dr["idfuncionario"]);
                    func.Nome = Convert.ToString(Dr["nome"]);
                    func.LoginFuncionario = Convert.ToString(Dr["loginfuncionario"]);
                    func.NivelAcesso = Convert.ToString(Dr["nivelacesso"]);

                    return func;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao obter Funcionario por ID :" + ex.Message);
            }
            finally
            {
                CloseConnection();
            }
        }


        public List<Funcionario> BuscarFuncionarioByNameOrLogin(string Nome, string Login)
        {
            try
            {
                OpenConnection();
                Cmd = new SqlCommand("SELECT * FROM funcionario WHERE Nome LIKE '%@v1%' OR Login LIKE '%@v2%'", Con);

                Cmd.Parameters.AddWithValue("@v1", Nome);
                Cmd.Parameters.AddWithValue("@v2", Login);

                Dr = Cmd.ExecuteReader();

                List<Funcionario> list = new List<Funcionario>();

                while (Dr.Read())
                {
                    var func = new Funcionario();

                    func.IdFuncionario = Convert.ToInt32(Dr["IdFuncionario"]);
                    func.Nome = Convert.ToString(Dr["Nome"]);
                    list.Add(func);
                }
                return list;
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
