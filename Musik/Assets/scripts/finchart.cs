using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class finchart : MonoBehaviour {

    void OnTriggerEnter(Collider other)
    {
        Application.LoadLevel(6);
    }
    void OnTriggerStay(Collider other)
    {
        Application.LoadLevel(6);
    }
}
