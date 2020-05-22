<%@ Page Title="" Language="C#" MasterPageFile="~/Exemplos/Exemplo.master" AutoEventWireup="true" CodeFile="ExemploInsertPerfil.aspx.cs" Inherits="Exemplos_ExemploInsertPerfil" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <div class="row">
        <div class="col-12">
            <h2>Exemplo de Insert - Tabela Perfil</h2>
        </div>

        <div class="col-6">
            <div class="row">
                <div class="col-12">
                    <label>Descrição</label>
                    <asp:TextBox  runat="server" required ID="txtDescricao" CssClass="form-control" />
                </div>
                <div class="col-12 mt-3">
                    <asp:Button runat="server" ID="btn" Text="Salvar" CssClass="btn btn-primary btn-block" OnClick="btn_Click"/>
                </div>
            </div>
            
        </div>
        <div class="col-6">
            <asp:GridView ID="grid" runat="server" CssClass="table table-hover" AutoGenerateColumns="False" >
                <Columns>
                 
                    <asp:BoundField DataField="per_descricao" HeaderText="Descrição" />
                </Columns>
            </asp:GridView>
            <asp:Literal runat="server" ID="ltlGrid" />
          
        </div>
    </div>

    <div class="row mt-5">
        <div class="col-12">
              <asp:Literal runat="server" ID="ltl" />
        </div>
    </div>
</asp:Content>

