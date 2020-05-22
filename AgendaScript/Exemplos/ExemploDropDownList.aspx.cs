using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data;

public partial class Exemplos_ExemploDropDownList : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            CarregarDDL();
        }
        
    }

    private void CarregarDDL()
    {
        DataSet ds = PerfilDB.SelectAll();
        ddl.DataSource = ds;
        ddl.DataTextField = "per_descricao";
        ddl.DataValueField = "per_codigo";
        ddl.DataBind();
        ddl.Items.Insert(0,"Selecione um item");
    }
}