using UnityEngine;
using System.Collections;

public class LoadOnClick : MonoBehaviour {

    public GameObject loadingImage;
    public static int difsel; //0 novato - 1 regular - 2 cazador

    public void LoadScene(int level)
    {

        loadingImage.SetActive(true);
        Application.LoadLevel(level);
    }
}
