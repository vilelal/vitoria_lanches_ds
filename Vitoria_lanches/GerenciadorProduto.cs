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
        private string string_conn = "server=127.0.0.1;database=bd_vitoria_lanches;user=root;password=Pe20082001.;";

        public GerenciadorProduto()
        {
            InitializeComponent();
            tipoProdutos();
        }

        public string nomeProd { get; set; }
        public string descricaoProd { get; set; }
        public int TipoProd { get; set; }
        public decimal preco { get; set; }


        private void tipoProdutos()
        {
            using (MySqlConnection conn = new MySqlConnection(string_conn))
            {
                conn.Open();

                string sqlQuery = "SELECT TB_TIPO_PRODUTO_ID, TB_TIPO_PRODUTO_DESC FROM tb_tipo_produto";

                MySqlDataAdapter data = new MySqlDataAdapter(sqlQuery, conn);
                DataTable dt = new DataTable();
                data.Fill(dt);
                cbTipoProd.ValueMember = "TB_TIPO_PRODUTO_ID";
                cbTipoProd.DisplayMember = "TB_TIPO_PRODUTO_DESC";
                cbTipoProd.DataSource = dt;

                conn.Close();

            }
        }

        public bool addProduto()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(string_conn))
                {
                    conn.Open();
                    string AddProd = "INSERT INTO tb_produto (TB_PRODUTO_NOME,TB_PRODUTO_DESC,TB_TIPO_PRODUTO_ID,TB_PRODUTO_PRECO_UNIT)"
                        + " Values (@nome,@desc,@tipo,@preco)";
                    MySqlCommand stmt = new MySqlCommand(AddProd, conn);
                    stmt.Parameters.AddWithValue("@nome", nomeProd);
                    stmt.Parameters.AddWithValue("@desc", descricaoProd);
                    stmt.Parameters.AddWithValue("@tipo", TipoProd);
                    stmt.Parameters.AddWithValue("@preco", preco);
                    stmt.ExecuteNonQuery();
                    MessageBox.Show("Produto cadastrado com sucesso!");
                    conn.Close();
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao cadastrar produto {ex.Message}");
                return false;
            }
        }




        private void cbTipoProd_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnCadastrarProd_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtNomeProd.Text) && !string.IsNullOrWhiteSpace(txtDescricaoProd.Text) && !string.IsNullOrWhiteSpace(txtPrecoProd.Text))
            {
                nomeProd = txtNomeProd.Text;
                descricaoProd = txtDescricaoProd.Text;

                if (!decimal.TryParse(txtPrecoProd.Text, out decimal precoParsed))
                {
                    MessageBox.Show("Por favor, insira um valor numérico.");
                    return;
                }
                preco = precoParsed;

                if (cbTipoProd.SelectedValue != null)
                {
                    int IDTipoProd;

                    if (!int.TryParse(cbTipoProd.SelectedValue.ToString(), out IDTipoProd))
                    {

                        if (cbTipoProd.SelectedItem is DataRowView selectedRow)
                        {
                            IDTipoProd = Convert.ToInt32(selectedRow["TB_TIPO_PRODUTO_ID"]);

                        }
                        else
                        {
                            MessageBox.Show("Por favor, selecione um tipo válido.");
                            return;
                        }


                        TipoProd = IDTipoProd;

                    }

                }
                else
                {
                    MessageBox.Show("Por favor, selecione um tipo válido.");
                    return;
                }

                if (addProduto())
                {
                    MessageBox.Show("Produto Adicionado com sucesso");
                    txtNomeProd.Clear();
                    txtDescricaoProd.Clear();
                    txtPrecoProd.Clear();
                    cbTipoProd.SelectedIndex = -1;
                }
                else
                {
                    MessageBox.Show("Falha ao adicionar produto.");
                }

            }
            else
            {
                MessageBox.Show("Preencha todos os campos!");
            }
        }




    }
}
