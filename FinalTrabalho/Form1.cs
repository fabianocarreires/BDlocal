using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalTrabalho
{

    public partial class Form1 : Form
    {
        

        public Form1()
        {
            InitializeComponent();
        }

        public void atualizaTabela()
        {
            this.clientesTableAdapter.Fill(this.lojaDataSet.clientes);
        }

        private void clientesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.clientesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.lojaDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'lojaDataSet.clientes'. Você pode movê-la ou removê-la conforme necessário.
            this.clientesTableAdapter.Fill(this.lojaDataSet.clientes);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            cadastro novaTela = new cadastro(this);
            novaTela.ShowDialog();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            this.clientesTableAdapter.FillByNome(this.lojaDataSet.clientes, "%" + textBox1.Text + "%");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
