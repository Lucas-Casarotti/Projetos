<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Cadastro.aspx.cs" Inherits="Site.Pages.Cadastro" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
    <head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
        <title>Cadastro de turísticos do Brasil</title>
        <link type="text/css" rel="stylesheet" href="Content/bootstrap.css" />
    </head>
    <script src="Scripts/jquery.1.9.0.min.js"></script>
    <script src="Scripts/bootstrap.min.js"></script>
    <body>
        <form id="form1" runat="server">
            <div class="container">
                <div class="span10 offset1">
                    <div class="col-md-12"> 
                        <h3 class="well">Cadastro de pontos turísticos do Brasil</h3>
                        <br />
                         Nome ponto turístico: <br />
                        <asp:TextBox ID="txtNome_PT" runat="server" placeholder="" Width="50%"  CssClass="form-control"/>
                        <asp:RequiredFieldValidator ID="RequiredFieldtxtNome_PT" runat="server" ControlToValidate="txtNome_PT" ErrorMessage="Preencha o Nome do ponto turístico!" ForeColor="Red" />

                        <br /><br />
                         Descrição ponto turístico: <br />
                        <asp:TextBox ID="txtDesc_PT" runat="server" TextMode="MultiLine" MaxLength="100" Width="50%"  CssClass="form-control"/>
                        <asp:RequiredFieldValidator ID="requiredtxtDesc_PT" runat="server" ControlToValidate="txtDesc_PT" ErrorMessage="Preencha a Descrição!" ForeColor="Red" />

                        <br /><br />
                         Endereço ponto turístico: <br />
                        <asp:TextBox ID="txtEndereco_PT" runat="server" placeholder="" Width="50%"  CssClass="form-control"/>
                        <asp:RequiredFieldValidator ID="RequiredFieldtxtEndereco_PT" runat="server" ControlToValidate="txtEndereco_PT" ErrorMessage="Preencha o Endereço!" ForeColor="Red" />

                        <br /><br />
                         Cidade ponto turístico : <br />
                        <asp:TextBox ID="txtCidade_PT" runat="server" placeholder="" Width="50%"  CssClass="form-control"/>
                        <asp:RequiredFieldValidator ID="RequiredFieldtxtCidade_PT" runat="server" ControlToValidate="txtCidade_PT" ErrorMessage="Preencha a Cidade!" ForeColor="Red" />
                        <br /><br />

                        Estado ponto turístico: <br />
                        <asp:DropDownList ID="dp_pt" runat="server">   
                        </asp:DropDownList>
                        
                        <br />
                        <p>
                            <asp:Label ID="LabelValues" runat="server" />
                        </p>
                        <br /><br />
                        <h1><asp:Label ID="lblMensagem" runat="server" /></h1>
                            
                       

                        <asp:Button ID="btnCadastro" runat="server" Text="Cadastrar" CssClass="btn btn-success btn-lg" OnClick="btnCadastroPT" />
                        <a href="Index.aspx" class="btn btn-default btn-lg">Voltar</a>
                    </div>
                    
                </div>
            </div>
        </form>
    </body>
</html>