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
        }

        private void gerenciarProd()
        {
            GerenciadorProduto gerenciarProd = new GerenciadorProduto();
            gerenciarProd.TopLevel = false;
            gerenciarProd.FormBorderStyle = FormBorderStyle.None;
            gerenciarProd.Dock = DockStyle.Fill;
            panelADM.Controls.Clear();
            panelADM.Controls.Add(gerenciarProd);
            gerenciarProd.Show();
        }

        private void gerenciarProdutoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gerenciarProd();
        }
        //Criar um form para ficar aparecendo como tela de boas vindas
        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
