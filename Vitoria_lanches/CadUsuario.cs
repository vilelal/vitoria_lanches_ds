using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Vitoria_lanches
{
    public partial class CadUsuario : Form
    {
        private string string_conn = "server=127.0.0.1;database=bd_vitoria_lanches;user=root;password=root;";
        public CadUsuario()
        {
            InitializeComponent();
        }

        private void CadUsuario_Load(object sender, EventArgs e)
        {
            string username;
            string password;
        }

        private void btnCadastrarUser_Click(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(string_conn))
                {
                    conn.Open();

                    string AddUser = "INSERT INTO tb_usuarios (TB_USUARIOS_USERNAME,TB_USUARIOS_PASSWORD,TB_USUARIOS_TIPO)"
                        + " Values (@username,@password,'cliente')";
                    MySqlCommand stmt = new MySqlCommand(AddUser, conn);

                    stmt.Parameters.AddWithValue("@username", txtUsername.Text);
                    stmt.Parameters.AddWithValue("@password", txtPassWord.Text);
                    stmt.ExecuteNonQuery();

                    MessageBox.Show("Cadastro concluído com sucesso!");
                    conn.Close();

                   



                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao se cadastrar {ex.Message}");
            }
        }
    }
}
