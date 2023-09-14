using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sistema_gestao_estudantes
{
    public partial class AtualizarDeletarEstudante : Form
    {
        Estudante estudante = new Estudante();
        public AtualizarDeletarEstudante()
        {
            InitializeComponent();
        }

        private void buttonProcurar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textBoxId.Text);
            MySqlCommand comando = new MySqlCommand("SELECT `id`,`nome`,`sobrenome`,`nascimento`,`genero`,`telefone`,`endereco`,`foto` FROM `estudantes id` WHERE `id` =" + id);

            DataTable tabela = estudante.getEstudantes(comando);

            if(tabela.Rows.Count > 0)
            {
                textBoxNome.Text = tabela.Rows[0]["nome"].ToString();
                textBoxSobrenome.Text = tabela.Rows[0]["sobrenome"].ToString();
                dateTimePickerNascimento.Value = (DateTime) tabela.Rows[0]["nascimento"];
                textBoxTelefone.Text = tabela.Rows[0]["telefone"].ToString();
                textBoxEndereco.Text = tabela.Rows[0]["endereco"].ToString();
                if (tabela.Rows[0]["genero"].ToString() == "Feminino")
                {
                    radioButtonFeminino.Checked = true;
                }
                else
                {
                    radioButtonMasculino.Checked = false;
                }

                byte[] fotoDaTabela = (byte[]) tabela.Rows[0]["foto"];
                MemoryStream fotoDaInterface = new MemoryStream(fotoDaTabela);
                pictureBoxFoto.Image = Image.FromStream(fotoDaInterface);
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void AtualizarDeletarEstudante_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void buttonEnviarF_Click(object sender, EventArgs e)
        {
            OpenFileDialog abrirArquivo = new OpenFileDialog();
            abrirArquivo.Filter = "Seleciona a foto(*.jpg;*png;*gif)|*.jpg;*.png;*.gif";
            if (abrirArquivo.ShowDialog() == DialogResult.OK)
            {
                pictureBoxFoto.Image = Image.FromFile(abrirArquivo.FileName);
            }
        }

        private void textBoxEndereco_TextChanged(object sender, EventArgs e)
        {

        }

        bool Verificar()
        {
            if ((textBoxNome.Text.Trim() == "") ||
                (textBoxSobrenome.Text.Trim() == "") ||
                (textBoxTelefone.Text.Trim() == "") ||
                (textBoxEndereco.Text.Trim() == "") ||
                (pictureBoxFoto.Image == null))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void buttonConfirmar_Click(object sender, EventArgs e)
        {
           //Estudante estudante = new Estudante();
            int id = Convert.ToInt32(textBoxId.Text);
            string nome = textBoxNome.Text;
            string telefone = textBoxTelefone.Text;
            DateTime nascimento = dateTimePickerNascimento.Value;
            string endereco = textBoxEndereco.Text;
            string genero = "feminino";
            string sobrenome = textBoxSobrenome.Text;
            if (radioButtonMasculino.Checked)
            {
                genero = "masculino";
            }

            MemoryStream foto = new MemoryStream();

            int anoDeNascimento = dateTimePickerNascimento.Value.Year;
            int anoAtual = DateTime.Now.Year;
            if ((anoAtual - anoDeNascimento < 10 ||
                (anoAtual - anoDeNascimento > 100)))
            {
                MessageBox.Show("A idade precisa ser entre 10 e 100 anos.",
                    "Idade Invalida",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (Verificar())
            {
                pictureBoxFoto.Image.Save(foto, pictureBoxFoto.Image.RawFormat);
                if (estudante.atualizarEstudante(id, nome, sobrenome, nascimento, genero, endereco, telefone, foto))
                {
                    MessageBox.Show("Informações atualizadas", "Sucesso!",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("erro", "Inserir estudante",
                       MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void buttonRemover_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textBoxId.Text);

            if (MessageBox.Show("tem certeza que quer remover o estudante?", "remover estudante",
               MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (estudante.deletarEstudante(id))
                {
                    MessageBox.Show("estudante removido", "remover estudante",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    textBoxId.Text = "";
                    textBoxNome.Text = "";
                    textBoxSobrenome.Text = "";
                    textBoxTelefone.Text = "";
                    textBoxEndereco.Text = "";
                    dateTimePickerNascimento.Value = DateTime.Now;
                    pictureBoxFoto.Image = null;
                }
                else
                {
                    MessageBox.Show("Estudante não removido", "Remover Estudante", 
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
