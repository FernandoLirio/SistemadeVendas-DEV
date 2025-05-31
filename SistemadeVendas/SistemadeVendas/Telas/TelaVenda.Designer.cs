namespace SistemadeVendas.Telas
{
    partial class TelaVenda
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.listView2_Carrinho = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button_Venda_Voltar = new System.Windows.Forms.Button();
            this.textBox1_pesquisa_produto = new System.Windows.Forms.TextBox();
            this.button1_Encontra_Produto = new System.Windows.Forms.Button();
            this.button1_Mandar_Carrrinho = new System.Windows.Forms.Button();
            this.button1_Finaliza_Compra = new System.Windows.Forms.Button();
            this.button1_Esvaziar_Carrinho = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.labelTotal = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SistemadeVendas.Properties.Resources.tela_admin_cliente;
            this.pictureBox1.Location = new System.Drawing.Point(2, -4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1072, 660);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 90);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(352, 340);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // listView2_Carrinho
            // 
            this.listView2_Carrinho.HideSelection = false;
            this.listView2_Carrinho.Location = new System.Drawing.Point(574, 46);
            this.listView2_Carrinho.Name = "listView2_Carrinho";
            this.listView2_Carrinho.Size = new System.Drawing.Size(500, 384);
            this.listView2_Carrinho.TabIndex = 2;
            this.listView2_Carrinho.UseCompatibleStateImageBehavior = false;
            this.listView2_Carrinho.SelectedIndexChanged += new System.EventHandler(this.listView2_Carrinho_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 26);
            this.label1.TabIndex = 3;
            this.label1.Text = "Selecionar produto:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(569, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 26);
            this.label2.TabIndex = 4;
            this.label2.Text = "Carrinho:";
            // 
            // button_Venda_Voltar
            // 
            this.button_Venda_Voltar.Location = new System.Drawing.Point(966, 614);
            this.button_Venda_Voltar.Name = "button_Venda_Voltar";
            this.button_Venda_Voltar.Size = new System.Drawing.Size(108, 42);
            this.button_Venda_Voltar.TabIndex = 5;
            this.button_Venda_Voltar.Text = "Voltar";
            this.button_Venda_Voltar.UseVisualStyleBackColor = true;
            this.button_Venda_Voltar.Click += new System.EventHandler(this.button_Venda_Voltar_Click);
            // 
            // textBox1_pesquisa_produto
            // 
            this.textBox1_pesquisa_produto.Location = new System.Drawing.Point(12, 61);
            this.textBox1_pesquisa_produto.Name = "textBox1_pesquisa_produto";
            this.textBox1_pesquisa_produto.Size = new System.Drawing.Size(173, 20);
            this.textBox1_pesquisa_produto.TabIndex = 6;
            this.textBox1_pesquisa_produto.TextChanged += new System.EventHandler(this.textBox1_pesquisa_produto_TextChanged);
            // 
            // button1_Encontra_Produto
            // 
            this.button1_Encontra_Produto.Location = new System.Drawing.Point(191, 61);
            this.button1_Encontra_Produto.Name = "button1_Encontra_Produto";
            this.button1_Encontra_Produto.Size = new System.Drawing.Size(75, 23);
            this.button1_Encontra_Produto.TabIndex = 7;
            this.button1_Encontra_Produto.Text = "Encontrar";
            this.button1_Encontra_Produto.UseVisualStyleBackColor = true;
            this.button1_Encontra_Produto.Click += new System.EventHandler(this.button1_Encontra_Produto_Click);
            // 
            // button1_Mandar_Carrrinho
            // 
            this.button1_Mandar_Carrrinho.Location = new System.Drawing.Point(168, 434);
            this.button1_Mandar_Carrrinho.Name = "button1_Mandar_Carrrinho";
            this.button1_Mandar_Carrrinho.Size = new System.Drawing.Size(168, 23);
            this.button1_Mandar_Carrrinho.TabIndex = 8;
            this.button1_Mandar_Carrrinho.Text = "Mandar para o Carrinho";
            this.button1_Mandar_Carrrinho.UseVisualStyleBackColor = true;
            this.button1_Mandar_Carrrinho.Click += new System.EventHandler(this.button1_Mandar_Carrrinho_Click);
            // 
            // button1_Finaliza_Compra
            // 
            this.button1_Finaliza_Compra.Location = new System.Drawing.Point(921, 436);
            this.button1_Finaliza_Compra.Name = "button1_Finaliza_Compra";
            this.button1_Finaliza_Compra.Size = new System.Drawing.Size(133, 23);
            this.button1_Finaliza_Compra.TabIndex = 9;
            this.button1_Finaliza_Compra.Text = "Finalizar a Compra";
            this.button1_Finaliza_Compra.UseVisualStyleBackColor = true;
            this.button1_Finaliza_Compra.Click += new System.EventHandler(this.button1_Finaliza_Compra_Click);
            // 
            // button1_Esvaziar_Carrinho
            // 
            this.button1_Esvaziar_Carrinho.Location = new System.Drawing.Point(619, 434);
            this.button1_Esvaziar_Carrinho.Name = "button1_Esvaziar_Carrinho";
            this.button1_Esvaziar_Carrinho.Size = new System.Drawing.Size(133, 23);
            this.button1_Esvaziar_Carrinho.TabIndex = 10;
            this.button1_Esvaziar_Carrinho.Text = "Esvaziar o Carrinho";
            this.button1_Esvaziar_Carrinho.UseVisualStyleBackColor = true;
            this.button1_Esvaziar_Carrinho.Click += new System.EventHandler(this.button1_Esvaziar_Carrinho_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(99, 436);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(54, 20);
            this.numericUpDown1.TabIndex = 11;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotal.Location = new System.Drawing.Point(767, 436);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(77, 20);
            this.labelTotal.TabIndex = 12;
            this.labelTotal.Text = "Total: R$ ";
            this.labelTotal.Click += new System.EventHandler(this.labelTotal_Click);
            // 
            // TelaVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1086, 668);
            this.Controls.Add(this.labelTotal);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.button1_Esvaziar_Carrinho);
            this.Controls.Add(this.button1_Finaliza_Compra);
            this.Controls.Add(this.button1_Mandar_Carrrinho);
            this.Controls.Add(this.button1_Encontra_Produto);
            this.Controls.Add(this.textBox1_pesquisa_produto);
            this.Controls.Add(this.button_Venda_Voltar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listView2_Carrinho);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "TelaVenda";
            this.Text = "TelaVenda";
            this.Load += new System.EventHandler(this.TelaVenda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ListView listView2_Carrinho;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_Venda_Voltar;
        private System.Windows.Forms.TextBox textBox1_pesquisa_produto;
        private System.Windows.Forms.Button button1_Encontra_Produto;
        private System.Windows.Forms.Button button1_Mandar_Carrrinho;
        private System.Windows.Forms.Button button1_Finaliza_Compra;
        private System.Windows.Forms.Button button1_Esvaziar_Carrinho;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label labelTotal;
    }
}