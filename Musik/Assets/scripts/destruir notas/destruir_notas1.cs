using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destruir_notas1 : MonoBehaviour {

    public AudioClip Sonido = null;
    public float Volumen = 1.0f;
    protected Transform Posicion = null;

    public void Start()
    {
        Posicion = transform;
    }

    void OnTriggerEnter(Collider other)
    {
        if (Input.GetKey("a"))
        {
            AudioSource.PlayClipAtPoint(Sonido, Posicion.position, Volumen);
            puntaje.bien++;
            puntaje.totalp = puntaje.totalp + 3;
            print("bien: "+puntaje.bien);
            Destroy(gameObject);
            
        }

    }

    private void OnTriggerStay(Collider other)
    {
        if (Input.GetKey("a"))
        {
            AudioSource.PlayClipAtPoint(Sonido, Posicion.position, Volumen);
            puntaje.perfecto++;
            print("perfekt: "+puntaje.perfecto);
            puntaje.totalp = puntaje.totalp + 5;
            Destroy(gameObject);
            
        }
    }
}