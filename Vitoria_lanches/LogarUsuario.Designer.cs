namespace Vitoria_lanches
{
    partial class LogarUsuario
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
            panel1 = new Panel();
            txtVerifUsername = new TextBox();
            txtVerifPassword = new TextBox();
            btnLogar = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnLogar);
            panel1.Controls.Add(txtVerifPassword);
            panel1.Controls.Add(txtVerifUsername);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 450);
            panel1.TabIndex = 0;
            // 
            // txtVerifUsername
            // 
            txtVerifUsername.Location = new Point(344, 101);
            txtVerifUsername.Name = "txtVerifUsername";
            txtVerifUsername.Size = new Size(100, 23);
            txtVerifUsername.TabIndex = 0;
            // 
            // txtVerifPassword
            // 
            txtVerifPassword.Location = new Point(344, 222);
            txtVerifPassword.Name = "txtVerifPassword";
            txtVerifPassword.Size = new Size(100, 23);
            txtVerifPassword.TabIndex = 1;
            // 
            // btnLogar
            // 
            btnLogar.Location = new Point(353, 337);
            btnLogar.Name = "btnLogar";
            btnLogar.Size = new Size(75, 23);
            btnLogar.TabIndex = 2;
            btnLogar.Text = "button1";
            btnLogar.UseVisualStyleBackColor = true;
            btnLogar.Click += btnLogar_Click;
            // 
            // LogarUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Name = "LogarUsuario";
            Text = "LogarUsuario";
            Load += LogarUsuario_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnLogar;
        private TextBox txtVerifPassword;
        private TextBox txtVerifUsername;
    }
}