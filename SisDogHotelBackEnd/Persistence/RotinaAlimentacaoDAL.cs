using SisDogHotelBackEnd.Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisDogHotelBackEnd.Persistence
{
    class RotinaAlimentacaoDAL : Conexao
    {
        public void CriarRotinaAlimentacao(RotinaAlimentacao Rotina, int IdFuncionario, int IdAnimal, int IdAlimentacao)
        {
            try
            {
                OpenConnection();
                Cmd = new SqlCommand("INSERT INTO RotinaAlimentacao SET IdAnimal = @v1, IdFuncionario = @v2, IdAlimentacao = @v3, Quantidade = @v4, HorarioAlimentacao = @v5," + 
                    " Data = @v6, NumeroRefeicao = @v7", Con);

                Cmd.Parameters.AddWithValue("@v1", Rotina.IdAnimal);
                Cmd.Parameters.AddWithValue("@v2", Rotina.IdFuncionario);
                Cmd.Parameters.AddWithValue("@v3", Rotina.IdAlimentacao);
                Cmd.Parameters.AddWithValue("@v4", Rotina.Quantidade);
                Cmd.Parameters.AddWithValue("@v5", Rotina.HorarioAlimentacao);
                Cmd.Parameters.AddWithValue("@v6", Rotina.Data);
                Cmd.Parameters.AddWithValue("@v7", Rotina.NumeroRefeicao);

                Cmd.ExecuteNonQuery();
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

        public void EditarRotinaAlimentacao(RotinaAlimentacao Rotina, int IDAnimal)
        {
            try
            {
                OpenConnection();
                Cmd = new SqlCommand("UPDATE RotinaAlimentacao SET Quantidade = @v1, HorarioAlimentacao = @v2, Data = @v3, NumeroRefeicao = @v4 WHERE IDAnimal = @v5", Con);

                Cmd.Parameters.AddWithValue("@v1", Rotina.Quantidade);
                Cmd.Parameters.AddWithValue("@v2", Rotina.HorarioAlimentacao);
                Cmd.Parameters.AddWithValue("@v3", Rotina.Data);
                Cmd.Parameters.AddWithValue("@v4", Rotina.NumeroRefeicao);
                Cmd.Parameters.AddWithValue("@v5", Rotina.IdAnimal);

                Cmd.ExecuteNonQuery();
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

        public void ExcluirRotina(int IDRotina)
        {
            try
            {
                OpenConnection();
                Cmd = new SqlCommand("DELETE * FROM RotinaAlimentacao WHERE IDRotinaAlimentacao = @v1", Con);

                Cmd.Parameters.AddWithValue("@v1", IDRotina);

                Cmd.ExecuteNonQuery();
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

        public List<RotinaAlimentacao> ListarRotinas(int IDRotina)
        {
            try
            {
                OpenConnection();
                Cmd = new SqlCommand("SELECT * FROM rotinaalimentacao WHERE idrotinaalimentacao = @v1", Con);

                Cmd.Parameters.AddWithValue("@v1", IDRotina);

                Dr = Cmd.ExecuteReader();

                List<RotinaAlimentacao> list = new List<RotinaAlimentacao>();

                while (Dr.Read())
                {
                    var Rotina = new RotinaAlimentacao();
                    Rotina.IdRotinaAlimentacao = Convert.ToInt32(Dr["idrotinaalimentacao"]);
                    Rotina.IdAnimal = Convert.ToInt32(Dr["IdAnimal"]);
                    Rotina.IdAlimentacao = Convert.ToInt32(Dr["IdAlimentacao"]);
                    Rotina.IdFuncionario = Convert.ToInt32(Dr["IdFuncionario"]);
                    Rotina.Data = Convert.ToDateTime(Dr["Data"]);
                    Rotina.HorarioAlimentacao = Convert.ToDateTime(Dr["HorarioAlimentacao"]);
                    Rotina.NumeroRefeicao = Convert.ToInt32(Dr["NumeroRefeicao"]);
                    Rotina.Quantidade = Convert.ToDecimal(Dr["Quantidade"]);

                    list.Add(Rotina);
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
