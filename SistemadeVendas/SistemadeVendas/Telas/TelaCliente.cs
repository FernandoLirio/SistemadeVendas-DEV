using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemadeVendas.Dados;
using System.Data.Odbc;

namespace SistemadeVendas.Telas
{
    public partial class TelaCliente : Form
    {
        public TelaCliente()
        {
            InitializeComponent();
        }

        private void button_Inserir_Click(object sender, EventArgs e)
        {
            try
            {
                using (OdbcConnection conexao = ConexaoBd.ObterConexao())
                {
                    conexao.Open();
                    string sql = "INSERT INTO usuario (nome, cpf_cnpj, senha, tipo, ativo) VALUES (?, ?, ?, 'cliente', TRUE)";

                    using (OdbcCommand cmd = new OdbcCommand(sql, conexao)) 
                    {
                        cmd.Parameters.AddWithValue("@nome", nomeClienteInserir.Text);
                        cmd.Parameters.AddWithValue("@cpf_cnpj", cpfcnpj_inserir.Text);
                        cmd.Parameters.AddWithValue("@senha", senha_cadastro_cliente.Text);

                        cmd.ExecuteNonQuery();
                    }
                    MessageBox.Show("Cliente cadastrado com sucesso!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao inserir o cliente: " + ex.Message);
            }
        }

        private void button_Procurar_cliente_admin_Click(object sender, EventArgs e)
        {
            try
            {
                using (OdbcConnection conexao = ConexaoBd.ObterConexao())
                {
                    conexao.Open();

                    string sql = "SELECT * FROM usuario WHERE (nome = ? OR cpf_cnpj = ?)";

                    using (OdbcCommand cmd = new OdbcCommand(sql, conexao))
                    {
                        cmd.Parameters.AddWithValue("@nome", Procura_nome_cliente.Text);
                        cmd.Parameters.AddWithValue("@cpf_cnpj", Procura_cpfcnpj_admin.Text);

                        using (OdbcDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string nome = reader["nome"].ToString();
                                string cpf = reader["cpf_cnpj"].ToString();
                                bool ativo = Convert.ToBoolean(reader["ativo"]);

                                MessageBox.Show($"Cliente encontrado:\nNome: {nome}\nCPF/CNPJ: {cpf}\nStatus: {(ativo ? "Ativo" : "Inativo")}");
                            }
                            else
                            {
                                MessageBox.Show("Cliente não encontrado.");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro na busca: " + ex.Message);
            }
        }


        private void button_Salvar_Admin_Click(object sender, EventArgs e)
        {
            try
            {
                bool novoStatus = radioButton_Ativar.Checked;

                using (OdbcConnection conexao = ConexaoBd.ObterConexao())
                {
                    conexao.Open();

                    string sql = "UPDATE usuario SET ativo = ? WHERE cpf_cnpj = ?";

                    using (OdbcCommand cmd = new OdbcCommand(sql, conexao))
                    {
                        cmd.Parameters.AddWithValue("@ativo", novoStatus);
                        cmd.Parameters.AddWithValue("@cpf_cnpj", Procura_cpfcnpj_admin.Text);

                        int linhasAfetadas = cmd.ExecuteNonQuery();

                        if (linhasAfetadas > 0)
                        {
                            MessageBox.Show("Status atualizado com sucesso!");
                        }
                        else
                        {
                            MessageBox.Show("Cliente não encontrado");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao atualizar o status: " + ex.Message);
            }
        }
    }
}
