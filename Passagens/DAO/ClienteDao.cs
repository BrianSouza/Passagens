using Passagens.Contratos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Passagens.DAO
{
    public class ClienteDao
    {
        public static List<Cliente> lstCLientes = new List<Cliente>();
        public void Add(Cliente c)
        {
            ClienteDao.lstCLientes.Add(c);
        }
        public bool Add(string nome,string cpf)
        {
            Cliente cliente = new Cliente
            {
                Nome = nome,
                Cpf = cpf
            };

            lstCLientes.Add(cliente);

            return true;
        }
        public Cliente Buscar(string nome)
        {
            var resultado = ClienteDao.lstCLientes.Where(c => c.Nome.Equals(nome)).FirstOrDefault();
            return (Cliente)resultado;
        }
    }
}
