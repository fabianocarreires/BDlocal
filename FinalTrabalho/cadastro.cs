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
    public partial class cadastro : Form
    {

        Form1 invocador;

        public cadastro(Form1 referencia)
        {
            InitializeComponent();
            invocador = referencia;
        }

        private void clientesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.clientesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.lojaDataSet);
            invocador.atualizaTabela();

        }

        private void cadastro_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'lojaDataSet.clientes'. Você pode movê-la ou removê-la conforme necessário.
            this.clientesTableAdapter.Fill(this.lojaDataSet.clientes);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
