using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

//Importando  as Classes do Projeto
using TestePratico.Class;


namespace TestePratico
{
    public partial class Index : System.Web.UI.Page
    {
        RotaQueryCarro QueryVendaCarro = new RotaQueryCarro();
        private void PopulaComboTeste()
        {
            this.cboTipoTeste.Items.Clear();

            this.cboTipoTeste.Items.Add(" ");
            this.cboTipoTeste.Items.Add("Teste 1");
            
            this.cboTipoTeste.SelectedIndex = -1;
        }


      
        ConexaoMYSQL ClassConectaBD = new ConexaoMYSQL();

        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if(!IsPostBack)
                {
                    PopulaComboTeste();
                }
            }
            catch (Exception)
            {

                
            }
            finally
            {
                
            }
        }

        protected void cboTipoTeste_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if(this.cboTipoTeste.SelectedValue == "Teste 1")
                {
                    Response.Redirect("Teste1.aspx");
                }
                else
                {

                }
            }
            catch (Exception)
            {

            }
        }
    }
}