using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiControle
{
    public partial class Form1 : Form
    {
        public List<Produto> listaEstoque = new List<Produto>();
        public Form1()
        {
            InitializeComponent();
            ConfigurarGrade();
            txtNome.CharacterCasing = CharacterCasing.Upper;
        }

        private void ConfigurarGrade()
        {
            DgvEstoque.Columns.Clear();
            DgvEstoque.Columns.Add("colNome", "Produto");
            DgvEstoque.Columns.Add("colQuantidade", "Quantidade");
            DgvEstoque.Columns.Add("ColValor", "Preço Unitario");
            DgvEstoque.Columns.Add("ColTotalItem", "Total do item");

            DgvEstoque.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgvEstoque.AllowUserToAddRows = false;
            DgvEstoque.ReadOnly = true;
            DgvEstoque.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void Produto_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtQuantidade_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }

        }
        private void txtValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back) return;
            if (e.KeyChar == ',' && !txtValor.Text.Contains(",")) return;
            e.Handled = true;

        }

        private void BtmSalvar_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text.Trim();
            if (string.IsNullOrEmpty(nome) ||
                !int.TryParse(txtQuantidade.Text, out int quantidade) ||
                !decimal.TryParse(txtValor.Text, out decimal valor))
            {
                MessageBox.Show("Por favor, preencha todos os campos corretamente!", "Avso",
                MessageBoxButtons.OK, MessageBoxIcon.Warning); return;
            }
            Produto novoProduto = new Produto
            {
                Nome = nome,
                Quantidade = quantidade,
                Valor = valor
            };
            listaEstoque.Add(novoProduto);
            AtualizarTabelaTela();
            txtNome.Clear();
            txtQuantidade.Clear();
            txtValor.Clear();
            txtNome.Focus();
        }


        private void AtualizarTabelaTela()
        {
            DgvEstoque.Rows.Clear();
            decimal ValorTotalAcumulado = 0;
            foreach (Produto prod in listaEstoque)
            {
                decimal totalDoItem = prod.Quantidade * prod.Valor;
                ValorTotalAcumulado += totalDoItem;
                DgvEstoque.Rows.Add(prod.Nome, prod.Quantidade, prod.Valor.ToString("C"),
                    totalDoItem.ToString("C"));

            }
            //Total acumulado do estoque exibido no label
            //lblTotalEstoque.Text = $"Valor total do estoque: {ValorTotalAcuulado:C}";

        }

        public class Produto
        {
            public string Nome { get; set; }
            public int Quantidade { get; set; }
            public decimal Valor { get; set; }

        }

 
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiControle
{
    public partial class Form1 : Form
    {
        public List<Produto> listaEstoque = new List<Produto>();
        public Form1()
        {
            InitializeComponent();
            ConfigurarGrade();
            txtNome.CharacterCasing = CharacterCasing.Upper;
        }

        private void ConfigurarGrade()
        {
            DgvEstoque.Columns.Clear();
            DgvEstoque.Columns.Add("colNome", "Produto");
            DgvEstoque.Columns.Add("colQuantidade", "Quantidade");
            DgvEstoque.Columns.Add("ColValor", "Preço Unitario");
            DgvEstoque.Columns.Add("ColTotalItem", "Total do item");

            DgvEstoque.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgvEstoque.AllowUserToAddRows = false;
            DgvEstoque.ReadOnly = true;
            DgvEstoque.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void Produto_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtQuantidade_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }

        }
        private void txtValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back) return;
            if (e.KeyChar == ',' && !txtValor.Text.Contains(",")) return;
            e.Handled = true;

        }

        private void BtmSalvar_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text.Trim();
            if (string.IsNullOrEmpty(nome) ||
                !int.TryParse(txtQuantidade.Text, out int quantidade) ||
                !decimal.TryParse(txtValor.Text, out decimal valor))
            {
                MessageBox.Show("Por favor, preencha todos os campos corretamente!", "Avso",
                MessageBoxButtons.OK, MessageBoxIcon.Warning); return;
            }
            Produto novoProduto = new Produto
            {
                Nome = nome,
                Quantidade = quantidade,
                Valor = valor
            };
            listaEstoque.Add(novoProduto);
            AtualizarTabelaTela();
            txtNome.Clear();
            txtQuantidade.Clear();
            txtValor.Clear();
            txtNome.Focus();
        }


        private void AtualizarTabelaTela()
        {
            DgvEstoque.Rows.Clear();
            decimal ValorTotalAcumulado = 0;
            foreach (Produto prod in listaEstoque)
            {
                decimal totalDoItem = prod.Quantidade * prod.Valor;
                ValorTotalAcumulado += totalDoItem;
                DgvEstoque.Rows.Add(prod.Nome, prod.Quantidade, prod.Valor.ToString("C"),
                    totalDoItem.ToString("C"));

            }
            //Total acumulado do estoque exibido no label
            //lblTotalEstoque.Text = $"Valor total do estoque: {ValorTotalAcuulado:C}";

        }

        public class Produto
        {
            public string Nome { get; set; }
            public int Quantidade { get; set; }
            public decimal Valor { get; set; }

        }

 
    }
}
