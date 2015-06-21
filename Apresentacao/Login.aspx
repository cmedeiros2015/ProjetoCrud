<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Apresentacao.Login" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Login</title>
    <link href="Content/bootstrap.css" rel="stylesheet" />
    <link href="css/Signin.css" rel="stylesheet" />
</head>
<body>
    <!-- container -->
    <div class="container-fluid">
        <form class="form-signin" runat="server" role="form">
            <h3 class="form-signin-heading">Login</h3>
            <h2 class="form-signin-heading">Sistema de Cadastro</h2>
            <asp:TextBox ID="txtEmail" runat="server" CssClass="form-control" placeholder="Endereço de Email" TextMode="Email" />
            <asp:TextBox ID="txtSenha" runat="server" CssClass="form-control" placeholder="Senha do Usuáro" TextMode="Password" />
            <div class="checkbox">
                <label>
                    <asp:CheckBox ID="checkbox" runat="server" value="Lembrar-me" Text="Lembrar-me" />
                </label>
            </div>
            <asp:Button ID="btnConfirmar" runat="server" CssClass="btn btn-lg btn-primary btn-block" Text="Confirmar" OnClick="btnConfirmar_Click" />
            <asp:Label ID="lblMensagem" runat="server" CssClass="label label-danger" />
        </form>
    </div>
    <!-- /container -->
    <!-- script -->
    <script src="Scripts/bootstrap.js"></script>
    <script src="Scripts/jquery-1.9.1.js"></script>
    <script>
        $(document).ready(function () {
            setInterval(function () {
                $('#lblMensagem').fadeOut();
            }, 2000);
        });
    </script>
    <!-- /script -->
</body>
</html>
