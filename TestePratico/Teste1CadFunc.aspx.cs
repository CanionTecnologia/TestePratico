using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TestePratico.Class;


namespace TestePratico
{
    public partial class Teste1CadFunc : System.Web.UI.Page
    {
        RotaQueryFuncionario QueryFuncionario = new RotaQueryFuncionario();
        string CodFuncSelecionado = "";

        private void PopulaGrid_Funcionarios()
        {
            try
            {
                String queryBus_Func = "";

                ConexaoMYSQL StringConexao = new ConexaoMYSQL();


                StringConexao.StrConectaBancoMySql();

                SqlDS_BuscaFuncionario.ConnectionString = StringConexao.connectionString;
                queryBus_Func = "select func.idfuncionario, func.Nome, func.salario from tbfuncionario func;";
                SqlDS_BuscaFuncionario.SelectCommand = queryBus_Func;

                StringConexao.StrDesconectaMySql();
            }
            catch (Exception ex)
            {

                //throw;
            }
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if(!IsPostBack)
                {
                    PopulaGrid_Funcionarios();
                    this.txtFuncionario.Focus();
                }
            }
            catch (Exception)
            {
            }
        }

        protected void btnSalvarFuncionario_Click(object sender, EventArgs e)
        {
            try
            {
                QueryFuncionario.StrSPVALIDA_ROTA_NOVO_FUNCIONARIO(this.txtFuncionario.Text, Convert.ToDouble(this.txtSalario.Text));
                Response.Redirect("Teste1CadFunc.aspx");
            }
            catch (Exception)
            {

            }
        }

        protected void BtnCadastrarVenda_Click(object sender, EventArgs e)
        {
            Response.Redirect("Teste1.aspx");
        }
    }
}