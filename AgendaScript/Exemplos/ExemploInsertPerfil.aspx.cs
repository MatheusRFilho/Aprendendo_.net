using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Exemplos_ExemploInsertPerfil : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            CarregarGrid();
        }
    }

    protected void btn_Click(object sender, EventArgs e)
    {
        Perfil p = new Perfil();
        p.Per_descricao = txtDescricao.Text;

        switch (PerfilDB.Insert(p))
        {
            case 0:
                ltl.Text = "<div class='alert alert-success'>";
                ltl.Text += ">>>>>>>>>> Cadastro OK <<<<<<<<<<";
                ltl.Text += "</div>";
                CarregarGrid();
                break;
            case -2:
                ltl.Text = "<div class='alert alert-danger'>";
                ltl.Text += ">>>>>>>>>> ERRO <<<<<<<<<<";
                ltl.Text += "</div>";
                break;
        }
    }
    private void CarregarGrid()
    {
        DataSet ds = PerfilDB.SelectAll();

        int qtd = ds.Tables[0].Rows.Count;
        if (qtd > 0)
        {
            grid.DataSource = ds.Tables[0].DefaultView;
            grid.DataBind();
            grid.Visible = true;
            ltlGrid.Text = "Foram Encontrados " + qtd + " de registros";
        }
        else
        {
            grid.Visible = false;
            ltlGrid.Text = "Foram Encontrados " + qtd + " de registros";
        }
    }
}