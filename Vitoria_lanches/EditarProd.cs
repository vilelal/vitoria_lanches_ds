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
    public partial class EditarProd : Form
    {
        private string string_conn = "server=127.0.0.1;database=bd_vitoria_lanches;user=root;password=root;";


        public EditarProd()
        {
            InitializeComponent();
            mostrarProd();
            tipoProdutos();
        }

        private void tipoProdutos()
        {
            using (MySqlConnection conn = new MySqlConnection(string_conn))
            {
                conn.Open();

                string sqlQuery = "SELECT TB_TIPO_PRODUTO_ID, TB_TIPO_PRODUTO_DESC FROM tb_tipo_produto";

                MySqlDataAdapter data = new MySqlDataAdapter(sqlQuery, conn);
                DataTable dt = new DataTable();
                data.Fill(dt);
                
                cbTipoProd.DataSource = dt;
                cbTipoProd.ValueMember = "TB_TIPO_PRODUTO_ID";
                cbTipoProd.DisplayMember = "TB_TIPO_PRODUTO_DESC";
                cbTipoProd.SelectedIndex = -1;

                conn.Close();

            }
        }

        private void mostrarProd()
        {


            using (MySqlConnection conn = new MySqlConnection(string_conn))
            {
                conn.Open();
                string query = "SELECT TB_PRODUTO_ID, TB_PRODUTO_NOME FROM tb_produto";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataAdapter adptar = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adptar.Fill(dt);
                cbProdutos.SelectedIndexChanged -= cbProdutos_SelectedIndexChanged;
                cbProdutos.DataSource = dt;
                cbProdutos.DisplayMember = "TB_PRODUTO_NOME";
                cbProdutos.ValueMember = "TB_PRODUTO_ID";
                cbProdutos.SelectedIndex = -1;
                cbProdutos.SelectedIndexChanged += cbProdutos_SelectedIndexChanged;


            }
            
        }

        private void cbProdutos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbProdutos.SelectedIndex == 0 || cbProdutos.SelectedValue == null)
                return;
            int Idlocal = Convert.ToInt32(cbProdutos.SelectedValue);

            using (MySqlConnection conn = new MySqlConnection(string_conn))
            {
                conn.Open();

                string query = $"SELECT * FROM tb_produto WHERE TB_PRODUTO_ID = @ID";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@ID", Idlocal); 
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            txtNomeProduto.Text = reader["TB_PRODUTO_NOME"].ToString();
                            txtDescricaoProd.Text = reader["TB_PRODUTO_DESC"].ToString();
                            decimal preco_prod = Convert.ToDecimal(reader["TB_PRODUTO_PRECO_UNIT"]);
                            txtPrecoUnit.Text = preco_prod.ToString("0.00");
                            
                            cbTipoProd.SelectedValue = Convert.ToInt32(reader["TB_TIPO_PRODUTO_ID"].ToString());
                        }
                    }
                }


            }
        }


        public string nomeProd { get; set; }
        public string descricaoProd { get; set; }
        public int TipoProd { get; set; }
        public decimal preco { get; set; }

        public bool EditProd(int id)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(string_conn))
                {
                    conn.Open();
                    string sql = "UPDATE tb_produto SET TB_PRODUTO_NOME = @nome, TB_PRODUTO_DESC = @desc, TB_TIPO_PRODUTO_ID = @tipo, TB_PRODUTO_PRECO_UNIT = @preco WHERE TB_PRODUTO_ID = @id";
                    using (MySqlCommand stmt = new MySqlCommand(sql, conn))
                    {
                        stmt.Parameters.AddWithValue("@nome", nomeProd);
                        stmt.Parameters.AddWithValue("@desc", descricaoProd);
                        stmt.Parameters.AddWithValue("@tipo", TipoProd);
                        stmt.Parameters.AddWithValue("@preco", preco);
                        stmt.Parameters.AddWithValue("@id", id);
                        stmt.ExecuteNonQuery();
                    }
                        MessageBox.Show("Produto editado com sucesso!");
                        conn.Close();
                        return true;
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao editar produto {ex.Message}");
                return false;
            }
        }

        private void btnAttProduto_Click(object sender, EventArgs e)
        {
            nomeProd = txtNomeProduto.Text;
            descricaoProd = txtDescricaoProd.Text;
            if (!decimal.TryParse(txtPrecoUnit.Text, out decimal precoParsed))
            {
                MessageBox.Show("Por favor, insira um valor numérico.");
                return;
            }
            preco = precoParsed;
            TipoProd = Convert.ToInt32(cbTipoProd.SelectedValue);
         
            int id = Convert.ToInt32(cbProdutos.SelectedValue);
            if (EditProd(id))
            {
                mostrarProd();
                MessageBox.Show("Produto atualizado com sucesso!");
            }
            
        }
    }
}
    

