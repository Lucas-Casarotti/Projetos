<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Detalhes.aspx.cs" Inherits="Site.Pages.Detalhes" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Informações pontos turísticos</title>
    <link type="text/css" rel="stylesheet" href="Content/bootstrap.css" />
</head>
<script src="Scripts/jquery.1.9.0.min.js"></script>
<script src="Scripts/bootstrap.min.js"></script>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <div class="span10 offset1">
                <div class="row">
                    <h3 class="well">Atualizar ponto turístico</h3>

                    <h1><asp:Label ID="lblMensagem1" runat="server" /></h1>
                       
                    <br />
                    <br />
                    Nome ponto turístico:
                        <br />
                    <asp:TextBox ID="txtNome_PT" runat="server" placeholder="" Width="50%" CssClass="form-control" />
                    <asp:RequiredFieldValidator ID="RequiredFieldtxtNome_PT" runat="server" ControlToValidate="txtNome_PT" ErrorMessage="Preencha o Nome do ponto turístico!" ForeColor="Red" />
                    <br />

                    Descrição ponto turístico:
                        <br />
                    <asp:TextBox ID="txtDesc_PT" runat="server" MaxLength="100" TextMode="MultiLine" placeholder="" Width="50%" CssClass="form-control" />
                    <asp:RequiredFieldValidator ID="requiredtxtDesc_PT" runat="server" ControlToValidate="txtDesc_PT" ErrorMessage="Preencha a Descrição!" ForeColor="Red" />

                    <br />
                    Endereço ponto turístico:
                        <br />
                    <asp:TextBox ID="txtEndereco_PT" runat="server" placeholder="" Width="50%" CssClass="form-control" />
                    <asp:RequiredFieldValidator ID="RequiredFieldtxtEndereco_PT" runat="server" ControlToValidate="txtEndereco_PT" ErrorMessage="Preencha o Endereço!" ForeColor="Red" />

                    <br />
                    Cidade ponto turístico :
                        <br />
                    <asp:TextBox ID="txtCidade_PT" runat="server" placeholder="" Width="50%" CssClass="form-control" />
                    <asp:RequiredFieldValidator ID="RequiredFieldtxtCidade_PT" runat="server" ControlToValidate="txtCidade_PT" ErrorMessage="Preencha a Cidade!" ForeColor="Red" />
                    <br />

                    Estado ponto turístico:
                        <br />
                    <asp:DropDownList ID="dp_pt" runat="server" SelectedValue='<%# Bind ("ID_Estado") %>' DataValueField="ID_Estado" />
                    <br />
                    <br />

                    <div class="row">
                        <div class="col-sm-2">
                            <asp:Button ID="btnAtualizar" runat="server" Text="Atualizar" CssClass="btn btn-warning btn-lg" OnClick="btnAtualizar_Click" />
                        </div>
                        <div class="col-sm-2">
                            <a href="Index.aspx" class="btn btn-default btn-lg">Voltar</a>
                        </div>
                    </div>
                    <br />

                    <h1>
                        <asp:Label ID="lblMensagem" runat="server" /></h1>

                </div>
            </div>
        </div>
    </form>
</body>
</html>

