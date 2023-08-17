using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sistema_gestao_estudantes
{
    public partial class FormListaDeEstudantes : Form
    {
        public FormListaDeEstudantes()
        {
            InitializeComponent();
        }

        Estudante estudante = new Estudante();

        private void botaoAtualizar(object sender, EventArgs e)
        {

        }

        private void FormListaDeEstudantes_Load(object sender, EventArgs e)
        {
            MySqlCommand comando = new MySqlCommand("SELECT * FROM 'estudantes'");
            dataGridViewLista.ReadOnly = true;
            DataGridViewImageColumn colunaDeFotos = new DataGridViewImageColumn();
            dataGridViewLista.RowTemplate.Height = 80;
            dataGridViewLista.DataSource = estudante.getEstudantes(comando);
            colunaDeFotos = (DataGridViewImageColumn)dataGridViewLista.Columns[7];
            colunaDeFotos.ImageLayout = DataGridViewImageCellLayout.Stretch;
            dataGridViewLista.AllowUserToAddRows= false;
        }

        private void dataGridViewLista_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridViewLista_DoubleClick(object sender, EventArgs e)
        {

        }
    }
}
