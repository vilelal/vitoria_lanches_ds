using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Vitoria_lanches
{
    public partial class GerenciadorProduto : Form
    {
        private string string_conn = "server=127.0.0.1;database=bd_vitoria_lanches;user=root;password=root;";

        public GerenciadorProduto()
        {
            InitializeComponent();
        }

        private void btnCadastrarProd_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(string_conn))
            {
                conn.Open();

                
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void GerenciadorProduto_Load(object sender, EventArgs e)
        {
            string nomeProd;
            string descricaoProd;
            int TipoProd;
            decimal preco;
        }
    }
}
