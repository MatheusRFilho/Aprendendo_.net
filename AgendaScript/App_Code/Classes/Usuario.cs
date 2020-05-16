using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
public class Usuario
{
    private int     usu_codigo;
    private string  usu_nome;
    private string  usu_email;
    private string  usu_senha;
    private DateTime  usu_datacadastro;

    private Perfil per_codigo; //FK

    public int Usu_codigo
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

    public string Usu_nome
    {
        get
        {
            return usu_nome;
        }

        set
        {
            usu_nome = value;
        }
    }

    public string Usu_email
    {
        get
        {
            return usu_email;
        }

        set
        {
            usu_email = value;
        }
    }

    public string Usu_senha
    {
        get
        {
            return usu_senha;
        }

        set
        {
            usu_senha = value;
        }
    }

    public DateTime Usu_datacadastro
    {
        get
        {
            return usu_datacadastro;
        }

        set
        {
            usu_datacadastro = value;
        }
    }

    public global::Perfil Per_codigo
    {
        get
        {
            return per_codigo;
        }

        set
        {
            per_codigo = value;
        }
    }
}