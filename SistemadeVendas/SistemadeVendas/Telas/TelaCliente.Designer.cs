using System;

namespace SistemadeVendas.Telas
{
    partial class TelaCliente
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
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cpfcnpj_inserir = new System.Windows.Forms.TextBox();
            this.nomeClienteInserir = new System.Windows.Forms.TextBox();
            this.button_Inserir = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.Procura_nome_cliente = new System.Windows.Forms.TextBox();
            this.Procura_cpfcnpj_admin = new System.Windows.Forms.TextBox();
            this.button_Procurar_cliente_admin = new System.Windows.Forms.Button();
            this.radioButton_Ativar = new System.Windows.Forms.RadioButton();
            this.radioButton_Desativar = new System.Windows.Forms.RadioButton();
            this.button_Salvar_Admin = new System.Windows.Forms.Button();
            this.senha_cadastro_cliente = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SistemadeVendas.Properties.Resources.tela_admin_cliente;
            this.pictureBox1.Location = new System.Drawing.Point(4, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1370, 770);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(428, 57);
            this.label1.TabIndex = 1;
            this.label1.Text = "Bem-Vindo Admin";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(4, 99);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1283, 583);
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.label2.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 23);
            this.label2.TabIndex = 6;
            this.label2.Text = "Cadastrar Cliente:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // cpfcnpj_inserir
            // 
            this.cpfcnpj_inserir.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.cpfcnpj_inserir.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cpfcnpj_inserir.Location = new System.Drawing.Point(26, 189);
            this.cpfcnpj_inserir.Name = "cpfcnpj_inserir";
            this.cpfcnpj_inserir.Size = new System.Drawing.Size(292, 31);
            this.cpfcnpj_inserir.TabIndex = 7;
            this.cpfcnpj_inserir.Text = "CPF/CNPJ:";
            // 
            // nomeClienteInserir
            // 
            this.nomeClienteInserir.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.nomeClienteInserir.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomeClienteInserir.Location = new System.Drawing.Point(26, 152);
            this.nomeClienteInserir.Name = "nomeClienteInserir";
            this.nomeClienteInserir.Size = new System.Drawing.Size(292, 31);
            this.nomeClienteInserir.TabIndex = 8;
            this.nomeClienteInserir.Text = "NOME:";
            // 
            // button_Inserir
            // 
            this.button_Inserir.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.button_Inserir.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Inserir.Location = new System.Drawing.Point(37, 282);
            this.button_Inserir.Name = "button_Inserir";
            this.button_Inserir.Size = new System.Drawing.Size(250, 47);
            this.button_Inserir.TabIndex = 9;
            this.button_Inserir.Text = "Inserir";
            this.button_Inserir.UseVisualStyleBackColor = false;
            this.button_Inserir.Click += new System.EventHandler(this.button_Inserir_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.label3.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 360);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 23);
            this.label3.TabIndex = 10;
            this.label3.Text = "Procura Cliente:";
            // 
            // Procura_nome_cliente
            // 
            this.Procura_nome_cliente.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.Procura_nome_cliente.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Procura_nome_cliente.Location = new System.Drawing.Point(26, 404);
            this.Procura_nome_cliente.Name = "Procura_nome_cliente";
            this.Procura_nome_cliente.Size = new System.Drawing.Size(292, 31);
            this.Procura_nome_cliente.TabIndex = 11;
            this.Procura_nome_cliente.Text = "NOME:";
            // 
            // Procura_cpfcnpj_admin
            // 
            this.Procura_cpfcnpj_admin.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.Procura_cpfcnpj_admin.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Procura_cpfcnpj_admin.Location = new System.Drawing.Point(26, 454);
            this.Procura_cpfcnpj_admin.Name = "Procura_cpfcnpj_admin";
            this.Procura_cpfcnpj_admin.Size = new System.Drawing.Size(292, 31);
            this.Procura_cpfcnpj_admin.TabIndex = 12;
            this.Procura_cpfcnpj_admin.Text = "CPF/CNPJ:";
            // 
            // button_Procurar_cliente_admin
            // 
            this.button_Procurar_cliente_admin.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.button_Procurar_cliente_admin.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Procurar_cliente_admin.Location = new System.Drawing.Point(37, 516);
            this.button_Procurar_cliente_admin.Name = "button_Procurar_cliente_admin";
            this.button_Procurar_cliente_admin.Size = new System.Drawing.Size(250, 47);
            this.button_Procurar_cliente_admin.TabIndex = 13;
            this.button_Procurar_cliente_admin.Text = "Procurar";
            this.button_Procurar_cliente_admin.UseVisualStyleBackColor = false;
            this.button_Procurar_cliente_admin.Click += new System.EventHandler(this.button_Procurar_cliente_admin_Click);
            // 
            // radioButton_Ativar
            // 
            this.radioButton_Ativar.AutoSize = true;
            this.radioButton_Ativar.Location = new System.Drawing.Point(361, 408);
            this.radioButton_Ativar.Name = "radioButton_Ativar";
            this.radioButton_Ativar.Size = new System.Drawing.Size(52, 17);
            this.radioButton_Ativar.TabIndex = 14;
            this.radioButton_Ativar.TabStop = true;
            this.radioButton_Ativar.Text = "Ativar";
            this.radioButton_Ativar.UseVisualStyleBackColor = true;
            // 
            // radioButton_Desativar
            // 
            this.radioButton_Desativar.AutoSize = true;
            this.radioButton_Desativar.Location = new System.Drawing.Point(361, 462);
            this.radioButton_Desativar.Name = "radioButton_Desativar";
            this.radioButton_Desativar.Size = new System.Drawing.Size(70, 17);
            this.radioButton_Desativar.TabIndex = 15;
            this.radioButton_Desativar.TabStop = true;
            this.radioButton_Desativar.Text = "Desativar";
            this.radioButton_Desativar.UseVisualStyleBackColor = true;
            // 
            // button_Salvar_Admin
            // 
            this.button_Salvar_Admin.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.button_Salvar_Admin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Salvar_Admin.Location = new System.Drawing.Point(361, 516);
            this.button_Salvar_Admin.Name = "button_Salvar_Admin";
            this.button_Salvar_Admin.Size = new System.Drawing.Size(81, 47);
            this.button_Salvar_Admin.TabIndex = 16;
            this.button_Salvar_Admin.Text = "Salvar";
            this.button_Salvar_Admin.UseVisualStyleBackColor = false;
            // 
            // senha_cadastro_cliente
            // 
            this.senha_cadastro_cliente.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.senha_cadastro_cliente.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.senha_cadastro_cliente.Location = new System.Drawing.Point(26, 233);
            this.senha_cadastro_cliente.Name = "senha_cadastro_cliente";
            this.senha_cadastro_cliente.Size = new System.Drawing.Size(292, 31);
            this.senha_cadastro_cliente.TabIndex = 17;
            this.senha_cadastro_cliente.Text = "Senha:";
            // 
            // TelaCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 771);
            this.Controls.Add(this.senha_cadastro_cliente);
            this.Controls.Add(this.button_Salvar_Admin);
            this.Controls.Add(this.radioButton_Desativar);
            this.Controls.Add(this.radioButton_Ativar);
            this.Controls.Add(this.button_Procurar_cliente_admin);
            this.Controls.Add(this.Procura_cpfcnpj_admin);
            this.Controls.Add(this.Procura_nome_cliente);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button_Inserir);
            this.Controls.Add(this.nomeClienteInserir);
            this.Controls.Add(this.cpfcnpj_inserir);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "TelaCliente";
            this.Text = "TelaCliente";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox cpfcnpj_inserir;
        private System.Windows.Forms.TextBox nomeClienteInserir;
        private System.Windows.Forms.Button button_Inserir;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Procura_nome_cliente;
        private System.Windows.Forms.TextBox Procura_cpfcnpj_admin;
        private System.Windows.Forms.Button button_Procurar_cliente_admin;
        private System.Windows.Forms.RadioButton radioButton_Ativar;
        private System.Windows.Forms.RadioButton radioButton_Desativar;
        private System.Windows.Forms.Button button_Salvar_Admin;
        private System.Windows.Forms.TextBox senha_cadastro_cliente;
    }
}