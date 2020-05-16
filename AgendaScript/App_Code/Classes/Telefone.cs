using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
public class Telefone
{
    private int          tel_codigo;
    private string       tel_ddd;
    private string       tel_numero;

    private Usuario      usu_codigo;     //fk
    private TipoTelefone tte_codigo;     //fk

    public int Tel_codigo
    {
        get
        {
            return tel_codigo;
        }

        set
        {
            tel_codigo = value;
        }
    }

    public string Tel_ddd
    {
        get
        {
            return tel_ddd;
        }

        set
        {
            tel_ddd = value;
        }
    }

    public string Tel_numero
    {
        get
        {
            return tel_numero;
        }

        set
        {
            tel_numero = value;
        }
    }

    public global::Usuario Usu_codigo
    {
        get
        {
            return usu_codigo;
        }

        set
        {
            usu_codigo = value;
        }
    }

    public global::TipoTelefone Tte_codigo
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
}