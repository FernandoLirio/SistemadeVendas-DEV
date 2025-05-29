using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemadeVendas.Modelos;

namespace SistemadeVendas.Telas
{
    public partial class TelaProduto : Form
    {
        public TelaProduto()
        {
            InitializeComponent();

            listView1_visualizar_Produtos.View = View.Details;
            listView1_visualizar_Produtos.Columns.Add("Código", 100);
            listView1_visualizar_Produtos.Columns.Add("Preco", 100);
            listView1_visualizar_Produtos.Columns.Add("Descrição", 100);
        }

        private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TelaCadastroProduto telaCadastro = new TelaCadastroProduto(produto =>
            {
                ListViewItem item = new ListViewItem(new[]
                {
                    produto.Codigo,
                    produto.Preco,
                    produto.Descricao
                });
                listView1_visualizar_Produtos.Items.Add(item);
            });
            telaCadastro.ShowDialog();
        }

        private void listView1_visualizar_Produtos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1_visualizar_Produtos.SelectedItems.Count == 0)
                return;

            var selectedItem = listView1_visualizar_Produtos.SelectedItems[0];

            Produto produtoSelecionado = new Produto
            {
                Codigo = selectedItem.SubItems[0].Text,
                Preco = selectedItem.SubItems[1].Text,
                Descricao = selectedItem.SubItems[2].Text
            };

            
            TelaCadastroProduto telaCadastro = new TelaCadastroProduto(produtoEditado =>
            {
                
                selectedItem.SubItems[0].Text = produtoEditado.Codigo;
                selectedItem.SubItems[1].Text = produtoEditado.Preco;
                selectedItem.SubItems[2].Text = produtoEditado.Descricao;
            }, selectedItem);

            telaCadastro.PreencherCampos(produtoSelecionado);
            telaCadastro.ShowDialog();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void relatórioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var telaVenda = new TelaVenda();
            telaVenda.ShowDialog();
        }
    }
}
