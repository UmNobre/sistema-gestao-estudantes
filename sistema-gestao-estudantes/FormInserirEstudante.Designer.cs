namespace sistema_gestao_estudantes
{
    partial class FormInserirEstudante
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.txtBoxSobrenome = new System.Windows.Forms.TextBox();
            this.dateTimePickerNascimento = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonFeminino = new System.Windows.Forms.RadioButton();
            this.buttonMasculino = new System.Windows.Forms.RadioButton();
            this.txtBoxTelefone = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBoxEndereco = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureFoto = new System.Windows.Forms.PictureBox();
            this.btnEnviarFoto = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureFoto)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Font = new System.Drawing.Font("Revit_HEB_DWG", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Font = new System.Drawing.Font("Revit_HEB_DWG", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Sobrenome";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Font = new System.Drawing.Font("Revit_HEB_DWG", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(168, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Data de nascimento";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // textBoxNome
            // 
            this.textBoxNome.Location = new System.Drawing.Point(144, 29);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(253, 20);
            this.textBoxNome.TabIndex = 3;
            // 
            // txtBoxSobrenome
            // 
            this.txtBoxSobrenome.Location = new System.Drawing.Point(144, 61);
            this.txtBoxSobrenome.Name = "txtBoxSobrenome";
            this.txtBoxSobrenome.Size = new System.Drawing.Size(253, 20);
            this.txtBoxSobrenome.TabIndex = 4;
            // 
            // dateTimePickerNascimento
            // 
            this.dateTimePickerNascimento.Location = new System.Drawing.Point(186, 96);
            this.dateTimePickerNascimento.Name = "dateTimePickerNascimento";
            this.dateTimePickerNascimento.Size = new System.Drawing.Size(211, 20);
            this.dateTimePickerNascimento.TabIndex = 5;
            this.dateTimePickerNascimento.ValueChanged += new System.EventHandler(this.dateTimePickerNascimento_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Font = new System.Drawing.Font("Revit_HEB_DWG", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Genero";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonFeminino);
            this.groupBox1.Controls.Add(this.buttonMasculino);
            this.groupBox1.Location = new System.Drawing.Point(144, 122);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(253, 50);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // buttonFeminino
            // 
            this.buttonFeminino.AutoSize = true;
            this.buttonFeminino.Location = new System.Drawing.Point(151, 20);
            this.buttonFeminino.Name = "buttonFeminino";
            this.buttonFeminino.Size = new System.Drawing.Size(66, 17);
            this.buttonFeminino.TabIndex = 1;
            this.buttonFeminino.TabStop = true;
            this.buttonFeminino.Text = "femininO";
            this.buttonFeminino.UseVisualStyleBackColor = true;
            // 
            // buttonMasculino
            // 
            this.buttonMasculino.AutoSize = true;
            this.buttonMasculino.Location = new System.Drawing.Point(22, 20);
            this.buttonMasculino.Name = "buttonMasculino";
            this.buttonMasculino.Size = new System.Drawing.Size(74, 17);
            this.buttonMasculino.TabIndex = 0;
            this.buttonMasculino.TabStop = true;
            this.buttonMasculino.Text = "masculinO";
            this.buttonMasculino.UseVisualStyleBackColor = true;
            this.buttonMasculino.CheckedChanged += new System.EventHandler(this.buttonMasculino_CheckedChanged);
            // 
            // txtBoxTelefone
            // 
            this.txtBoxTelefone.Location = new System.Drawing.Point(144, 189);
            this.txtBoxTelefone.Name = "txtBoxTelefone";
            this.txtBoxTelefone.Size = new System.Drawing.Size(253, 20);
            this.txtBoxTelefone.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Font = new System.Drawing.Font("Revit_HEB_DWG", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Telefone";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // txtBoxEndereco
            // 
            this.txtBoxEndereco.Location = new System.Drawing.Point(144, 215);
            this.txtBoxEndereco.Multiline = true;
            this.txtBoxEndereco.Name = "txtBoxEndereco";
            this.txtBoxEndereco.Size = new System.Drawing.Size(253, 64);
            this.txtBoxEndereco.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Font = new System.Drawing.Font("Revit_HEB_DWG", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 233);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "Endereço";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label7.Font = new System.Drawing.Font("Revit_HEB_DWG", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(125, 296);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 17);
            this.label7.TabIndex = 12;
            this.label7.Text = "Foto";
            // 
            // pictureFoto
            // 
            this.pictureFoto.BackColor = System.Drawing.Color.White;
            this.pictureFoto.Location = new System.Drawing.Point(186, 285);
            this.pictureFoto.Name = "pictureFoto";
            this.pictureFoto.Size = new System.Drawing.Size(175, 142);
            this.pictureFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureFoto.TabIndex = 13;
            this.pictureFoto.TabStop = false;
            this.pictureFoto.Click += new System.EventHandler(this.pictureFoto_Click);
            // 
            // btnEnviarFoto
            // 
            this.btnEnviarFoto.Location = new System.Drawing.Point(243, 433);
            this.btnEnviarFoto.Name = "btnEnviarFoto";
            this.btnEnviarFoto.Size = new System.Drawing.Size(75, 23);
            this.btnEnviarFoto.TabIndex = 14;
            this.btnEnviarFoto.Text = "Enviar Foto";
            this.btnEnviarFoto.UseVisualStyleBackColor = true;
            this.btnEnviarFoto.Click += new System.EventHandler(this.btnEnviarFoto_Click);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(4, 393);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(75, 34);
            this.btnCadastrar.TabIndex = 15;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(105, 393);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 34);
            this.btnCancelar.TabIndex = 16;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // FormInserirEstudante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(429, 477);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.btnEnviarFoto);
            this.Controls.Add(this.pictureFoto);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtBoxEndereco);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtBoxTelefone);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dateTimePickerNascimento);
            this.Controls.Add(this.txtBoxSobrenome);
            this.Controls.Add(this.textBoxNome);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormInserirEstudante";
            this.Text = "FormInserirEstudante";
            this.Load += new System.EventHandler(this.FormInserirEstudante_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureFoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxNome;
        private System.Windows.Forms.TextBox txtBoxSobrenome;
        private System.Windows.Forms.DateTimePicker dateTimePickerNascimento;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton buttonFeminino;
        private System.Windows.Forms.RadioButton buttonMasculino;
        private System.Windows.Forms.TextBox txtBoxTelefone;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBoxEndereco;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureFoto;
        private System.Windows.Forms.Button btnEnviarFoto;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnCancelar;
    }
}