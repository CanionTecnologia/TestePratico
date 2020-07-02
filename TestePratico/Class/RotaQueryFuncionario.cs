using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

//Referencia DLL Conexão com MySQL
using MySql.Data.MySqlClient;


namespace TestePratico.Class
{   
    public class RotaQueryFuncionario
    {
        ConexaoMYSQL ClassMYSQL = new ConexaoMYSQL();


        #region VALIDAÇÃO DE CADASTRO FUNCIONARIO
        public string StrSPVALIDA_ROTA_NOVO_FUNCIONARIO(string OUTSTR_NOME_FUNCIONARIO, double OUTFLT_SALARIO)
        {
            try
            {

                MySqlCommand CMD_VALIDA_ROTA_NOVO_FUNCIONARIO = new MySqlCommand();
                
                //Abrindo conexao com Banco de Dados;
                ClassMYSQL.StrConectaBancoMySql();

                CMD_VALIDA_ROTA_NOVO_FUNCIONARIO.CommandText = "insert into tbfuncionario (Nome,salario) values(@FUNCIONARIO, @SALARIO); ";
                CMD_VALIDA_ROTA_NOVO_FUNCIONARIO.Parameters.AddWithValue("@FUNCIONARIO", OUTSTR_NOME_FUNCIONARIO.ToString());
                CMD_VALIDA_ROTA_NOVO_FUNCIONARIO.Parameters.AddWithValue("@SALARIO", OUTFLT_SALARIO.ToString());


                CMD_VALIDA_ROTA_NOVO_FUNCIONARIO.Connection = ClassMYSQL.connectionMysql;
                CMD_VALIDA_ROTA_NOVO_FUNCIONARIO.ExecuteNonQuery();
            }

            catch (Exception ex)
            {
                return ex.ToString();
                //throw ex;
            }

            finally
            {
                ClassMYSQL.StrDesconectaMySql();
            }

            return "Sucesso";
        }
        #endregion

    }
}