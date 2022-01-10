<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="Site.Pages.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Pontos turísticos do Brasil</title>
    <link type="text/css" rel="stylesheet" href="Content/bootstrap.css" />
</head>
<script src="Scripts/jquery.1.9.0.min.js"></script>
<script src="Scripts/bootstrap.min.js"></script>
<body>

    <form id="form1" runat="server">
        <div class="container">
            <div class="span10 offset1">

                <h3 class="well">Pontos Turísticos</h3>

                <div class="row">
                    <div class="col-sm-3">
                        <a href="Cadastro.aspx" class="btn btn-primary btn-lg">Novo Ponto turístico</a>
                    </div>
                    <div class="col-sm-4">
                        
                        <asp:TextBox ID="txtNome_PT" runat="server" placeholder="" Width="80%" CssClass="form-control" />
                    </div>
                    <div class="col-sm-2">
                        
                        <asp:Button ID="btnBuscarNome" runat="server" Text="Buscar" CssClass="btn btn-primary mr-sm-2" OnClick="btnBuscarNomePT" />
                        
                    </div>
                </div>

                <br />
                <br />
                <asp:GridView ID="gridPT" runat="server" CssClass="table table-hover table-striped" GridLines="none" AutoGenerateColumns="false" BackColor="#ccffcc" DataKeyNames="ID_PT" PageSize="3" AllowPaging="True" OnPageIndexChanging="gridPT_PageIndexChanging" EmptyDataText="Não existem registros">

                    <Columns>
                        <asp:BoundField DataField="ID_PT" HeaderText="Código Ponto Turístico" />
                        <asp:BoundField DataField="Nome_PT" HeaderText="Nome Ponto Turístico" />
                        <asp:BoundField DataField="Endereco_PT" HeaderText="Endereço" />
                        <asp:BoundField DataField="Cidade_PT" HeaderText="Cidade" />

                            <asp:TemplateField>
                                <ItemTemplate>
                                    <asp:Button ID="btnVisualizar" Text="Visualizar" CssClass="btn btn-primary btn" runat="server" CommandArgument='<%#Eval("ID_PT") %>' OnClick="btnVisualizarPT" />
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField>
                            
                                <ItemTemplate>
                                    <asp:Button ID="btnEditar" Text="Editar" CssClass="btn btn-warning btn" runat="server" CommandArgument='<%#Eval("ID_PT") %>' OnClick="btnEditarPT" />
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField>
                                <ItemTemplate>
                                    <asp:Button ID="btnExcluir" Text="Excluir" CssClass="btn btn-danger btn" runat="server" CommandArgument='<%#Eval("ID_PT") %>' OnClick="btnExcluirPT" />
                                </ItemTemplate>
                            </asp:TemplateField>
                    </Columns>
                </asp:GridView>
                <p>
                    <asp:Label ID="lblMensagem" runat="server" />
                </p>
            </div>

        </div>
    </form>
</body>
</html>
