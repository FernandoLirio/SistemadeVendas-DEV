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
using SistemadeVendas.Modelos;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SistemadeVendas.Telas
{
    public partial class TelaVenda : Form
    {
        private List<Produto> produtosDisponiveis;
        private List<(Produto produto, int quantidade)> carrinho = new List<(Produto, int)>();
        public TelaVenda(List<Produto> produtos)
        {
            InitializeComponent();
            produtosDisponiveis = produtos;
            CarregarProdutos();
        }

        private void TelaVenda_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_pesquisa_produto_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Encontra_Produto_Click(object sender, EventArgs e)
        {
            string termo = textBox1_pesquisa_produto.Text.Trim().ToLower();

            listView1.Items.Clear();
            listView1.View = View.Details;
            listView1.FullRowSelect = true;

            if (listView1.Columns.Count == 0)
            {
                listView1.Columns.Add("Código", 100);
                listView1.Columns.Add("Descrição", 200);
                listView1.Columns.Add("Preço", 100);
            }

            var resultados = produtosDisponiveis.Where(p =>
                p.Codigo.ToLower().Contains(termo) ||
                p.Descricao.ToLower().Contains(termo)).ToList();

            foreach (var produto in resultados)
            {
                var item = new ListViewItem(produto.Codigo);
                item.SubItems.Add(produto.Descricao);
                item.SubItems.Add(produto.Preco);
                listView1.Items.Add(item);
            }

            if (resultados.Count == 0)
            {
                MessageBox.Show("Produto não encontrado.");
            }
        }

        private void CarregarProdutos()
        {
            listView1.Items.Clear();
            listView1.View = View.Details;
            listView1.FullRowSelect = true;

            if (listView1.Columns.Count == 0)
            {
                listView1.Columns.Add("Código", 100);
                listView1.Columns.Add("Descrição", 200);
                listView1.Columns.Add("Preço", 100);
            }

            foreach (var produto in produtosDisponiveis)
            {
                var item = new ListViewItem(produto.Codigo);
                item.SubItems.Add(produto.Descricao);
                item.SubItems.Add(produto.Preco);
                listView1.Items.Add(item);
            }
        }


        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Mandar_Carrrinho_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Selecione um produto.");
                return;
            }

            var itemSelecionado = listView1.SelectedItems[0];
            string codigo = itemSelecionado.SubItems[0].Text;
            var produto = produtosDisponiveis.FirstOrDefault(p => p.Codigo == codigo);
            int quantidade = (int)numericUpDown1.Value;

            if (quantidade <= 0)
            {
                MessageBox.Show("Informe uma quantidade válida.");
                return;
            }

            carrinho.Add((produto, quantidade));

            var itemCarrinho = new ListViewItem(produto.Codigo);
            itemCarrinho.SubItems.Add(produto.Descricao);
            itemCarrinho.SubItems.Add(produto.Preco);
            itemCarrinho.SubItems.Add(quantidade.ToString());
            listView2_Carrinho.Items.Add(itemCarrinho);

            AtualizarTotal();
        }

        private void listView2_Carrinho_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Esvaziar_Carrinho_Click(object sender, EventArgs e)
        {
            carrinho.Clear();
            listView2_Carrinho.Items.Clear();
            AtualizarTotal();
        }

        private void button1_Finaliza_Compra_Click(object sender, EventArgs e)
        {
            if (carrinho.Count == 0)
            {
                MessageBox.Show("Carrinho vazio!");
                return;
            }

            try
            {
                using (var conexao = ConexaoBd.ObterConexao())
                {
                    conexao.Open();

                    
                    decimal total = 0;
                    foreach (var (produto, quantidade) in carrinho)
                    {
                        if (decimal.TryParse(produto.Preco, out decimal preco))
                            total += preco * quantidade;
                    }


                    string sqlVenda = "INSERT INTO venda (cliente_id, data_venda, valor_total) VALUES (?, ?, ?)";

                    int vendaId;

                    using (var cmdVenda = new OdbcCommand(sqlVenda, conexao))
                    {
                        cmdVenda.Parameters.AddWithValue("cliente_id", 1);
                        cmdVenda.Parameters.AddWithValue("data_venda", DateTime.Now);
                        cmdVenda.Parameters.AddWithValue("valor_total", total);

                        
                        cmdVenda.ExecuteNonQuery();

                        
                        var cmdId = new OdbcCommand("SELECT currval(pg_get_serial_sequence('venda','id'))", conexao);
                        vendaId = Convert.ToInt32(cmdId.ExecuteScalar());
                    }

                    
                    foreach (var (produto, quantidade) in carrinho)
                    {
                        decimal precoUnit = decimal.Parse(produto.Preco);
                        decimal valorTotalItem = precoUnit * quantidade;

                        string sqlItem = "INSERT INTO item_venda (venda_id, produto_id, quantidade, valor) VALUES (?, ?, ?, ?)";

                        using (var cmdItem = new OdbcCommand(sqlItem, conexao))
                        {
                            cmdItem.Parameters.AddWithValue("venda_id", vendaId);
                            cmdItem.Parameters.AddWithValue("produto_id", int.Parse(produto.Codigo));
                            cmdItem.Parameters.AddWithValue("quantidade", quantidade);
                            cmdItem.Parameters.AddWithValue("valor", valorTotalItem);
                            cmdItem.ExecuteNonQuery();
                        }
                    }

                    MessageBox.Show("Venda registrada com sucesso!");
                    carrinho.Clear();
                    listView2_Carrinho.Items.Clear();
                    AtualizarTotal();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao finalizar venda: " + ex.Message);
            }
        }

        private void button_Venda_Voltar_Click(object sender, EventArgs e)
        {

        }

        private void AtualizarTotal()
        {
            decimal total = 0;
            foreach (var (produto, quantidade) in carrinho)
            {
                if (decimal.TryParse(produto.Preco, out decimal preco))
                {
                    total += preco * quantidade;
                }
            }

            labelTotal.Text = $"Total: R$ {total:F2}";
        }

        private void labelTotal_Click(object sender, EventArgs e)
        {

        }
    }
}
