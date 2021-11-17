using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using _3A1JoãoPaulo203etp.Code.BLL;
using _3A1JoãoPaulo203etp.Code.DTO;

namespace _3A1JoãoPaulo203etp
{
    public partial class Form1 : Form
    {

        cadProdBLL prodbll = new cadProdBLL();
        cadProdDTO proddto = new cadProdDTO();


        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            proddto.Produto = txtProduto.Text;
            proddto.Preco = numPreco.Text;

            prodbll.Insert(proddto);

            MessageBox.Show("Cadastrado com Sucesso");

            dgvProdutos.DataSource = prodbll.Listar();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dgvProdutos.DataSource = prodbll.Listar();
        }

        private void dgvProdutos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtID.Text = dgvProdutos.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtProduto.Text = dgvProdutos.Rows[e.RowIndex].Cells[1].Value.ToString();
            numPreco.Text = dgvProdutos.Rows[e.RowIndex].Cells[2].Value.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            proddto.Id = int.Parse(txtID.Text);
            proddto.Produto = txtProduto.Text;
            proddto.Preco = numPreco.Text.ToString();

            prodbll.Editar(proddto);

            MessageBox.Show("Alterado com sucesso");

            dgvProdutos.DataSource = prodbll.Listar();

            txtID.Clear();
            txtProduto.Clear();
            numPreco.Clear();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            proddto.Id = int.Parse(txtID.Text);
            prodbll.Excluir(proddto);

            MessageBox.Show("Deletado com Sucesso");
            dgvProdutos.DataSource = prodbll.Listar();

            txtID.Clear();
            txtProduto.Clear();
            numPreco.Clear();
        }
    }
}
