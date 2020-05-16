using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
public class Endereco
{
    private int      end_codigo;
    private string   end_rua;
    private string   end_numero;
    private string   end_bairro;
    private string   end_cidade;
    private string   end_estado;
    private string   end_cep;

    private Usuario  usu_codigo;    //FK
    private TipoEndereco ten_codigo;    //FK

    public int End_codigo
    {
        get
        {
            return end_codigo;
        }

        set
        {
            end_codigo = value;
        }
    }

    public string End_rua
    {
        get
        {
            return end_rua;
        }

        set
        {
            end_rua = value;
        }
    }

    public string End_numero
    {
        get
        {
            return end_numero;
        }

        set
        {
            end_numero = value;
        }
    }

    public string End_bairro
    {
        get
        {
            return end_bairro;
        }

        set
        {
            end_bairro = value;
        }
    }

    public string End_cidade
    {
        get
        {
            return end_cidade;
        }

        set
        {
            end_cidade = value;
        }
    }

    public string End_estado
    {
        get
        {
            return end_estado;
        }

        set
        {
            end_estado = value;
        }
    }

    public string End_cep
    {
        get
        {
            return end_cep;
        }

        set
        {
            end_cep = value;
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

    public global::TipoEndereco Ten_codigo
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
}