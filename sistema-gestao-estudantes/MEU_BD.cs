using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace sistema_gestao_estudantes
{
    //Classe do banco de dados.
    internal class MEU_BD
    {
        //O "objeto" que representa a nossa conexão com o banco de dados.
        MySqlConnection conexao = new MySqlConnection("datasource=localhost;username=root;password=;database=sga_estudantes_bd_t4");
    }
}
