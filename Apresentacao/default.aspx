<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="Apresentacao._default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>CRUD BootStrap</title>
    <link href="Content/bootstrap.css" rel="stylesheet" />
    <link href="css/PageStyle.css" rel="stylesheet" />
</head>
<body>
    <form id="formEntrada" runat="server" class="modal-content conteudo">
        <div class="jumbotron">
            <div class="col-lg-12">
                <h1 style="text-align: center">Crud com EntityFramework e BootStrap</h1>
            </div>
        </div>
        <div class="container-fluid">
            <div class="col-lg-10">
                <asp:DropDownList ID="ddlEscolha" runat="server" CssClass="form-control signin" Height="40px" Width="30%">
                    <asp:ListItem Value="0" Text="Escolha a Operação..." />
                    <asp:ListItem Value="1" Text="Cadastrar" />
                    <asp:ListItem Value="2" Text="Listar" />
                    <asp:ListItem Value="3" Text="Detalhes" />
                    <asp:ListItem Value="4" Text="Alterar" />
                    <asp:ListItem Value="5" Text="Sobre" />
                    <asp:ListItem Value="6" Text="Sair do Sistema" />
                </asp:DropDownList>
                <br />
                <br />
                <asp:Button ID="btnEnviar" runat="server" Text="Confirmar" CssClass="btn btn-primary signin" OnClick="btnEnviar_Click" Height="40px" Width="15%" />
                <br />
                <br />
                <br />
            </div>
        </div>
        <asp:Panel ID="pnlMensagem" runat="server">
            <div class="container">
                <asp:Label ID="lblMensagem" runat="server" CssClass="alert alert-danger" />
            </div>
        </asp:Panel>
        <div class="modal-footer" style="text-align: center">
            <h5>Sistema de Cadastro de Pessoas - &copy <i>Todos os direitos reservados - 2014</i></h5>
        </div>
    </form>
    <script src="Scripts/bootstrap.js"></script>
    <script src="Scripts/jquery-1.9.1.js"></script>
    <script>
        $(function () {
            $('#pnlMensagem').slideUp(3000)
        });
    </script>
</body>
</html>
