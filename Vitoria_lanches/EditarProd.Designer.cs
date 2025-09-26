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
            btnProx = new Button();
            BtnAnterior = new Button();
            textBox4 = new TextBox();
            comboBox1 = new ComboBox();
            btnAttProduto = new Button();
            label4 = new Label();
            label3 = new Label();
            label5 = new Label();
            label2 = new Label();
            label1 = new Label();
            textBox3 = new TextBox();
            txtDescricaoProd = new TextBox();
            txtNomeProduto = new TextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnProx);
            panel1.Controls.Add(BtnAnterior);
            panel1.Controls.Add(textBox4);
            panel1.Controls.Add(comboBox1);
            panel1.Controls.Add(btnAttProduto);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(textBox3);
            panel1.Controls.Add(txtDescricaoProd);
            panel1.Controls.Add(txtNomeProduto);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 450);
            panel1.TabIndex = 0;
            // 
            // btnProx
            // 
            btnProx.Location = new Point(217, 330);
            btnProx.Name = "btnProx";
            btnProx.Size = new Size(75, 23);
            btnProx.TabIndex = 11;
            btnProx.Text = "Próximo";
            btnProx.UseVisualStyleBackColor = true;
            // 
            // BtnAnterior
            // 
            BtnAnterior.Location = new Point(101, 330);
            BtnAnterior.Name = "BtnAnterior";
            BtnAnterior.Size = new Size(75, 23);
            BtnAnterior.TabIndex = 10;
            BtnAnterior.Text = "Anterior";
            BtnAnterior.UseVisualStyleBackColor = true;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(558, 105);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(230, 251);
            textBox4.TabIndex = 9;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(395, 119);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 8;
            // 
            // btnAttProduto
            // 
            btnAttProduto.Location = new Point(302, 368);
            btnAttProduto.Name = "btnAttProduto";
            btnAttProduto.Size = new Size(121, 23);
            btnAttProduto.TabIndex = 7;
            btnAttProduto.Text = "Atualizar Produto";
            btnAttProduto.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(101, 230);
            label4.Name = "label4";
            label4.Size = new Size(37, 15);
            label4.TabIndex = 6;
            label4.Text = "Preço";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(101, 167);
            label3.Name = "label3";
            label3.Size = new Size(121, 15);
            label3.TabIndex = 5;
            label3.Text = "Descrição do produto";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(395, 101);
            label5.Name = "label5";
            label5.Size = new Size(94, 15);
            label5.TabIndex = 4;
            label5.Text = "Tipo do Produto";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(101, 101);
            label2.Name = "label2";
            label2.Size = new Size(106, 15);
            label2.TabIndex = 4;
            label2.Text = "Nome do produto:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F);
            label1.Location = new Point(276, 25);
            label1.Name = "label1";
            label1.Size = new Size(225, 45);
            label1.TabIndex = 3;
            label1.Text = "Editar Produto";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(101, 248);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(156, 23);
            textBox3.TabIndex = 2;
            // 
            // txtDescricaoProd
            // 
            txtDescricaoProd.Location = new Point(101, 185);
            txtDescricaoProd.Name = "txtDescricaoProd";
            txtDescricaoProd.Size = new Size(156, 23);
            txtDescricaoProd.TabIndex = 1;
            // 
            // txtNomeProduto
            // 
            txtNomeProduto.Location = new Point(101, 119);
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
            Load += EditarProd_Load;
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
        private TextBox textBox3;
        private TextBox txtDescricaoProd;
        private TextBox txtNomeProduto;
        private Button btnProx;
        private Button BtnAnterior;
        private TextBox textBox4;
        private ComboBox comboBox1;
        private Label label5;
    }
}