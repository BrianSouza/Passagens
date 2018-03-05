using Passagens.Contratos;
using Passagens.DAO;
using Passagens.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Passagens.Services
{
    public class ClienteService : IClienteService
    {
        public void Add(Cliente c)
        {
            ClienteDao dao = new ClienteDao();
            dao.Add(c);
        }

        public bool AddWeb(string nome, string cpf)
        {
            ClienteDao dao = new ClienteDao();
            return dao.Add(nome, cpf);
        }

        public Cliente Buscar(string nome)
        {
            ClienteDao dao = new ClienteDao();
            return dao.Buscar(nome);
        }

        public List<Cliente> ListarTodos()
        {
            return ClienteDao.lstCLientes;
        }
    }
}
