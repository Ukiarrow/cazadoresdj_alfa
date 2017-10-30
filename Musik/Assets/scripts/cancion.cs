using UnityEngine;
using System.Collections;
using System;

public class cancion : IComparable<cancion>
{
    public string titulo;
    public string artista;
    public string dif_facil;
    public string dif_medio;
    public string id;
    public int requisito;
    public int mejorpuntaje;

    public cancion(string newtitulo,string newartista,string newdif_facil,string newdif_medio, string newid, int newrequisito,int newmejorpuntaje)
    {
        titulo = newtitulo;
        artista = newartista;
        dif_facil = newdif_facil;
        dif_medio = newdif_medio;
        id = newid;
        requisito = newrequisito;
        mejorpuntaje = newmejorpuntaje;
    }

    public int CompareTo(cancion otro)
    {
        if(otro == null)
        {
            return 1;
        }
        return 0;
    }

    public void setpuntaje(int pts)
    {
        mejorpuntaje = pts;
    }

    public int getpuntaje()
    {
        return mejorpuntaje;
    }
}