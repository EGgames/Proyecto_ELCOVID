using UnityEngine;
using System.Collections;

public class MovimientoPlataformas : MonoBehaviour
{

    public float velocidadX;
    public float velocidadY;
    public float velocidadZ;
    public Transform plataforma;
   // float tiempo = 0;

    public void izquierda()
    {
        plataforma.Translate(10 * Time.deltaTime, 0 * Time.deltaTime, 0 * Time.deltaTime);
    }

    public void derecha()
    {
        plataforma.Translate(-10 * Time.deltaTime, 0 * Time.deltaTime, 0 * Time.deltaTime);

    }

    void Update()
    {
            Invoke("izquierda", 2.0f);
            Invoke("derecha", 2.0f);

 }
}