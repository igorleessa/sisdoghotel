using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SisDogHotelDAL.Entity;
using System.Data.SqlClient;

namespace SisDogHotelDAL.Persistence
{
    public class ClienteDAL : Conexao
    {
        //inserir cliente
        public void InsertCliente(Cliente c)
        {
            try
            {
                OpenConnection();
                Cmd = new SqlCommand("INSERT INTO Cliente(Nome, Sobrenome, DataNascimento, Telefone, Celular, " +
                    "Cep, Rua, NumeroCasa, Complemento, Cidade, Estato, Pais, Cpf, Rg, UsuarioCliente, SenhaCliente)" +
                    "VALUES(@v1, @v2, @v3, @v4, @v5, @v6, @v7, @v8, @v9, @v10, @v11, @v12, @v13, @v14, @v15, @v16)", Con);

                Cmd.Parameters.AddWithValue("@v1", c.Nome);
                Cmd.Parameters.AddWithValue("@v2", c.Sobrenome);
                Cmd.Parameters.AddWithValue("@v3", c.DataNascimento);
                Cmd.Parameters.AddWithValue("@v4", c.Telefone);
                Cmd.Parameters.AddWithValue("@v5", c.Celular);
                Cmd.Parameters.AddWithValue("@v6", c.Cep);
                Cmd.Parameters.AddWithValue("@v7", c.Rua);
                Cmd.Parameters.AddWithValue("@v8", c.NumeroCasa);
                Cmd.Parameters.AddWithValue("@v9", c.Complemento);
                Cmd.Parameters.AddWithValue("@v10", c.Cidade);
                Cmd.Parameters.AddWithValue("@v11", c.Estado);
                Cmd.Parameters.AddWithValue("@v12", c.Pais);
                Cmd.Parameters.AddWithValue("@v13", c.Cpf);
                Cmd.Parameters.AddWithValue("@v14", c.Rg);
                Cmd.Parameters.AddWithValue("@v15", c.UsuarioCliente);
                Cmd.Parameters.AddWithValue("@v16", c.SenhaCliente);

                Cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao inserir Cliente: " + ex.Message);
            }
            finally
            {
                CloseConnection();
            }
        }


        public bool HasCliente(int Cpf)
        {
            try
            {
                OpenConnection();

                Cmd = new SqlCommand("SELECT COUNT(*) FROM Cliente WHERE Cpf = @v1", Con);

                Cmd.Parameters.AddWithValue("@v1", Cpf);

                int Qtd = Convert.ToInt32(Cmd.ExecuteScalar());

                if (Qtd > 0)
                    return true;
                else
                    return false;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao obter CPF: " + ex.Message);
            }
            finally
            {
                CloseConnection();
            }
        }


        public void Atualizar(Cliente c)
        {
            try
            {
                OpenConnection();
                Cmd = new SqlCommand("UPDATE Cliente SET Nome = @V1, Sobrenome = @V2, DataNascimento = @V3, Telefone = @V4, " +
                    "Celular = @V5, Cep = @V6, Rua = @V7, NumeroCasa = @V8, Complemento = @V9, Cidade = @V10, Estato = @11, " +
                    "Pais = @V12, Cpf = @V13, Rg = @V14, UsuarioCliente = @V15, SenhaCliente = @V16 WHERE IdCliente = @v17", Con);

                Cmd.Parameters.AddWithValue("@v1", c.Nome);
                Cmd.Parameters.AddWithValue("@v2", c.Sobrenome);
                Cmd.Parameters.AddWithValue("@v3", c.DataNascimento);
                Cmd.Parameters.AddWithValue("@v4", c.Telefone);
                Cmd.Parameters.AddWithValue("@v5", c.Celular);
                Cmd.Parameters.AddWithValue("@v6", c.Cep);
                Cmd.Parameters.AddWithValue("@v7", c.Rua);
                Cmd.Parameters.AddWithValue("@v8", c.NumeroCasa);
                Cmd.Parameters.AddWithValue("@v9", c.Complemento);
                Cmd.Parameters.AddWithValue("@v10", c.Cidade);
                Cmd.Parameters.AddWithValue("@v11", c.Estado);
                Cmd.Parameters.AddWithValue("@v12", c.Pais);
                Cmd.Parameters.AddWithValue("@v13", c.Cpf);
                Cmd.Parameters.AddWithValue("@v14", c.Rg);
                Cmd.Parameters.AddWithValue("@v15", c.UsuarioCliente);
                Cmd.Parameters.AddWithValue("@v16", c.SenhaCliente);
                Cmd.Parameters.AddWithValue("@v17", c.IdCliente);

                Cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao atualizar Cliente: " + ex.Message);
            }
            finally
            {
                CloseConnection();
            }
        }
    }
}
