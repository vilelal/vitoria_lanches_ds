namespace Vitoria_lanches
{
    partial class CadUsuario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnCadastrarUser = new Button();
            label1 = new Label();
            txtUsername = new TextBox();
            txtPassWord = new TextBox();
            panelCadUser = new Panel();
            panelCadUser.SuspendLayout();
            SuspendLayout();
            // 
            // btnCadastrarUser
            // 
            btnCadastrarUser.Location = new Point(345, 309);
            btnCadastrarUser.Name = "btnCadastrarUser";
            btnCadastrarUser.Size = new Size(75, 23);
            btnCadastrarUser.TabIndex = 0;
            btnCadastrarUser.Text = "button1";
            btnCadastrarUser.UseVisualStyleBackColor = true;
            btnCadastrarUser.Click += btnCadastrarUser_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 32F);
            label1.Location = new Point(224, 38);
            label1.Name = "label1";
            label1.Size = new Size(331, 59);
            label1.TabIndex = 1;
            label1.Text = "Cadastrar Conta";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(332, 161);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(100, 23);
            txtUsername.TabIndex = 2;
            // 
            // txtPassWord
            // 
            txtPassWord.Location = new Point(332, 248);
            txtPassWord.Name = "txtPassWord";
            txtPassWord.Size = new Size(100, 23);
            txtPassWord.TabIndex = 3;
            // 
            // panelCadUser
            // 
            panelCadUser.Controls.Add(txtUsername);
            panelCadUser.Controls.Add(txtPassWord);
            panelCadUser.Controls.Add(btnCadastrarUser);
            panelCadUser.Controls.Add(label1);
            panelCadUser.Dock = DockStyle.Fill;
            panelCadUser.Location = new Point(0, 0);
            panelCadUser.Name = "panelCadUser";
            panelCadUser.Size = new Size(800, 450);
            panelCadUser.TabIndex = 4;
            // 
            // CadUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panelCadUser);
            Name = "CadUsuario";
            Text = "CadUsuario";
            Load += CadUsuario_Load;
            panelCadUser.ResumeLayout(false);
            panelCadUser.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnCadastrarUser;
        private Label label1;
        private TextBox txtUsername;
        private TextBox txtPassWord;
        private Panel panelCadUser;
    }
}