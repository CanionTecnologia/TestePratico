using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

//Referencia DLL Conexão com MySQL
using MySql.Data.MySqlClient;

namespace TestePratico.Class
{
    public class ConexaoMYSQL
    {

        // Variavel de definição para acesso a connectionStrings do Web.Config

        public MySqlConnection connectionMysql;
        public MySqlConnection conn;

        public string connectionString;


        #region Conexão com MySQL

        //Inicio de Procedimento e Funções
        public void StrConectaBancoMySql()
        {
            try
            {
                //String da Conexão Banco de Dados Produção en HostGator
                connectionString = "SERVER=ns718.hostgator.com.br;UID=canio531_teste;PWD=GrupoCanion@20; database=canio531_testepratico; Connect Timeout=20";
                connectionMysql = new MySqlConnection(connectionString);

                //Abrindo a Conexão com o Banco de Dados MySQL
                connectionMysql.Open();
            }
            catch (Exception ex)
            {

            }
        }


        public void StrDesconectaMySql()
        {
            try
            {
                //Desconecta com Banco de Dados MYSQL
                connectionMysql.Close();
            }
            catch (Exception ex)
            {

            }
        }

        #endregion
    }
}