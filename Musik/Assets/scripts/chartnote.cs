using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chartnote : MonoBehaviour
{
    public float velocidad = 3;
    
    // Update is called once per frame
    void Update()
    {
        //if("Evento que activa el inicio del chart") { }
        //if (notam1)
        //{
            Rigidbody rb = GetComponent<Rigidbody>();
            rb.velocity = Vector3.down * velocidad;
        //}
        /*
        if (nota_marca2 == true)
        {
            Rigidbody rb2 = nota_marca2.GetComponent<Rigidbody>();
            rb2.velocity = Vector3.down * velocidad;
        }
        */
    }
}
