<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Detalhes.aspx.cs" Inherits="CRUD.View.Detalhes" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.1.3/css/bootstrap.min.css" integrity="sha384-MCw98/SFnGE8fJT3GXwEOngsV7Zt27NXFoaoApmYm81iuXoPkFOJwJ8ERdknLPMO" crossorigin="anonymous" />
    <title>Editar Cliente</title>
</head>
<body>
    <form id="form1" runat="server">
        <div class="" style="margin-top: 50px;">
            <div class="container">
                Nome do Cliente:
            <asp:TextBox ID="txtNome" runat="server" class="form-control" />
                Endereço:
            <asp:TextBox ID="txtEndereco" runat="server" class="form-control" />
                E-mail:
            <asp:TextBox ID="txtEmail" runat="server" class="form-control" />
                <div class="">
                    <br />
                    <asp:Button ID="btnEditar" runat="server" class="btn btn-primary btn-lg btn-block" Text="Salvar" OnClick="btnEditar_Click" />
                    <asp:Button ID="btnVoltar" runat="server" class="btn btn-secondary btn-lg btn-block" Text="Voltar" OnClick="btnVoltar_Click" />
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
