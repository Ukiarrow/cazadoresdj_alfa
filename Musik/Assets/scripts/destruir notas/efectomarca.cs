using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class efectomarca : MonoBehaviour {

    public Image sprite0;

    public void Start()
    {
        sprite0 = GameObject.Find("Image1").GetComponent<Image>();
        sprite0.sprite = Resources.Load<Sprite>("sprites/spr_noteA_0");
        sprite0 = GameObject.Find("Image2").GetComponent<Image>();
        sprite0.sprite = Resources.Load<Sprite>("sprites/spr_noteA_0");
        sprite0 = GameObject.Find("Image3").GetComponent<Image>();
        sprite0.sprite = Resources.Load<Sprite>("sprites/spr_noteA_0");
        sprite0 = GameObject.Find("Image4").GetComponent<Image>();
        sprite0.sprite = Resources.Load<Sprite>("sprites/spr_noteA_0");
    }

    public void Update()
    {
        if (Input.GetKey("a"))
        {
            sprite0 = GameObject.Find("Image1").GetComponent<Image>();
            sprite0.sprite = Resources.Load<Sprite>("sprites/spr_noteAm_0");
        }else{
            sprite0 = GameObject.Find("Image1").GetComponent<Image>();
            sprite0.sprite = Resources.Load<Sprite>("sprites/spr_noteA_0");
        }

        if (Input.GetKey("s"))
        {
            sprite0 = GameObject.Find("Image2").GetComponent<Image>();
            sprite0.sprite = Resources.Load<Sprite>("sprites/spr_noteAm_0");
        }else{
            sprite0 = GameObject.Find("Image2").GetComponent<Image>();
            sprite0.sprite = Resources.Load<Sprite>("sprites/spr_noteS_0");
        }

        if (Input.GetKey("d"))
        {
            sprite0 = GameObject.Find("Image3").GetComponent<Image>();
            sprite0.sprite = Resources.Load<Sprite>("sprites/spr_noteAm_0");
        }else{
            sprite0 = GameObject.Find("Image3").GetComponent<Image>();
            sprite0.sprite = Resources.Load<Sprite>("sprites/spr_noteD_0");
        }

        if (Input.GetKey("f"))
        {
            sprite0 = GameObject.Find("Image4").GetComponent<Image>();
            sprite0.sprite = Resources.Load<Sprite>("sprites/spr_noteAm_0");
        }else{
            sprite0 = GameObject.Find("Image4").GetComponent<Image>();
            sprite0.sprite = Resources.Load<Sprite>("sprites/spr_noteF_0");
        }
    }
}
