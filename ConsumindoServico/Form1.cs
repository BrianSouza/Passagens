using ConsumindoServico.ClienteServiceReference;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsumindoServico
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;
            ClienteServiceClient servico = new ClienteServiceClient();
            Cliente clienteBusca = servico.Buscar(nome);
            txtCPF.Text = clienteBusca.Cpf;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;
            string cpf = txtCPF.Text;

            ClienteServiceClient servico = new ClienteServiceClient();
            Cliente cliente = new Cliente
            {
                Nome = nome,
                Cpf = cpf
            };

            servico.Add(cliente);

            MessageBox.Show("Cliente Cadastrado");
            MessageBox.Show("Cliente Cadastrado");
        }
    }
}
