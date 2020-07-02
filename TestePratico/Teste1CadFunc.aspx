<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Teste1CadFunc.aspx.cs" Inherits="TestePratico.Teste1CadFunc" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
     <meta charset="utf-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta http-equiv="Content-Language" content="en">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>

    <title>Teste Prático</title>

    <meta name="viewport" content="width=device-width, initial-scale=1, maximum-scale=1, user-scalable=no, shrink-to-fit=no" />
    <meta name="description" content="Wide selection of forms controls, using the Bootstrap 4 code base, but built with React.">
    <meta name="msapplication-tap-highlight" content="no">
   
    <link href="main.css" rel="stylesheet">
</head>
<body>
    <form id="form1" runat="server">
        
         <div class="app-container app-theme-white body-tabs-shadow fixed-sidebar fixed-header">
        <div class="app-header header-shadow">
            <div class="app-header__logo">
                <div class="logo-src"></div>
              
            </div>
            <div class="app-header__mobile-menu">
                <div>
                    <!-- Alguma Mudanca a ser Realizada para Mobile -->
                </div>
            </div>
            <div class="app-header__menu">
                <span>
                   
                </span>
            </div>    
                <div class="app-header__content">
                               
                    <div class="app-header-right">
                    <div class="header-btn-lg pr-0">
                        <div class="widget-content p-0">
                            <div class="widget-content-wrapper">
                                <div class="widget-content-left">
                                    
                                </div>
                               
                            </div>
                        </div>
                    </div>        </div>
            </div>
        </div>       
              
            
            
            <div class="app-main__outer">
                    <div class="app-main__inner">
                        <div class="app-page-title">
                            <div class="page-title-wrapper">
                                <div class="page-title-heading">
                                    <div class="page-title-icon">
                                        <i class="pe-7s-display1 icon-gradient bg-premium-dark">
                                        </i>
                                    </div>
                                   
                                </div>
                                </div>
                        </div>

                            <ul class="body-tabs body-tabs-layout tabs-animated body-tabs-animated nav">
                           
                            </ul>

                        <!-- Inicio Formulario -->

                        <div class="tab-content">
                            <div class="tab-pane tabs-animation fade show active" id="tab-content-0" role="tabpanel">
                                <div class="main-card mb-3 card">
                                    <div class="card-body">
                                        <h5 class="card-title">Cadastro Funcionário</h5>
                                        <asp:Button ID="BtnCadastrarVenda" runat="server" class="mt-2 btn btn-primary" Text="Cadastrar Venda" OnClick="BtnCadastrarVenda_Click"/>
                                        
                                        <div class="tab-content">
                                          <div class="tab-pane tabs-animation fade show active" id="tab-content-0" role="tabpanel">
                                            <div class="main-card mb-3 card">
                                                <div class="card-body">
                                                    <h5 class="card-title">Ambiente Cadastro Funcionario</h5>
                                                
                                                    <div class="card-body">
                                                        <asp:Label ID="Label1" runat="server" Text="Funcionario"></asp:Label>
                                                        <asp:TextBox ID="txtFuncionario" runat="server"></asp:TextBox>
                                                        
                                                    </div>

                                                    <div class="card-body">
                                                        <asp:Label ID="Label2" runat="server" Text="Salário"></asp:Label>
                                                        <asp:TextBox ID="txtSalario" runat="server" MaxLength="5"></asp:TextBox>
                                                        
                                                        
                                                    </div>


                                                     <div class="card-body">
                                                        
                                                        <asp:Button ID="btnSalvarFuncionario" runat="server" class="mt-2 btn btn-primary" Text="Gravar" OnClick="btnSalvarFuncionario_Click"/>
                                                    </div>
                                                </div>
                                            </div>

                                          </div>

                                        </div>
    
                                    <!-- Grid de Dados  -->
                                    <div class="main-card mb-3 card">
                                        <div class="card-header">Funcionarios
                                            
                                        </div>
                                            <div class="table-responsive">

                                            <!-- Inicio Grid  -->
                                                <div class="col-lg-12 ">
                                                    <div class="table-responsive">

                                                    <ContentTemplate>
                                                        <asp:GridView ID="dgGestaoTeste" runat="server"  
                                                        AutoGenerateColumns="false" 
                                                        AllowSorting="True" 
                                                        AllowPaging="True"
                                                        Width="100%" 
                                                        PageSize="100"
                                                        EmptyDataText="Sem Registros"
                                                        HorizontalAlign="Center"
                                                        DataKeyNames="idfuncionario"
                                                        DataSourceID="SqlDS_BuscaFuncionario"
                                                        CssClass="table table-striped table-bordered">
                                                        
                                                        
                                                
                                            
                                                    <HeaderStyle CssClass="gridViewHeader" />

                                                        <Columns>
                                                            <asp:BoundField DataField="idfuncionario" HeaderText="idfuncionario" 
                                                                SortExpression="idfuncionario" HeaderStyle-CssClass="visible-lg" ItemStyle-CssClass="visible-lg" Visible="false" 
                                                                ItemStyle-HorizontalAlign="Center" />
                                                

                                                            <asp:BoundField DataField="Nome" HeaderText="Funcionario" 
                                                               HeaderStyle-CssClass="visible-lg" ItemStyle-CssClass="visible-lg" />
                                                
                                                                <asp:BoundField DataField="salario" HeaderText="salario"  
                                                                HeaderStyle-CssClass="visible-lg" ItemStyle-CssClass="visible-lg" />

                                                        </Columns>
                                                
                                                        </asp:GridView>
                                                     </ContentTemplate>

                                                         <asp:SqlDataSource ID="SqlDS_BuscaFuncionario" runat="server" ProviderName="MySql.Data.MySqlClient"></asp:SqlDataSource>
                                                    </div>
                                                </div>
                                            </div>
                                    </div>
                                    <!-- Final Grid -->

                                    </div>
                                </div>
                                
                            </div>
                            
                        </div>

                      
                </div>
        </div>
    </div>
    </form>
    <script type="text/javascript" src="./assets/scripts/main.js"></script>
</body>
</html>
