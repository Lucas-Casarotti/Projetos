<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="CRUD.View.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <!-- BOOTSTRAP -->
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.1.3/css/bootstrap.min.css" integrity="sha384-MCw98/SFnGE8fJT3GXwEOngsV7Zt27NXFoaoApmYm81iuXoPkFOJwJ8ERdknLPMO" crossorigin="anonymous" />
    <title>Index</title>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <br /><br />
            <div class="row">
                <div class="col-sm-3">
                    <button type="button" class="btn btn-success" data-toggle="modal" data-target="#CadastrarCliente" runat="server">Novo cliente</button>
                    
                </div>
                <div>

                </div>
                <div class="col-sm-4">
                    <asp:TextBox ID="txtNomeBuscar" runat="server" placeholder="Pesquisar por nome"  CssClass="form-control" />

                </div>
                    <asp:Button ID="btnBuscarNome" runat="server" Text="Buscar" Style="margin-right: 50px;" CssClass="btn btn-primary mr-sm-2" OnClick="btnBuscarNome_Click"/>
            </div>
            <br />
            <br />
            <asp:GridView ID="gridPessoas" runat="server" CssClass="table" GridLines="none" AutoGenerateColumns="false" BackColor="" PageSize="5" AllowPaging="True" OnPageIndexChanging="gridPessoas_PageIndexChanging" EmptyDataText="Nenhum registro encontrado">
                <Columns>
                    <asp:BoundField DataField="Codigo" HeaderText="Codigo" />
                    <asp:BoundField DataField="Nome" HeaderText="Nome" />
                    <asp:BoundField DataField="Email" HeaderText="E-mail" />
                    <asp:BoundField DataField="Endereco" HeaderText="Endereço" />
                    <asp:TemplateField HeaderText="Ação">
                        <ItemTemplate>
                            <asp:Button ID="btnEditar" Text="Editar" runat="server" class="btn btn-warning" CommandArgument='<%#Eval("Codigo") %>' OnClick="btnEditar_Click" />
                            <asp:Button ID="btnExcluir" Text="Excluir" runat="server" class="btn btn-danger" CommandArgument='<%#Eval("Codigo") %>' OnClick="btnExcluir_Click" />
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>

            </asp:GridView>
            <asp:Label ID="lblMensagem" runat="server" Style="color: red;" />
        </div>


        <!-- MODAL CADASTRAR CLIENTE -->
        <div class="modal fade" id="CadastrarCliente" tabindex="-1" role="dialog" aria-labelledby="exampleModalLabel" aria-hidden="true">
            <div class="modal-dialog" role="document">
                <div class="modal-content">
                    <div class="modal-header">
                        <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                            <span aria-hidden="true">&times;</span>
                        </button>
                    </div>
                    <div class="modal-body">
                        Nome do Cliente:
                        <br />
                        <asp:TextBox ID="txtNome" runat="server" class="form-control" />
                        <br />
                        Endereço:
                        <br />
                        <asp:TextBox ID="txtEndereco" runat="server" class="form-control" />
                        <br />
                        E-mail:
                        <br />
                        <asp:TextBox ID="txtEmail" runat="server" class="form-control" />
                    </div>
                    <div class="modal-footer">
                        <asp:Button ID="btnFechar" Text="Fechar" runat="server" class="btn btn-secondary" data-dismiss="modal" OnClick="btnFechar_Click" />
                        <asp:Button ID="btnCadastrar" Text="Cadastrar" runat="server" class="btn btn-primary" OnClick="btnCadastrar_Click"/>
                    </div>
                </div>
            </div>
        </div>
    </form>
    <!-- JS DO BOOTSTRAP -->
    <script src="https://code.jquery.com/jquery-3.3.1.slim.min.js" integrity="sha384-q8i/X+965DzO0rT7abK41JStQIAqVgRVzpbzo5smXKp4YfRvH+8abtTE1Pi6jizo" crossorigin="anonymous"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.3/umd/popper.min.js" integrity="sha384-ZMP7rVo3mIykV+2+9J3UJ46jBk0WLaUAdn689aCwoqbBJiSnjAK/l8WvCWPIPm49" crossorigin="anonymous"></script>
    <script src="https://stackpath.bootstrapcdn.com/bootstrap/4.1.3/js/bootstrap.min.js" integrity="sha384-ChfqqxuZUCnJSK3+MXmPNIyE6ZbWh2IMqE241rYiqJxyMiZ6OW/JmZQ5stwEULTy" crossorigin="anonymous"></script>
</body>
</html>
