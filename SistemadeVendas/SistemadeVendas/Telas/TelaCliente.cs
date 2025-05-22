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

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                using (OdbcConnection conexao = ConexaoBd.ObterConexao())
                {
                    conexao.Open();
                    MessageBox.Show("Conexao com o banco de dados realizado com sucesso");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro na conxexao: " + ex.Message);
            }
        }
    }
}
