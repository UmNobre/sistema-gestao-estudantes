using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace sistema_gestao_estudantes
{
    //Classe do banco de dados.
    internal class MEU_BD
    {
        //O "objeto" que representa a nossa conexão com o banco de dados.
       private MySqlConnection conexao = new MySqlConnection("datasource=localhost;username=root;password=;database=sga_estudantes_bd_t4");
        // Contorla o acesso a variável "conexao"
        public MySqlConnection getConexao
        {
           get 
            {
                return conexao; 
            }            
        }
        // Método para ABRIR a conexão com o banco de dados.
        public void abrirconexao()
        {
            if (conexao.State == ConnectionState.Closed)
            {
                conexao.Open();
            }
        }
        public void fecharconexao()
        {
            if (conexao.State == ConnectionState.Open)
            {
                conexao.Close();
            }
        }
    }
}
