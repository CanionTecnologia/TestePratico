using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TestePratico.Class;

namespace TestePratico
{
    public partial class Teste1 : System.Web.UI.Page
    {
        RotaQueryCarro QueryVendaCarros = new RotaQueryCarro();
        double percentual = 5.0 / 100.0; // 5%

        private void INCarregaCombo_Funcionario()
        {
            this.cboFuncionario.Items.Clear();

            this.cboFuncionario.DataSource = QueryVendaCarros.DtVCARREGA_FUNCIONARIO();

            this.cboFuncionario.DataTextField = "nome";
            this.cboFuncionario.DataBind();
            this.cboFuncionario.SelectedIndex = -1;
        }


        private void PopulaGrid_Vendas()
        {
            try
            {
                String queryBus_Func = "";

                ConexaoMYSQL StringConexao = new ConexaoMYSQL();


                StringConexao.StrConectaBancoMySql();

                SqlDS_BuscaVenda.ConnectionString = StringConexao.connectionString;
                queryBus_Func = "select idvenda, funcionario, valorCarro, comissao from tbvenda;";
                SqlDS_BuscaVenda.SelectCommand = queryBus_Func;

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
                    INCarregaCombo_Funcionario();
                    PopulaGrid_Vendas();
                }
            }
            catch (Exception)
            {

                //throw;
            }
        }


        protected void BtnCadastrarFuncionario_Click(object sender, EventArgs e)
        {
            Response.Redirect("Teste1CadFunc.aspx");
        }

        protected void btnSalvarVenda_Click(object sender, EventArgs e)
        {
            
            double valorCarro =  Convert.ToDouble(this.txtValorCarro.Text); // valor original vem do Usuario


            double ComissaoVenda = (percentual * valorCarro);

            
            QueryVendaCarros.StrSPVALIDA_ROTA_VENDA_CARRO(this.cboFuncionario.Text, Convert.ToDouble(this.txtValorCarro.Text), ComissaoVenda);

            Response.Redirect("Teste1.aspx");
        }
    }
}