using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Odbc;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemadeVendas.Dados;

namespace SistemadeVendas.Telas
{
    public partial class TelaLogin : Form
    {
        public TelaLogin()
        {
            InitializeComponent();
        }

        private void TelaLogin_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                using (var conexao = ConexaoBd.ObterConexao())
                {
                    conexao.Open();

                    string sql = "SELECT * FROM usuario WHERE cpf_cnpj = ? AND senha = ?";

                    using (var cmd = new OdbcCommand(sql, conexao))
                    {
                        cmd.Parameters.AddWithValue("@cpf_cnpj", txtCpfCnpj.Text.Trim());
                        cmd.Parameters.AddWithValue("@senha", txtSenha.Text.Trim());

                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                var valorAtivo = reader["ativo"].ToString().ToLower();
                                bool ativo = valorAtivo == "true" || valorAtivo == "t" || valorAtivo == "1";

                                if (!ativo)
                                {
                                    MessageBox.Show("Usuário inativo. Contate o Administrador.");
                                    return;
                                }

                                string tipo = reader["tipo"].ToString();
                                string nome = reader["nome"].ToString();

                                MessageBox.Show($"Bem-vindo, {nome}!");

                                if (tipo == "admin")
                                {
                                    TelaCliente tela = new TelaCliente();
                                    tela.Show();
                                }
                                else
                                {
                                    TelaProduto telaProduto = new TelaProduto();
                                    telaProduto.Show();
                                    this.Hide();
                                }

                                
                            }
                            else
                            {
                                MessageBox.Show("CPF/CNPJ ou senha inválidos.");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro no login: " + ex.Message);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
