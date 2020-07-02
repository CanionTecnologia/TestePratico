using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

//Referencia DLL Conexão com MySQL
using MySql.Data.MySqlClient;

namespace TestePratico.Class
{
    public class RotaQueryCarro
    {
        ConexaoMYSQL ClassMYSQL = new ConexaoMYSQL();

        public DataTable DtVCARREGA_FUNCIONARIO()
        {

            try
            {

                MySqlCommand CMD_CARREGA_FUNCIONARIO = new MySqlCommand();

                //Abrindo conexao com Banco de Dados;
                ClassMYSQL.StrConectaBancoMySql();


                CMD_CARREGA_FUNCIONARIO.CommandText = "select nome from tbfuncionario; ";
                
                CMD_CARREGA_FUNCIONARIO.Connection = ClassMYSQL.connectionMysql;


                DataTable dt = new DataTable();

                dt.Load(CMD_CARREGA_FUNCIONARIO.ExecuteReader());

                return dt;
            }
 
            catch (Exception)
            {

                throw;
            }
        }


        #region VALIDAÇÃO DE VENDA DE CARRO
        public string StrSPVALIDA_ROTA_VENDA_CARRO(string OUTSTR_NOME_FUNCIONARIO, double OUTFLT_VALORCARRO, double OUTFLT_COMISSAO)
        {
            try
            {

                MySqlCommand CMD_VALIDA_ROTA_VENDA_CARRO = new MySqlCommand();

                //Abrindo conexao com Banco de Dados;
                ClassMYSQL.StrConectaBancoMySql();

                CMD_VALIDA_ROTA_VENDA_CARRO.CommandText = "insert into tbvenda (funcionario,valorCarro,comissao) values(@FUNCIONARIO, @VALORCARRO, @COMISSAO); ";
                CMD_VALIDA_ROTA_VENDA_CARRO.Parameters.AddWithValue("@FUNCIONARIO", OUTSTR_NOME_FUNCIONARIO.ToString());
                CMD_VALIDA_ROTA_VENDA_CARRO.Parameters.AddWithValue("@VALORCARRO", OUTFLT_VALORCARRO.ToString());
                CMD_VALIDA_ROTA_VENDA_CARRO.Parameters.AddWithValue("@COMISSAO", OUTFLT_COMISSAO.ToString());


                CMD_VALIDA_ROTA_VENDA_CARRO.Connection = ClassMYSQL.connectionMysql;
                CMD_VALIDA_ROTA_VENDA_CARRO.ExecuteNonQuery();
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