using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chart0001 : MonoBehaviour {
    
    //props audio
    public AudioClip s0001 = null;
    public float Volumen = 1.0f;
    protected Transform Posicion = null;

    //props chart
    public GameObject nota1,n1;
    public GameObject nota2,n2;
    public GameObject nota3,n3;
    public GameObject nota4,n4;
    public GameObject notafin;
    float beat = 0.9230772f;
    // Use this for initialization
    void Start() {
        Posicion = transform;

        AudioSource.PlayClipAtPoint(s0001, Posicion.position, Volumen); //inicia cancion
        //inicia chart de notas
        //1
        m1(5);
        m1(6);
        m2(7);
        m2(8);
        //2
        m1(9);
        m1(10);
        m3(11);
        m3(12);
        //3
        m1(13);
        m1(14);
        m4(15);
        m4(16);
        //4
        m1(17);
        m1(18);
        m3(19);
        m3(20);
        //5
        m1(21);
        m1(22);
        m1(23);
        m1(24);
        //6
        m2(25);
        m2(26);
        m2(27);
        m2(28);
        //7
        m3(29);
        m3(30);
        m3(31);
        m3(32);
        //fin(33); //---------------------------------
        //8
        m4(33);
        m4(34);
        m4(35);
        m4(36);
        //9
        m1(37);
        m2(38);
        m3(39);
        m4(40);
        //10
        m1(41);
        m2(42);
        m3(43);
        m4(44);
        //11
        m4(45);
        m3(46);
        m2(47);
        m1(48);
        //12
        m4(49);
        m3(50);
        m2(51);
        m1(52);
        //13
        m12(53);
        //14
        m1(57);
        //15
        m12(61);
        //16
        m1(65);
        //17
        m34(69);
        //18
        m4(73);
        //19
        m34(77);
        //20
        m4(81);
        //21
        m1(85);
        m1(86);
        m2(87);
        m2(88);
        //22
        m3(89);
        m3(90);
        m4(91);
        m4(92);
        //23
        m1(93);
        m2(94);
        m3(95);
        m4(96);
        //24
        m1(97);
        m2(98);
        m3(99);
        m4(100);
        //25
        m1(101);
        m2(103);
        //26
        m3(105);
        m4(107);
        //27
        m1(109);
        m2(111);
        //28
        m3(113);
        m4(115);
        //29
        m4(117);
        m3(119);
        //30
        m2(121);
        m1(123);
        //31
        m4(125);
        m4(126);
        m3(127);
        m3(128);
        //32
        m2(129);
        m2(130);
        m1(131);
        m1(132);
        //33
        m1(133);
        m1(134);
        m1(135);
        m1(136);
        //34
        m2(137);
        m2(138);
        m2(139);
        m2(140);
        //35
        m3(141);
        m3(142);
        m3(143);
        m3(144);
        //36
        m4(145);
        m4(146);
        m4(147);
        m4(148);
        //37
        m12(149);
        m34(151);
        //38
        m12(153);
        m34(155);
        //39
        m23(157);
        m14(159);
        //40
        m23(161);
        m14(163);
        //41
        m1(165);
        m1(166);
        m4(167);
        m4(168);
        //42
        m1(169);
        m1(170);
        m4(171);
        m4(172);
        //43
        m23(173);
        //44
        m14(177);
        //45
        m1(181);
        m1(182);
        m4(183);
        m4(184);
        //46
        m1(185);
        m1(186);
        m4(187);
        m4(188);
        //47
        m23(189);
        //48
        m14(193);
        //49
        m1(197);
        m1(198);
        m2(199);
        m2(200);
        //50
        m3(201);
        m3(202);
        m4(203);
        m4(204);
        //51
        m14(205);
        //52
        m23(209);
        //53
        m1(213);
        m3(214);
        m1(215);
        m2(216);
        //54
        m1(217);
        m4(218);
        m1(219);
        m14(220);
        fin(222);


        //instansiar nota de fin
    }

    public void m1(float tiempo)
    {
        Instantiate(n1, nota1.transform.position + Vector3.up * (beat * tiempo), transform.rotation);
    }
    public void m2(float tiempo)
    {
        Instantiate(n2, nota2.transform.position + Vector3.up * (beat * tiempo), transform.rotation);
    }
    public void m3(float tiempo)
    {
        Instantiate(n3, nota3.transform.position + Vector3.up * (beat * tiempo), transform.rotation);
    }
    public void m4(float tiempo)
    {
        Instantiate(n4, nota4.transform.position + Vector3.up * (beat * tiempo), transform.rotation);
    }
    public void m12(float tiempo)
    {
        Instantiate(n1, nota1.transform.position + Vector3.up * (beat * tiempo), transform.rotation);
        Instantiate(n2, nota2.transform.position + Vector3.up * (beat * tiempo), transform.rotation);
    }
    public void m13(float tiempo)
    {
        Instantiate(n1, nota1.transform.position + Vector3.up * (beat * tiempo), transform.rotation);
        Instantiate(n3, nota3.transform.position + Vector3.up * (beat * tiempo), transform.rotation);
    }
    public void m14(float tiempo)
    {
        Instantiate(n1, nota1.transform.position + Vector3.up * (beat * tiempo), transform.rotation);
        Instantiate(n4, nota4.transform.position + Vector3.up * (beat * tiempo), transform.rotation);
    }
    public void m23(float tiempo)
    {
        Instantiate(n2, nota2.transform.position + Vector3.up * (beat * tiempo), transform.rotation);
        Instantiate(n3, nota3.transform.position + Vector3.up * (beat * tiempo), transform.rotation);
    }
    public void m24(float tiempo)
    {
        Instantiate(n2, nota2.transform.position + Vector3.up * (beat * tiempo), transform.rotation);
        Instantiate(n4, nota4.transform.position + Vector3.up * (beat * tiempo), transform.rotation);
    }
    public void m34(float tiempo)
    {
        Instantiate(n3, nota3.transform.position + Vector3.up * (beat * tiempo), transform.rotation);
        Instantiate(n4, nota4.transform.position + Vector3.up * (beat * tiempo), transform.rotation);
    }
    public void fin(float tiempo)
    {
        Instantiate(notafin, notafin.transform.position + Vector3.up * (beat * tiempo), transform.rotation);
    }

}
