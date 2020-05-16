using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
public class TipoEndereco
{
    private int      ten_codigo;
    private string   ten_descricao;

    public int Ten_codigo
    {
        get
        {
            return ten_codigo;
        }

        set
        {
            ten_codigo = value;
        }
    }

    public string Ten_descricao
    {
        get
        {
            return ten_descricao;
        }

        set
        {
            ten_descricao = value;
        }
    }
}