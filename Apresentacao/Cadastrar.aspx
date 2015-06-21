<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Cadastrar.aspx.cs" Inherits="Apresentacao.Cadastrar" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Cadastro de Pessoas</title>
    <link href="Content/bootstrap.css" rel="stylesheet" />
    <link href="css/PageStyle.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server" class="modal-content conteudo" style="height: 80%;">
        <div class="container-fluid">
            <div class="row">
                <div class="col-lg-12">
                    <h1 class="well">Cadastro de Pessoas - Entity Framework</h1>
                    <div class="well">
                        <div class="row">
                            <div class="col-xs-5">
                                Nome:
                                    <div class="input-group">
                                        <span class="input-group-addon"><span class="glyphicon glyphicon-user"></span></span>
                                        <asp:TextBox ID="txtNome" runat="server" CssClass="form-control" ToolTip="Digite seu Nome" />
                                    </div>
                            </div>
                            <div class="col-xs-3">
                                Sobrenome:
                                    <asp:TextBox ID="txtSobrenome" runat="server" CssClass="form-control" ToolTip="Digite o seu Sobrenome" />
                            </div>
                        </div>
                        Endereço:
                            <div class="input-group">
                                <span class="input-group-addon"><span class="glyphicon glyphicon-home"></span></span>
                                <asp:TextBox ID="txtEndereco" runat="server" CssClass="form-control" ToolTip="Digite seu endereço" Width="50%" />
                            </div>
                        Telefone:
                            <div class="input-group">
                                <span class="input-group-addon"><span class="glyphicon glyphicon-phone-alt"></span></span>
                                <asp:TextBox ID="txtTelefone" runat="server" CssClass="form-control" ToolTip="Digite seu Telefone com  código de área" Width="15%" />
                            </div>
                        Email:
                            <div class="input-group">
                                <span class="input-group-addon"><span class="glyphicon glyphicon-envelope"></span></span>
                                <asp:TextBox ID="txtEmail" runat="server" CssClass="form-control" TextMode="Email" ToolTip="Digite seu email" Width="50%" />
                            </div>
                        Data do Cadastro:
                            <div class="input-group">
                                <span class="input-group-addon"><span class="glyphicon glyphicon-calendar"></span></span>
                                <asp:TextBox ID="txtDataCad" runat="server" CssClass="form-control" ReadOnly="True" Width="15%" />
                            </div>
                    </div>
                    <div class="well">
                        <asp:Button ID="btnConfirmar" runat="server" Text="Confirmar" CssClass="btn btn-primary" OnClick="btnConfirmar_Click" />
                        <asp:Button ID="btnVoltar" runat="server" Text="Voltar" CssClass="btn btn-primary" OnClick="btnVoltar_Click" />
                    </div>
                    <br />
                    <asp:Panel ID="pnlMensagem" runat="server">
                        <div class="well">
                            <asp:Label ID="lblMensagem" runat="server" Text="Mensagem do Sistema" CssClass="alert alert-info" />
                        </div>
                    </asp:Panel>
                </div>
            </div>
        </div>
    </form>
    <script src="Scripts/bootstrap.js"></script>
    <script src="Scripts/jquery-1.9.1.js"></script>
    <script>
        $(document).ready(function () {
            $('#pnlMensagem').slideUp(2000);
        });
    </script>
</body>
</html>
