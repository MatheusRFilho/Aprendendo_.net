using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data;


public partial class Exemplos_ExemploGridView : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            CarregarGrid();
        }
    }

    private void CarregarGrid()
    {
        DataSet ds = PerfilDB.SelectAll();

        int qtd = ds.Tables[0].Rows.Count;
        if(qtd > 0)
        {
            grid.DataSource = ds.Tables[0].DefaultView;
            grid.DataBind();
            grid.Visible = true;
            ltl.Text = "Foram Encontrados " + qtd + " de registros";
        }
        else
        {
            grid.Visible = false;
            ltl.Text = "Foram Encontrados " + qtd + " de registros";
        }
    }

    
}