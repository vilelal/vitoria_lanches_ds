namespace Vitoria_lanches
{
    partial class EditarProd
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
            label6 = new Label();
            cbProdutos = new ComboBox();
            cbTipoProd = new ComboBox();
            btnAttProduto = new Button();
            label4 = new Label();
            label3 = new Label();
            label5 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtPrecoUnit = new TextBox();
            txtDescricaoProd = new TextBox();
            txtNomeProduto = new TextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label6);
            panel1.Controls.Add(cbProdutos);
            panel1.Controls.Add(cbTipoProd);
            panel1.Controls.Add(btnAttProduto);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txtPrecoUnit);
            panel1.Controls.Add(txtDescricaoProd);
            panel1.Controls.Add(txtNomeProduto);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 450);
            panel1.TabIndex = 0;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(116, 126);
            label6.Name = "label6";
            label6.Size = new Size(183, 15);
            label6.TabIndex = 11;
            label6.Text = "Selecione um produto para editar";
            // 
            // cbProdutos
            // 
            cbProdutos.FormattingEnabled = true;
            cbProdutos.Location = new Point(116, 144);
            cbProdutos.Name = "cbProdutos";
            cbProdutos.Size = new Size(121, 23);
            cbProdutos.TabIndex = 10;
            cbProdutos.SelectedIndexChanged += cbProdutos_SelectedIndexChanged;
            // 
            // cbTipoProd
            // 
            cbTipoProd.FormattingEnabled = true;
            cbTipoProd.Location = new Point(589, 130);
            cbTipoProd.Name = "cbTipoProd";
            cbTipoProd.Size = new Size(121, 23);
            cbTipoProd.TabIndex = 8;
            // 
            // btnAttProduto
            // 
            btnAttProduto.Location = new Point(416, 318);
            btnAttProduto.Name = "btnAttProduto";
            btnAttProduto.Size = new Size(121, 23);
            btnAttProduto.TabIndex = 7;
            btnAttProduto.Text = "Atualizar Produto";
            btnAttProduto.UseVisualStyleBackColor = true;
            btnAttProduto.Click += btnAttProduto_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(400, 241);
            label4.Name = "label4";
            label4.Size = new Size(37, 15);
            label4.TabIndex = 6;
            label4.Text = "Preço";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(400, 178);
            label3.Name = "label3";
            label3.Size = new Size(121, 15);
            label3.TabIndex = 5;
            label3.Text = "Descrição do produto";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(589, 112);
            label5.Name = "label5";
            label5.Size = new Size(94, 15);
            label5.TabIndex = 4;
            label5.Text = "Tipo do Produto";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(400, 112);
            label2.Name = "label2";
            label2.Size = new Size(106, 15);
            label2.TabIndex = 4;
            label2.Text = "Nome do produto:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F);
            label1.Location = new Point(287, 24);
            label1.Name = "label1";
            label1.Size = new Size(225, 45);
            label1.TabIndex = 3;
            label1.Text = "Editar Produto";
            // 
            // txtPrecoUnit
            // 
            txtPrecoUnit.Location = new Point(400, 259);
            txtPrecoUnit.Name = "txtPrecoUnit";
            txtPrecoUnit.Size = new Size(156, 23);
            txtPrecoUnit.TabIndex = 2;
            // 
            // txtDescricaoProd
            // 
            txtDescricaoProd.Location = new Point(400, 196);
            txtDescricaoProd.Name = "txtDescricaoProd";
            txtDescricaoProd.Size = new Size(156, 23);
            txtDescricaoProd.TabIndex = 1;
            // 
            // txtNomeProduto
            // 
            txtNomeProduto.Location = new Point(400, 130);
            txtNomeProduto.Name = "txtNomeProduto";
            txtNomeProduto.Size = new Size(156, 23);
            txtNomeProduto.TabIndex = 0;
            // 
            // EditarProd
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Name = "EditarProd";
            Text = "EditarProd";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnAttProduto;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtPrecoUnit;
        private TextBox txtDescricaoProd;
        private TextBox txtNomeProduto;
        private ComboBox cbTipoProd;
        private Label label5;
        private Label label6;
        private ComboBox cbProdutos;
    }
}