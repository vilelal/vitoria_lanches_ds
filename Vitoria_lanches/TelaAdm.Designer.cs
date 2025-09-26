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
            criarProdutoToolStripMenuItem = new ToolStripMenuItem();
            excluirProdutoToolStripMenuItem = new ToolStripMenuItem();
            editarProdutoToolStripMenuItem = new ToolStripMenuItem();
            produtosCadastradosToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
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
            gerenciarProdutoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { criarProdutoToolStripMenuItem, excluirProdutoToolStripMenuItem, editarProdutoToolStripMenuItem, produtosCadastradosToolStripMenuItem });
            gerenciarProdutoToolStripMenuItem.Name = "gerenciarProdutoToolStripMenuItem";
            gerenciarProdutoToolStripMenuItem.Size = new Size(120, 20);
            gerenciarProdutoToolStripMenuItem.Text = "Gerenciar Produtos";
            // 
            // relatórioToolStripMenuItem
            // 
            relatórioToolStripMenuItem.Name = "relatórioToolStripMenuItem";
            relatórioToolStripMenuItem.Size = new Size(66, 20);
            relatórioToolStripMenuItem.Text = "Relatório";
            // 
            // panelADM
            // 
            panelADM.Dock = DockStyle.Fill;
            panelADM.Location = new Point(0, 24);
            panelADM.Name = "panelADM";
            panelADM.Size = new Size(800, 426);
            panelADM.TabIndex = 1;
            // 
            // criarProdutoToolStripMenuItem
            // 
            criarProdutoToolStripMenuItem.Name = "criarProdutoToolStripMenuItem";
            criarProdutoToolStripMenuItem.Size = new Size(190, 22);
            criarProdutoToolStripMenuItem.Text = "Criar Produto";
            criarProdutoToolStripMenuItem.Click += criarProdutoToolStripMenuItem_Click;
            // 
            // excluirProdutoToolStripMenuItem
            // 
            excluirProdutoToolStripMenuItem.Name = "excluirProdutoToolStripMenuItem";
            excluirProdutoToolStripMenuItem.Size = new Size(190, 22);
            excluirProdutoToolStripMenuItem.Text = "Excluir Produto";
            // 
            // editarProdutoToolStripMenuItem
            // 
            editarProdutoToolStripMenuItem.Name = "editarProdutoToolStripMenuItem";
            editarProdutoToolStripMenuItem.Size = new Size(190, 22);
            editarProdutoToolStripMenuItem.Text = "Editar Produto";
            // 
            // produtosCadastradosToolStripMenuItem
            // 
            produtosCadastradosToolStripMenuItem.Name = "produtosCadastradosToolStripMenuItem";
            produtosCadastradosToolStripMenuItem.Size = new Size(190, 22);
            produtosCadastradosToolStripMenuItem.Text = "Produtos Cadastrados";
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
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem homeToolStripMenuItem;
        private ToolStripMenuItem gerenciarProdutoToolStripMenuItem;
        private ToolStripMenuItem relatórioToolStripMenuItem;
        private Panel panelADM;
        private ToolStripMenuItem criarProdutoToolStripMenuItem;
        private ToolStripMenuItem excluirProdutoToolStripMenuItem;
        private ToolStripMenuItem editarProdutoToolStripMenuItem;
        private ToolStripMenuItem produtosCadastradosToolStripMenuItem;
    }
}