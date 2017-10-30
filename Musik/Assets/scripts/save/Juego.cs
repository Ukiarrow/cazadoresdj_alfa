using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine;

public class Juego : MonoBehaviour
{
    public static int desbloqueo = 0;
    public static List<int> puntajes = new List<int>();
    public static int historia = 0;
    private string rutaArchivo;
    
    public void Guardar()
    {
        rutaArchivo = Application.persistentDataPath + "/Juego.sav";
        BinaryFormatter bf = new BinaryFormatter();
        Debug.Log(Application.persistentDataPath);
        FileStream file = File.Create(rutaArchivo);

        DatosAGuardar Datos = new DatosAGuardar();

        Datos.desbloqueo1 = Juego.desbloqueo;
        Datos.puntajes1.Clear();
        for(int i=0;i<4;i++) Datos.puntajes1.Add(Juego.puntajes[i]);
        Datos.historia1 = Juego.historia;

        bf.Serialize(file, Datos);
        file.Close();
    }

    public void Cargar()
    {
        if (File.Exists(rutaArchivo))
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream file = File.Open(rutaArchivo, FileMode.Open);

            DatosAGuardar Datos = (DatosAGuardar)bf.Deserialize(file);

            Juego.desbloqueo = Datos.desbloqueo1;
            Juego.historia = Datos.historia1;
            Juego.puntajes.Clear();
            for (int i = 0; i < 4; i++) Juego.puntajes.Add(Juego.puntajes[i]);
            file.Close();
        }
        else
        {
            puntajes.Clear();
            for (int i = 0; i < 4; i++) Juego.puntajes.Add(0);
        }
    }
}

[System.Serializable]
class DatosAGuardar
{
    public int desbloqueo1;
    public List<int> puntajes1 = new List<int>();
    public int historia1;

    public DatosAGuardar()
    {
        desbloqueo1 = 0;
        historia1 = 0;
    }
}