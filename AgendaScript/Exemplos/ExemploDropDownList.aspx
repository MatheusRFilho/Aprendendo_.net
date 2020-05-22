<%@ Page Title="" Language="C#" MasterPageFile="~/Exemplos/Exemplo.master" AutoEventWireup="true" CodeFile="ExemploDropDownList.aspx.cs" Inherits="Exemplos_ExemploDropDownList" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <div class="container">
        <div class="row">
            <div class="col-12">
                <h2>Exemplo: DropDownList Dinâmica</h2>

                <h4> Dados - Perfil </h4>

                <asp:DropDownList ID="ddl" runat="server" CssClass="form-control"></asp:DropDownList>
            </div>
        </div>
    </div>
</asp:Content>

