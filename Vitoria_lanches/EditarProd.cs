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
        int idtemp = 1;
        private string string_conn = "server=127.0.0.1;database=bd_vitoria_lanches;user=root;password=root;";


        public EditarProd()
        {
            InitializeComponent();
        }

        private void EditarProd_Load(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(string_conn))
            {
                conn.Open();

                if (conexao.DataSave.vID > 0)
                {
                    // Preenche os campos com os dados da tarefa selecionada
                    txtNomeProduto.Text = conexao.DadosGlobais.vNome;
                    txtDescricaoProd.Text = Conexao.DadosGlobais.vDesc;
                    dateTimePickerData.Value = Conexao.DadosGlobais.vData;
                    cbStatus.SelectedItem = Conexao.DadosGlobais.vStatus;
                }
                else
                {
                    idtemp = 1;
                    try
                    {
                        conexao.ExecutarUmaConsulta(idtemp);
                        tbNome.Text = Conexao.DadosGlobais.vNome;
                        tbDesc.Text = Conexao.DadosGlobais.vDesc;
                        dateTimePickerData.Value = Conexao.DadosGlobais.vData;
                        cbStatus.SelectedItem = Conexao.DadosGlobais.vStatus;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Erro ao obter o ID da tarefa: {ex.Message}");
                    }


                    //MessageBox.Show("Nenhuma tarefa selecionada para edição.");
                }

            }
        }
    }
}
