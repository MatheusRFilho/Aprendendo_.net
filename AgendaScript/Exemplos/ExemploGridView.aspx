<%@ Page Title="" Language="C#" MasterPageFile="~/Exemplos/Exemplo.master" AutoEventWireup="true" CodeFile="ExemploGridView.aspx.cs" Inherits="Exemplos_ExemploGridView" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <div class="row">
        <div class="col-12">
            <h2>Exemplo: Carregando um grid</h2>

            <asp:GridView ID="grid" runat="server" CssClass="table table-hover" AutoGenerateColumns="False" >
                <Columns>
                    <asp:BoundField DataField="per_codigo" HeaderText="Código" />
                    <asp:BoundField DataField="per_descricao" HeaderText="Descrição" />
                </Columns>
            </asp:GridView>

            <asp:Literal runat="server" ID="ltl"></asp:Literal>
        </div>
    </div>
</asp:Content>

