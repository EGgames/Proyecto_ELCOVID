using UnityEngine;
using System.Collections;

public class MovimientoObstaculos3 : MonoBehaviour {
    public float VelocidadX;
    public float VelocidadY;
    public float VelocidadZ;
    public float velo;
    private float tiempo;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
    tiempo += Time.deltaTime;
       // print(tiempo);

    if (tiempo >= 0)
    {
        VelocidadX = velo;
    }

    if (tiempo >= 2)
    {
        VelocidadX = -VelocidadX;
    }

    if (tiempo >= 4)
    {
        VelocidadX = velo;
    }

    if (tiempo >= 6)
    {
        VelocidadX = -VelocidadX;
    }
    if (tiempo >= 8)
    {
        tiempo = 0;

    }

        
  
        transform.Translate(VelocidadX * Time.deltaTime, VelocidadY * Time.deltaTime, VelocidadZ * Time.deltaTime);
                
        }
}