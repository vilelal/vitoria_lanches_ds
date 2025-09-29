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

                if (conexao.DataSave.vId > 0)
                {
                    txtNomeProduto.Text = conexao.DataSave.vNome;
                    txtDescricaoProd.Text = conexao.DataSave.vDesc;
                    txtPrecoUnit.Text = conexao.DataSave.vPreco.ToString();
                }
                else
                {
                    idtemp = 1;
                    try
                    {
                        conexao.ExecutarUmaConsulta(idtemp);
                        txtNomeProduto.Text = conexao.DataSave.vNome;
                        txtDescricaoProd.Text = conexao.DataSave.vDesc;
                        txtPrecoUnit.Text = conexao.DataSave.vPreco.ToString();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Erro ao obter o ID da tarefa: {ex.Message}");
                    }


                    //MessageBox.Show("Nenhuma tarefa selecionada para edição.");
                }
            }
        }
        private void btAnter_Click(object sender, EventArgs e)
        {
            idtemp = conexao.DataSave.vId - 1; // Pega o ID da tarefa selecionada
            if (conexao.DataSave.vId > 1)
            {

                try
                {
                    txtNomeProduto.Text = conexao.DataSave.vNome;
                    txtDescricaoProd.Text = conexao.DataSave.vDesc;
                    txtPrecoUnit.Text = conexao.DataSave.vPreco.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao obter o ID da tarefa: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("Você já está na primeira tarefa.");
            }
        }



        private void btnProx_Click_1(object sender, EventArgs e)
        {
            int maximo = conexao.contarTarefas(); // Obtém o número total de tarefas
            idtemp = conexao.DataSave.vId + 1; // Pega o ID da tarefa selecionada

            if (idtemp > maximo)
            {
                MessageBox.Show("Você já está na última tarefa.");
                return;
            }
            else
            {
                try
                {
                    conexao.ExecutarUmaConsulta(idtemp);
                    txtNomeProduto.Text = conexao.DataSave.vNome;
                    txtDescricaoProd.Text = conexao.DataSave.vDesc;
                    txtPrecoUnit.Text = conexao.DataSave.vPreco.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao obter o ID da tarefa: {ex.Message}");
                }
            }
        }

        private void btAtu_Click(object sender, EventArgs e)
        {

            string tNome = txtNomeProduto.Text;
            string tDesc = txtDescricaoProd.Text;

            int tId = conexao.DataSave.vId; 

            string update = "UPDATE tb_produtos SET TB_PRODUTO_NOME = @Nome, TB_PRODUTO_DESC = @Desc,TB_TIPO_PRODUTO_ID = @idTipoProd  WHERE TB_PRODUTO_ID = @Id;";
            // preenche os parâmetros para enviar 
            update = update.Replace("@Nome", $"'{tNome}'")
                                    
                                 .Replace("@Desc", $"'{tDesc}'")
                                 .Replace("@tb", $"'{tDesc}'")
                                 .Replace("@Id", tId.ToString());
            try
            {
                conexao.ExecutarComando(tualizala); // Executa o comando de atualização no banco de dados
                MessageBox.Show("Tarefa atualizada com sucesso!");
                this.Close(); // Fecha o formulário após a atualização da tarefa
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao atualizar a tarefa: {ex.Message}");

            }
        }


    }
}
    

