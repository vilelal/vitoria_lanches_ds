using System;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Vitoria_lanches
{
    public partial class LogarUsuario : Form
    {
        private string string_conn = "server=127.0.0.1;database=bd_vitoria_lanches;user=root;password=Pe20082001.;";

        public LogarUsuario()
        {
            InitializeComponent();
        }

        private void btnLogar_Click(object sender, EventArgs e)
        {

            using (MySqlConnection conn = new MySqlConnection(string_conn))
            {
                try
                {
                    conn.Open();

                    string sqlQuery = "SELECT * FROM tb_usuarios WHERE TB_USUARIOS_USERNAME = @username AND TB_USUARIOS_PASSWORD = @password";

                    MySqlCommand cmd = new MySqlCommand(sqlQuery, conn);
                    cmd.Parameters.AddWithValue("@username", txtVerifUsername.Text);

                    cmd.Parameters.AddWithValue("@password", txtVerifPassword.Text);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string tipoUsuario = reader["TB_USUARIOS_TIPO"].ToString();

                            if (tipoUsuario.Equals("adm", StringComparison.OrdinalIgnoreCase))
                            {
                                TelaAdm gerenciar = new TelaAdm();
                                gerenciar.TopLevel = false;
                                gerenciar.FormBorderStyle = FormBorderStyle.None;
                                gerenciar.Dock = DockStyle.Fill;
                                panel1.Controls.Clear();
                                panel1.Controls.Add(gerenciar);
                                gerenciar.Show();
                            }
                            else if (tipoUsuario.Equals("cliente", StringComparison.OrdinalIgnoreCase))
                            {
                                Home voltar = new Home();
                                voltar.TopLevel = false;
                                voltar.FormBorderStyle = FormBorderStyle.None;
                                voltar.Dock = DockStyle.Fill;
                                panel1.Controls.Clear();
                                panel1.Controls.Add(voltar);
                                voltar.Show();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Usuário ou senha incorretos.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ocorreu um erro: {ex.Message}");
                }
            }
        }


        private void LogarUsuario_Load(object sender, EventArgs e)
        {
            string username;
            string password;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}