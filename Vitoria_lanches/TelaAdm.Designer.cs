namespace Vitoria_lanches
{
    partial class TelaAdm
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
            menuStrip1 = new MenuStrip();
            homeToolStripMenuItem = new ToolStripMenuItem();
            gerenciarProdutoToolStripMenuItem = new ToolStripMenuItem();
            relatórioToolStripMenuItem = new ToolStripMenuItem();
            panelADM = new Panel();
            label1 = new Label();
            menuStrip1.SuspendLayout();
            panelADM.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { homeToolStripMenuItem, gerenciarProdutoToolStripMenuItem, relatórioToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // homeToolStripMenuItem
            // 
            homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            homeToolStripMenuItem.Size = new Size(52, 20);
            homeToolStripMenuItem.Text = "Home";
            homeToolStripMenuItem.Click += homeToolStripMenuItem_Click;
            // 
            // gerenciarProdutoToolStripMenuItem
            // 
            gerenciarProdutoToolStripMenuItem.Name = "gerenciarProdutoToolStripMenuItem";
            gerenciarProdutoToolStripMenuItem.Size = new Size(115, 20);
            gerenciarProdutoToolStripMenuItem.Text = "Gerenciar Produto";
            gerenciarProdutoToolStripMenuItem.Click += gerenciarProdutoToolStripMenuItem_Click;
            // 
            // relatórioToolStripMenuItem
            // 
            relatórioToolStripMenuItem.Name = "relatórioToolStripMenuItem";
            relatórioToolStripMenuItem.Size = new Size(66, 20);
            relatórioToolStripMenuItem.Text = "Relatório";
            // 
            // panelADM
            // 
            panelADM.Controls.Add(label1);
            panelADM.Dock = DockStyle.Fill;
            panelADM.Location = new Point(0, 24);
            panelADM.Name = "panelADM";
            panelADM.Size = new Size(800, 426);
            panelADM.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 32F);
            label1.Location = new Point(266, 68);
            label1.Name = "label1";
            label1.Size = new Size(246, 59);
            label1.TabIndex = 0;
            label1.Text = "Você é adm";
            // 
            // TelaAdm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panelADM);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "TelaAdm";
            Text = "GerenciadorProduto";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panelADM.ResumeLayout(false);
            panelADM.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem homeToolStripMenuItem;
        private ToolStripMenuItem gerenciarProdutoToolStripMenuItem;
        private ToolStripMenuItem relatórioToolStripMenuItem;
        private Panel panelADM;
        private Label label1;
    }
}