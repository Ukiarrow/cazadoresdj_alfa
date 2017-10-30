using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class bd : MonoBehaviour {

    public Sprite[] jackets;
    public static int n;
    public static List<cancion> canciones = new List<global::cancion>();
    public static int sizecanciones;

    // Use this for initialization
    public void Start() {

        n = 0; //seteo para uso en menu izq/der
        canciones.Clear();


        //agrego en un arraylist songlist
        canciones.Add(new cancion("Tutorial", "Uki", "1", "5", "s0001", 0, 0));
        Juego.puntajes.Add(0);

        if (Juego.desbloqueo > 0)
        {
            canciones.Add(new cancion("Laguna Darkness", "Uki", "3", "6", "s0002", 1, 0));
            Juego.puntajes.Add(0);
        }

        if (Juego.desbloqueo > 1)
        {
            canciones.Add(new cancion("Pasajer@ de recuerdos", "Uki", "2", "5", "s0003", 2, 0));
            Juego.puntajes.Add(0);
        }

        if (Juego.desbloqueo > 2)
        {
            canciones.Add(new cancion("Lesson Uno", "Uki", "4", "7", "s0004", 3, 0));
            Juego.puntajes.Add(0);
        }

        sizecanciones = canciones.Count;

        //agregar mejores puntajes
        for (int i = 0; i < sizecanciones; i++)
        {
            print("i "+i);
            print("sizecanciones " +sizecanciones);
            print("bd.kansiones.mejorpuntaje "+bd.canciones[i].mejorpuntaje);
            print("juego.puntajes "+Juego.puntajes[i]);
            bd.canciones[i].mejorpuntaje = Juego.puntajes[i];
            print("paso");
        }

    }

    public void Update()
    {
        canciones.Clear();


        //agrego en un arraylist songlist
        canciones.Add(new cancion("Tutorial", "Uki", "1", "5", "s0001", 0, 0));
        Juego.puntajes.Add(0);

        if (Juego.desbloqueo >= 1)
        {
            canciones.Add(new cancion("Laguna Darkness", "Uki", "3", "6", "s0002", 1, 0));
        }

        if (Juego.desbloqueo >= 2)
        {
            canciones.Add(new cancion("Pasajer@ de recuerdos", "Uki", "2", "5", "s0003", 2, 0));
        }

        if (Juego.desbloqueo >= 3)
        {
            canciones.Add(new cancion("Lesson Uno", "Uki", "4", "7", "s0004", 3, 0));
        }

        sizecanciones = canciones.Count;

        //agregar mejores puntajes
        for (int i = 0; i < sizecanciones; i++)
        {
            bd.canciones[i].mejorpuntaje = Juego.puntajes[i];
        }
    }
}
