using Passagens.Contratos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Threading.Tasks;

namespace Passagens.Services.Interfaces
{
    [ServiceContract]
    public interface IClienteService
    {
        [OperationContract]
        void Add(Cliente c);
        [OperationContract]
        [WebInvoke(Method ="GET",ResponseFormat = WebMessageFormat.Json,UriTemplate ="Buscar/{nome}" )]
        Cliente Buscar(string nome);
        [OperationContract]
        [WebInvoke(Method = "GET", ResponseFormat = WebMessageFormat.Json, UriTemplate = "Add/{nome};{cpf}")]
        bool AddWeb(string nome, string cpf);
        [OperationContract]
        [WebInvoke(Method ="GET",ResponseFormat =WebMessageFormat.Json,UriTemplate ="listarTodo/")]
        List<Cliente> ListarTodos();
    }
}
