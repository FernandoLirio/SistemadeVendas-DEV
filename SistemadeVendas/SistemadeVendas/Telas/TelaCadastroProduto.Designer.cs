namespace SistemadeVendas.Telas
{
    partial class TelaCadastroProduto
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBoxCodigo = new System.Windows.Forms.TextBox();
            this.textBoxDescricao = new System.Windows.Forms.TextBox();
            this.textBoxPreco = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button_Novo_Produto = new System.Windows.Forms.Button();
            this.button2_Deletar_Produto = new System.Windows.Forms.Button();
            this.button3_Salvar_Produto = new System.Windows.Forms.Button();
            this.button4_Sair_Produto = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SistemadeVendas.Properties.Resources.tela_admin_cliente;
            this.pictureBox1.Location = new System.Drawing.Point(2, -6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1071, 585);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // textBoxCodigo
            // 
            this.textBoxCodigo.Location = new System.Drawing.Point(129, 58);
            this.textBoxCodigo.Name = "textBoxCodigo";
            this.textBoxCodigo.Size = new System.Drawing.Size(199, 20);
            this.textBoxCodigo.TabIndex = 1;
            // 
            // textBoxDescricao
            // 
            this.textBoxDescricao.Location = new System.Drawing.Point(129, 139);
            this.textBoxDescricao.Multiline = true;
            this.textBoxDescricao.Name = "textBoxDescricao";
            this.textBoxDescricao.Size = new System.Drawing.Size(438, 90);
            this.textBoxDescricao.TabIndex = 2;
            // 
            // textBoxPreco
            // 
            this.textBoxPreco.Location = new System.Drawing.Point(129, 99);
            this.textBoxPreco.Name = "textBoxPreco";
            this.textBoxPreco.Size = new System.Drawing.Size(199, 20);
            this.textBoxPreco.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Cod.Produto:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Preço do Produto:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Descrição:";
            // 
            // button_Novo_Produto
            // 
            this.button_Novo_Produto.Location = new System.Drawing.Point(89, 275);
            this.button_Novo_Produto.Name = "button_Novo_Produto";
            this.button_Novo_Produto.Size = new System.Drawing.Size(75, 23);
            this.button_Novo_Produto.TabIndex = 7;
            this.button_Novo_Produto.Text = "NOVO";
            this.button_Novo_Produto.UseVisualStyleBackColor = true;
            this.button_Novo_Produto.Click += new System.EventHandler(this.button_Novo_Produto_Click);
            // 
            // button2_Deletar_Produto
            // 
            this.button2_Deletar_Produto.Location = new System.Drawing.Point(301, 275);
            this.button2_Deletar_Produto.Name = "button2_Deletar_Produto";
            this.button2_Deletar_Produto.Size = new System.Drawing.Size(75, 23);
            this.button2_Deletar_Produto.TabIndex = 8;
            this.button2_Deletar_Produto.Text = "DELETAR";
            this.button2_Deletar_Produto.UseVisualStyleBackColor = true;
            this.button2_Deletar_Produto.Click += new System.EventHandler(this.button2_Deletar_Produto_Click);
            // 
            // button3_Salvar_Produto
            // 
            this.button3_Salvar_Produto.Location = new System.Drawing.Point(195, 275);
            this.button3_Salvar_Produto.Name = "button3_Salvar_Produto";
            this.button3_Salvar_Produto.Size = new System.Drawing.Size(75, 23);
            this.button3_Salvar_Produto.TabIndex = 9;
            this.button3_Salvar_Produto.Text = "SALVAR";
            this.button3_Salvar_Produto.UseVisualStyleBackColor = true;
            this.button3_Salvar_Produto.Click += new System.EventHandler(this.button3_Salvar_Produto_Click);
            // 
            // button4_Sair_Produto
            // 
            this.button4_Sair_Produto.Location = new System.Drawing.Point(412, 275);
            this.button4_Sair_Produto.Name = "button4_Sair_Produto";
            this.button4_Sair_Produto.Size = new System.Drawing.Size(75, 23);
            this.button4_Sair_Produto.TabIndex = 10;
            this.button4_Sair_Produto.Text = "SAIR";
            this.button4_Sair_Produto.UseVisualStyleBackColor = true;
            this.button4_Sair_Produto.Click += new System.EventHandler(this.button4_Sair_Produto_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button4_Sair_Produto);
            this.groupBox1.Controls.Add(this.button3_Salvar_Produto);
            this.groupBox1.Controls.Add(this.button2_Deletar_Produto);
            this.groupBox1.Controls.Add(this.button_Novo_Produto);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBoxPreco);
            this.groupBox1.Controls.Add(this.textBoxDescricao);
            this.groupBox1.Controls.Add(this.textBoxCodigo);
            this.groupBox1.Location = new System.Drawing.Point(32, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(830, 509);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cadastro de Produtos:";
            // 
            // TelaCadastroProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1073, 591);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "TelaCadastroProduto";
            this.Text = "TelaCadastroProduto";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBoxCodigo;
        private System.Windows.Forms.TextBox textBoxDescricao;
        private System.Windows.Forms.TextBox textBoxPreco;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button_Novo_Produto;
        private System.Windows.Forms.Button button2_Deletar_Produto;
        private System.Windows.Forms.Button button3_Salvar_Produto;
        private System.Windows.Forms.Button button4_Sair_Produto;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}