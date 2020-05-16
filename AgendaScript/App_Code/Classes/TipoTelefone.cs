using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
public class TipoTelefone
{
    private int     tte_codigo;
    private string  tte_descricao;

    public int Tte_codigo
    {
        get
        {
            return tte_codigo;
        }

        set
        {
            tte_codigo = value;
        }
    }

    public string Tte_descricao
    {
        get
        {
            return tte_descricao;
        }

        set
        {
            tte_descricao = value;
        }
    }
}