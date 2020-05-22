using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;


public class PerfilDB
{
   public static DataSet SelectAll()
    {
        DataSet ds = new DataSet();
        IDbConnection objConnection;
        IDbCommand objCommand;
        IDataAdapter objDataDadapter;
        
        objConnection   = Mapped.Connection();
        string sql      = "select * from perfil";
        //objCommand    = Mapped.Command("select * from perfil", objConnection);
        objCommand      = Mapped.Command(sql, objConnection);

        objDataDadapter = Mapped.Adapter(objCommand);
        objDataDadapter.Fill(ds);

        objConnection.Close();
        objCommand.Dispose();
        objConnection.Dispose();
        return ds;
    }
    public static int Insert(Perfil perfil)
    {
        int retorno = 0;

        try
        {
            IDbConnection objConnection;
            IDbCommand objCommand;

            string sql = "insert into perfil(per_descricao) values (?per_descricao)";

            objConnection = Mapped.Connection();
            objCommand = Mapped.Command(sql, objConnection);


            //parametrização
            objCommand.Parameters.Add(Mapped.Parameter("?per_descricao",perfil.Per_descricao));
            objCommand.ExecuteNonQuery();

            objConnection.Close();
            objConnection.Dispose();
            objCommand.Dispose();
        }
        catch (Exception ex)
        {
            retorno = -2;
        }
        return retorno;
    }
    
}