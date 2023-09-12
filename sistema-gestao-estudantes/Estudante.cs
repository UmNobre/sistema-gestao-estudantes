using Microsoft.SqlServer.Server;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistema_gestao_estudantes
{
    internal class Estudante
    {
        MEU_BD bancoDeDados = new MEU_BD();

        public bool inserirEstudante(string nome, string sobrenome, 
            DateTime nascimento, string telefone, string genero,
            string endereco, MemoryStream foto)
        {
            MySqlCommand comando = new MySqlCommand("INSERT INTO `estudantes id`(`nome`, `sobrenome`, `nascimento`, `genero`, `telefone`, `endereco`, `foto`) VALUES (@nm,@sbn,@nsc,@end,@tel,@gen, @fot)",
                bancoDeDados.getConexao);

            comando.Parameters.Add("@nm", MySqlDbType.VarChar).Value = nome;
            comando.Parameters.Add("@sbn", MySqlDbType.VarChar).Value = sobrenome;
            comando.Parameters.Add("@nsc", MySqlDbType.Date).Value = nascimento;
            comando.Parameters.Add("@gen", MySqlDbType.VarChar).Value = genero;
            comando.Parameters.Add("@tel", MySqlDbType.VarChar).Value = telefone;
            comando.Parameters.Add("@end", MySqlDbType.VarChar).Value = endereco;
            comando.Parameters.Add("@fot", MySqlDbType.LongBlob).Value = foto.ToArray();

            bancoDeDados.abrirconexao();

            if (comando.ExecuteNonQuery() == 1)
            {
                bancoDeDados.fecharconexao();
                return true;
            }
            else
            {
                bancoDeDados.fecharconexao();
                return false;

            }
        }

        public bool atualizarEstudante(int id, string nome, string sobrenome,
            DateTime nascimento, string telefone, string genero,
            string endereco, MemoryStream foto)
        {
            MySqlCommand comando = new MySqlCommand("UPDATE `estudantes id` SET `nome`=@nm,`sobrenome`=@sbn,`nascimento`=@nsc," +
                "`genero`=@gen,`telefone`=@tel,`endereco`=@end,`foto`=@fot WHERE `id` = @id)",
                bancoDeDados.getConexao);

            comando.Parameters.Add("@id", MySqlDbType.Int32).Value = id;
            comando.Parameters.Add("@nm", MySqlDbType.VarChar).Value = nome;
            comando.Parameters.Add("@sbn", MySqlDbType.VarChar).Value = sobrenome;
            comando.Parameters.Add("@nsc", MySqlDbType.Date).Value = nascimento;
            comando.Parameters.Add("@gen", MySqlDbType.VarChar).Value = genero;
            comando.Parameters.Add("@tel", MySqlDbType.VarChar).Value = telefone;
            comando.Parameters.Add("@end", MySqlDbType.VarChar).Value = endereco;
            comando.Parameters.Add("@fot", MySqlDbType.LongBlob).Value = foto.ToArray();

            bancoDeDados.abrirconexao();

            if (comando.ExecuteNonQuery() == 1)
            {
                bancoDeDados.fecharconexao();
                return true;
            }
            else
            {
                bancoDeDados.fecharconexao();
                return false;

            }
        }

        // Deletar o estudante.
        public bool deletarEstudante(int id)
        {
            MySqlCommand comando = new MySqlCommand("DELETE FROM `estudantes id` WHERE `id`= @studentid");
            comando.Parameters.Add("@studentid", MySqlDbType.Int32).Value = id;

            bancoDeDados.abrirconexao();

            if (comando.ExecuteNonQuery() == 1)
            {
                bancoDeDados.fecharconexao();
                return true;
            }
            else
            {
                bancoDeDados.fecharconexao();
                return false;

            }
        }



        public DataTable getEstudantes(MySqlCommand comando)
        {
            comando.Connection = bancoDeDados.getConexao;
            MySqlDataAdapter adaptador = new MySqlDataAdapter(comando);
            DataTable tabela = new DataTable();
            adaptador.Fill(tabela);

            return tabela;
        }
    }
}
