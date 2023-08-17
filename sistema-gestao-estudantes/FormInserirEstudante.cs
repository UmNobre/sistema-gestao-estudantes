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
    public partial class FormInserirEstudante : Form
    {
        public FormInserirEstudante()
        {
            InitializeComponent();
        }

        private void FormInserirEstudante_Load(object sender, EventArgs e)
        {
           // FormInserirEstudante inserirEstudante = new FormInserirEstudante();
           // inserirEstudante.Show(this);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnEnviarFoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog abrirArquivo = new OpenFileDialog();
            abrirArquivo.Filter = "Seleciona a foto(*.jpg;*png;*gif)|*.jpg;*.png;*.gif";
            if (abrirArquivo.ShowDialog() == DialogResult.OK)
            {
                pictureFoto.Image = Image.FromFile(abrirArquivo.FileName);
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Estudante estudante = new Estudante();
            string nome = textBoxNome.Text;
            string telefone = txtBoxTelefone.Text;
            DateTime nascimento = dateTimePickerNascimento.Value;
            string endereco = txtBoxEndereco.Text;
            string genero = "feminino";
            string sobrenome = txtBoxSobrenome.Text;
            if (buttonMasculino.Checked)
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
                pictureFoto.Image.Save(foto, pictureFoto.Image.RawFormat);
                if (estudante.inserirEstudante(nome, sobrenome, nascimento, telefone, endereco, genero, foto))
                {
                    MessageBox.Show("Novo estudante cadatrado", "Sucesso!",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("erro","Inserir estudante", 
                       MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }




        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pictureFoto_Click(object sender, EventArgs e)
        {

        }

        

        bool Verificar()
        {
            if ((textBoxNome.Text.Trim() == "") || 
                (txtBoxSobrenome.Text.Trim() == "") ||
                (txtBoxTelefone.Text.Trim() == "") ||
                (txtBoxEndereco.Text.Trim() == "") ||
                (pictureFoto.Image == null))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void dateTimePickerNascimento_ValueChanged(object sender, EventArgs e)
        {

        }

        private void buttonMasculino_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txtBoxEndereco_TextChanged(object sender, EventArgs e)
        {

        }
    }   
}
