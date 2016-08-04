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
        public void InsertAnimal(Animal animal, int IdFuncionario, int IdCliente)
        {
            try
            {
                OpenConnection();
                Cmd = new SqlCommand("INSERT INTO animal(nome, cor, obervacao, idfuncionario, idcliente, peso, raca)" + 
                    "VALUES(@v1, @v2, @v3, @v4, @v5, @v6, @v7)", Con);

                Cmd.Parameters.AddWithValue("@v1", animal.Nome);
                Cmd.Parameters.AddWithValue("@v2", animal.Cor);
                Cmd.Parameters.AddWithValue("@v3", animal.Observacao);
                Cmd.Parameters.AddWithValue("@v4", animal.IdFuncionario);
                Cmd.Parameters.AddWithValue("@v5", animal.IdCliente);
                Cmd.Parameters.AddWithValue("@v6", animal.Peso);
                Cmd.Parameters.AddWithValue("@v7", animal.Raca);

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


        public List<Animal> BuscaAnimalByFiltro(string Nome, string Raca)
        {
            try
            {
                OpenConnection();
                Cmd = new SqlCommand("SELECT * FROM Animal WHERE Nome LIKE '%@v1%' OR Raca LIKE '%@v2%'");

                Cmd.Parameters.AddWithValue("@v1", Nome);
                Cmd.Parameters.AddWithValue("@v2", Raca);

                Dr = Cmd.ExecuteReader();

                List<Animal> list = new List<Animal>();

                while (Dr.Read())
                {
                    var Animal = new Animal();

                    Animal.Nome = Convert.ToString(Dr["Nome"]);
                    Animal.Cor = Convert.ToString(Dr["Cor"]);
                    Animal.Peso = Convert.ToDecimal(Dr["Peso"]);
                    Animal.Raca = Convert.ToString(Dr["Raca"]);
                    Animal.Observacao = Convert.ToString(Dr["Observacao"]);
                    Animal.IdFuncionario = Convert.ToInt32(Dr["IdFuncionario"]);
                    Animal.IdCliente = Convert.ToInt32(Dr["IdCliente"]);
                    list.Add(Animal);
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

        public List<Animal> ListarAnimalByCliente(int IdCliente)
        {
            try
            {
                OpenConnection();
                Cmd = new SqlCommand("SELECT * FROM ANIMAL WHERE idcliente = @v1");

                Cmd.Parameters.AddWithValue("@v1", IdCliente);

                Dr = Cmd.ExecuteReader();

                List<Animal> list = new List<Animal>();

                while (Dr.Read())
                {
                    var Cao = new Animal();
                    Cao.IdAnimal = Convert.ToInt32(Dr["idanimal"]);
                    Cao.Nome = Convert.ToString(Dr["nome"]);
                    Cao.Raca = Convert.ToString(Dr["raca"]);
                    Cao.Peso = Convert.ToDecimal(Dr["peso"]);
                    Cao.Cor = Convert.ToString(Dr["cor"]);
                    Cao.Observacao = Convert.ToString(Dr["observacao"]);
                    Cao.IdFuncionario = Convert.ToInt32(Dr["idfuncionario"]);
                    list.Add(Cao); 
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

        public void ExcluirAnimal(int IdAnimal)
        {
            try
            {
                OpenConnection();
                Cmd = new SqlCommand("DELETE * FROM animal WHERE IdAnimal = @v1", Con);

                Cmd.Parameters.AddWithValue("@v1", IdAnimal);

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

        public void EditarAnimal(Animal Animal)
        {
            try
            {
                OpenConnection();
                Cmd = new SqlCommand("UPDATE animal SET nome = @v1, cor = @v2, peso = @v3, observacao = @v4, raca = @v5 WHERE IdAnimal = @v6", Con);

                Cmd.Parameters.AddWithValue("@v1", Animal.Nome);
                Cmd.Parameters.AddWithValue("@v2", Animal.Cor);
                Cmd.Parameters.AddWithValue("@v3", Animal.Peso);
                Cmd.Parameters.AddWithValue("@v4", Animal.Observacao);
                Cmd.Parameters.AddWithValue("@v5", Animal.Raca);

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
    }
}
