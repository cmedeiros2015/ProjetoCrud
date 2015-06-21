<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Alterar.aspx.cs" Inherits="Apresentacao.Alterar" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Alterar Dados</title>
    <link href="Content/bootstrap.css" rel="stylesheet" />
    <link href="css/PageStyle.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server" class="modal-content conteudo" style="height: 92%;">
        <div class="container-fluid">
            <div class="row">
                <div class="col-lg-12">
                    <h1 class="well">Alterar Dados Pessoais</h1>
                    <asp:Panel ID="pnlIDConfirma" runat="server">
                        <div class="well">
                            <div class="col-xs-3">
                                Digite o Código Identificador:
                            <div class="input-group">
                                <span class="input-group-addon">
                                    <span class="glyphicon glyphicon-search"></span></span>
                                <asp:TextBox ID="txtID" runat="server" placeholder="Digite o Código" CssClass="form-control" />
                            </div>
                            </div>
                            <br />
                            <asp:Button ID="btnConfirmar" runat="server" Text="Confirmar" CssClass="btn btn-primary" OnClick="btnConfirmar_Click" TabIndex="1" />
                        </div>
                    </asp:Panel>
                    <asp:Panel ID="pnlDados" runat="server">
                        <div class="well">
                            Nome:
                            <asp:TextBox ID="txtNome" runat="server" ReadOnly="false" CssClass="form-control" />
                            Sobrenome:
                            <asp:TextBox ID="txtSobrenome" runat="server" ReadOnly="false" CssClass="form-control" />
                            Endereço:
                            <asp:TextBox ID="txtEndereco" runat="server" ReadOnly="false" CssClass="form-control" />
                            Telefone:
                            <asp:TextBox ID="txtTelefone" runat="server" ReadOnly="false" CssClass="form-control" />
                            Email:
                            <asp:TextBox ID="txtEmail" runat="server" ReadOnly="false" CssClass="form-control" />
                            <div class="row">
                                <div class="col-xs-3">
                                    Data de Cadastro no Sistema:
                                    <div class="input-group">
                                        <span class="input-group-addon"><span class="glyphicon glyphicon-calendar"></span></span>
                                        <asp:TextBox ID="txtDataCad" runat="server" ReadOnly="true" CssClass="form-control" />
                                    </div>
                                </div>
                                <div class="col-xs-3">
                                    Data de Alteração do Cadastro:
                                    <div class="input-group">
                                        <span class="input-group-addon"><span class="glyphicon glyphicon-calendar"></span></span>
                                        <asp:TextBox ID="txtDataAltCad" runat="server" ReadOnly="true" CssClass="form-control" />
                                    </div>
                                </div>
                            </div>
                        </div>
                    </asp:Panel>
                    <asp:Panel ID="pnlMensagem" runat="server">
                        <div class="well">
                            <asp:Label ID="lblMensagem" runat="server" CssClass="alert  alert-info" />
                        </div>
                    </asp:Panel>
                    <asp:Panel ID="pnlBotoes" runat="server">
                        <div class="well">
                            <asp:Button ID="btnAlterar" runat="server" Text="Alterar" CssClass="btn btn-primary" OnClick="btnAlterar_Click" />
                            <asp:Button ID="btnNConsulta" runat="server" Text="Nova Consulta" CssClass="btn btn-primary" OnClick="btnNConsulta_Click" />
                            <asp:Button ID="btnVoltar" runat="server" Text="Voltar" CssClass="btn btn-primary" OnClick="btnVoltar_Click" />
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
            $('#pnlMensagem').slideUp(3000);
        });
    </script>
</body>
</html>
