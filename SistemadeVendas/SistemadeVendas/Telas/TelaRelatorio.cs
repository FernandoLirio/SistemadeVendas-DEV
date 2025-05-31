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
    public partial class TelaRelatorio : Form
    {
        public TelaRelatorio()
        {
            InitializeComponent();
            CarregarRelatorioClientes();
        }

        private void CarregarRelatorioClientes()
        {
            listViewRelatorio.Items.Clear();

            using (var conexao = ConexaoBd.ObterConexao())
            {
                conexao.Open();
                    string sql = @"
                    SELECT u.nome, SUM(v.valor_total) AS total_comprado
                    FROM usuario u
                    JOIN venda v ON v.cliente_id = u.id
                    WHERE u.tipo = 'cliente'
                    GROUP BY u.nome
                    ORDER BY total_comprado DESC;
                ";


                using (var cmd = new OdbcCommand(sql, conexao))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string nome = reader["nome"].ToString();
                        string total = Convert.ToDecimal(reader["total_comprado"]).ToString("C2");

                        var item = new ListViewItem(nome);
                        item.SubItems.Add(total);
                        listViewRelatorio.Items.Add(item);
                    }
                }
            }
        }
    
        private void listViewRelatorio_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
