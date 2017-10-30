using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CambioImagenDer : MonoBehaviour {

    public Image UIImagen;
    public Text id_t;
    public Text id_a;
    public Text dif1;
    public Text dif2;
    public Text dif3;
    public Text npuntaje;
    public int contador;

    public void Start()
    {
        UIImagen = GameObject.Find("jacket").GetComponent<Image>();
        contador = 0; //para recorrer la List de canciones
        UIImagen.sprite = Resources.Load<Sprite>("Jackets/jck_0");
        foreach (cancion s in bd.canciones)
        {
            if (bd.n == s.requisito)
            {
                id_t.text = s.titulo;
                id_a.text = s.artista;
                dif1.text = s.dif_facil;
                dif2.text = s.dif_medio;
                dif3.text = "0";
                npuntaje.text = s.mejorpuntaje.ToString();
                print(s.titulo);
            }

            //id_t.text = bd.canciones.GetHashCode().ToString();
        }
    }
	
    public void cambiarimagender()
    {
        bd.n++;
        if (bd.n > bd.sizecanciones - 1)
        {
            bd.n = 0;
        }
        if (bd.n == 0)
        {
            UIImagen.sprite = Resources.Load<Sprite>("Jackets/jck_0");
        }
        else if (bd.n == 1)
        {
            UIImagen.sprite = Resources.Load<Sprite>("Jackets/jck_1");
        }
        else if (bd.n == 2)
        {
            UIImagen.sprite = Resources.Load<Sprite>("Jackets/jck_2");
        }
        else if (bd.n == 3)
        {
            UIImagen.sprite = Resources.Load<Sprite>("Jackets/jck_3");
        }

        foreach (cancion s in bd.canciones)
        {
            if (bd.n == s.requisito)
            {
                id_t.text = s.titulo;
                id_a.text = s.artista;
                dif1.text = s.dif_facil;
                dif2.text = s.dif_medio;
                dif3.text = "0";
                npuntaje.text = s.mejorpuntaje.ToString();
            }
        }
    }
	
}
