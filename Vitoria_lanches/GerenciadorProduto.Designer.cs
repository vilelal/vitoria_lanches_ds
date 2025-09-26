namespace Vitoria_lanches
{
    partial class GerenciadorProduto
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
            btnCadastrarProd = new Button();
            cbTipoProd = new ComboBox();
            label5 = new Label();
            label3 = new Label();
            label6 = new Label();
            label2 = new Label();
            txtDescricaoProd = new TextBox();
            txtPrecoProd = new TextBox();
            txtNomeProd = new TextBox();
            label1 = new Label();
            btnAddTipoProd = new Button();
            label4 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label4);
            panel1.Controls.Add(btnAddTipoProd);
            panel1.Controls.Add(btnCadastrarProd);
            panel1.Controls.Add(cbTipoProd);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtDescricaoProd);
            panel1.Controls.Add(txtPrecoProd);
            panel1.Controls.Add(txtNomeProd);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 450);
            panel1.TabIndex = 0;
            // 
            // btnCadastrarProd
            // 
            btnCadastrarProd.Location = new Point(365, 344);
            btnCadastrarProd.Name = "btnCadastrarProd";
            btnCadastrarProd.Size = new Size(75, 23);
            btnCadastrarProd.TabIndex = 6;
            btnCadastrarProd.Text = "Cadastrar";
            btnCadastrarProd.UseVisualStyleBackColor = true;
            btnCadastrarProd.Click += btnCadastrarProd_Click;
            // 
            // cbTipoProd
            // 
            cbTipoProd.FormattingEnabled = true;
            cbTipoProd.Location = new Point(458, 153);
            cbTipoProd.Name = "cbTipoProd";
            cbTipoProd.Size = new Size(121, 23);
            cbTipoProd.TabIndex = 5;
            cbTipoProd.SelectedIndexChanged += cbTipoProd_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(172, 135);
            label5.Name = "label5";
            label5.Size = new Size(106, 15);
            label5.TabIndex = 4;
            label5.Text = "Nome do produto:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(172, 189);
            label3.Name = "label3";
            label3.Size = new Size(61, 15);
            label3.TabIndex = 4;
            label3.Text = "Descrição:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(458, 135);
            label6.Name = "label6";
            label6.Size = new Size(97, 15);
            label6.TabIndex = 4;
            label6.Text = "Tipo do produto:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(171, 269);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 4;
            label2.Text = "Preço:";
            // 
            // txtDescricaoProd
            // 
            txtDescricaoProd.Location = new Point(172, 207);
            txtDescricaoProd.Multiline = true;
            txtDescricaoProd.Name = "txtDescricaoProd";
            txtDescricaoProd.Size = new Size(147, 59);
            txtDescricaoProd.TabIndex = 3;
            // 
            // txtPrecoProd
            // 
            txtPrecoProd.Location = new Point(171, 287);
            txtPrecoProd.Name = "txtPrecoProd";
            txtPrecoProd.Size = new Size(147, 23);
            txtPrecoProd.TabIndex = 2;
            // 
            // txtNomeProd
            // 
            txtNomeProd.Location = new Point(172, 150);
            txtNomeProd.Name = "txtNomeProd";
            txtNomeProd.Size = new Size(147, 23);
            txtNomeProd.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F);
            label1.Location = new Point(299, 33);
            label1.Name = "label1";
            label1.Size = new Size(189, 30);
            label1.TabIndex = 0;
            label1.Text = "Adicionar produto";
            // 
            // btnAddTipoProd
            // 
            btnAddTipoProd.Location = new Point(456, 206);
            btnAddTipoProd.Name = "btnAddTipoProd";
            btnAddTipoProd.Size = new Size(123, 34);
            btnAddTipoProd.TabIndex = 7;
            btnAddTipoProd.Text = "Adicionar";
            btnAddTipoProd.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(458, 189);
            label4.Name = "label4";
            label4.Size = new Size(144, 15);
            label4.TabIndex = 8;
            label4.Text = "Adicionar tipo de produto";
            // 
            // GerenciadorProduto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Name = "GerenciadorProduto";
            Text = "GerenciadorProduto";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private TextBox txtPrecoProd;
        private TextBox txtNomeProd;
        private Label label2;
        private TextBox txtDescricaoProd;
        private Label label3;
        private Label label5;
        private Label label6;
        private ComboBox cbTipoProd;
        private Button btnCadastrarProd;
        private Label label4;
        private Button btnAddTipoProd;
    }
}