using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vitoria_lanches
{
    public partial class TelaAdm : Form
    {
        public TelaAdm()
        {
            InitializeComponent();
            TelaInicial();
        }

        private void criarProd()
        {
            GerenciadorProduto gerenciarProd = new GerenciadorProduto();
            gerenciarProd.TopLevel = false;
            gerenciarProd.FormBorderStyle = FormBorderStyle.None;
            gerenciarProd.Dock = DockStyle.Fill;
            panelADM.Controls.Clear();
            panelADM.Controls.Add(gerenciarProd);
            gerenciarProd.Show();
        }

        private void TelaInicial()
        {
            boasvindas Boasvindas = new boasvindas();
            Boasvindas.TopLevel = false;
            Boasvindas.FormBorderStyle = FormBorderStyle.None;
            Boasvindas.Dock = DockStyle.Fill;
            panelADM.Controls.Clear();
            panelADM.Controls.Add(Boasvindas);
            Boasvindas.Show();
        }

        private void EditarProd()
        {
            EditarProd EditProd = new EditarProd();
            EditProd.TopLevel = false;
            EditProd.FormBorderStyle = FormBorderStyle.None;
            EditProd.Dock = DockStyle.Fill;
            panelADM.Controls.Clear();
            panelADM.Controls.Add(EditProd);
            EditProd.Show();
        }

        private void gerenciarProdutoToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }
        //Criar um form para ficar aparecendo como tela de boas vindas
        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TelaInicial();
        }

        private void criarProdutoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            criarProd();
        }

        private void editarProdutoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditarProd();
        }
    }
}
