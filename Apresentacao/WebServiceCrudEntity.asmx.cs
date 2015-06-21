using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using ClasseAcessaDados;
using Negocio;
using System.Web.Script.Serialization;

namespace Apresentacao
{
    /// <summary>
    /// Summary description for WebServiceCrudEntity
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebServiceCrudEntity : System.Web.Services.WebService
    {

        [WebMethod]
        public string ConsultaPessoas()
        {
                try
                {
                    InteracaoBancoDados consulta = new InteracaoBancoDados();
                    JavaScriptSerializer jsSerializer = new JavaScriptSerializer();
                    
                    string json = string.Empty;
                    var novaConsulta = consulta.Listar();
                    json = jsSerializer.Serialize(novaConsulta);
                  
                    return json;
                }
                catch (Exception ex)
                {
                    throw new Exception("Erro ao tentar consultar tabela. Mais informações: " + ex.Message);
                }
        }
    }
}
