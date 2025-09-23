using MySqlX.XDevAPI;

namespace Vitoria_lanches
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void InserirUser()
        {
            CadUsuario cadUser = new CadUsuario();
            cadUser.TopLevel = false;
            cadUser.FormBorderStyle = FormBorderStyle.None;
            cadUser.Dock = DockStyle.Fill;
            panel1.Controls.Clear();
            panel1.Controls.Add(cadUser);
            cadUser.Show();


        }

        private void LogarUsuario()
        {
            LogarUsuario logar = new LogarUsuario();
            logar.TopLevel = false;
            logar.FormBorderStyle = FormBorderStyle.None;
            logar.Dock = DockStyle.Fill;
            panel1.Controls.Clear();
            panel1.Controls.Add(logar);
            logar.Show();
        }

        private void cadastrarUsuárioToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            InserirUser();
        }

        private void entrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LogarUsuario();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
