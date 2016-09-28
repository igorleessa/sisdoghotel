using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.Script.Serialization;
using Newtonsoft.Json;
using SisDogHotelBackEnd.Persistence;
using System.Web.Script.Services;

namespace SisDogHotelBackEnd
{
    /// <summary>
    /// Summary description for WebService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService : System.Web.Services.WebService
    {
        //********************************Cliente**********************************
        #region Cliente
        [WebMethod]
        [ScriptMethod(UseHttpGet = true, ResponseFormat = ResponseFormat.Json)]
        public void ListarTodosClientes(string JsonChamada)
        {
            try
            {
                JavaScriptSerializer js = new JavaScriptSerializer();
                Context.Response.Clear();
                Context.Response.ContentType = "application/json";

                ClienteDAL Cliente = new ClienteDAL();
                var Retorno = Cliente.ListarClientes();
                Context.Response.Write(js.Serialize(Retorno));
            }
            catch (Exception)
            {
                throw;
            }
        }
        #endregion

        //********************************Funcionarios**********************************
        #region Funcionario
        [WebMethod]
        [ScriptMethod(UseHttpGet = true, ResponseFormat = ResponseFormat.Json)]
        public void ListarTodosFuncionarios(string JsonChamada)
        {
            try
            {
                JavaScriptSerializer js = new JavaScriptSerializer();
                Context.Response.Clear();
                Context.Response.ContentType = "application/json";

                FuncionarioDAL Funcionario = new FuncionarioDAL();
                var Retorno = Funcionario.ListarFuncionarios();
                Context.Response.Write(js.Serialize(Retorno));
            }
            catch (Exception)
            {
                throw;
            }
        }
        #endregion


    }
}
