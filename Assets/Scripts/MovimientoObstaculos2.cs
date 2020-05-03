using UnityEngine;
using System.Collections;

public class MovimientoObstaculos2 : MonoBehaviour {
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
        VelocidadY = velo;
    }

    if (tiempo >= 2)
    {
        VelocidadY = -VelocidadY;
    }

    if (tiempo >= 4)
    {
        VelocidadY = velo;
    }

    if (tiempo >= 6)
    {
        VelocidadY = -VelocidadY;
    }
    if (tiempo >= 8)
    {
        tiempo = 0;

    }

        
  
        transform.Translate(VelocidadX * Time.deltaTime, VelocidadY * Time.deltaTime, VelocidadZ * Time.deltaTime);
                
        }
}