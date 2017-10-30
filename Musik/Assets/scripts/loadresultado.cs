using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class loadresultado : MonoBehaviour {
    public Text titulo;
    public Text perf;
    public Text bien;
    public Text mal;
    public Text puntos;

	// Use this for initialization
	void Start () {
        //mostrar estadisticas
        foreach(cancion s in bd.canciones)
        {
            if(bd.n == s.requisito)
            {
                titulo.text = s.titulo;
            }
        }
        print("totalperf: " + puntaje.perfecto);
        print("totalbien: " + puntaje.bien);
        print("totalmal: " + puntaje.mal);
        print("totalpuntos: " + puntaje.totalp);

        perf.text = puntaje.perfecto.ToString();
        bien.text = puntaje.bien.ToString();
        mal.text = puntaje.mal.ToString();
        puntos.text = puntaje.totalp.ToString();

        //guardar puntajes
        for(int i=0; i < bd.sizecanciones; i++)
        {
            if(i == bd.canciones[i].requisito)
            {
                if(puntaje.totalp > bd.canciones[i].getpuntaje())
                {
                    bd.canciones[i].setpuntaje(puntaje.totalp);
                    Juego.puntajes[i] = puntaje.totalp;
                }
            }
        }
        

        //pregunto si se cumplio alguna mision/desbloqueo?
        if((puntaje.perfecto >= 100) && (Juego.desbloqueo == 0)) { //desbloqueo 1 
            Juego.desbloqueo = 1;
        }
	}
	
	// Update is called once per frame
	void Update () {
        puntaje.perfecto = 0;
        puntaje.bien = 0;
        puntaje.mal = 0;
        puntaje.totalp = 0;
	}
}
