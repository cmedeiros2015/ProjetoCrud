<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Listar.aspx.cs" Inherits="Apresentacao.Listar" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Listar Pessoas</title>
    <link href="Content/bootstrap.css" rel="stylesheet" />
    <link href="css/PageStyle.css" rel="stylesheet" />
    <link href="Content/gridView.css" rel="stylesheet" />
</head>
<script src="Scripts/bootstrap.js"></script>
<script src="Scripts/jquery-1.9.1.js"></script>
<body>
    <form id="form1" runat="server" class="modal-content conteudo">
        <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
        <div class="container-fluid">
            <div class="row">
                <div class="col-lg-12">
                    <h1 class="well">Lista de Pessoas Cadastradas</h1>
                    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                        <ContentTemplate>
                            <asp:GridView
                                ID="gvPessoas"
                                runat="server"
                                CssClass="table table-hover table-striped"
                                AutoGenerateColumns="False"
                                AllowPaging="True"
                                OnPageIndexChanging="gvPessoas_PageIndexChanging" 
                                BackColor="#CCCCCC" 
                                BorderColor="#999999" 
                                BorderStyle="Solid" 
                                BorderWidth="2px" 
                                CellPadding="4" 
                                CellSpacing="2"
                                PageSize="10" 
                                ForeColor="Black">
                                <Columns>
                                    <asp:BoundField DataField="id_pessoa" HeaderText="Código">
                                        <HeaderStyle ForeColor="#00A5E4" HorizontalAlign="Center" />
                                    </asp:BoundField>
                                    <asp:BoundField DataField="Nome_pessoa" HeaderText="Nome">
                                        <HeaderStyle ForeColor="#00A5E4" HorizontalAlign="Center" />
                                    </asp:BoundField>
                                    <asp:BoundField DataField="Sobrenome_pessoa" HeaderText="Sobrenome">
                                        <HeaderStyle ForeColor="#00A5E4" HorizontalAlign="Center" />
                                    </asp:BoundField>
                                    <asp:BoundField DataField="Endereco_pessoa" HeaderText="Endereço">
                                        <HeaderStyle ForeColor="#00A5E4" HorizontalAlign="Center" />
                                    </asp:BoundField>
                                    <asp:BoundField DataField="Telefone_pessoa" HeaderText="Telefone">
                                        <HeaderStyle ForeColor="#00A5E4" HorizontalAlign="Center" />
                                    </asp:BoundField>
                                    <asp:BoundField DataField="Email_pessoa" HeaderText="Email">
                                        <HeaderStyle ForeColor="#00A5E4" HorizontalAlign="Center" />
                                    </asp:BoundField>
                                    <asp:BoundField DataField="DataCadastro_pessoa" HeaderText="Data Cadastro" DataFormatString="{0:dd/MM/yyyy}">
                                        <HeaderStyle ForeColor="#00A5E4" HorizontalAlign="Center" />
                                    </asp:BoundField>
                                    <asp:BoundField DataField="DataAltCadastro_pessoa" HeaderText="Data Alt Cad" DataFormatString="{0:dd/MM/yyyy}">
                                        <HeaderStyle ForeColor="#00A5E4" HorizontalAlign="Center" />
                                    </asp:BoundField>
                                </Columns>
                                <FooterStyle BackColor="#CCCCCC" />
                                <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
                                <PagerStyle BackColor="#CCCCCC" ForeColor="Black" HorizontalAlign="Left" />
                                <RowStyle BackColor="White" />
                                <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
                                <SortedAscendingCellStyle BackColor="#F1F1F1" />
                                <SortedAscendingHeaderStyle BackColor="#808080" />
                                <SortedDescendingCellStyle BackColor="#CAC9C9" />
                                <SortedDescendingHeaderStyle BackColor="#383838" />
                            </asp:GridView>
                            <br />
                            <div class="well">
                                <asp:Button ID="btnVoltar" runat="server" Text="Voltar" CssClass="btn btn-primary" OnClick="btnVoltar_Click" />
                            </div>
                        </ContentTemplate>
                    </asp:UpdatePanel>
                </div>
            </div>
        </div>
    </form>
</body>
</html>
