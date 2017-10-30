using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destruir_notas3 : MonoBehaviour {

    public AudioClip Sonido = null;
    public float Volumen = 1.0f;
    protected Transform Posicion = null;

    public void Start()
    {
        Posicion = transform;
    }

    void OnTriggerEnter(Collider other)
    {
        if (Input.GetKey("d"))
        {
            AudioSource.PlayClipAtPoint(Sonido, Posicion.position, Volumen);
            puntaje.bien++;
            print("bien: " + puntaje.bien);
            puntaje.totalp = puntaje.totalp + 3;
            Destroy(gameObject);
        }

    }

    private void OnTriggerStay(Collider other)
    {
        if (Input.GetKey("d"))
        {
            AudioSource.PlayClipAtPoint(Sonido, Posicion.position, Volumen);
            puntaje.perfecto++;
            print("perfekt: " + puntaje.perfecto);
            puntaje.totalp = puntaje.totalp + 5;
            Destroy(gameObject);
        }
    }

}
