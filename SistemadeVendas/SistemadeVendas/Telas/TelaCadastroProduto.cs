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
    public partial class TelaCadastroProduto : Form
    {
        private readonly Action<Produto> onSalvarProduto;
        private ListViewItem itemEditar;

        public TelaCadastroProduto(Action<Produto> onSalvarProduto, ListViewItem itemEditar = null)
        {
            InitializeComponent();
            this.onSalvarProduto = onSalvarProduto;
            this.itemEditar = itemEditar;
        }

        public TelaCadastroProduto() : this(null) { }
        private void button_Novo_Produto_Click(object sender, EventArgs e)
        {
            textBoxCodigo.Clear();
            textBoxPreco.Clear();
            textBoxDescricao.Clear();

        }

        private void button3_Salvar_Produto_Click(object sender, EventArgs e)
        {
            Produto novoProduto = new Produto
            {
                Codigo = textBoxCodigo.Text,
                Preco = textBoxPreco.Text,
                Descricao = textBoxDescricao.Text
            };

            onSalvarProduto?.Invoke(novoProduto);
            this.Close();
        }

        private void button2_Deletar_Produto_Click(object sender, EventArgs e)
        {
            if (itemEditar != null)
            {
                itemEditar.Remove(); 
                this.Close();
            }
            else
            {
                MessageBox.Show("Nenhum produto selecionado para deletar.");
            }
        }

        private void button4_Sair_Produto_Click(object sender, EventArgs e)
        {

        }

        public void PreencherCampos(Produto produto)
        {
            textBoxCodigo.Text = produto.Codigo;
            textBoxPreco.Text = produto.Preco;
            textBoxDescricao.Text = produto.Descricao;
        }

    }
}
