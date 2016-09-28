using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SisDogHotelBackEnd.Entity;
using System.Data.SqlClient;

namespace SisDogHotelBackEnd.Persistence
{
    public class ClienteDAL : Conexao
    {
        //inserir cliente
        public void InsertCliente(Cliente c)
        {
            try
            {
                OpenConnection();
                Cmd = new SqlCommand("INSERT INTO cliente(Nome, Sobrenome, DataNascimento, Telefone, Celular, " +
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


        public bool HasClienteByCpf(int Cpf)
        {
            try
            {
                OpenConnection();

                Cmd = new SqlCommand("SELECT COUNT(*) FROM cliente WHERE Cpf = @v1", Con);

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


        public void Atualizar(Cliente Clientes)
        {
            try
            {
                OpenConnection();
                Cmd = new SqlCommand("UPDATE cliente SET Nome = @V1, Sobrenome = @V2, DataNascimento = @V3, Telefone = @V4, " +
                    "Celular = @V5, Cep = @V6, Rua = @V7, NumeroCasa = @V8, Complemento = @V9, Cidade = @V10, Estato = @11, " +
                    "Pais = @V12, Cpf = @V13, Rg = @V14, UsuarioCliente = @V15, SenhaCliente = @V16 WHERE IdCliente = @v17", Con);

                Cmd.Parameters.AddWithValue("@v1", Clientes.Nome);
                Cmd.Parameters.AddWithValue("@v2", Clientes.Sobrenome);
                Cmd.Parameters.AddWithValue("@v3", Clientes.DataNascimento);
                Cmd.Parameters.AddWithValue("@v4", Clientes.Telefone);
                Cmd.Parameters.AddWithValue("@v5", Clientes.Celular);
                Cmd.Parameters.AddWithValue("@v6", Clientes.Cep);
                Cmd.Parameters.AddWithValue("@v7", Clientes.Rua);
                Cmd.Parameters.AddWithValue("@v8", Clientes.NumeroCasa);
                Cmd.Parameters.AddWithValue("@v9", Clientes.Complemento);
                Cmd.Parameters.AddWithValue("@v10", Clientes.Cidade);
                Cmd.Parameters.AddWithValue("@v11", Clientes.Estado);
                Cmd.Parameters.AddWithValue("@v12", Clientes.Pais);
                Cmd.Parameters.AddWithValue("@v13", Clientes.Cpf);
                Cmd.Parameters.AddWithValue("@v14", Clientes.Rg);
                Cmd.Parameters.AddWithValue("@v15", Clientes.UsuarioCliente);
                Cmd.Parameters.AddWithValue("@v16", Clientes.SenhaCliente);
                Cmd.Parameters.AddWithValue("@v17", Clientes.IdCliente);

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





        public List<Cliente> BuscarClienteByFiltro(string Nome, string Sobrenome, string LoginCliente)
        {
            try
            {
                OpenConnection();
                Cmd = new SqlCommand("SELECT * FROM Cliente WHERE Nome LIKE '%@v1%' OR Sobrenome LIKE '%@v2%' OR UsuarioCliente LIKE '%@v3%'", Con);

                Cmd.Parameters.AddWithValue("@v1", Nome);
                Cmd.Parameters.AddWithValue("@v2", Sobrenome);
                Cmd.Parameters.AddWithValue("@v3", LoginCliente);

                Dr = Cmd.ExecuteReader();

                List<Cliente> list = new List<Cliente>();

                while (Dr.Read())
                {
                    var cliente = new Cliente();

                    cliente.Nome = Convert.ToString(Dr["nome"]);
                    cliente.Sobrenome = Convert.ToString(Dr["sobrenome"]);
                    cliente.DataNascimento = Convert.ToDateTime(Dr["datanascimento"]);
                    cliente.Telefone = Convert.ToString(Dr["telefone"]);
                    cliente.Celular = Convert.ToString(Dr["celular"]);
                    cliente.Cep = Convert.ToString(Dr["cep"]);
                    cliente.Rua = Convert.ToString(Dr["rua"]);
                    cliente.NumeroCasa = Convert.ToString(Dr["numerocasa"]);
                    cliente.Complemento = Convert.ToString(Dr["complemento"]);
                    cliente.Cidade = Convert.ToString(Dr["cidade"]);
                    cliente.Estado = Convert.ToString(Dr["estado"]);
                    cliente.Pais = Convert.ToString(Dr["pais"]);
                    cliente.Cpf = Convert.ToString(Dr["cpf"]);
                    cliente.Rg = Convert.ToString(Dr["rg"]);
                    cliente.UsuarioCliente = Convert.ToString(Dr["usuariocliente"]);
                    cliente.SenhaCliente = Convert.ToString(Dr["senhacliente"]);
                    list.Add(cliente);
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

        public bool HasLoginCliente(string Login)
        {
            try
            {
                OpenConnection();

                Cmd = new SqlCommand("SELECT COUNT(*) FROM cliente WHERE usuariocliente = @v1", Con);

                Cmd.Parameters.AddWithValue("@v1", Login);

                int Qtd = Convert.ToInt32(Cmd.ExecuteScalar());

                if (Qtd > 0)
                    return true;
                else
                    return false;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao obter Login de Cliente: " + ex.Message);
            }
            finally
            {
                CloseConnection();
            }
        }


        public List<Cliente> ListarClientes()
        {
            try
            {
                OpenConnection();

                Cmd = new SqlCommand("SELECT * FROM Cliente", Con);

                Dr = Cmd.ExecuteReader();

                List<Cliente> Lista = new List<Cliente>();
                while (Dr.Read())
                {
                    Cliente cliente = new Cliente();

                    cliente.IdCliente = Convert.ToInt32(Dr["IdCliente"]);
                    cliente.Nome = Convert.ToString(Dr["Nome"]);
                    cliente.Sobrenome = Convert.ToString(Dr["Sobrenome"]);
                    cliente.DataNascimento = Convert.ToDateTime(Dr["DataNascimento"]);
                    cliente.Telefone = Convert.ToString(Dr["Telefone"]);
                    cliente.Celular = Convert.ToString(Dr["Celular"]);
                    cliente.Cep = Convert.ToString(Dr["Cep"]);
                    cliente.Rua = Convert.ToString(Dr["Rua"]);
                    cliente.NumeroCasa = Convert.ToString(Dr["NumeroCasa"]);
                    cliente.Complemento = Convert.ToString(Dr["Complemento"]);
                    cliente.Cidade = Convert.ToString(Dr["Cidade"]);
                    cliente.Estado = Convert.ToString(Dr["Estado"]);
                    cliente.Pais = Convert.ToString(Dr["Pais"]);
                    cliente.Cpf = Convert.ToString(Dr["Cpf"]);
                    cliente.Rg = Convert.ToString(Dr["Rg"]);
                    cliente.UsuarioCliente = Convert.ToString(Dr["UsuarioCliente"]);
                    cliente.SenhaCliente = Convert.ToString(Dr["SenhaCliente"]);

                    Lista.Add(cliente);
                }
                return Lista;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao listar todos os Clientes: " + ex.Message);
            }
            finally
            {
                CloseConnection();
            }
        }
    }
}
